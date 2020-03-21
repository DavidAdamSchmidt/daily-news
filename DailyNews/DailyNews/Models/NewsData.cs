using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DailyNews.Models
{
    public class NewsData
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }
    }
}
