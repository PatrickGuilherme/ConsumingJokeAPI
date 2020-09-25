using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ClassLibrary
{
    public class Client
    {
        private string UrlJokeApi { get; set; }

        public Client(string url)
        {
            if(url != null)
            {
                if(url.Trim().Length > 0)
                {
                    this.UrlJokeApi = url;
                }
            }
        }

        public async System.Threading.Tasks.Task<FinalJoke> StartHttpClientAsync()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, this.UrlJokeApi);
            HttpResponseMessage response = httpClient.SendAsync(request).Result;
            string dados = await response.Content.ReadAsStringAsync();
            FinalJoke finalJoke = JsonConvert.DeserializeObject<FinalJoke>(dados);
            return finalJoke;
        }
    }
}
