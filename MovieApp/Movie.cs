
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
                    throw new Exception($"Year given is invalid. Please enter a valid year between 1832 or {DateTime.Now.Year}.");
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

        /* Storage for movie list.
         * 
         * Initial movies picked from this list:
         * https://editorial.rottentomatoes.com/guide/essential-movies-to-watch-now/
         */
        private static Dictionary<string,Movie> movieList = new Dictionary<string,Movie>(StringComparer.OrdinalIgnoreCase) {
            { "12 Angry Men", new Movie("12 Angry Men", "Drama", 1957, 95, "Following the closing arguments in a murder trial, the 12 members of the jury must deliberate, with a guilty verdict meaning death for the accused, an inner-city teen. As the dozen men try to reach a unanimous decision while sequestered in a room, one juror (Henry Fonda) casts considerable doubt on elements of the case. Personal issues soon rise to the surface, and conflict threatens to derail the delicate process that will decide one boy's fate.") },
            { "2001: A Space Odyssey",  new Movie("2001: A Space Odyssey", "Sci-Fi", 1968, 139, "An imposing black structure provides a connection between the past and the future in this enigmatic adaptation of a short story by revered sci-fi author Arthur C. Clarke. When Dr. Dave Bowman (Keir Dullea) and other astronauts are sent on a mysterious mission, their ship's computer system, HAL, begins to display increasingly strange behavior, leading up to a tense showdown between man and machine that results in a mind-bending trek through space and time.") },
            { "The 400 Blows", new Movie("The 400 Blows", "Crime/Drama", 1959, 93, "For young Parisian boy Antoine Doinel (Jean-Pierre Léaud), life is one difficult situation after another. Surrounded by inconsiderate adults, including his neglectful parents (Claire Maurier, Albert Remy), Antoine spends his days with his best friend, Rene (Patrick Auffray), trying to plan for a better life. When one of their schemes goes awry, Antoine ends up in trouble with the law, leading to even more conflicts with unsympathetic authority figures.") }
        };
        internal static Dictionary<string, Movie> MovieList { get => movieList; }
    }
}
