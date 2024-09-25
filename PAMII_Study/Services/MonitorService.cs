using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PAMII_Study.Models;

namespace PAMII_Study.Service
{
    public class MonitorService
    {
        
         private HttpClient _httpClient;
        private Models.Monitor Monitor;
        private List<Models.Monitor> Monitores;
        private JsonSerializerOptions _serializerOptions;

        public MonitorService() { 
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions();
                PropertyWamingPolicy = JsonNamingPolicy.CamelCase;
                WriteIndented = true
        }

        public async Task<List<Models.Monitor>> GetAllMonitorAsync()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/photos");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    posts = JsonSerializer.Deserialize<List<Post>>(content, _serializerOptions);
                    fotos = JsonSerializer.Deserialize<List<Foto>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return posts;
            return fotos;

        }
    }
}
