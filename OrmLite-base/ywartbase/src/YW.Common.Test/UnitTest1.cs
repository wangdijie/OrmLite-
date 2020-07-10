using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using YW.Dal.Database;
using YW.Common.Convertor;
using YW.Common.Search;

namespace YW.Common.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchTest()
        {
            var sc = new AliCouldSearch(
                "XXXXXXXXXXX",
                "jiushitereertre",
                "http://opensearch-cn-beijing.aliyuncs.com",
                "ywart_artwork"
                );
            int count = 0;
            var sp = new SearchParams { };
            sp.Keywords = "灰色";
            sp.Filter = "is_collect=0";
            sp.Start=0;
            sp.Size=10;
            //sp.SortField = "-sort_key";
            var sr = sc.Search<SearchModel>(sp, out count);
            Assert.IsNotNull(sr);
        }

        public class SearchModel
        {
            public long Id { get; set; }

            public string Artwork_Name { get; set; }
            public string Tags { get; set; }
        }
        [TestMethod]
        public void PinyinCovertorTest1()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("我和我的祖国", "wohewodezuguo");
            foreach (var item in dict)
            {
                var pinyin = YW.Common.Pinyin.PinyinConvertor.GetPinyin(item.Key);
                Assert.AreEqual(item.Value, pinyin);
            }
        }

        [TestMethod]
        public void PinyinCovertorTest2()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("我和我的祖国", "whwdzg");
            dict.Add("我和我的祖 国", "whwdz g");
            foreach (var item in dict)
            {
                var pinyin = YW.Common.Pinyin.PinyinConvertor.GetPinyin(item.Key, true);
                Assert.AreEqual(item.Value, pinyin);
            }
        }
        //[TestMethod]
        //public void DbSumTest()
        //{
        //    var sum = DbFactory.YW2016.ArtworkOrder.Sum<decimal>(m => m.PayAmount, m => true);
        //    Assert.IsTrue(sum > 0);
        //}

        [TestMethod]
        public void AmountFormatTest()
        {
            SortedDictionary<decimal, string> dictUseCase = new SortedDictionary<decimal, string>();
            dictUseCase.Add(10000m, "10,000");
            dictUseCase.Add(10000.001m, "10,000");
            dictUseCase.Add(10000.3m, "10,000.30");
            dictUseCase.Add(10000.114m, "10,000.11");
            dictUseCase.Add(10000.115m, "10,000.12");
            dictUseCase.Add(-10000m, "-10,000");
            dictUseCase.Add(.01m, "0.01");
            dictUseCase.Add(.1m, "0.10");

            foreach (var item in dictUseCase)
            {
                Assert.AreEqual(item.Value, DataFormatter.AmountFormat(item.Key));
            }
        }

    }
}
