using Newtonsoft.Json;

namespace ProjectStructure.Models
{
    public class Request<TModel>
    {
        /// <summary>
        /// Model
        /// </summary>
        [JsonProperty]
        public TModel Data { get; set; }
    }

    public class Request
    {
    }
}
