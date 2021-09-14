using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InputSelectFilter.Data
{
    public class EntSel
    {
        public int Id { get; set; }
        public string ValStrs { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }

    class EntList
    {
        [JsonPropertyName("entities")]
        public List<EntSel> Ents { get; set; }
    }
}
