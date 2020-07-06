 
 
namespace YW.InnerService.Apis
{
    using System;
    using YW.InnerService.Models;
    using YW.InnerService.Client;
    using YW.Model;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using YW.Model.Entitys.YW2016; 
    
    /// <summary>
    /// Artists
    /// </summary>
    public partial class ArtistsApi:ApiBase
    {
         /// <summary>
        /// 艺术家展示数量加一未登录用户id填0
        /// </summary>
        public ResultModel ViewCountAdd(long id,long userId)
        {
            var _path="/api/Artists/{id}/ViewCount/Add/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 艺术家展示数量加一未登录用户id填0
        /// </summary>
        public async Task<ResultModel> ViewCountAddAsync(long id,long userId)
        {
            var _path="/api/Artists/{id}/ViewCount/Add/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.ViewCountAdd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 评论艺术家
        /// </summary>
        public ResultModel Comment(long id,ArtistCommentModel model)
        {
            var _path="/api/Artists/{id}/Comment";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 评论艺术家
        /// </summary>
        public async Task<ResultModel> CommentAsync(long id,ArtistCommentModel model)
        {
            var _path="/api/Artists/{id}/Comment";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.Comment}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置首页信息
        /// </summary>
        public ResultModel SetMainInfo(long id)
        {
            var _path="/api/Artists/{id}/SetMainInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置首页信息
        /// </summary>
        public async Task<ResultModel> SetMainInfoAsync(long id)
        {
            var _path="/api/Artists/{id}/SetMainInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.SetMainInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置所有艺术家首页信息
        /// </summary>
        public ResultModel SetAllMainInfo()
        {
            var _path="/api/Artists/SetAllMainInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置所有艺术家首页信息
        /// </summary>
        public async Task<ResultModel> SetAllMainInfoAsync()
        {
            var _path="/api/Artists/SetAllMainInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.SetAllMainInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel ClearName1()
        {
            var _path="/api/Artists/ClearName1";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> ClearName1Async()
        {
            var _path="/api/Artists/ClearName1";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.ClearName1}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel TestAgentOrder(long orderId)
        {
            var _path="/api/Artists/{orderId}/TestAgentOrder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "orderId",orderId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> TestAgentOrderAsync(long orderId)
        {
            var _path="/api/Artists/{orderId}/TestAgentOrder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "orderId",orderId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtistsApi.TestAgentOrder}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Artworks
    /// </summary>
    public partial class ArtworksApi:ApiBase
    {
         /// <summary>
        /// 艺术品搜索
        /// </summary>
        public PagedResultModel<ArtworkDataModel> QueryArtworks(ArtworkSearchModel model)
        {
            var _path="/api/Artworks/Search";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PagedResultModel<ArtworkDataModel>>(response);
        }
        /// <summary>
        /// 艺术品搜索
        /// </summary>
        public async Task<PagedResultModel<ArtworkDataModel>> QueryArtworksAsync(ArtworkSearchModel model)
        {
            var _path="/api/Artworks/Search";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<PagedResultModel<ArtworkDataModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return PagedResultModel<ArtworkDataModel>.Failed("调用内部服务{ArtworksApi.QueryArtworks}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 评论时调用.处理评论之后的逻辑
        /// </summary>
        public ResultModel Comment(long id)
        {
            var _path="/api/Artworks/Comments/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 评论时调用.处理评论之后的逻辑
        /// </summary>
        public async Task<ResultModel> CommentAsync(long id)
        {
            var _path="/api/Artworks/Comments/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.Comment}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 统计并同步作品库存
        /// </summary>
        public ResultModel SyncStock4Artworks(long[] ids)
        {
            var _path="/api/Artworks/SyncStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=ids;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 统计并同步作品库存
        /// </summary>
        public async Task<ResultModel> SyncStock4ArtworksAsync(long[] ids)
        {
            var _path="/api/Artworks/SyncStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=ids;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SyncStock4Artworks}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 统计并同步作品库存
        /// </summary>
        public ResultModel SyncStock4Artwork(long id)
        {
            var _path="/api/Artworks/{id}/SyncStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 统计并同步作品库存
        /// </summary>
        public async Task<ResultModel> SyncStock4ArtworkAsync(long id)
        {
            var _path="/api/Artworks/{id}/SyncStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SyncStock4Artwork}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 同步所有艺术品库存
        /// </summary>
        public ResultModel SyncStock4AllArtworks()
        {
            var _path="/api/Artworks/SyncAllStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 同步所有艺术品库存
        /// </summary>
        public async Task<ResultModel> SyncStock4AllArtworksAsync()
        {
            var _path="/api/Artworks/SyncAllStock";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SyncStock4AllArtworks}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 根据艺术品id获取对应的可用画框
        /// </summary>
        public QueryResultModel<ArtworkFrameModel[]> Frames(long id)
        {
            var _path="/api/Artworks/{id}/Frames";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkFrameModel[]>>(response);
        }
        /// <summary>
        /// 根据艺术品id获取对应的可用画框
        /// </summary>
        public async Task<QueryResultModel<ArtworkFrameModel[]>> FramesAsync(long id)
        {
            var _path="/api/Artworks/{id}/Frames";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkFrameModel[]>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<ArtworkFrameModel[]>.Failed("调用内部服务{ArtworksApi.Frames}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取画框费用,运费
        /// </summary>
        public QueryResultModel<ArtworkFramePriceModel> FrameAmount(long id,long frameId,long paddingId)
        {
            var _path="/api/Artworks/{id}/Frames/{frameId}/Paddings/{paddingId}/FrameAmount";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "frameId",frameId },
                { "paddingId",paddingId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkFramePriceModel>>(response);
        }
        /// <summary>
        /// 获取画框费用,运费
        /// </summary>
        public async Task<QueryResultModel<ArtworkFramePriceModel>> FrameAmountAsync(long id,long frameId,long paddingId)
        {
            var _path="/api/Artworks/{id}/Frames/{frameId}/Paddings/{paddingId}/FrameAmount";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "frameId",frameId },
                { "paddingId",paddingId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkFramePriceModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<ArtworkFramePriceModel>.Failed("调用内部服务{ArtworksApi.FrameAmount}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 艺术家推荐作品审核通过
        /// </summary>
        public ResultModel ArtistRecommendPass(long id)
        {
            var _path="/api/Artworks/ArtistRecommend/{id}/Pass";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 艺术家推荐作品审核通过
        /// </summary>
        public async Task<ResultModel> ArtistRecommendPassAsync(long id)
        {
            var _path="/api/Artworks/ArtistRecommend/{id}/Pass";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.ArtistRecommendPass}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 艺术家推荐作品审核拒绝
        /// </summary>
        public ResultModel ArtistRecommendReject(long id)
        {
            var _path="/api/Artworks/ArtistRecommend/{id}/Reject";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 艺术家推荐作品审核拒绝
        /// </summary>
        public async Task<ResultModel> ArtistRecommendRejectAsync(long id)
        {
            var _path="/api/Artworks/ArtistRecommend/{id}/Reject";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.ArtistRecommendReject}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 艺术家推荐艺术品,在调用前需校验是否是自己的作品
        /// </summary>
        public ResultModel RecommendFromArtist(long id,string content)
        {
            var _path="/api/Artworks/{id}/RecommendFromArtist";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=content;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 艺术家推荐艺术品,在调用前需校验是否是自己的作品
        /// </summary>
        public async Task<ResultModel> RecommendFromArtistAsync(long id,string content)
        {
            var _path="/api/Artworks/{id}/RecommendFromArtist";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=content;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.RecommendFromArtist}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 同步艺术品标签
        /// </summary>
        public ResultModel SyncTag(long id)
        {
            var _path="/api/Artworks/{id}/Tag/Sync";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 同步艺术品标签
        /// </summary>
        public async Task<ResultModel> SyncTagAsync(long id)
        {
            var _path="/api/Artworks/{id}/Tag/Sync";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SyncTag}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 从clarifai同步颜色信息
        /// </summary>
        public ResultModel SetClarifaiInfo()
        {
            var _path="/api/Artworks/SetClarifaiInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 从clarifai同步颜色信息
        /// </summary>
        public async Task<ResultModel> SetClarifaiInfoAsync()
        {
            var _path="/api/Artworks/SetClarifaiInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SetClarifaiInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置clarifai信息
        /// </summary>
        public ResultModel SetClarifaiInfo(long id)
        {
            var _path="/api/Artworks/{id}/SetClarifaiInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置clarifai信息
        /// </summary>
        public async Task<ResultModel> SetClarifaiInfoAsync(long id)
        {
            var _path="/api/Artworks/{id}/SetClarifaiInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SetClarifaiInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel SyncTag4All()
        {
            var _path="/api/Artworks/Tag/Sync";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> SyncTag4AllAsync()
        {
            var _path="/api/Artworks/Tag/Sync";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.SyncTag4All}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 艺术品展示数量加一未登录用户id填0
        /// </summary>
        public ResultModel ViewCountAdd(long id,long userId)
        {
            var _path="/api/Artworks/{id}/ViewCount/Add/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 艺术品展示数量加一未登录用户id填0
        /// </summary>
        public async Task<ResultModel> ViewCountAddAsync(long id,long userId)
        {
            var _path="/api/Artworks/{id}/ViewCount/Add/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{ArtworksApi.ViewCountAdd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public QueryResultModel<String[]> GetColors(string file)
        {
            var _path="/api/Artworks/GetColors";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=file;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String[]>>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<QueryResultModel<String[]>> GetColorsAsync(string file)
        {
            var _path="/api/Artworks/GetColors";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=file;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String[]>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<String[]>.Failed("调用内部服务{ArtworksApi.GetColors}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Auctions
    /// </summary>
    public partial class AuctionsApi:ApiBase
    {
         /// <summary>
        /// 支付保证金支付单
        /// </summary>
        public QueryResultModel<Int64> CreateDepositPayorder(long id,DepositPayorderCreateModel model)
        {
            var _path="/api/Auctions/Round/{id}/DeopositPayorder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 支付保证金支付单
        /// </summary>
        public async Task<QueryResultModel<Int64>> CreateDepositPayorderAsync(long id,DepositPayorderCreateModel model)
        {
            var _path="/api/Auctions/Round/{id}/DeopositPayorder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{AuctionsApi.CreateDepositPayorder}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 退还保证金
        /// </summary>
        public ResultModel DepositBack(long id)
        {
            var _path="/api/Auctions/Round/{id}/DepositPayorder/Back";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 退还保证金
        /// </summary>
        public async Task<ResultModel> DepositBackAsync(long id)
        {
            var _path="/api/Auctions/Round/{id}/DepositPayorder/Back";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.DepositBack}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 保证经支付成功调用
        /// </summary>
        public ResultModel MarginPaymented(long payorderid)
        {
            var _path="/api/Auctions/Round/MarginPayorder/{payorderid}/Paymented";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "payorderid",payorderid }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 保证经支付成功调用
        /// </summary>
        public async Task<ResultModel> MarginPaymentedAsync(long payorderid)
        {
            var _path="/api/Auctions/Round/MarginPayorder/{payorderid}/Paymented";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "payorderid",payorderid }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.MarginPaymented}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 竞价
        /// </summary>
        public ResultModel BidPrice(long goodId,BidPriceModel model)
        {
            var _path="/api/Auctions/Goods/{goodId}/BidPrice";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 竞价
        /// </summary>
        public async Task<ResultModel> BidPriceAsync(long goodId,BidPriceModel model)
        {
            var _path="/api/Auctions/Goods/{goodId}/BidPrice";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.BidPrice}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍品结拍
        /// </summary>
        public ResultModel GoodEnd(long goodId)
        {
            var _path="/api/Auctions/Goods/{goodId}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍品结拍
        /// </summary>
        public async Task<ResultModel> GoodEndAsync(long goodId)
        {
            var _path="/api/Auctions/Goods/{goodId}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.GoodEnd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 专场开始
        /// </summary>
        public ResultModel Start(long id)
        {
            var _path="/api/Auctions/Round/{id}/Start";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 专场开始
        /// </summary>
        public async Task<ResultModel> StartAsync(long id)
        {
            var _path="/api/Auctions/Round/{id}/Start";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.Start}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 专场结束
        /// </summary>
        public ResultModel End(long id)
        {
            var _path="/api/Auctions/Round/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 专场结束
        /// </summary>
        public async Task<ResultModel> EndAsync(long id)
        {
            var _path="/api/Auctions/Round/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.End}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍卖订单支付成功调用
        /// </summary>
        public ResultModel OrderPaid(long orderId)
        {
            var _path="/api/Auctions/Order/{orderId}/Paid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "orderId",orderId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍卖订单支付成功调用
        /// </summary>
        public async Task<ResultModel> OrderPaidAsync(long orderId)
        {
            var _path="/api/Auctions/Order/{orderId}/Paid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "orderId",orderId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.OrderPaid}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 关注专场
        /// </summary>
        public ResultModel FollowAuction(long id,long userId)
        {
            var _path="/api/Auctions/{id}/Follow/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 关注专场
        /// </summary>
        public async Task<ResultModel> FollowAuctionAsync(long id,long userId)
        {
            var _path="/api/Auctions/{id}/Follow/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.FollowAuction}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 取消关注拍卖专场
        /// </summary>
        public ResultModel CancelFollowAuction(long id,long userId)
        {
            var _path="/api/Auctions/{id}/Follow/{userId}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 取消关注拍卖专场
        /// </summary>
        public async Task<ResultModel> CancelFollowAuctionAsync(long id,long userId)
        {
            var _path="/api/Auctions/{id}/Follow/{userId}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.CancelFollowAuction}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 关注拍品
        /// </summary>
        public ResultModel FollowGood(long goodId,long userId)
        {
            var _path="/api/Auctions/Goods/{goodId}/Follow/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 关注拍品
        /// </summary>
        public async Task<ResultModel> FollowGoodAsync(long goodId,long userId)
        {
            var _path="/api/Auctions/Goods/{goodId}/Follow/{userId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.FollowGood}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 取消关注拍品
        /// </summary>
        public ResultModel CancelFollowGood(long goodId,long userId)
        {
            var _path="/api/Auctions/Goods/{goodId}/Follow/{userId}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId },
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 取消关注拍品
        /// </summary>
        public async Task<ResultModel> CancelFollowGoodAsync(long goodId,long userId)
        {
            var _path="/api/Auctions/Goods/{goodId}/Follow/{userId}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "goodId",goodId },
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.CancelFollowGood}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel Comment(long id,AuctionsCommentModel model)
        {
            var _path="/api/Auctions/{id}/Comment";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> CommentAsync(long id,AuctionsCommentModel model)
        {
            var _path="/api/Auctions/{id}/Comment";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{AuctionsApi.Comment}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Email
    /// </summary>
    public partial class EmailApi:ApiBase
    {
         /// <summary>
        /// 发送电子邮件
        /// </summary>
        public ResultModel Send(EmailSendModel model)
        {
            var _path="/api/Email";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 发送电子邮件
        /// </summary>
        public async Task<ResultModel> SendAsync(EmailSendModel model)
        {
            var _path="/api/Email";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{EmailApi.Send}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// MainOrders
    /// </summary>
    public partial class MainOrdersApi:ApiBase
    {
         /// <summary>
        /// 创建主订单
        /// </summary>
        public QueryResultModel<Int64> Create(MainOrderCreateModel model)
        {
            var _path="/Api/MainOrder/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 创建主订单
        /// </summary>
        public async Task<QueryResultModel<Int64>> CreateAsync(MainOrderCreateModel model)
        {
            var _path="/Api/MainOrder/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{MainOrdersApi.Create}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 套餐订单预览接口
        /// </summary>
        public QueryResultModel<ArtworkPackageOrderPreviewModel> PackageOrderPreview(MainOrderCreateModel model)
        {
            var _path="/Api/MainOrder/PackageOrderPreview";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkPackageOrderPreviewModel>>(response);
        }
        /// <summary>
        /// 套餐订单预览接口
        /// </summary>
        public async Task<QueryResultModel<ArtworkPackageOrderPreviewModel>> PackageOrderPreviewAsync(MainOrderCreateModel model)
        {
            var _path="/Api/MainOrder/PackageOrderPreview";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<ArtworkPackageOrderPreviewModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<ArtworkPackageOrderPreviewModel>.Failed("调用内部服务{MainOrdersApi.PackageOrderPreview}出错.请联系管理员");
            }
        }


        /// <summary>
        /// todo:只复制了，还没改，以后用到主订单再改微信小程序支付只能自己支付自己的订单不可用todo
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WxMiniPay(long id,string openid)
        {
            var _path="/Api/MainOrder/{id}/Payment/WxMiniPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// todo:只复制了，还没改，以后用到主订单再改微信小程序支付只能自己支付自己的订单不可用todo
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WxMiniPayAsync(long id,string openid)
        {
            var _path="/Api/MainOrder/{id}/Payment/WxMiniPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{MainOrdersApi.WxMiniPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 微信公众号支付主订单(PC/微信端)微信支付只能自己支付自己的订单todo:wx支付回调https的暂时不可用,
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WechatMpPay(long id,string openid)
        {
            var _path="/Api/MainOrder/{id}/Payment/Wechat/Mp";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// 微信公众号支付主订单(PC/微信端)微信支付只能自己支付自己的订单todo:wx支付回调https的暂时不可用,
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WechatMpPayAsync(long id,string openid)
        {
            var _path="/Api/MainOrder/{id}/Payment/Wechat/Mp";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{MainOrdersApi.WechatMpPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 微信开放平台支付(APP微信支付)todo:这个app端并没有使用
        /// </summary>
        public QueryResultModel<WechatPrepayOrderModel> WechatAppPay(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/WechatAppPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<WechatPrepayOrderModel>>(response);
        }
        /// <summary>
        /// 微信开放平台支付(APP微信支付)todo:这个app端并没有使用
        /// </summary>
        public async Task<QueryResultModel<WechatPrepayOrderModel>> WechatAppPayAsync(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/WechatAppPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<WechatPrepayOrderModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<WechatPrepayOrderModel>.Failed("调用内部服务{MainOrdersApi.WechatAppPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 支付宝APP支付
        /// </summary>
        public QueryResultModel<String> AlipayAppPay(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/Alipay/App";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(response);
        }
        /// <summary>
        /// 支付宝APP支付
        /// </summary>
        public async Task<QueryResultModel<String>> AlipayAppPayAsync(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/Alipay/App";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<String>.Failed("调用内部服务{MainOrdersApi.AlipayAppPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 支付宝PC支付返回html
        /// </summary>
        public QueryResultModel<String> AlipayWebPay(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/Alipay/Web";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(response);
        }
        /// <summary>
        /// 支付宝PC支付返回html
        /// </summary>
        public async Task<QueryResultModel<String>> AlipayWebPayAsync(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/Alipay/Web";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<String>.Failed("调用内部服务{MainOrdersApi.AlipayWebPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 苹果APP支付返回tn码
        /// </summary>
        public QueryResultModel<String> ApplePay(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/ApplePay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(response);
        }
        /// <summary>
        /// 苹果APP支付返回tn码
        /// </summary>
        public async Task<QueryResultModel<String>> ApplePayAsync(long id)
        {
            var _path="/Api/MainOrder/{id}/Payment/ApplePay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<String>.Failed("调用内部服务{MainOrdersApi.ApplePay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 主订单支付成功时调用
        /// </summary>
        public ResultModel Payd(long id)
        {
            var _path="/Api/MainOrder/{id}/Payd";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 主订单支付成功时调用
        /// </summary>
        public async Task<ResultModel> PaydAsync(long id)
        {
            var _path="/Api/MainOrder/{id}/Payd";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MainOrdersApi.Payd}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// MainPayment
    /// </summary>
    public partial class MainPaymentApi:ApiBase
    {
         /// <summary>
        /// 主支付单支付成功
        /// </summary>
        public ResultModel Payd(long id)
        {
            var _path="/api/MainPayment/{id}/Payd";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 主支付单支付成功
        /// </summary>
        public async Task<ResultModel> PaydAsync(long id)
        {
            var _path="/api/MainPayment/{id}/Payd";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MainPaymentApi.Payd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 主支付单退款
        /// </summary>
        public ResultModel Refund(long id)
        {
            var _path="/api/MainPayment/{id}/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 主支付单退款
        /// </summary>
        public async Task<ResultModel> RefundAsync(long id)
        {
            var _path="/api/MainPayment/{id}/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MainPaymentApi.Refund}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Message
    /// </summary>
    public partial class MessageApi:ApiBase
    {
         /// <summary>
        /// 发送拍卖专场开始消息
        /// </summary>
        public ResultModel AuctionsRoundStart(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/Start";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 发送拍卖专场开始消息
        /// </summary>
        public async Task<ResultModel> AuctionsRoundStartAsync(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/Start";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsRoundStart}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 发送拍卖专场结束消息
        /// </summary>
        public ResultModel AuctionsRoundEnd(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 发送拍卖专场结束消息
        /// </summary>
        public async Task<ResultModel> AuctionsRoundEndAsync(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsRoundEnd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍品有新出价
        /// </summary>
        public ResultModel AuctionsGoodsNewBid(long id)
        {
            var _path="/api/Message/Auctions/Goods/{id}/Bid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍品有新出价
        /// </summary>
        public async Task<ResultModel> AuctionsGoodsNewBidAsync(long id)
        {
            var _path="/api/Message/Auctions/Goods/{id}/Bid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsGoodsNewBid}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍品拍卖结束
        /// </summary>
        public ResultModel AuctionsGoodsEnd(long id)
        {
            var _path="/api/Message/Auctions/Goods/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍品拍卖结束
        /// </summary>
        public async Task<ResultModel> AuctionsGoodsEndAsync(long id)
        {
            var _path="/api/Message/Auctions/Goods/{id}/End";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsGoodsEnd}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍卖专场保证经退款
        /// </summary>
        public ResultModel AuctionsDepositRefund(long id)
        {
            var _path="/api/Message/Auctions/Deposits/{id}/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍卖专场保证经退款
        /// </summary>
        public async Task<ResultModel> AuctionsDepositRefundAsync(long id)
        {
            var _path="/api/Message/Auctions/Deposits/{id}/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsDepositRefund}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 拍卖专场保证经退款
        /// </summary>
        public ResultModel AuctionsRoundDepositRefund(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/Deposits/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 拍卖专场保证经退款
        /// </summary>
        public async Task<ResultModel> AuctionsRoundDepositRefundAsync(long id)
        {
            var _path="/api/Message/Auctions/Rounds/{id}/Deposits/Refund";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsRoundDepositRefund}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 保证金支付成功后发送消息
        /// </summary>
        public ResultModel AuctionsDepositPaid(long id)
        {
            var _path="/api/Message/Auctions/Round/Deposit/{id}/Paid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 保证金支付成功后发送消息
        /// </summary>
        public async Task<ResultModel> AuctionsDepositPaidAsync(long id)
        {
            var _path="/api/Message/Auctions/Round/Deposit/{id}/Paid";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.AuctionsDepositPaid}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 发送站内信
        /// </summary>
        public ResultModel Send(UserMessageModel model)
        {
            var _path="/api/Message/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 发送站内信
        /// </summary>
        public async Task<ResultModel> SendAsync(UserMessageModel model)
        {
            var _path="/api/Message/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.Send}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 一条消息已读取
        /// </summary>
        public ResultModel Read(long id)
        {
            var _path="/api/Message/{id}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 一条消息已读取
        /// </summary>
        public async Task<ResultModel> ReadAsync(long id)
        {
            var _path="/api/Message/{id}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.Read}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 用户阅读所有发送给他的消息
        /// </summary>
        public ResultModel ReadUserMsg(long userId)
        {
            var _path="/api/Message/To/{userId}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 用户阅读所有发送给他的消息
        /// </summary>
        public async Task<ResultModel> ReadUserMsgAsync(long userId)
        {
            var _path="/api/Message/To/{userId}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.ReadUserMsg}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 阅读一个人发给另外一个人所有消息
        /// </summary>
        public ResultModel ReadUser2UserMsg(long fromUserId,long toUserId)
        {
            var _path="/api/Message/From/{fromUserId}/To/{toUserId}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "fromUserId",fromUserId },
                { "toUserId",toUserId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 阅读一个人发给另外一个人所有消息
        /// </summary>
        public async Task<ResultModel> ReadUser2UserMsgAsync(long fromUserId,long toUserId)
        {
            var _path="/api/Message/From/{fromUserId}/To/{toUserId}/Read";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "fromUserId",fromUserId },
                { "toUserId",toUserId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.ReadUser2UserMsg}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给所有app发送消息推送
        /// </summary>
        public ResultModel SendToAllApp(AppNotifyModel model)
        {
            var _path="/api/Message/SendToApp";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给所有app发送消息推送
        /// </summary>
        public async Task<ResultModel> SendToAllAppAsync(AppNotifyModel model)
        {
            var _path="/api/Message/SendToApp";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendToAllApp}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给制定用户的
        /// </summary>
        public ResultModel SendToApp(long id,AppNotifyModel model)
        {
            var _path="/api/Message/SendToApp/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给制定用户的
        /// </summary>
        public async Task<ResultModel> SendToAppAsync(long id,AppNotifyModel model)
        {
            var _path="/api/Message/SendToApp/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendToApp}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 发送模版短信
        /// </summary>
        public ResultModel SendTemplateSMS(string phone,string template,string[] pms)
        {
            var _path="/api/Message/SendTemplateSMS/{phone}/{template}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=pms;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone },
                { "template",template }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 发送模版短信
        /// </summary>
        public async Task<ResultModel> SendTemplateSMSAsync(string phone,string template,string[] pms)
        {
            var _path="/api/Message/SendTemplateSMS/{phone}/{template}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=pms;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone },
                { "template",template }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendTemplateSMS}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 提交订单发送短信和微信
        /// </summary>
        public ResultModel SendCreateOrderMessage(long id)
        {
            var _path="/api/Message/SendCreateOrderMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 提交订单发送短信和微信
        /// </summary>
        public async Task<ResultModel> SendCreateOrderMessageAsync(long id)
        {
            var _path="/api/Message/SendCreateOrderMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendCreateOrderMessage}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 支付成功发送短信和微信
        /// </summary>
        public ResultModel SendOrderPaySuccessMessage(long id)
        {
            var _path="/api/Message/SendOrderPaySuccessMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 支付成功发送短信和微信
        /// </summary>
        public async Task<ResultModel> SendOrderPaySuccessMessageAsync(long id)
        {
            var _path="/api/Message/SendOrderPaySuccessMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendOrderPaySuccessMessage}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 转账支付发送短信和微信
        /// </summary>
        public ResultModel SendFinancialAuditMessage(long id)
        {
            var _path="/api/Message/SendFinancialAuditMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 转账支付发送短信和微信
        /// </summary>
        public async Task<ResultModel> SendFinancialAuditMessageAsync(long id)
        {
            var _path="/api/Message/SendFinancialAuditMessage/{id}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{MessageApi.SendFinancialAuditMessage}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Orders
    /// </summary>
    public partial class OrdersApi:ApiBase
    {
         /// <summary>
        /// 积分商品订单创建接口如果是积分购买返回成功时.订单状态就是成功.如果是rmb购买.返回成功时需再调用主订单创建支付单接口,创建支付单并支付
        /// </summary>
        public QueryResultModel<Int64> CreatePointsOrder(CreateAccumulatePointsOrderParamModel model)
        {
            var _path="/Api/Order/Points/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 积分商品订单创建接口如果是积分购买返回成功时.订单状态就是成功.如果是rmb购买.返回成功时需再调用主订单创建支付单接口,创建支付单并支付
        /// </summary>
        public async Task<QueryResultModel<Int64>> CreatePointsOrderAsync(CreateAccumulatePointsOrderParamModel model)
        {
            var _path="/Api/Order/Points/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{OrdersApi.CreatePointsOrder}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 创建支付单
        /// </summary>
        public QueryResultModel<String> CreatePayorder(long id,PayOrderCreateModel model)
        {
            var _path="/Api/Order/{id}/Payorder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(response);
        }
        /// <summary>
        /// 创建支付单
        /// </summary>
        public async Task<QueryResultModel<String>> CreatePayorderAsync(long id,PayOrderCreateModel model)
        {
            var _path="/Api/Order/{id}/Payorder";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<String>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<String>.Failed("调用内部服务{OrdersApi.CreatePayorder}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 创建订单
        /// </summary>
        public QueryResultModel<Int64> CreateOrder(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 创建订单
        /// </summary>
        public async Task<QueryResultModel<Int64>> CreateOrderAsync(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{OrdersApi.CreateOrder}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 创建订单
        /// </summary>
        public QueryResultModel<Int64> CreateOrder2(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create2";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 创建订单
        /// </summary>
        public async Task<QueryResultModel<Int64>> CreateOrder2Async(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create2";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{OrdersApi.CreateOrder2}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 订单创建预览接口
        /// </summary>
        public QueryResultModel<OrderPreviewModel> PreviewCreate(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create/Preview";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<OrderPreviewModel>>(response);
        }
        /// <summary>
        /// 订单创建预览接口
        /// </summary>
        public async Task<QueryResultModel<OrderPreviewModel>> PreviewCreateAsync(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create/Preview";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<OrderPreviewModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<OrderPreviewModel>.Failed("调用内部服务{OrdersApi.PreviewCreate}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 订单创建预览接口
        /// </summary>
        public QueryResultModel<OrderPreviewModel> PreviewCreate2(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create/Preview2";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<OrderPreviewModel>>(response);
        }
        /// <summary>
        /// 订单创建预览接口
        /// </summary>
        public async Task<QueryResultModel<OrderPreviewModel>> PreviewCreate2Async(CreateOrderParamModel model)
        {
            var _path="/Api/Order/Create/Preview2";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<OrderPreviewModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<OrderPreviewModel>.Failed("调用内部服务{OrdersApi.PreviewCreate2}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 订单支付成功逻辑
        /// </summary>
        public ResultModel Paid(long id,long payorderId)
        {
            var _path="/Api/Order/{id}/Paid/{payorderId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "payorderId",payorderId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 订单支付成功逻辑
        /// </summary>
        public async Task<ResultModel> PaidAsync(long id,long payorderId)
        {
            var _path="/Api/Order/{id}/Paid/{payorderId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "payorderId",payorderId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{OrdersApi.Paid}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 取消订单
        /// </summary>
        public ResultModel CancelOrder(long id)
        {
            var _path="/Api/Order/{id}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        public async Task<ResultModel> CancelOrderAsync(long id)
        {
            var _path="/Api/Order/{id}/Cancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{OrdersApi.CancelOrder}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 自动取消所有支付超时订单
        /// </summary>
        public ResultModel AutoCancel()
        {
            var _path="/Api/Order/AutoCancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 自动取消所有支付超时订单
        /// </summary>
        public async Task<ResultModel> AutoCancelAsync()
        {
            var _path="/Api/Order/AutoCancel";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{OrdersApi.AutoCancel}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Payorders
    /// </summary>
    public partial class PayordersApi:ApiBase
    {
         /// <summary>
        /// 微信公众支付支付单
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WeChatMpPay(long id,string openid)
        {
            var _path="/api/Payorders/{id}/WeChatMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// 微信公众支付支付单
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WeChatMpPayAsync(long id,string openid)
        {
            var _path="/api/Payorders/{id}/WeChatMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{PayordersApi.WeChatMpPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 微信小程序支付支付单
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WxMiniMpPay(long id,string openid)
        {
            var _path="/api/Payorders/{id}/WxMiniMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// 微信小程序支付支付单
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WxMiniMpPayAsync(long id,string openid)
        {
            var _path="/api/Payorders/{id}/WxMiniMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{PayordersApi.WxMiniMpPay}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 微信公众支付主支付单
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WeChatMpPayMain(long id,string openid)
        {
            var _path="/api/Payorders/Main/{id}/WeChatMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// 微信公众支付主支付单
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WeChatMpPayMainAsync(long id,string openid)
        {
            var _path="/api/Payorders/Main/{id}/WeChatMpPay";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{PayordersApi.WeChatMpPayMain}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 微信小程序支付主支付单
        /// </summary>
        public QueryResultModel<MpPayReqeustModel> WxMiniMpPayMain(long id,string openid)
        {
            var _path="/api/Payorders/Main/{id}/WxMiniMpPayMain";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(response);
        }
        /// <summary>
        /// 微信小程序支付主支付单
        /// </summary>
        public async Task<QueryResultModel<MpPayReqeustModel>> WxMiniMpPayMainAsync(long id,string openid)
        {
            var _path="/api/Payorders/Main/{id}/WxMiniMpPayMain";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=openid;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<MpPayReqeustModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<MpPayReqeustModel>.Failed("调用内部服务{PayordersApi.WxMiniMpPayMain}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel Payd()
        {
            var _path="/api/Payorders";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> PaydAsync()
        {
            var _path="/api/Payorders";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{PayordersApi.Payd}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Spu
    /// </summary>
    public partial class SpuApi:ApiBase
    {
         /// <summary>
        /// spu创建接口
        /// </summary>
        public ResultModel Post(SpuCreateModel model)
        {
            var _path="/api/Spu";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// spu创建接口
        /// </summary>
        public async Task<ResultModel> PostAsync(SpuCreateModel model)
        {
            var _path="/api/Spu";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{SpuApi.Post}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// Users
    /// </summary>
    public partial class UsersApi:ApiBase
    {
         /// <summary>
        /// 根据用户ID推荐艺术品
        /// </summary>
        public QueryResultModel<Int64[]> RecommendArtworks(long userId,int recArtworkNums)
        {
            var _path="/api/Users/{userId}/RecommendArtworks/{recArtworkNums}";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId },
                { "recArtworkNums",recArtworkNums }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64[]>>(response);
        }
        /// <summary>
        /// 根据用户ID推荐艺术品
        /// </summary>
        public async Task<QueryResultModel<Int64[]>> RecommendArtworksAsync(long userId,int recArtworkNums)
        {
            var _path="/api/Users/{userId}/RecommendArtworks/{recArtworkNums}";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId },
                { "recArtworkNums",recArtworkNums }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64[]>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64[]>.Failed("调用内部服务{UsersApi.RecommendArtworks}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置密码
        /// </summary>
        public ResultModel SetPassword(long id,string password)
        {
            var _path="/api/Users/{id}/Password/{password}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "password",password }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置密码
        /// </summary>
        public async Task<ResultModel> SetPasswordAsync(long id,string password)
        {
            var _path="/api/Users/{id}/Password/{password}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "password",password }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetPassword}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 检查用户是否满足首次充一年会员送版画
        /// </summary>
        public ResultModel CheckFreeArtworkForVip(long userId)
        {
            var _path="/api/Users/{userId}/CheckFreeArtworkForVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 检查用户是否满足首次充一年会员送版画
        /// </summary>
        public async Task<ResultModel> CheckFreeArtworkForVipAsync(long userId)
        {
            var _path="/api/Users/{userId}/CheckFreeArtworkForVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.CheckFreeArtworkForVip}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 赠送版画
        /// </summary>
        public QueryResultModel<Int64> PresentFreeArtworkForVip(CreateOrderParamModel model)
        {
            var _path="/api/Users/PresentFreeArtworkForVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(response);
        }
        /// <summary>
        /// 赠送版画
        /// </summary>
        public async Task<QueryResultModel<Int64>> PresentFreeArtworkForVipAsync(CreateOrderParamModel model)
        {
            var _path="/api/Users/PresentFreeArtworkForVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Int64>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Int64>.Failed("调用内部服务{UsersApi.PresentFreeArtworkForVip}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 通过短信验证码重置密码
        /// </summary>
        public ResultModel SetPasswordByCode(ResetPasswordModel model)
        {
            var _path="/api/Users/Password";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 通过短信验证码重置密码
        /// </summary>
        public async Task<ResultModel> SetPasswordByCodeAsync(ResetPasswordModel model)
        {
            var _path="/api/Users/Password";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetPasswordByCode}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置手机号码
        /// </summary>
        public ResultModel SetPhone(long id,SetPhoneNumberParamsModel model)
        {
            var _path="/api/Users/{id}/Phone";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置手机号码
        /// </summary>
        public async Task<ResultModel> SetPhoneAsync(long id,SetPhoneNumberParamsModel model)
        {
            var _path="/api/Users/{id}/Phone";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetPhone}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置用户基本信息
        /// </summary>
        public ResultModel SetInfo(long id,UserInfoParamModel info)
        {
            var _path="/api/Users/{id}/Info";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=info;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置用户基本信息
        /// </summary>
        public async Task<ResultModel> SetInfoAsync(long id,UserInfoParamModel info)
        {
            var _path="/api/Users/{id}/Info";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=info;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 上传用户头像,正文为图片字节流.
        /// </summary>
        public ResultModel UploadPhoto(long id,byte[] file)
        {
            var _path="/api/Users/{id}/Photo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=file;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 上传用户头像,正文为图片字节流.
        /// </summary>
        public async Task<ResultModel> UploadPhotoAsync(long id,byte[] file)
        {
            var _path="/api/Users/{id}/Photo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=file;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.UploadPhoto}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 使用默认头像
        /// </summary>
        public ResultModel SetPhoto(long id,string path)
        {
            var _path="/api/Users/{id}/Photo/Path";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=path;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 使用默认头像
        /// </summary>
        public async Task<ResultModel> SetPhotoAsync(long id,string path)
        {
            var _path="/api/Users/{id}/Photo/Path";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=path;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetPhoto}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 手机号码是已注册
        /// </summary>
        public QueryResultModel<Boolean> PhoneIsReg(string phone)
        {
            var _path="/api/Users/{phone}/IsReg";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Boolean>>(response);
        }
        /// <summary>
        /// 手机号码是已注册
        /// </summary>
        public async Task<QueryResultModel<Boolean>> PhoneIsRegAsync(string phone)
        {
            var _path="/api/Users/{phone}/IsReg";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Boolean>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Boolean>.Failed("调用内部服务{UsersApi.PhoneIsReg}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        public ResultModel Delete(string phone)
        {
            var _path="/api/Users/{phone}/Delete";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        public async Task<ResultModel> DeleteAsync(string phone)
        {
            var _path="/api/Users/{phone}/Delete";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "phone",phone }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.Delete}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 设置非vip
        /// </summary>
        public ResultModel SetNotVip(long id)
        {
            var _path="/api/Users/{id}/SetNotVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 设置非vip
        /// </summary>
        public async Task<ResultModel> SetNotVipAsync(long id)
        {
            var _path="/api/Users/{id}/SetNotVip";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SetNotVip}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 是否是微信关注用户
        /// </summary>
        public QueryResultModel<Boolean> WeiXinIsSubscribe(long id)
        {
            var _path="/api/Users/{id}/WeiXinSubscribe";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Boolean>>(response);
        }
        /// <summary>
        /// 是否是微信关注用户
        /// </summary>
        public async Task<QueryResultModel<Boolean>> WeiXinIsSubscribeAsync(long id)
        {
            var _path="/api/Users/{id}/WeiXinSubscribe";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Boolean>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Boolean>.Failed("调用内部服务{UsersApi.WeiXinIsSubscribe}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public ResultModel WeixinUserInfo(long id)
        {
            var _path="/api/Users/{id}/WeixinUserInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<ResultModel> WeixinUserInfoAsync(long id)
        {
            var _path="/api/Users/{id}/WeixinUserInfo";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.WeixinUserInfo}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 添加心愿单
        /// </summary>
        public ResultModel LikeArtwork(long id,long artworkId)
        {
            var _path="/api/Users/{id}/Like/Artworks/{artworkId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artworkId",artworkId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 添加心愿单
        /// </summary>
        public async Task<ResultModel> LikeArtworkAsync(long id,long artworkId)
        {
            var _path="/api/Users/{id}/Like/Artworks/{artworkId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artworkId",artworkId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.LikeArtwork}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 删除心愿单
        /// </summary>
        public ResultModel UnLikeArtwork(long id,long artworkId)
        {
            var _path="/api/Users/{id}/UnLike/Artworks/{artworkId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artworkId",artworkId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 删除心愿单
        /// </summary>
        public async Task<ResultModel> UnLikeArtworkAsync(long id,long artworkId)
        {
            var _path="/api/Users/{id}/UnLike/Artworks/{artworkId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artworkId",artworkId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.UnLikeArtwork}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 喜欢艺术家
        /// </summary>
        public ResultModel LikeArtist(long id,long artistId)
        {
            var _path="/api/Users/{id}/Like/Artists/{artistId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artistId",artistId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 喜欢艺术家
        /// </summary>
        public async Task<ResultModel> LikeArtistAsync(long id,long artistId)
        {
            var _path="/api/Users/{id}/Like/Artists/{artistId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artistId",artistId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.LikeArtist}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 不再喜欢艺术家
        /// </summary>
        public ResultModel UnLikeArtist(long id,long artistId)
        {
            var _path="/api/Users/{id}/UnLike/Artists/{artistId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artistId",artistId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 不再喜欢艺术家
        /// </summary>
        public async Task<ResultModel> UnLikeArtistAsync(long id,long artistId)
        {
            var _path="/api/Users/{id}/UnLike/Artists/{artistId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "artistId",artistId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.UnLikeArtist}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 用户签到
        /// </summary>
        public ResultModel SignIn(long id)
        {
            var _path="/api/Users/{id}/SignIn";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 用户签到
        /// </summary>
        public async Task<ResultModel> SignInAsync(long id)
        {
            var _path="/api/Users/{id}/SignIn";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SignIn}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 增加用户积分2.签到积分  3.消费积分(不可用) 4.点赞积分 5.评论积分 6.分享评论赠送积分 7.浏览作品送积分
        /// </summary>
        public ResultModel GivePoint(long id,int type)
        {
            var _path="/api/Users/{id}/GivePoint/{type}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "type",type }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 增加用户积分2.签到积分  3.消费积分(不可用) 4.点赞积分 5.评论积分 6.分享评论赠送积分 7.浏览作品送积分
        /// </summary>
        public async Task<ResultModel> GivePointAsync(long id,int type)
        {
            var _path="/api/Users/{id}/GivePoint/{type}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "type",type }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.GivePoint}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给制定用户发送制定优惠券
        /// </summary>
        public ResultModel SendVoucher(long id,long voucherId)
        {
            var _path="/api/Users/{id}/Vouchers/{voucherId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "voucherId",voucherId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给制定用户发送制定优惠券
        /// </summary>
        public async Task<ResultModel> SendVoucherAsync(long id,long voucherId)
        {
            var _path="/api/Users/{id}/Vouchers/{voucherId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "voucherId",voucherId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SendVoucher}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给批量用户发送指定优惠券
        /// </summary>
        public ResultModel SendBatchVoucher(UserSendVoucher model)
        {
            var _path="/api/Users/Vouchers/BatchSend";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给批量用户发送指定优惠券
        /// </summary>
        public async Task<ResultModel> SendBatchVoucherAsync(UserSendVoucher model)
        {
            var _path="/api/Users/Vouchers/BatchSend";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=model;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SendBatchVoucher}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给指定的用户发送指定的运费券
        /// </summary>
        public ResultModel SendFreightVoucher(long id,long voucherId)
        {
            var _path="/api/Users/{id}/FreightVouchers/{voucherId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "voucherId",voucherId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给指定的用户发送指定的运费券
        /// </summary>
        public async Task<ResultModel> SendFreightVoucherAsync(long id,long voucherId)
        {
            var _path="/api/Users/{id}/FreightVouchers/{voucherId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id },
                { "voucherId",voucherId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SendFreightVoucher}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 给VIP用户赠送3张优惠券
        /// </summary>
        public ResultModel SendVipVouchers(long userId)
        {
            var _path="/api/Users/Vip/Vouchers/{userId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 给VIP用户赠送3张优惠券
        /// </summary>
        public async Task<ResultModel> SendVipVouchersAsync(long userId)
        {
            var _path="/api/Users/Vip/Vouchers/{userId}/Send";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.SendVipVouchers}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取获取分销人/分销组织的可提现金额，若是分销组织，则isOrg为true
        /// </summary>
        public QueryResultModel<Decimal> GetAgentUserAvailableAmount(long userId,bool isOrg,long orgId)
        {
            var _path="/api/Users/{userId}/UserAvailableAmount/{isOrg}/Get/{orgId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId },
                { "isOrg",isOrg },
                { "orgId",orgId }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Decimal>>(response);
        }
        /// <summary>
        /// 获取获取分销人/分销组织的可提现金额，若是分销组织，则isOrg为true
        /// </summary>
        public async Task<QueryResultModel<Decimal>> GetAgentUserAvailableAmountAsync(long userId,bool isOrg,long orgId)
        {
            var _path="/api/Users/{userId}/UserAvailableAmount/{isOrg}/Get/{orgId}";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "userId",userId },
                { "isOrg",isOrg },
                { "orgId",orgId }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<Decimal>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<Decimal>.Failed("调用内部服务{UsersApi.GetAgentUserAvailableAmount}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 用户注册接口
        /// </summary>
        public ResultModel Post(UserRegModel user)
        {
            var _path="/api/Users";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=user;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(response);
        }
        /// <summary>
        /// 用户注册接口
        /// </summary>
        public async Task<ResultModel> PostAsync(UserRegModel user)
        {
            var _path="/api/Users";
            var _method=System.Net.Http.HttpMethod.Post;
            object _body=user;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultModel>(jsonstr); 
            }
            catch (Exception)
            {
                return ResultModel.Failed("调用内部服务{UsersApi.Post}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取用户信息
        /// </summary>
        public QueryResultModel<UserInfoModel> Get(long id)
        {
            var _path="/api/Users/{id}";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<UserInfoModel>>(response);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public async Task<QueryResultModel<UserInfoModel>> GetAsync(long id)
        {
            var _path="/api/Users/{id}";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                { "id",id }
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<UserInfoModel>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<UserInfoModel>.Failed("调用内部服务{UsersApi.Get}出错.请联系管理员");
            }
        }


    }
    
    /// <summary>
    /// WeChat
    /// </summary>
    public partial class WeChatApi:ApiBase
    {
         /// <summary>
        /// 获取微信公众号AccessToken
        /// </summary>
        public QueryResultModel<AccessToken> AccessToken()
        {
            var _path="/api/WeChat/AccessToken";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<AccessToken>>(response);
        }
        /// <summary>
        /// 获取微信公众号AccessToken
        /// </summary>
        public async Task<QueryResultModel<AccessToken>> AccessTokenAsync()
        {
            var _path="/api/WeChat/AccessToken";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<AccessToken>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<AccessToken>.Failed("调用内部服务{WeChatApi.AccessToken}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取新的微信公众号AccessToken
        /// </summary>
        public QueryResultModel<AccessToken> RefreshAccessToken()
        {
            var _path="/api/WeChat/AccessToken/Refresh";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<AccessToken>>(response);
        }
        /// <summary>
        /// 获取新的微信公众号AccessToken
        /// </summary>
        public async Task<QueryResultModel<AccessToken>> RefreshAccessTokenAsync()
        {
            var _path="/api/WeChat/AccessToken/Refresh";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<AccessToken>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<AccessToken>.Failed("调用内部服务{WeChatApi.RefreshAccessToken}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取微信公众号JsApiTicket
        /// </summary>
        public QueryResultModel<JsApiTicket> JsApiTicket()
        {
            var _path="/api/WeChat/JsApiTicket";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<JsApiTicket>>(response);
        }
        /// <summary>
        /// 获取微信公众号JsApiTicket
        /// </summary>
        public async Task<QueryResultModel<JsApiTicket>> JsApiTicketAsync()
        {
            var _path="/api/WeChat/JsApiTicket";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<JsApiTicket>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<JsApiTicket>.Failed("调用内部服务{WeChatApi.JsApiTicket}出错.请联系管理员");
            }
        }


        /// <summary>
        /// 获取微信公众号JsApiTicket
        /// </summary>
        public QueryResultModel<JsApiTicket> RefreshJsApiTicket()
        {
            var _path="/api/WeChat/JsApiTicket/Refresh";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
            var response = Send(_method, _path, _urlparam, _body).Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<JsApiTicket>>(response);
        }
        /// <summary>
        /// 获取微信公众号JsApiTicket
        /// </summary>
        public async Task<QueryResultModel<JsApiTicket>> RefreshJsApiTicketAsync()
        {
            var _path="/api/WeChat/JsApiTicket/Refresh";
            var _method=System.Net.Http.HttpMethod.Get;
            object _body=null;
            Dictionary<string, object> _urlparam = new Dictionary<string, object>
            {
                
            };
			
            try
            {
				var response =await SendAsync(_method, _path, _urlparam, _body);
				var jsonstr =await response.Content.ReadAsStringAsync();
				return Newtonsoft.Json.JsonConvert.DeserializeObject<QueryResultModel<JsApiTicket>>(jsonstr); 
            }
            catch (Exception)
            {
                return QueryResultModel<JsApiTicket>.Failed("调用内部服务{WeChatApi.RefreshJsApiTicket}出错.请联系管理员");
            }
        }


    }

}