using ADP.Model.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace ADP.Lib
{
    public class Http
    {
        static readonly HttpClient _httpClient = new HttpClient();

        public Http(string baseAddress)
        {
            if (_httpClient.BaseAddress == null)
                _httpClient.BaseAddress = new Uri(baseAddress);
        }

        public async Task<T> GetRequest<T>(string url)
        {
            var request = await _httpClient.GetAsync(url);

            if (!request.IsSuccessStatusCode)
                throw new Exception("Erro ao obter a requisição.");

            var model = await request.Content.ReadAsAsync<T>();

            return model;
        }

        public async Task<RequestResult> PostRequest<T>(string url, T model)
        {
            var request = await _httpClient.PostAsync(url,
                new StringContent(JsonConvert.SerializeObject(model,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }), Encoding.UTF8, "application/json"));

            return new RequestResult()
            {
                StatusCode = request.StatusCode,
                Message = await request.Content.ReadAsStringAsync()
            };
        }
    }
}