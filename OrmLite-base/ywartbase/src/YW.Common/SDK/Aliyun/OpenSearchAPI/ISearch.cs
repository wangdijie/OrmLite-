using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Model;

namespace YW.Common.Search
{
    /// <summary>
    /// 搜索服务接口
    /// </summary>
    public interface ISearch
    {
        /// <summary>
        /// 添加搜索项
        /// </summary>
        ResultModel AddDoc(IEnumerable<object> doc, string table = "main");
        /// <summary>
        /// 更新搜索项
        /// </summary>
        ResultModel UpdateDoc(IEnumerable<object> doc, string table = "main");
        /// <summary>
        /// 删除搜索项
        /// </summary>
        ResultModel DeleteDoc(IEnumerable<object> doc, string table = "main");
        /// <summary>
        /// 搜索
        /// </summary>
        IEnumerable<T> Search<T>(SearchParams param, out int count) where T : class, new();
        /// <summary>
        /// 自动完成搜索
        /// </summary>
        IEnumerable<string> AutoComplete(string suggest, string keywords);

    }
}
