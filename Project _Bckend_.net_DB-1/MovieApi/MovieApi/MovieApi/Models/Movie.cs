using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieApi.Models
{
    public class Movie
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("imdb_id")] 
        public string? ImdbId { get; set; }

        [JsonPropertyName("popularity")]
        public string? Popularity { get; set; }

        [JsonPropertyName("budget")] 
        public string? Budget { get; set; }

        [JsonPropertyName("revenue")]
        public string? Revenue { get; set; }
        [JsonPropertyName("original_title")]
        public string? OriginalTitle { get; set; }

        [JsonPropertyName("cast")]
        public string? Cast { get; set; }
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }
        [JsonPropertyName("director")]
        public string? Director { get; set; }
        [JsonPropertyName("tagline")]
        public string? Tagline { get; set; }
        [JsonPropertyName("keywords")]
        public string? Keywords { get; set; }
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }
       
        [JsonPropertyName("runtime")]
        public string? Runtime { get; set; }


        [JsonPropertyName("genres")]
        public string? Genres { get; set; }


        [JsonPropertyName("production_companies")]
        public string? ProductionCompanies { get; set; }


        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }


        [JsonPropertyName("vote_count")]
        public string? VoteCount { get; set; }

        //follow same for other
        [JsonPropertyName("vote_average")]
        public string? VoteAverage { get; set; }

        [JsonPropertyName("release_year")]
        public string? ReleaseYear { get; set; }

        [JsonPropertyName("budget_adj")]
        public string? BudgetAdj { get; set; }

        [JsonPropertyName("revenue_adj")]
        public string? RevenueAdj { get; set; }
    }// done ra

}
