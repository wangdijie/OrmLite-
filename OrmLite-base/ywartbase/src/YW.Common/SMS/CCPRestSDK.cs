using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace YW.Common.SMS
{
	public class CCPRestSDK
	{
		private const string softVer = "2013-12-26";

		private string m_restAddress;

		private string m_restPort;

		private string m_mainAccount;

		private string m_mainToken;

		private string m_subAccount;

		private string m_subToken;

		private string m_voipAccount;

		private string m_voipPwd;

		private string m_appId;

		private bool m_isWriteLog;

		private EBodyType m_bodyType;

		public bool init(string restAddress, string restPort)
		{
			this.m_restAddress = restAddress;
			this.m_restPort = restPort;
			return this.m_restAddress != null && this.m_restAddress.Length >= 0 && this.m_restPort != null && this.m_restPort.Length >= 0 && Convert.ToInt32(this.m_restPort) >= 0;
		}

		public void setAccount(string accountSid, string accountToken)
		{
			this.m_mainAccount = accountSid;
			this.m_mainToken = accountToken;
		}

		public void setSubAccount(string subAccountSid, string subAccountToken, string voipAccount, string voipPassword)
		{
			this.m_subAccount = subAccountSid;
			this.m_subToken = subAccountToken;
			this.m_voipAccount = voipAccount;
			this.m_voipPwd = voipPassword;
		}

		public void setAppId(string appId)
		{
			this.m_appId = appId;
		}

		public void enabeLog(bool enable)
		{
			this.m_isWriteLog = enable;
		}

		public string GetLogPath()
		{
			string dllpath = Assembly.GetExecutingAssembly().CodeBase;
			dllpath = dllpath.Substring(8, dllpath.Length - 8);
			return Path.GetDirectoryName(dllpath) + "\\log.txt";
		}

		public Dictionary<string, object> QueryAccountInfo()
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/AccountInfo?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("QueryAccountInfo url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "GET";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
					{
						StreamReader reader = new StreamReader(response.GetResponseStream());
						string responseStr = reader.ReadToEnd();
						this.WriteLog("QueryAccountInfo responseBody = " + responseStr);
						if (responseStr != null && responseStr.Length > 0)
						{
							Dictionary<string, object> responseResult = new Dictionary<string, object>
							{
								{
									"statusCode",
									"0"
								},
								{
									"statusMsg",
									"成功"
								},
								{
									"data",
									null
								}
							};
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							foreach (XmlNode item in nodeList)
							{
								if (item.Name == "statusCode")
								{
									responseResult["statusCode"] = item.InnerText;
								}
								else if (item.Name == "statusMsg")
								{
									responseResult["statusMsg"] = item.InnerText;
								}
								else if (item.Name == "Account")
								{
									Dictionary<string, object> data = new Dictionary<string, object>();
									foreach (XmlNode subItem in item.ChildNodes)
									{
										data.Add(subItem.Name, subItem.InnerText);
									}
									responseResult["data"] = new Dictionary<string, object>
									{
										{
											item.Name,
											data
										}
									};
								}
							}
							result = responseResult;
							return result;
						}
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
						return result;
					}
				}
				request.Accept = "application/json";
				request.ContentType = "application/json;charset=utf-8";
				using (HttpWebResponse response2 = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader2 = new StreamReader(response2.GetResponseStream());
					string responseStr2 = reader2.ReadToEnd();
					this.WriteLog("QueryAccountInfo responseBody = " + responseStr2);
					if (responseStr2 != null && responseStr2.Length > 0)
					{
						Dictionary<string, object> responseResult2 = new Dictionary<string, object>();
						responseResult2["resposeBody"] = responseStr2;
						result = responseResult2;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> CreateSubAccount(string friendlyName)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/SubAccounts?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("CreateSubAccount url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<friendlyName>").Append(friendlyName).Append("</friendlyName>");
					data.Append("</SubAccount>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append(",\"friendlyName\":\"").Append(friendlyName).Append("\"");
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("CreateSubAccount requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("CreateSubAccount responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();

                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "SubAccount")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_44B;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_44B:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> GetSubAccounts(uint startNo, uint offset)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (offset < 1u || offset > 100u)
			{
				throw new ArgumentOutOfRangeException("offset超出范围");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/GetSubAccounts?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("GetSubAccounts url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<startNo>").Append(startNo).Append("</startNo>");
					data.Append("<offset>").Append(offset).Append("</offset>");
					data.Append("</SubAccount>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append(",\"startNo\":\"").Append(startNo).Append("\"");
					data.Append(",\"offset\":\"").Append(offset).Append("\"");
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("GetSubAccounts requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("GetSubAccounts responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						Dictionary<string, object> retData = new Dictionary<string, object>();
						List<object> subAccountList = new List<object>();
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "totalCount")
									{
										retData.Add(item.Name, item.InnerText);
									}
									else if (item.Name == "SubAccount")
									{
										Dictionary<string, object> SubAccount = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											SubAccount.Add(subItem.Name, subItem.InnerText);
										}
										subAccountList.Add(SubAccount);
									}
								}
								goto IL_4AD;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_4AD:
						if (retData.Count > 0)
						{
							if (subAccountList.Count > 0)
							{
								retData.Add("SubAccount", subAccountList);
							}
							responseResult["data"] = retData;
						}
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> QuerySubAccount(string friendlyName)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/QuerySubAccountByName?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("QuerySubAccount url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<friendlyName>").Append(friendlyName).Append("</friendlyName>");
					data.Append("</SubAccount>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append(",\"friendlyName\":\"").Append(friendlyName).Append("\"");
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("QuerySubAccount requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("QuerySubAccount responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "SubAccount")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_44B;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_44B:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> SendSMS(string to, string body)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			if (body == null)
			{
				throw new ArgumentNullException("body");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/SMS/Messages?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("SendSMS url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><SMSMessage>");
					data.Append("<to>").Append(to).Append("</to>");
					data.Append("<body>").Append(body).Append("</body>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("</SMSMessage>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"to\":\"").Append(to).Append("\"");
					data.Append(",\"body\":\"").Append(body).Append("\"");
					data.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("SendSMS requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("SendSMS responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "SMSMessage")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_499;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_499:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> SendTemplateSMS(string to, string templateId, string[] data)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			if (templateId == null)
			{
				throw new ArgumentNullException("templateId");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/SMS/TemplateSMS?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("SendTemplateSMS url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder bodyData = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					bodyData.Append("<?xml version='1.0' encoding='utf-8'?><TemplateSMS>");
					bodyData.Append("<to>").Append(to).Append("</to>");
					bodyData.Append("<appId>").Append(this.m_appId).Append("</appId>");
					bodyData.Append("<templateId>").Append(templateId).Append("</templateId>");
					if (data != null && data.Length > 0)
					{
						bodyData.Append("<datas>");
						for (int i = 0; i < data.Length; i++)
						{
							string item = data[i];
							bodyData.Append("<data>").Append(item).Append("</data>");
						}
						bodyData.Append("</datas>");
					}
					bodyData.Append("</TemplateSMS>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					bodyData.Append("{");
					bodyData.Append("\"to\":\"").Append(to).Append("\"");
					bodyData.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
					bodyData.Append(",\"templateId\":\"").Append(templateId).Append("\"");
					if (data != null && data.Length > 0)
					{
						bodyData.Append(",\"datas\":[");
						int index = 0;
						for (int j = 0; j < data.Length; j++)
						{
							string item2 = data[j];
							if (index == 0)
							{
								bodyData.Append("\"" + item2 + "\"");
							}
							else
							{
								bodyData.Append(",\"" + item2 + "\"");
							}
							index++;
						}
						bodyData.Append("]");
					}
					bodyData.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(bodyData.ToString());
				this.WriteLog("SendTemplateSMS requestBody = " + bodyData.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("SendTemplateSMS responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item3 = (XmlNode)enumerator.Current;
									if (item3.Name == "statusCode")
									{
										responseResult["statusCode"] = item3.InnerText;
									}
									else if (item3.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item3.InnerText;
									}
									else if (item3.Name == "TemplateSMS")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item3.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item3.Name,
												retData
											}
										};
									}
								}
								goto IL_578;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_578:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> CallBack(string from, string to, string customerSerNum, string fromSerNum, string promptTone)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckSunAccount();
			if (initError != null)
			{
				return initError;
			}
			if (from == null)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_subAccount + this.m_subToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/SubAccounts/{3}/Calls/Callback?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_subAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("CallBack url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_subAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><CallBack>");
					data.Append("<from>").Append(from).Append("</from>");
					data.Append("<to>").Append(to).Append("</to>");
					if (customerSerNum != null)
					{
						data.Append("<customerSerNum>").Append(customerSerNum).Append("</customerSerNum>");
					}
					if (fromSerNum != null)
					{
						data.Append("<fromSerNum>").Append(fromSerNum).Append("</fromSerNum>");
					}
					if (promptTone != null)
					{
						data.Append("<promptTone>").Append(promptTone).Append("</promptTone>");
					}
					data.Append("</CallBack>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"from\":\"").Append(from).Append("\"");
					data.Append(",\"to\":\"").Append(to).Append("\"");
					if (customerSerNum != null)
					{
						data.Append(",\"customerSerNum\":\"").Append(customerSerNum).Append("\"");
					}
					if (fromSerNum != null)
					{
						data.Append(",\"fromSerNum\":\"").Append(fromSerNum).Append("\"");
					}
					if (promptTone != null)
					{
						data.Append(",\"promptTone\":\"").Append(promptTone).Append("\"");
					}
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("CallBack requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("CallBack responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "CallBack")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_511;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_511:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> LandingCall(string to, string mediaName, string mediaTxt, string displayNum, string playTimes, int type, string respUrl)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			if (mediaName == null && mediaTxt == null)
			{
				throw new ArgumentNullException("mediaName和mediaTxt同时为null");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/Calls/LandingCalls?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("LandingCall url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><LandingCall>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<to>").Append(to).Append("</to>");
					if (mediaName != null)
					{
						data.Append("<mediaName type=\"" + type + "\">").Append(mediaName).Append("</mediaName>");
					}
					if (mediaTxt != null)
					{
						data.Append("<mediaTxt>").Append(mediaTxt).Append("</mediaTxt>");
					}
					if (displayNum != null)
					{
						data.Append("<displayNum>").Append(displayNum).Append("</displayNum>");
					}
					if (playTimes != null)
					{
						data.Append("<playTimes>").Append(playTimes).Append("</playTimes>");
					}
					if (respUrl != null)
					{
						data.Append("<respUrl>").Append(respUrl).Append("</respUrl>");
					}
					data.Append("</LandingCall>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"to\":\"").Append(to).Append("\"");
					data.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
					if (mediaName != null)
					{
						data.Append(",\"mediaName\":\"").Append(mediaName).Append("\"");
						data.Append(",\"mediaNameType\":\"").Append(type).Append("\"");
					}
					if (mediaTxt != null)
					{
						data.Append(",\"mediaTxt\":\"").Append(mediaTxt).Append("\"");
					}
					if (displayNum != null)
					{
						data.Append(",\"displayNum\":\"").Append(displayNum).Append("\"");
					}
					if (playTimes != null)
					{
						data.Append(",\"playTimes\":\"").Append(playTimes).Append("\"");
					}
					if (respUrl != null)
					{
						data.Append(",\"respUrl\":\"").Append(respUrl).Append("\"");
					}
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("LandingCall requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("LandingCall responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "LandingCall")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_5DD;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_5DD:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> VoiceVerify(string to, string verifyCode, string displayNum, string playTimes, string respUrl)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			if (verifyCode == null)
			{
				throw new ArgumentNullException("verifyCode");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/Calls/VoiceVerify?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("VoiceVerify url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><VoiceVerify>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<verifyCode>").Append(verifyCode).Append("</verifyCode>");
					data.Append("<to>").Append(to).Append("</to>");
					if (displayNum != null)
					{
						data.Append("<displayNum>").Append(displayNum).Append("</displayNum>");
					}
					if (playTimes != null)
					{
						data.Append("<playTimes>").Append(playTimes).Append("</playTimes>");
					}
					if (respUrl != null)
					{
						data.Append("<respUrl>").Append(respUrl).Append("</respUrl>");
					}
					data.Append("</VoiceVerify>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"to\":\"").Append(to).Append("\"");
					data.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append(",\"verifyCode\":\"").Append(verifyCode).Append("\"");
					if (displayNum != null)
					{
						data.Append(",\"displayNum\":\"").Append(displayNum).Append("\"");
					}
					if (playTimes != null)
					{
						data.Append(",\"playTimes\":\"").Append(playTimes).Append("\"");
					}
					if (respUrl != null)
					{
						data.Append(",\"respUrl\":\"").Append(respUrl).Append("\"");
					}
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("VoiceVerify requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("VoiceVerify responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else if (item.Name == "VoiceVerify")
									{
										Dictionary<string, object> retData = new Dictionary<string, object>();
										foreach (XmlNode subItem in item.ChildNodes)
										{
											retData.Add(subItem.Name, subItem.InnerText);
										}
										responseResult["data"] = new Dictionary<string, object>
										{
											{
												item.Name,
												retData
											}
										};
									}
								}
								goto IL_561;
							}
							finally
							{
								IDisposable disposable2 = enumerator as IDisposable;
								if (disposable2 != null)
								{
									disposable2.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_561:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> IvrDial(string number, string userdata, string record)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (number == null)
			{
				throw new ArgumentNullException("number");
			}
			Dictionary<string, object> result;
			try
			{
				string date = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + date);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/ivr/dial?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("IvrDial url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				request.Accept = "application/xml";
				request.ContentType = "application/xml;charset=utf-8";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + date);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				data.Append("<?xml version='1.0' encoding='utf-8'?><Request>");
				data.Append("<Appid>").Append(this.m_appId).Append("</Appid>");
				data.Append("<Dial ");
				data.Append("number=\"" + number + "\"");
				if (userdata != null)
				{
					data.Append(" userdata=\"" + userdata + "\"");
				}
				if (record != null && record == "true")
				{
					data.Append(" record=\"true\"");
				}
				data.Append("></Dial>");
				data.Append("</Request>");
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("IvrDial requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("IvrDial responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
								}
								goto IL_37D;
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_37D:
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		public Dictionary<string, object> BillRecords(string date, string keywords)
		{
			Dictionary<string, object> initError = this.paramCheckRest();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckMainAccount();
			if (initError != null)
			{
				return initError;
			}
			initError = this.paramCheckAppId();
			if (initError != null)
			{
				return initError;
			}
			if (date == null)
			{
				throw new ArgumentNullException("date");
			}
			Dictionary<string, object> result;
			try
			{
				string mydate = DateTime.Now.ToString("yyyyMMddhhmmss");
				string sigstr = CCPRestSDK.MD5Encrypt(this.m_mainAccount + this.m_mainToken + mydate);
				string uriStr = string.Format("https://{0}:{1}/{2}/Accounts/{3}/BillRecords?sig={4}", new object[]
				{
					this.m_restAddress,
					this.m_restPort,
					"2013-12-26",
					this.m_mainAccount,
					sigstr
				});
				Uri address = new Uri(uriStr);
				this.WriteLog("BillRecords url = " + uriStr);
				HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
				this.setCertificateValidationCallBack();
				request.Method = "POST";
				Encoding myEncoding = Encoding.GetEncoding("utf-8");
				byte[] myByte = myEncoding.GetBytes(this.m_mainAccount + ":" + mydate);
				string authStr = Convert.ToBase64String(myByte);
				request.Headers.Add("Authorization", authStr);
				StringBuilder data = new StringBuilder();
				if (this.m_bodyType == EBodyType.EType_XML)
				{
					request.Accept = "application/xml";
					request.ContentType = "application/xml;charset=utf-8";
					data.Append("<?xml version='1.0' encoding='utf-8'?><BillRecords>");
					data.Append("<appId>").Append(this.m_appId).Append("</appId>");
					data.Append("<date>").Append(date).Append("</date>");
					if (keywords != null)
					{
						data.Append("<keywords>").Append(keywords).Append("</keywords>");
					}
					data.Append("</BillRecords>");
				}
				else
				{
					request.Accept = "application/json";
					request.ContentType = "application/json;charset=utf-8";
					data.Append("{");
					data.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
					data.Append(",\"date\":\"").Append(date).Append("\"");
					if (keywords != null)
					{
						data.Append(",\"keywords\":\"").Append(keywords).Append("\"");
					}
					data.Append("}");
				}
				byte[] byteData = Encoding.UTF8.GetBytes(data.ToString());
				this.WriteLog("BillRecords requestBody = " + data.ToString());
				using (Stream postStream = request.GetRequestStream())
				{
					postStream.Write(byteData, 0, byteData.Length);
				}
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					StreamReader reader = new StreamReader(response.GetResponseStream());
					string responseStr = reader.ReadToEnd();
					this.WriteLog("BillRecords responseBody = " + responseStr);
					if (responseStr != null && responseStr.Length > 0)
					{
						Dictionary<string, object> responseResult = new Dictionary<string, object>
						{
							{
								"statusCode",
								"0"
							},
							{
								"statusMsg",
								"成功"
							},
							{
								"data",
								null
							}
						};
						Dictionary<string, object> retData = new Dictionary<string, object>();
						if (this.m_bodyType == EBodyType.EType_XML)
						{
							XmlDocument resultXml = new XmlDocument();
                            resultXml.XmlResolver = null;//解决XML解析存在的安全问题
                            resultXml.LoadXml(responseStr);
							XmlNodeList nodeList = resultXml.SelectSingleNode("Response").ChildNodes;
							IEnumerator enumerator = nodeList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode item = (XmlNode)enumerator.Current;
									if (item.Name == "statusCode")
									{
										responseResult["statusCode"] = item.InnerText;
									}
									else if (item.Name == "statusMsg")
									{
										responseResult["statusMsg"] = item.InnerText;
									}
									else
									{
										retData.Add(item.Name, item.InnerText);
									}
								}
								goto IL_40F;
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						responseResult.Clear();
						responseResult["resposeBody"] = responseStr;
						IL_40F:
						if (retData.Count > 0)
						{
							responseResult["data"] = retData;
						}
						result = responseResult;
					}
					else
					{
						result = new Dictionary<string, object>
						{
							{
								"statusCode",
								172002
							},
							{
								"statusMsg",
								"无返回"
							},
							{
								"data",
								null
							}
						};
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}
			return result;
		}

		private void WriteLog(string log)
		{
			if (this.m_isWriteLog)
			{
				string strFilePath = this.GetLogPath();
				FileStream fs = new FileStream(strFilePath, FileMode.Append);
				StreamWriter sw = new StreamWriter(fs, Encoding.Default);
				sw.WriteLine(DateTime.Now.ToString() + "\t" + log);
				sw.Close();
				fs.Close();
			}
		}

		private Dictionary<string, object> paramCheckRest()
		{
			int statusCode = 0;
			string statusMsg = null;
			if (this.m_restAddress == null)
			{
				statusCode = 172004;
				statusMsg = "IP空";
			}
			else if (this.m_restPort == null)
			{
				statusCode = 172005;
				statusMsg = "端口错误";
			}
			if (statusCode != 0)
			{
				return new Dictionary<string, object>
				{
					{
						"statusCode",
						string.Concat(statusCode)
					},
					{
						"statusMsg",
						statusMsg
					},
					{
						"data",
						null
					}
				};
			}
			return null;
		}

		private Dictionary<string, object> paramCheckMainAccount()
		{
			int statusCode = 0;
			string statusMsg = null;
			if (this.m_mainAccount == null)
			{
				statusCode = 172006;
				statusMsg = "主帐号空";
			}
			else if (this.m_mainToken == null)
			{
				statusCode = 172007;
				statusMsg = "主帐号令牌空";
			}
			if (statusCode != 0)
			{
				return new Dictionary<string, object>
				{
					{
						"statusCode",
						string.Concat(statusCode)
					},
					{
						"statusMsg",
						statusMsg
					},
					{
						"data",
						null
					}
				};
			}
			return null;
		}

		private Dictionary<string, object> paramCheckSunAccount()
		{
			int statusCode = 0;
			string statusMsg = null;
			if (this.m_subAccount == null)
			{
				statusCode = 172008;
				statusMsg = "子帐号空";
			}
			else if (this.m_subToken == null)
			{
				statusCode = 172009;
				statusMsg = "子帐号令牌空";
			}
			else if (this.m_voipAccount == null)
			{
				statusCode = 1720010;
				statusMsg = "VoIP帐号空";
			}
			else if (this.m_voipPwd == null)
			{
				statusCode = 172011;
				statusMsg = "VoIP密码空";
			}
			if (statusCode != 0)
			{
				return new Dictionary<string, object>
				{
					{
						"statusCode",
						string.Concat(statusCode)
					},
					{
						"statusMsg",
						statusMsg
					},
					{
						"data",
						null
					}
				};
			}
			return null;
		}

		private Dictionary<string, object> paramCheckAppId()
		{
			if (this.m_appId == null)
			{
				return new Dictionary<string, object>
				{
					{
						"statusCode",
						string.Concat(172012)
					},
					{
						"statusMsg",
						"应用ID为空"
					},
					{
						"data",
						null
					}
				};
			}
			return null;
		}

		public static string MD5Encrypt(string source)
		{
			MD5 md5Hasher = MD5.Create();
			byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(source));
			StringBuilder sBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("X2"));
			}
			return sBuilder.ToString();
		}

		public void setCertificateValidationCallBack()
		{
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CertificateValidationResult);
		}

		public bool CertificateValidationResult(object obj, X509Certificate cer, X509Chain chain, SslPolicyErrors error)
		{
			return true;
		}
	}
}
