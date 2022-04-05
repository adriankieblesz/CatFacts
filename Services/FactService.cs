using NetwiseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace NetwiseTest.Services
{
    //Service that provides fetching data connecting to a specific endpoint 
    public class FactService : IFactService
    {
        //Dependency injection goes here
        private readonly IHttpClientFactory _clientFactory;
        public bool GetFactError { get; private set; }
        public FactService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        //Task that returns deserialized JSON data
        public async Task<Fact> GetFact()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://catfact.ninja/fact");

            HttpClient client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                GetFactError = false;

                return  await JsonSerializer.DeserializeAsync<Fact>(responseStream);
            }
            else
            {
                GetFactError = true;
                throw new HttpRequestException();
            }
        }
    }
}
