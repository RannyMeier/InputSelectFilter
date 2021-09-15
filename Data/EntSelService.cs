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
        private List<EntSel> entSelList;
        private List<EntSel> itmSelList;
        public EntSelService(IOptions<DataConfig> options)
        {
            _jsonPaths = options.Value;
        }
        public async Task<List<EntSel>> GetEntsAsync()
        {
            if (entSelList == null)
            {
                HttpResponseMessage response = await client.GetAsync(_jsonPaths.EntsJsonPath);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var ents = JsonSerializer.Deserialize<EntList>(responseBody);
                entSelList = ents.Ents;
            }
            return entSelList;
        }
        public async Task<List<EntSel>> GetItmsAsync()
        {
            if (itmSelList == null)
            {
                HttpResponseMessage response = await client.GetAsync(_jsonPaths.ItmsJsonPath);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var itms = JsonSerializer.Deserialize<EntList>(responseBody);
                itmSelList = itms.Ents;
            }
            return itmSelList;
        }
        public List<Order> GetOrders()
        {
            List<Order> ol = new List<Order>();
            ol.Add(new Order() { Id = 1, DocNum = "N001", Date = new DateTime(2021, 2, 1), EntId = 3404, ItmId = 73858, Amount = 100M });
            ol.Add(new Order() { Id = 2, DocNum = "N002", Date = new DateTime(2021, 3, 1), EntId = 6646, ItmId = 54151, Amount = 100M });
            ol.Add(new Order() { Id = 3, DocNum = "N003", Date = new DateTime(2021, 4, 1), EntId = 10630, ItmId = 33396, Amount = 100M });
            ol.Add(new Order() { Id = 4, DocNum = "N004", Date = new DateTime(2021, 5, 1), EntId = 16105, ItmId = 51478, Amount = 100M });
            ol.Add(new Order() { Id = 5, DocNum = "N005", Date = new DateTime(2021, 6, 1), EntId = 20669, ItmId = 30520, Amount = 100M });
            return ol;
        }
    }

    public class DataConfig
    {
        public const string DataPaths = "DataPaths";
        public string EntsJsonPath { get; set; }
        public string ItmsJsonPath { get; set; }
    }
}
