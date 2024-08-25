using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace comoencasa_Escritorio
{
    public static class APIConnection
    {
        private static readonly HttpClient client = new HttpClient();

        static APIConnection()
        {
            client.BaseAddress = new Uri("http://192.168.1.106:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await client.GetAsync(endpoint);
            return await HandleResponse<T>(response);
        }

        public static async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(endpoint, content);
            return await HandleResponse<T>(response);
        }

        public static async Task<T> PutAsync<T>(string endpoint, object data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(endpoint, content);
            return await HandleResponse<T>(response);
        }

        public static async Task DeleteAsync(string endpoint)
        {
            HttpResponseMessage response = await client.DeleteAsync(endpoint);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error encountered: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        private static async Task<T> HandleResponse<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            else
            {
                throw new HttpRequestException($"Error encountered: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}

