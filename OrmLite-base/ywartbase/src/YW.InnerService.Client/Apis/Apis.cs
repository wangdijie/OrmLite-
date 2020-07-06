 
 
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
        /// ������չʾ������һδ��¼�û�id��0
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
        /// ������չʾ������һδ��¼�û�id��0
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.ViewCountAdd}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����������
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
        /// ����������
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.Comment}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ������ҳ��Ϣ
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
        /// ������ҳ��Ϣ
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.SetMainInfo}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����������������ҳ��Ϣ
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
        /// ����������������ҳ��Ϣ
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.SetAllMainInfo}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.ClearName1}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{ArtistsApi.TestAgentOrder}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Artworks
    /// </summary>
    public partial class ArtworksApi:ApiBase
    {
         /// <summary>
        /// ����Ʒ����
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
        /// ����Ʒ����
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
                return PagedResultModel<ArtworkDataModel>.Failed("�����ڲ�����{ArtworksApi.QueryArtworks}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����ʱ����.��������֮����߼�
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
        /// ����ʱ����.��������֮����߼�
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.Comment}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ͳ�Ʋ�ͬ����Ʒ���
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
        /// ͳ�Ʋ�ͬ����Ʒ���
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SyncStock4Artworks}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ͳ�Ʋ�ͬ����Ʒ���
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
        /// ͳ�Ʋ�ͬ����Ʒ���
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SyncStock4Artwork}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ͬ����������Ʒ���
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
        /// ͬ����������Ʒ���
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SyncStock4AllArtworks}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������Ʒid��ȡ��Ӧ�Ŀ��û���
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
        /// ��������Ʒid��ȡ��Ӧ�Ŀ��û���
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
                return QueryResultModel<ArtworkFrameModel[]>.Failed("�����ڲ�����{ArtworksApi.Frames}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ�������,�˷�
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
        /// ��ȡ�������,�˷�
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
                return QueryResultModel<ArtworkFramePriceModel>.Failed("�����ڲ�����{ArtworksApi.FrameAmount}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �������Ƽ���Ʒ���ͨ��
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
        /// �������Ƽ���Ʒ���ͨ��
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.ArtistRecommendPass}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �������Ƽ���Ʒ��˾ܾ�
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
        /// �������Ƽ���Ʒ��˾ܾ�
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.ArtistRecommendReject}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �������Ƽ�����Ʒ,�ڵ���ǰ��У���Ƿ����Լ�����Ʒ
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
        /// �������Ƽ�����Ʒ,�ڵ���ǰ��У���Ƿ����Լ�����Ʒ
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.RecommendFromArtist}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ͬ������Ʒ��ǩ
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
        /// ͬ������Ʒ��ǩ
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SyncTag}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��clarifaiͬ����ɫ��Ϣ
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
        /// ��clarifaiͬ����ɫ��Ϣ
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SetClarifaiInfo}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����clarifai��Ϣ
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
        /// ����clarifai��Ϣ
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SetClarifaiInfo}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.SyncTag4All}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����Ʒչʾ������һδ��¼�û�id��0
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
        /// ����Ʒչʾ������һδ��¼�û�id��0
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
                return ResultModel.Failed("�����ڲ�����{ArtworksApi.ViewCountAdd}����.����ϵ����Ա");
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
                return QueryResultModel<String[]>.Failed("�����ڲ�����{ArtworksApi.GetColors}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Auctions
    /// </summary>
    public partial class AuctionsApi:ApiBase
    {
         /// <summary>
        /// ֧����֤��֧����
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
        /// ֧����֤��֧����
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{AuctionsApi.CreateDepositPayorder}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �˻���֤��
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
        /// �˻���֤��
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.DepositBack}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��֤��֧���ɹ�����
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
        /// ��֤��֧���ɹ�����
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.MarginPaymented}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����
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
        /// ����
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.BidPrice}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��Ʒ����
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
        /// ��Ʒ����
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.GoodEnd}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ר����ʼ
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
        /// ר����ʼ
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.Start}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ר������
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
        /// ר������
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.End}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������֧���ɹ�����
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
        /// ��������֧���ɹ�����
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.OrderPaid}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ער��
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
        /// ��ער��
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.FollowAuction}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ȡ����ע����ר��
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
        /// ȡ����ע����ר��
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.CancelFollowAuction}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ע��Ʒ
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
        /// ��ע��Ʒ
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.FollowGood}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ȡ����ע��Ʒ
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
        /// ȡ����ע��Ʒ
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.CancelFollowGood}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{AuctionsApi.Comment}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Email
    /// </summary>
    public partial class EmailApi:ApiBase
    {
         /// <summary>
        /// ���͵����ʼ�
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
        /// ���͵����ʼ�
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
                return ResultModel.Failed("�����ڲ�����{EmailApi.Send}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// MainOrders
    /// </summary>
    public partial class MainOrdersApi:ApiBase
    {
         /// <summary>
        /// ����������
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
        /// ����������
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{MainOrdersApi.Create}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �ײͶ���Ԥ���ӿ�
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
        /// �ײͶ���Ԥ���ӿ�
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
                return QueryResultModel<ArtworkPackageOrderPreviewModel>.Failed("�����ڲ�����{MainOrdersApi.PackageOrderPreview}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// todo:ֻ�����ˣ���û�ģ��Ժ��õ��������ٸ�΢��С����֧��ֻ���Լ�֧���Լ��Ķ���������todo
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
        /// todo:ֻ�����ˣ���û�ģ��Ժ��õ��������ٸ�΢��С����֧��ֻ���Լ�֧���Լ��Ķ���������todo
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{MainOrdersApi.WxMiniPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ΢�Ź��ں�֧��������(PC/΢�Ŷ�)΢��֧��ֻ���Լ�֧���Լ��Ķ���todo:wx֧���ص�https����ʱ������,
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
        /// ΢�Ź��ں�֧��������(PC/΢�Ŷ�)΢��֧��ֻ���Լ�֧���Լ��Ķ���todo:wx֧���ص�https����ʱ������,
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{MainOrdersApi.WechatMpPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ΢�ſ���ƽ̨֧��(APP΢��֧��)todo:���app�˲�û��ʹ��
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
        /// ΢�ſ���ƽ̨֧��(APP΢��֧��)todo:���app�˲�û��ʹ��
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
                return QueryResultModel<WechatPrepayOrderModel>.Failed("�����ڲ�����{MainOrdersApi.WechatAppPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ֧����APP֧��
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
        /// ֧����APP֧��
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
                return QueryResultModel<String>.Failed("�����ڲ�����{MainOrdersApi.AlipayAppPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ֧����PC֧������html
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
        /// ֧����PC֧������html
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
                return QueryResultModel<String>.Failed("�����ڲ�����{MainOrdersApi.AlipayWebPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ƻ��APP֧������tn��
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
        /// ƻ��APP֧������tn��
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
                return QueryResultModel<String>.Failed("�����ڲ�����{MainOrdersApi.ApplePay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ������֧���ɹ�ʱ����
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
        /// ������֧���ɹ�ʱ����
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
                return ResultModel.Failed("�����ڲ�����{MainOrdersApi.Payd}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// MainPayment
    /// </summary>
    public partial class MainPaymentApi:ApiBase
    {
         /// <summary>
        /// ��֧����֧���ɹ�
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
        /// ��֧����֧���ɹ�
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
                return ResultModel.Failed("�����ڲ�����{MainPaymentApi.Payd}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��֧�����˿�
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
        /// ��֧�����˿�
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
                return ResultModel.Failed("�����ڲ�����{MainPaymentApi.Refund}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Message
    /// </summary>
    public partial class MessageApi:ApiBase
    {
         /// <summary>
        /// ��������ר����ʼ��Ϣ
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
        /// ��������ר����ʼ��Ϣ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsRoundStart}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������ר��������Ϣ
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
        /// ��������ר��������Ϣ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsRoundEnd}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��Ʒ���³���
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
        /// ��Ʒ���³���
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsGoodsNewBid}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��Ʒ��������
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
        /// ��Ʒ��������
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsGoodsEnd}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����ר����֤���˿�
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
        /// ����ר����֤���˿�
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsDepositRefund}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����ר����֤���˿�
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
        /// ����ר����֤���˿�
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsRoundDepositRefund}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��֤��֧���ɹ�������Ϣ
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
        /// ��֤��֧���ɹ�������Ϣ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.AuctionsDepositPaid}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����վ����
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
        /// ����վ����
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.Send}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// һ����Ϣ�Ѷ�ȡ
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
        /// һ����Ϣ�Ѷ�ȡ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.Read}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �û��Ķ����з��͸�������Ϣ
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
        /// �û��Ķ����з��͸�������Ϣ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.ReadUserMsg}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �Ķ�һ���˷�������һ����������Ϣ
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
        /// �Ķ�һ���˷�������һ����������Ϣ
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.ReadUser2UserMsg}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ������app������Ϣ����
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
        /// ������app������Ϣ����
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendToAllApp}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ���ƶ��û���
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
        /// ���ƶ��û���
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendToApp}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����ģ�����
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
        /// ����ģ�����
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendTemplateSMS}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �ύ�������Ͷ��ź�΢��
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
        /// �ύ�������Ͷ��ź�΢��
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendCreateOrderMessage}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ֧���ɹ����Ͷ��ź�΢��
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
        /// ֧���ɹ����Ͷ��ź�΢��
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendOrderPaySuccessMessage}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ת��֧�����Ͷ��ź�΢��
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
        /// ת��֧�����Ͷ��ź�΢��
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
                return ResultModel.Failed("�����ڲ�����{MessageApi.SendFinancialAuditMessage}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Orders
    /// </summary>
    public partial class OrdersApi:ApiBase
    {
         /// <summary>
        /// ������Ʒ���������ӿ�����ǻ��ֹ��򷵻سɹ�ʱ.����״̬���ǳɹ�.�����rmb����.���سɹ�ʱ���ٵ�������������֧�����ӿ�,����֧������֧��
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
        /// ������Ʒ���������ӿ�����ǻ��ֹ��򷵻سɹ�ʱ.����״̬���ǳɹ�.�����rmb����.���سɹ�ʱ���ٵ�������������֧�����ӿ�,����֧������֧��
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{OrdersApi.CreatePointsOrder}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����֧����
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
        /// ����֧����
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
                return QueryResultModel<String>.Failed("�����ڲ�����{OrdersApi.CreatePayorder}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������
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
        /// ��������
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{OrdersApi.CreateOrder}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������
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
        /// ��������
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{OrdersApi.CreateOrder2}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������Ԥ���ӿ�
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
        /// ��������Ԥ���ӿ�
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
                return QueryResultModel<OrderPreviewModel>.Failed("�����ڲ�����{OrdersApi.PreviewCreate}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������Ԥ���ӿ�
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
        /// ��������Ԥ���ӿ�
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
                return QueryResultModel<OrderPreviewModel>.Failed("�����ڲ�����{OrdersApi.PreviewCreate2}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����֧���ɹ��߼�
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
        /// ����֧���ɹ��߼�
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
                return ResultModel.Failed("�����ڲ�����{OrdersApi.Paid}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ȡ������
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
        /// ȡ������
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
                return ResultModel.Failed("�����ڲ�����{OrdersApi.CancelOrder}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �Զ�ȡ������֧����ʱ����
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
        /// �Զ�ȡ������֧����ʱ����
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
                return ResultModel.Failed("�����ڲ�����{OrdersApi.AutoCancel}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Payorders
    /// </summary>
    public partial class PayordersApi:ApiBase
    {
         /// <summary>
        /// ΢�Ź���֧��֧����
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
        /// ΢�Ź���֧��֧����
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{PayordersApi.WeChatMpPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ΢��С����֧��֧����
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
        /// ΢��С����֧��֧����
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{PayordersApi.WxMiniMpPay}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ΢�Ź���֧����֧����
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
        /// ΢�Ź���֧����֧����
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{PayordersApi.WeChatMpPayMain}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ΢��С����֧����֧����
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
        /// ΢��С����֧����֧����
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
                return QueryResultModel<MpPayReqeustModel>.Failed("�����ڲ�����{PayordersApi.WxMiniMpPayMain}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{PayordersApi.Payd}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Spu
    /// </summary>
    public partial class SpuApi:ApiBase
    {
         /// <summary>
        /// spu�����ӿ�
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
        /// spu�����ӿ�
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
                return ResultModel.Failed("�����ڲ�����{SpuApi.Post}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// Users
    /// </summary>
    public partial class UsersApi:ApiBase
    {
         /// <summary>
        /// �����û�ID�Ƽ�����Ʒ
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
        /// �����û�ID�Ƽ�����Ʒ
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
                return QueryResultModel<Int64[]>.Failed("�����ڲ�����{UsersApi.RecommendArtworks}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��������
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
        /// ��������
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetPassword}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����û��Ƿ������״γ�һ���Ա�Ͱ滭
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
        /// ����û��Ƿ������״γ�һ���Ա�Ͱ滭
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.CheckFreeArtworkForVip}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ���Ͱ滭
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
        /// ���Ͱ滭
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
                return QueryResultModel<Int64>.Failed("�����ڲ�����{UsersApi.PresentFreeArtworkForVip}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ͨ��������֤����������
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
        /// ͨ��������֤����������
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetPasswordByCode}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �����ֻ�����
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
        /// �����ֻ�����
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetPhone}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �����û�������Ϣ
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
        /// �����û�������Ϣ
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetInfo}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �ϴ��û�ͷ��,����ΪͼƬ�ֽ���.
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
        /// �ϴ��û�ͷ��,����ΪͼƬ�ֽ���.
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.UploadPhoto}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ʹ��Ĭ��ͷ��
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
        /// ʹ��Ĭ��ͷ��
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetPhoto}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �ֻ���������ע��
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
        /// �ֻ���������ע��
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
                return QueryResultModel<Boolean>.Failed("�����ڲ�����{UsersApi.PhoneIsReg}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ɾ���û�
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
        /// ɾ���û�
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.Delete}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ���÷�vip
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
        /// ���÷�vip
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SetNotVip}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �Ƿ���΢�Ź�ע�û�
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
        /// �Ƿ���΢�Ź�ע�û�
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
                return QueryResultModel<Boolean>.Failed("�����ڲ�����{UsersApi.WeiXinIsSubscribe}����.����ϵ����Ա");
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.WeixinUserInfo}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �����Ը��
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
        /// �����Ը��
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.LikeArtwork}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ɾ����Ը��
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
        /// ɾ����Ը��
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.UnLikeArtwork}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ϲ��������
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
        /// ϲ��������
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.LikeArtist}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ����ϲ��������
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
        /// ����ϲ��������
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.UnLikeArtist}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �û�ǩ��
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
        /// �û�ǩ��
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SignIn}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �����û�����2.ǩ������  3.���ѻ���(������) 4.���޻��� 5.���ۻ��� 6.�����������ͻ��� 7.�����Ʒ�ͻ���
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
        /// �����û�����2.ǩ������  3.���ѻ���(������) 4.���޻��� 5.���ۻ��� 6.�����������ͻ��� 7.�����Ʒ�ͻ���
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.GivePoint}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ���ƶ��û������ƶ��Ż�ȯ
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
        /// ���ƶ��û������ƶ��Ż�ȯ
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SendVoucher}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �������û�����ָ���Ż�ȯ
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
        /// �������û�����ָ���Ż�ȯ
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SendBatchVoucher}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ָ�����û�����ָ�����˷�ȯ
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
        /// ��ָ�����û�����ָ�����˷�ȯ
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SendFreightVoucher}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��VIP�û�����3���Ż�ȯ
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
        /// ��VIP�û�����3���Ż�ȯ
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.SendVipVouchers}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ��ȡ������/������֯�Ŀ����ֽ����Ƿ�����֯����isOrgΪtrue
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
        /// ��ȡ��ȡ������/������֯�Ŀ����ֽ����Ƿ�����֯����isOrgΪtrue
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
                return QueryResultModel<Decimal>.Failed("�����ڲ�����{UsersApi.GetAgentUserAvailableAmount}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// �û�ע��ӿ�
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
        /// �û�ע��ӿ�
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
                return ResultModel.Failed("�����ڲ�����{UsersApi.Post}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ�û���Ϣ
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
        /// ��ȡ�û���Ϣ
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
                return QueryResultModel<UserInfoModel>.Failed("�����ڲ�����{UsersApi.Get}����.����ϵ����Ա");
            }
        }


    }
    
    /// <summary>
    /// WeChat
    /// </summary>
    public partial class WeChatApi:ApiBase
    {
         /// <summary>
        /// ��ȡ΢�Ź��ں�AccessToken
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
        /// ��ȡ΢�Ź��ں�AccessToken
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
                return QueryResultModel<AccessToken>.Failed("�����ڲ�����{WeChatApi.AccessToken}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ�µ�΢�Ź��ں�AccessToken
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
        /// ��ȡ�µ�΢�Ź��ں�AccessToken
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
                return QueryResultModel<AccessToken>.Failed("�����ڲ�����{WeChatApi.RefreshAccessToken}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ΢�Ź��ں�JsApiTicket
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
        /// ��ȡ΢�Ź��ں�JsApiTicket
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
                return QueryResultModel<JsApiTicket>.Failed("�����ڲ�����{WeChatApi.JsApiTicket}����.����ϵ����Ա");
            }
        }


        /// <summary>
        /// ��ȡ΢�Ź��ں�JsApiTicket
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
        /// ��ȡ΢�Ź��ں�JsApiTicket
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
                return QueryResultModel<JsApiTicket>.Failed("�����ڲ�����{WeChatApi.RefreshJsApiTicket}����.����ϵ����Ա");
            }
        }


    }

}