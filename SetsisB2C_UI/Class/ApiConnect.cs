using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace SetsisB2B.Class
{


    public class ApiConnect
    {
        private string strResponse;
        public string StrResponse
        {
            get
            {
                return strResponse;
            }
            set
            {
                strResponse = value;
            }
        }

        public ApiConnect(string endPoint)
        {
            RestClient rest = new RestClient();

            rest.authType = authenticationType.NTLM;
            rest.endPoint = endPoint;
            StrResponse = string.Empty;
            StrResponse = rest.makeRequest();
        }

        public ApiConnect(string endPoint, string POST)
        {
            RestClient rest = new RestClient(1);

            rest.authType = authenticationType.NTLM;
            rest.endPoint = endPoint;
            StrResponse = string.Empty;
            StrResponse = rest.makeRequest();
        }

    }
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum authenticationType
    {
        Basic,
        NTLM
    }

    public enum autheticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public autheticationTechnique authTech { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public RestClient(int a)
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.POST;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = "GET";
            request.ServicePoint.Expect100Continue = false;
            request.ProtocolVersion = HttpVersion.Version11;
            request.KeepAlive = true;
            request.AllowAutoRedirect = false;
            request.ContentType = "application/json; charset=utf-8";
            request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            request.CookieContainer = new CookieContainer();
            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.3) Gecko/20070309 Firefox/2.0.0.3";
            request.Headers.Add("Keep-Alive", "300");
            request.Timeout = 15000;
            request.Pipelined = false;
            String authHeaer = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userName + ":" + userPassword));
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {

                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }

            }

            return strResponseValue;
        }
        public async Task<string> GetWebRequestAsync(string _url)
        {
            WebRequest webRequest = WebRequest.Create(_url);
            webRequest.Timeout = Int32.MaxValue;
            WebResponse response = await webRequest.GetResponseAsync();
            StreamReader _sr = new StreamReader(response.GetResponseStream());
            return await _sr.ReadToEndAsync();
        }


    }
}
