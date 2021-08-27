
namespace Movies
{
    public class MovieData
    {
        public MovieData(string title, string imageUrl, string year, string type, string imdbID)
        {
            Title = title;
            ImageUrl = imageUrl;
            Year = year;
            Type = type;
            ImdbID = imdbID;
        }

        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string ImdbID { get; set; }
    }
}
