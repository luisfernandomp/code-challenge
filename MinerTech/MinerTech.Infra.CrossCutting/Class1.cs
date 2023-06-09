using Newtonsoft.Json;
using RestSharp;
using System.Runtime.CompilerServices;

namespace MinerTech.Infra.CrossCutting
{
    public class Miner
    {
        private readonly IRestClient _restClient;
        private RestRequest _restRequest;

        public Miner(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
            _restRequest = new RestRequest();
        }

        private void Initialize()
        {
            _restRequest.Timeout = 999;

            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddHeader("Content-Type", "application/json");
        }

        public async Task<T> Execute<T>(string body, Method method, string resource) where T : class 
        {
            _restRequest.Method = method;
            _restRequest.Resource= resource;
            
            if(!string.IsNullOrEmpty(body)) 
                _restRequest.AddJsonBody(body);

            
            var response = await _restClient.ExecuteAsync(_restRequest);

            return JsonConvert.DeserializeObject<T>(response.Content ?? "") 
                    ?? throw new Exception("");
        }

    }
}