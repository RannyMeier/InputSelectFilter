using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace InputSelectFilter.Data
{
    public class EntSelService
    {
        

        public List<EntSel> GetEnts()
        {
            string entsJson = File.ReadAllText(@"TestEnts.json");
            var ents = JsonSerializer.Deserialize<EntList>(entsJson);
            return ents.Ents;
        }

    }
}
