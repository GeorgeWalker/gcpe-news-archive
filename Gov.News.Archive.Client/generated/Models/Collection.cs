// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.News.Archive.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Collection
    {
        /// <summary>
        /// Initializes a new instance of the Collection class.
        /// </summary>
        public Collection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Collection class.
        /// </summary>
        public Collection(string id = default(string), string name = default(string), System.DateTimeOffset? startDate = default(System.DateTimeOffset?), System.DateTimeOffset? endDate = default(System.DateTimeOffset?))
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTimeOffset? EndDate { get; set; }

    }
}