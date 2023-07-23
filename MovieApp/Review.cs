
namespace MovieApp
{
    internal struct Review
    {
        public string Username { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Review ( string username, int rating, string comment ) {
            Username = username;
            Rating = rating;
            Comment = comment;
        }
    }
}
