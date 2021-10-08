using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Web.DAL.Interfaces;

namespace Web.DAL
{
    public class RequestHandler : IRequestHandler
    {

        static HttpClient client;//recommended to be static for connection performance

        public RequestHandler(string endpointUrl)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (client == null)
            {
                client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true });
                client.BaseAddress = new Uri(endpointUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public void Post<T>(string operationPath, T postContent)
        {
            var payload = JsonConvert.SerializeObject(postContent);

            HttpContent content = new StringContent(payload, Encoding.UTF8, "application/json");

            var response = client.PostAsync(operationPath, content).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error connecting to API ,base Url '{client.BaseAddress}',Operation name '{operationPath}' ,HTTP response code is '{response.StatusCode}'");
            }
        }
    }
}
