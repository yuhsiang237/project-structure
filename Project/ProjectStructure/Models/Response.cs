using Newtonsoft.Json;

namespace ProjectStructure.Models
{
    public class Response<TData>
    {
        [JsonProperty("Data")]
        public TData Data { get; set; }
    }

    public class Response
    {
    }
}
