
namespace MovieApp
{
    internal class Movie
    {
        public string Title { get; set; }

        public string Genre { get; set; }

        /* The year was chosen over a full date because it simplifies filtering.
         * A DateTime or DateOnly field would need to be used for full date filtering.
         */
        private int releaseYear;
        public int ReleaseYear {
            get { return releaseYear; }
            set {
                // Check if given year is outside a valid range.
                // Cannot be after current year.
                // Cannot be before the history of motion pictures. https://www.britannica.com/art/history-of-the-motion-picture
                if (value < 1832 || value > DateTime.Now.Year)
                {
                    throw new Exception("Year given is invalid. Please enter a valid year.");
                } else
                {
                    releaseYear = value;
                }
            }
        }

        // Duration in minutes.
        public int Duration { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public Movie( string title, string genre, int releaseYear, int duration, string description )
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            Duration = duration;
            Description = description;
        }

    }
}
