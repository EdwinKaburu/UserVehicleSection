using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserVehicleSection.Models.APIAcess
{
    public class GetAllMakes
    {
        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("SearchCriteria")]
        public object SearchCriteria { get; set; }

        [JsonProperty("Results")]
        public List<Result> Results { get; set; }
    }
    public partial class Result
    {
        [JsonProperty("Make_ID")]
        public long MakeId { get; set; }

        [JsonProperty("Make_Name")]
        public string MakeName { get; set; }
    }
}
