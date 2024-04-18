using System;
using System.Text.Json.Serialization;

/*public class MovieReview
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Review { get; set; }

    public string Rating { get; set; }

    public string MovieId { get; }
    public string Author { get; }




}*/




public class MovieReview
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imdbId")]
    public string ImdbId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("review")]
    public string Review { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }


    [JsonPropertyName("rating")]
    public decimal Rating { get; set; }




    [JsonConstructor]
    public MovieReview(int id, string imdbId, string title, string review, string author, decimal rating)
    {
        Id = id;
        ImdbId = imdbId;
        Title = title;
        Review = review; 
        Author = author;
        Rating = rating;
    }

  /*  public MovieReview(int id,string imdbId, string title, string review, string author,decimal rating)
    {
        Id = id;
        IMDbId = imdbId;
        Title = title;
        Review = review;
        Author = author;
        Rating = rating;
    }*/
}
