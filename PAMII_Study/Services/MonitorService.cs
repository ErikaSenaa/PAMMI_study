using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PAMII_Study.Models;

namespace PAMII_Study.Service
{
    public class MonitorService
    {
        
         private HttpClient client;
        private PAMII_Study.Models.Monitor monitor;

        private List<Models.Monitor> monitores;

        private JsonSerializerOptions _serializerOptions;

        public MonitorService() { 

              client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
             };
               
        }

        public async Task<List<Models.Monitor>> GetAllMonitorAsync()
        {
            Uri uri = new Uri("https://localhost:8080/monitores");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitores = JsonSerializer.Deserialize<List<Models.Monitor>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return monitores;
            
        }
    }
}
