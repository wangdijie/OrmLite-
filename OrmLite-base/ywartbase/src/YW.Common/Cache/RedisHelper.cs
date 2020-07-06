using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using YW.Common.Extend;

namespace YW.Common.Cache
{
    /// <summary>
    /// Redis缓存
    /// </summary>
    public class RedisHelper
    {

        private static string CachePrefix = ConfigurationManager.AppSettings["cachePrefix"];

        /// <summary>
        /// Redis 服务器参数
        /// </summary>
        private static readonly string redisAddress = "Redis_Address".GetAppSetting() ?? "123.56.177.80";
        private static readonly string redisPort = "Redis_Port".GetAppSetting() ?? "6379";
        private static readonly string redisPwd = "Redis_Pwd".GetAppSetting() ?? "yw@jh3./2019";
        //是否启用缓存
        private static readonly string isOpenCache = "IsOpenCache".GetAppSetting();
        //是否启用阿里云的云服务Redis
        private static readonly string  isEnableAliyunRedis = "IsEnableAliyunRedis".GetAppSetting();

        #region 初始化参数

        private static RedisHelper _redisHelper = new RedisHelper();
        private static object _locker = new Object();

        // 定义一个静态变量来保存类的实例
        private static ConnectionMultiplexer _instance = null;

        /// <summary>
        /// 使用一个静态属性来返回已连接的实例，如下列中所示。
        /// 这样，一旦 ConnectionMultiplexer 断开连接，便可以初始化新的连接实例。
        /// </summary>
        public static ConnectionMultiplexer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null || !_instance.IsConnected)
                        {
                            _instance = GetInstance();
                        }
                    }
                }
                return _instance;
            }
        }

        private RedisHelper()
        {
        }

        public static IDatabase GetDataBase()
        {
            if (Instance.IsConnected)
            {
                return Instance.GetDatabase();
            }
            else
            {
                return GetInstance().GetDatabase();
            }
        }

        private static ConnectionMultiplexer GetInstance(string connectionString = null)
        {
            //var config = new ConfigurationOptions()
            //{
            //    KeepAlive = 0,
            //    AllowAdmin = true,
            //    ConnectTimeout = 30000,
            //    EndPoints = {
            //        { "127.0.0.1", 30000 },
            //        { "127.0.0.1", 30001 },
            //        { "127.0.0.1", 30002 },
            //        { "127.0.0.1", 30003 },
            //        { "127.0.0.1", 30004 },
            //        { "127.0.0.1", 30005 }
            //    }
            //};
            //return ConnectionMultiplexer.Connect(config);

            //使用阿里云的redis服务
            if (!string.IsNullOrEmpty(isEnableAliyunRedis) && Convert.ToBoolean(isEnableAliyunRedis))
            {
                return ConnectionMultiplexer.Connect(new ConfigurationOptions()
                {
                    KeepAlive = 0,
                    AllowAdmin = true,
                    ConnectTimeout = 30000,
                    Password = "Aliyun_Redis_Pwd".GetAppSetting(),
                    EndPoints = { { "Aliyun_Redis_Address".GetAppSetting(), int.Parse("Aliyun_Redis_Port".GetAppSetting()) } }
                });
            }

            var config = new ConfigurationOptions()
            {
                KeepAlive = 0,
                AllowAdmin = true,
                ConnectTimeout = 30000,
                Password = redisPwd,
                EndPoints = { { redisAddress, int.Parse(redisPort) } }
            };
            return ConnectionMultiplexer.Connect(config);


            //if (string.IsNullOrEmpty(connectionString))
            //{
            //    connectionString = ConfigurationManager.AppSettings["RedisConnection"];
            //}
            //return ConnectionMultiplexer.Connect(connectionString);
        }

        #endregion

        /// <summary>
        /// 判断是够存在Key
        /// </summary>
        public static bool HasKey(string Key)
        {
            return GetDataBase().KeyExists(Key);
        }

        /// <summary>
        /// 获取缓存字符串
        /// </summary>
        public static string Get(string Key)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return null;
            }
            string cacheKey = CachePrefix + "|" + Key;
            return GetDataBase().StringGet(cacheKey);
        }
        /// <summary>
        /// 获取缓存实体
        /// </summary>
        public static T Get<T>(string Key)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return default(T);
            }
            string cacheKey = CachePrefix + "|" + Key;
            if (HasKey(cacheKey))
            {
                var cacheData = GetDataBase().StringGet(cacheKey);
                return ConvertObj<T>(cacheData);
            }
            else
                return default(T);
            //return Deserialize<T>(cacheData);
        }

        /// <summary>
        /// 获取缓存实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="setDefault"></param>
        /// <param name="expireMinutes"></param>
        /// <returns></returns>
        public static T Get<T>(string Key, Func<T> setDefault = null, int expireMinutes = 0)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return default(T);
            }
            string cacheKey = CachePrefix + "|" + Key;
            try
            {
                if (HasKey(cacheKey))
                {
                    var cacheData = GetDataBase().StringGet(cacheKey);
                    return ConvertObj<T>(cacheData);
                }
                else
                {
                    if (setDefault == null)
                    {
                        return default(T);
                    }
                    else
                    {
                        var r = setDefault();
                        SetCache<T>(cacheKey, r, expireMinutes);
                        return r;
                    }
                }
            }
            catch
            {
                return setDefault != null ? setDefault() : default(T);
            }
        }


        /// <summary>
        /// 设置缓存(无前缀)
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <param name="expireMinutes">绝对时间</param>
        /// <returns></returns>
        public static bool SetCache(string Key, string Value, int expireMinutes = 0)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return false;
            }
            if (expireMinutes > 0)
            {
                return GetDataBase().StringSet(Key, Value, TimeSpan.FromMinutes(expireMinutes));
            }
            else
            {
                return GetDataBase().StringSet(Key, Value);
            }
        }

        /// <summary>
        /// 设置缓存(有前缀)
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <param name="expireMinutes">绝对时间</param>
        /// <returns></returns>
        public static bool SetCachePrefix(string Key, string Value, int expireMinutes = 0)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return false;
            }
            string cacheKey = CachePrefix + "|" + Key;
            if (expireMinutes > 0)
            {
                return GetDataBase().StringSet(cacheKey, Value, TimeSpan.FromMinutes(expireMinutes));
            }
            else
            {
                return GetDataBase().StringSet(cacheKey, Value);
            }
        }

        /// <summary>
        /// 设置缓存实体（无前缀）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <param name="expireMinutes">绝对时间</param>
        /// <returns></returns>
        public static bool SetCache<T>(string Key, T Value, int expireMinutes = 0)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return false;
            }
            //byte[] obj = Serialize(Value);
            string json = ConvertJson<T>(Value);
            if (expireMinutes > 0)
            {
                return GetDataBase().StringSet(Key, json, TimeSpan.FromMinutes(expireMinutes));
            }
            else
            {
                return GetDataBase().StringSet(Key, json);
            }
        }

        /// <summary>
        /// 设置缓存实体（有前缀）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <param name="expireMinutes">绝对时间</param>
        /// <returns></returns>
        public static bool SetCachePrefix<T>(string Key, T Value, int expireMinutes = 0)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return false;
            }
            string cacheKey = CachePrefix + "|" + Key;
            //byte[] obj = Serialize(Value);
            string json = ConvertJson<T>(Value);
            if (expireMinutes > 0)
            {
                return GetDataBase().StringSet(cacheKey, json, TimeSpan.FromMinutes(expireMinutes));
            }
            else
            {
                return GetDataBase().StringSet(cacheKey, json);
            }
        }

        /// <summary>
        /// 清除缓存
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static bool Remove(string Key)
        {
            if (!string.IsNullOrEmpty(isOpenCache) && !Convert.ToBoolean(isOpenCache))
            {
                return false;
            }
            string cacheKey = CachePrefix + "|" + Key;
            return GetDataBase().KeyDelete(cacheKey);
        }


        private static string ConvertJson<T>(T value)
        {
            string result = value is string ? value.ToString() : JsonConvert.SerializeObject(value);
            return result;
        }

        private static T ConvertObj<T>(RedisValue value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        private static List<T> ConvetList<T>(RedisValue[] values)
        {
            List<T> result = new List<T>();
            foreach (var item in values)
            {
                var model = ConvertObj<T>(item);
                result.Add(model);
            }
            return result;
        }

        static byte[] Serialize(object o)
        {
            if (o == null)
            {
                return null;
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, o);
                byte[] objectDataAsStream = memoryStream.ToArray();
                return objectDataAsStream;
            }
        }

        static T Deserialize<T>(byte[] stream)
        {
            if (stream == null)
            {
                return default(T);
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(stream))
            {
                T result = (T)binaryFormatter.Deserialize(memoryStream);
                return result;
            }
        }


    }

}
