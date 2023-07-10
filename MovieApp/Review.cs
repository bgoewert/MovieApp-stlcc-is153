
namespace MovieApp
{
    internal class Review
    {
        public string Username { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }

        public Review ( string username, double rating, string comment ) {
            Username = username;
            Rating = rating;
            Comment = comment;
        }
    }
}
