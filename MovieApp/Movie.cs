
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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
                /*
                 * Check if given year is outside a valid range.
                 * Cannot be after current year or be before the history of motion pictures.
                 * https://www.britannica.com/art/history-of-the-motion-picture
                 */
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

        // Defines the average rating.
        public double Rating { get; set; }

        public string Description { get; set; }

        // Storage for all the reviews related to a movie.
        public List<Review> Reviews { get; set; } = new List<Review>();

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
