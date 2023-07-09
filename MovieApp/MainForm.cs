using Microsoft.VisualBasic.Devices;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MovieApp
{
    public partial class MainForm : Form
    {
        /* Storage for movie list.
         * 
         * Initial movies picked from this list:
         * https://editorial.rottentomatoes.com/guide/essential-movies-to-watch-now/
         * 
         * A BindingList was used here because it provides a two-way data-binding for the ListBox data source.
         * See https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-7.0#remarks
         */
        BindingList<Movie> movies = new BindingList<Movie> {
            new Movie("12 Angry Men", "Drama", 1957, 95, "Following the closing arguments in a murder trial, the 12 members of the jury must deliberate, with a guilty verdict meaning death for the accused, an inner-city teen. As the dozen men try to reach a unanimous decision while sequestered in a room, one juror (Henry Fonda) casts considerable doubt on elements of the case. Personal issues soon rise to the surface, and conflict threatens to derail the delicate process that will decide one boy's fate."),
            new Movie("2001: A Space Odyssey", "Sci-Fi", 1968, 139, "An imposing black structure provides a connection between the past and the future in this enigmatic adaptation of a short story by revered sci-fi author Arthur C. Clarke. When Dr. Dave Bowman (Keir Dullea) and other astronauts are sent on a mysterious mission, their ship's computer system, HAL, begins to display increasingly strange behavior, leading up to a tense showdown between man and machine that results in a mind-bending trek through space and time."),
            new Movie("The 400 Blows", "Crime/Drama", 1959, 93, "For young Parisian boy Antoine Doinel (Jean-Pierre Léaud), life is one difficult situation after another. Surrounded by inconsiderate adults, including his neglectful parents (Claire Maurier, Albert Remy), Antoine spends his days with his best friend, Rene (Patrick Auffray), trying to plan for a better life. When one of their schemes goes awry, Antoine ends up in trouble with the law, leading to even more conflicts with unsympathetic authority figures.")
        };

        // Action to perform on save.
        string SaveAction { get; set; }

        public MainForm()
        {
            InitializeComponent();

            // Populate movie list.
            lstMovies.DataSource = movies;
            lstMovies.DisplayMember = "Title";
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            // Set save action.
            SaveAction = "AddMovie";

            // Clear movie selection
            if (lstMovies.SelectedIndex >= 0)
            {
                lstMovies.ClearSelected();

                txtTitle.Text = string.Empty;
                txtGenre.Text = string.Empty;
                txtReleaseYear.Text = string.Empty;
                txtDuration.Text = string.Empty;
                txtAvgRating.Text = string.Empty;
                txtDescription.Text = string.Empty;
            }

            // Enable inputs.
            txtTitle.ReadOnly = false;
            txtGenre.ReadOnly = false;
            txtReleaseYear.ReadOnly = false;
            txtDuration.ReadOnly = false;
            txtDescription.ReadOnly = false;
            btnSaveMovie.Enabled = true;
            btnCancelMovie.Enabled = true;
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            // Set save action.
            SaveAction = "EditMovie";

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Enable inputs.
            txtTitle.ReadOnly = false;
            txtGenre.ReadOnly = false;
            txtReleaseYear.ReadOnly = false;
            txtDuration.ReadOnly = false;
            txtDescription.ReadOnly = false;
            btnSaveMovie.Enabled = true;
            btnCancelMovie.Enabled = true;
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            // Remove selected movie from collection.
            movies.Remove(movies[lstMovies.SelectedIndex]);
        }

        private void btnCancelMovie_Click(object sender, EventArgs e)
        {
            ClearMovieForm();
            DisableMovieForm();
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditMovie.Enabled = true;
            btnDeleteMovie.Enabled = true;

            try
            {
                // If there is a movie selected.
                if (lstMovies.SelectedIndex >= 0)
                {
                    // Get selected movie.
                    Movie movie = (Movie)lstMovies.SelectedItem;

                    // Display 'No Ratings' if there are no ratings.
                    string rating = "No Ratings";

                    // Otherwise, get rating.
                    if (movie.Rating != 0)
                    {
                        rating = movie.Rating.ToString();
                    }

                    // Populate inputs with selected movie details.
                    txtTitle.Text = movie.Title;
                    txtGenre.Text = movie.Genre;
                    txtReleaseYear.Text = movie.ReleaseYear.ToString();
                    txtDuration.Text = movie.Duration.ToString();
                    txtAvgRating.Text = rating;
                    txtDescription.Text = movie.Description;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            int duration, releaseYear;

            try
            {

                // Convert duration and releaseYear to an integer.
                Int32.TryParse(txtDuration.Text, out duration);
                Int32.TryParse(txtReleaseYear.Text, out releaseYear);


                switch (SaveAction)
                {
                    case "AddMovie":

                        // Add new movie to list.
                        movies.Add(new Movie(
                            txtTitle.Text,
                            txtGenre.Text,
                            releaseYear,
                            duration,
                            txtDescription.Text
                        ));

                        lstMovies.SelectedItem = movies.Last();
                        break;

                    case "EditMovie":

                        // Get selected movie
                        Movie movie = movies[lstMovies.SelectedIndex];

                        // Check if the title is changed. The ListBox DisplayMember will need to be updated if so.
                        bool titleChanged = false;
                        if (movie.Title != txtTitle.Text) titleChanged = true;

                        // Update movie details.
                        movie.Title = txtTitle.Text;
                        movie.Genre = txtGenre.Text;
                        movie.ReleaseYear = releaseYear;
                        movie.Duration = duration;
                        movie.Description = txtDescription.Text;

                        // Redraw ListBox DisplayMember if title has changed.
                        // If this is not done, the ListBox displays the old title.
                        if (titleChanged)
                        {
                            lstMovies.DisplayMember = string.Empty;
                            lstMovies.DisplayMember = "Title";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Disable the form once an action is performed.
            DisableMovieForm();
        }

        private void ClearMovieForm()
        {
            // Clear save action.
            SaveAction = string.Empty;

            // Clear inputs.
            txtTitle.Text = string.Empty;
            txtGenre.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtAvgRating.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void DisableMovieForm()
        {
            // Disable inputs.
            txtTitle.ReadOnly = true;
            txtGenre.ReadOnly = true;
            txtReleaseYear.ReadOnly = true;
            txtDuration.ReadOnly = true;
            txtDescription.ReadOnly = true;
            btnSaveMovie.Enabled = false;
            btnCancelMovie.Enabled = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            // Check if both min and max values are defined.
            if (txtFilterYearMin.Text != string.Empty && txtFilterYearMax.Text == string.Empty) { MessageBox.Show("Max Year Required"); return; }
            if (txtFilterYearMax.Text != string.Empty && txtFilterYearMin.Text == string.Empty) { MessageBox.Show("Min Year Required"); return; }
            if (txtFilterRatingMin.Text != string.Empty && txtFilterRatingMax.Text == string.Empty) { MessageBox.Show("Max Rating Required"); return; }
            if (txtFilterRatingMax.Text != string.Empty && txtFilterRatingMin.Text == string.Empty) { MessageBox.Show("Min Rating Required"); return; }

            // Get filter values
            int yearMin, yearMax, ratingMin, ratingMax;
            Int32.TryParse(txtFilterYearMin.Text, out yearMin);
            Int32.TryParse(txtFilterYearMax.Text, out yearMax);
            Int32.TryParse(txtFilterRatingMin.Text, out ratingMin);
            Int32.TryParse(txtFilterRatingMax.Text, out ratingMax);

            // Filter movies and display results
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
            BindingList<Movie> moviesFiltered = new BindingList<Movie>(movies.Where(m => (m.ReleaseYear > yearMin && m.ReleaseYear < yearMax) || (m.Rating < ratingMin && m.Rating > ratingMax)).ToList());

            lstMovies.DataSource = moviesFiltered;
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            txtFilterYearMin.Text = string.Empty;
            txtFilterYearMax.Text = string.Empty;
            txtFilterRatingMin.Text = string.Empty;
            txtFilterRatingMax.Text = string.Empty;

            lstMovies.DataSource = movies;
        }

    }
}