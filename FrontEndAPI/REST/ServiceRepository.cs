using System;
using System.Net.Http;

namespace FrontEndAPI.REST
{
    public class ServiceRepository
    {
        public HttpClient Client { get; set; }

        public ServiceRepository(string url)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }

        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage PostResponse(string url, object model)
        {
            url = Client.BaseAddress.ToString() + url;
            return Client.PostAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }
    }
}