using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TheTVDBClient.Models;

namespace TheTVDBClient
{
    public class TvdbClient
    {
        static HttpClient _client = new HttpClient();
        private string _token;
        private static string BaseUrl => "https://api.thetvdb.com";
        
        public async Task<Episode> GetEpisodeAsync(int id)
        {
            return await SendAuthenticatedGetRequestAsync<Episode>($"episodes/{id}");
        }

        public async Task RefreshTokenAsync(string apiKey, string userKey, string username)
        {
            await RefreshTokenAsync(new { apikey = apiKey, userkey = userKey, username = username });
        }

        private async Task RefreshTokenAsync(object body)
        {
            var response = await SendRequestAsync<Login>(GetRequestFromPath("login", HttpMethod.Get, body));
            _token = response.Token;
        }

        public async Task RefreshTokenAsync(string apiKey)
        {
            await RefreshTokenAsync(new { apikey = apiKey });
        }

        public string ConstructEndpoint(string path) =>
            $"{BaseUrl}/{path.TrimStart('/')}";

        private HttpRequestMessage GetRequestFromPath(string path, HttpMethod method, object body)
        {
            var request = GetRequestFromPath(path, method);
            request.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            return request;
        }

        private HttpRequestMessage GetRequestFromPath(string path, HttpMethod method)
        {
            return new HttpRequestMessage(method, new Uri(ConstructEndpoint(path)));
        }

        private async Task<T> SendAuthenticatedGetRequestAsync<T>(string path)
        {
            return await SendAuthenticatedRequestAsync<T>(GetRequestFromPath(path, HttpMethod.Get));
        }

        private async Task<T> SendAuthenticatedPostRequestAsync<T>(object body, string path)
        {
            return await SendAuthenticatedRequestAsync<T>(GetRequestFromPath(path, HttpMethod.Post, body));
        }

        private async Task<T> SendAuthenticatedRequestAsync<T>(string path, HttpMethod method)
        {
            return await SendAuthenticatedRequestAsync<T>(GetRequestFromPath(path, method));
        }

        private async Task<T> SendAuthenticatedRequestAsync<T>(HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            return await SendRequestAsync<T>(request);
        }

        private async Task<T> SendRequestAsync<T>(HttpRequestMessage request)
        {
            var response = await _client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(body);
        }
    }
}
