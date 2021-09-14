using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http;

namespace InputSelectFilter.Data
{
    public class EntSelService
    {
        private readonly DataConfig _jsonPaths;
        private static readonly HttpClient client = new HttpClient();
        public EntSelService(IOptions<DataConfig> options)
        {
            _jsonPaths = options.Value;
        }
        public async Task<List<EntSel>> GetEntsAsync()
        {
            HttpResponseMessage response = await client.GetAsync(_jsonPaths.EntsJsonPath);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var ents = JsonSerializer.Deserialize<EntList>(responseBody);
            return ents.Ents;
        }

        public async Task<List<EntSel>> GetItmsAsync()
        {
            HttpResponseMessage response = await client.GetAsync(_jsonPaths.ItmsJsonPath);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var itms = JsonSerializer.Deserialize<EntList>(responseBody);
            return itms.Ents;
        }
    }

    public class DataConfig
    {
        public const string DataPaths = "DataPaths";
        public string EntsJsonPath { get; set; }
        public string ItmsJsonPath { get; set; }
    }
}
