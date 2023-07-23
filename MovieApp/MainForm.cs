using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MovieApp
{
    public partial class MainForm : Form
    {

        // Action to perform on save.
        string SaveAction { get; set; }

        // Login form instance, not yet displayed.
        private LoginForm loginForm = new LoginForm();

        // Currently logged in user.
        internal static User? currentUser;

        public MainForm()
        {
            InitializeComponent();

            /* 
             * Add some placeholder reviews.
             * 
             * Reviews are my own or from Roger Ebert.
             * https://www.rogerebert.com/reviews/
             */
            Movie.MovieList.Values.ElementAt(0).Reviews.Add(new Review("brennangoewert", 5, "I was not angry that I watched this. Very good film."));
            Movie.MovieList.Values.ElementAt(0).Reviews.Add(new Review("rogerebert", 4, "In form, \"12 Angry Men\" is a courtroom drama. In purpose, it's a crash course in those passages of the Constitution that promise defendants a fair trial and the presumption of innocence."));
            Movie.MovieList.Values.ElementAt(1).Reviews.Add(new Review("brennangoewert", 5, "The cinematography was mind blowing. They captured the feeling of outer space so well."));
            Movie.MovieList.Values.ElementAt(1).Reviews.Add(new Review("rogerebert", 5, "It was e. e. cummings, the poet, who said he'd rather learn from one bird how to sing than teach 10,000 stars how not to dance. I imagine cummings would not have enjoyed Stanley Kubrick's \"2001: A Space Odyssey,\" in which stars dance but birds do not sing."));
            Movie.MovieList.Values.ElementAt(2).Reviews.Add(new Review("brennangoewert", 4, "I don't understand French. But, it was very engaging with subtitles."));
            Movie.MovieList.Values.ElementAt(2).Reviews.Add(new Review("rogerebert", 4, "Francois Truffaut's \"The 400 Blows\" (1959) is one of the most intensely touching stories ever made about a young adolescent."));

            // Recalculate Average Reviews
            foreach (Movie movie in Movie.MovieList.Values) {
                movie.Rating = movie.Reviews.Average(r => r.Rating);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Add event handler to apply access control when successfully logged in.
            loginForm.FormClosed += new FormClosedEventHandler((object sender, FormClosedEventArgs e) => ApplyAccessControl());
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Show LoginForm as a dialog box after MainForm is displayed.
            if (currentUser is null) loginForm.ShowDialog();
        }

        private void ApplyAccessControl()
        {
            if (currentUser is not null)
            {
                txtLoggedInAs.Text = currentUser.Username;

                // Add access for different controls.
                if (currentUser.Username == "admin")
                {
                    btnAddMovie.Visible = true;
                    btnEditMovie.Visible = true;
                    btnDeleteMovie.Visible = true;
                    btnRegisterNewUser.Visible = true;
                    btnSaveMovie.Visible = true;
                    btnCancelMovie.Visible = true;
                }
                else
                {
                    // Hide all access controled controls.
                    btnAddMovie.Visible = false;
                    btnEditMovie.Visible = false;
                    btnDeleteMovie.Visible = false;
                    btnRegisterNewUser.Visible = false;
                    btnSaveMovie.Visible = false;
                    btnCancelMovie.Visible = false;
                }
            }
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

            // Focus on the movie form
            txtTitle.Focus();
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            // Set save action.
            SaveAction = "EditMovie";

            // Enable inputs.
            txtTitle.ReadOnly = false;
            txtGenre.ReadOnly = false;
            txtReleaseYear.ReadOnly = false;
            txtDuration.ReadOnly = false;
            txtDescription.ReadOnly = false;
            btnSaveMovie.Enabled = true;
            btnCancelMovie.Enabled = true;

            // Change focus to first input.
            txtTitle.Focus();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            // Remove selected movie from collection.
            if (lstMovies.SelectedItem is not null)
            {
                Movie.MovieList.Remove(((Movie)lstMovies.SelectedItem).Title);
                UpdateMovieList(Movie.MovieList.Values.ToList());
            }
        }

        private void btnCancelMovie_Click(object sender, EventArgs e)
        {
            ClearMovieForm();
            DisableMovieForm();
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If there is a movie selected.
                if (lstMovies.SelectedIndex != -1 && currentUser is not null)
                {
                    // Enable edit/delete buttons
                    btnEditMovie.Enabled = true;
                    btnDeleteMovie.Enabled = true;

                    // Get selected movie.
                    Movie movie = (Movie)lstMovies.SelectedItem;

                    // Display 'No Ratings' if there are no ratings.
                    string rating = "No Ratings";

                    // Otherwise, get rating.
                    if (movie.Reviews.Count > 0)
                    {
                        rating = movie.Rating.ToString("f1");
                    }

                    // Populate inputs with selected movie details.
                    txtTitle.Text = movie.Title;
                    txtGenre.Text = movie.Genre;
                    txtReleaseYear.Text = movie.ReleaseYear.ToString();
                    txtDuration.Text = movie.Duration.ToString();
                    txtAvgRating.Text = rating;
                    txtDescription.Text = movie.Description;

                    // Clear review list.
                    txtReviews.Text = string.Empty;

                    // Populate Reviews list.
                    for (int i = 0; i < movie.Reviews.Count; i++)
                    {
                        txtReviews.Text += "\"" + movie.Reviews[i].Comment + "\"\r\n" + movie.Reviews[i].Username + " - " + movie.Reviews[i].Rating.ToString("f1");
                        txtReviews.Text += "\r\n\r\n";
                    }

                    // Check if user has reviewed already
                    Review userReview = movie.Reviews.Find(r => r.Username == currentUser.Username);
                    if (movie.Reviews.FindIndex(r => r.Username == currentUser.Username) != -1)
                    {
                        // If review was found, disable and populate inputs
                        cboUserRating.SelectedIndex = userReview.Rating - 1;
                        txtUserReview.Text = userReview.Comment;
                        btnAddReview.Enabled = false;
                        cboUserRating.Enabled = false;
                        txtUserReview.ReadOnly = true;
                    }
                }
                else
                {
                    ClearMovieForm();
                    DisableMovieForm();
                    txtReviews.Text = string.Empty;
                    ClearReviewForm();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveMovie_Click(object sender, EventArgs e) { SaveMovie(); }

        private void btnSaveMovie_KeyPress(object sender, KeyPressEventArgs e) {

            // Attempt to save movie if either the Enter or Spacebar is pressed.
            if (e.KeyChar == (char) Keys.Enter || e.KeyChar == (char) Keys.Space)
                SaveMovie();

        }

        private void SaveMovie()
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

                        // Create new movie object.
                        Movie newMovie = new Movie(
                            txtTitle.Text,
                            txtGenre.Text,
                            releaseYear,
                            duration,
                            txtDescription.Text
                        );

                        // Check to see if movie does not already exist.
                        if (Movie.MovieList.ContainsKey(newMovie.Title)) throw new Exception("Movie already exists.");

                        // Add new movie to list.
                        Movie.MovieList.Add(newMovie.Title, newMovie);
                        UpdateMovieList(Movie.MovieList.Values.ToList()); // Update movie list with new movie
                        lstMovies.SelectedItem = Movie.MovieList.Values.Last(); // Select the new movie
                        lstMovies.Focus(); // Change focus to the movie list
                        break;

                    case "EditMovie":

                        // Get selected movie
                        Movie movie = (Movie)lstMovies.SelectedItem;

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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearFilterForm()
        {
            txtFilterYearMin.Text = string.Empty;
            txtFilterYearMax.Text = string.Empty;
            txtFilterRatingMin.Text = string.Empty;
            txtFilterRatingMax.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            // Get filtered movies
            List<Movie> filteredMovies = FilterMovies(Movie.MovieList.Values.ToList());

            // Update movie list
            UpdateMovieList(filteredMovies);
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            // Clear filter and search inputs
            ClearFilterForm();

            // Reset movie list
            UpdateMovieList(Movie.MovieList.Values.ToList());
        }

        private void ClearReviewForm()
        {
            cboUserRating.SelectedIndex = -1;
            txtUserReview.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMovieList();
        }

        private List<Movie> FilterMovies(List<Movie> moviesToFilter)
        {
            List<Movie> moviesFiltered = new List<Movie>();

            try
            {
                // Check if both min and max values are defined. Otherwise, return the original list.
                if (txtFilterYearMin.Text != string.Empty && txtFilterYearMax.Text == string.Empty) { MessageBox.Show("Max Year Required"); return moviesToFilter; }
                if (txtFilterYearMax.Text != string.Empty && txtFilterYearMin.Text == string.Empty) { MessageBox.Show("Min Year Required"); return moviesToFilter; }
                if (txtFilterRatingMin.Text != string.Empty && txtFilterRatingMax.Text == string.Empty) { MessageBox.Show("Max Rating Required"); return moviesToFilter; }
                if (txtFilterRatingMax.Text != string.Empty && txtFilterRatingMin.Text == string.Empty) { MessageBox.Show("Min Rating Required"); return moviesToFilter; }

                // If no filter is defined, return original list.
                if (txtFilterYearMin.Text == string.Empty && txtFilterRatingMin.Text == string.Empty) return moviesToFilter;

                // Get filter values.
                int yearMin, yearMax;
                double ratingMin, ratingMax;
                bool boolYearMin = Int32.TryParse(txtFilterYearMin.Text, out yearMin);
                bool boolYearMax = Int32.TryParse(txtFilterYearMax.Text, out yearMax);
                bool boolRatingMin = double.TryParse(txtFilterRatingMin.Text, out ratingMin);
                bool boolRatingMax = double.TryParse(txtFilterRatingMax.Text, out ratingMax);

                // Check if filter values are invalid and if so return original list.
                if (!boolYearMin && txtFilterYearMin.Text != string.Empty)
                {
                    MessageBox.Show("Invalid Filter Value. Please enter a valid minumum Release Year.");
                    return moviesToFilter;
                }
                if (!boolYearMax && txtFilterYearMax.Text != string.Empty)
                {
                    MessageBox.Show("Invalid Filter Value. Please enter a valid maximum Release Year.");
                    return moviesToFilter;
                }

                if (!boolRatingMin && txtFilterRatingMin.Text != string.Empty)
                {
                    MessageBox.Show("Invalid Filter Value. Please enter a valid minimum Rating.");
                    return moviesToFilter;
                }
                if (!boolRatingMax && txtFilterRatingMax.Text != string.Empty)
                {
                    MessageBox.Show("Invalid Filter Value. Please enter a valid maximum Rating.");
                    return moviesToFilter;
                }

                // Filter movies
                // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
                if (txtFilterYearMin.Text != string.Empty || txtFilterRatingMin.Text != string.Empty)
                {
                    moviesFiltered = new List<Movie>(moviesToFilter.Where(m => (m.ReleaseYear > yearMin && m.ReleaseYear < yearMax) || (m.Rating > ratingMin && m.Rating < ratingMax)).ToList());
                }
                if (txtFilterYearMin.Text != string.Empty && txtFilterRatingMin.Text != string.Empty)
                {
                    moviesFiltered = new List<Movie>(moviesToFilter.Where(m => (m.ReleaseYear > yearMin && m.ReleaseYear < yearMax) && (m.Rating > ratingMin && m.Rating < ratingMax)).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Return results
            return moviesFiltered;
        }

        private List<Movie> SearchMovies(List<Movie> moviesToSearch)
        {
            // Search movies
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
            List<Movie> moviesFiltered = new List<Movie>(moviesToSearch.Where(m => (m.Title.Contains(txtSearch.Text) || m.Genre.Contains(txtSearch.Text))).ToList());

            // Return results
            return moviesFiltered;
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {

            // Ensure a movie is selected
            if (lstMovies.SelectedItem is not null && currentUser is not null)
            {
                // Get selected movie
                Movie movie = (Movie)lstMovies.SelectedItem;

                try
                {
                    // Parse rating
                    int rating;
                    int.TryParse(cboUserRating.Text, out rating);

                    // Create new review object.
                    Review review = new Review(currentUser.Username, rating, txtUserReview.Text);

                    // Add new review
                    movie.Reviews.Add(review);

                    // Add review to list.
                    txtReviews.Text += (review.Comment != "" ? "\"" + review.Comment + "\"\r\n" : "") + review.Username + " - " + review.Rating.ToString("f1");
                    txtReviews.Text += "\r\n\r\n";

                    // Update new average rating
                    movie.Rating = movie.Reviews.Average(r => r.Rating);
                    txtAvgRating.Text = movie.Rating.ToString("f1");

                    // Clear form after submitting.
                    ClearReviewForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateMovieList(List<Movie> movies)
        {
            lstMovies.DataSource = null; // Clear list
            lstMovies.DataSource = movies; // Update list
            lstMovies.DisplayMember = "Title"; // Reset display member

            // Clear selected items on load.
            // Unsure why there was an initial selection.
            lstMovies.ClearSelected();
            ClearMovieForm();
        }

        private void btnViewAllMovies_Click(object sender, EventArgs e)
        {
            // Display movies
            UpdateMovieList(Movie.MovieList.Values.ToList());

            // Clear filters
            ClearFilterForm();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If Enter key is pressed, try searching the movie list.
            if (e.KeyChar == (char)Keys.Enter) SearchMovieList();
        }

        private void SearchMovieList()
        {
            List<Movie> moviesFiltered = new List<Movie>();

            // If a filter is enabled, apply it first.
            moviesFiltered = FilterMovies(Movie.MovieList.Values.ToList());

            // Search movies
            moviesFiltered = SearchMovies(moviesFiltered);

            // Update movie list
            UpdateMovieList(moviesFiltered);
        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            // Create a new registration form instance.
            RegistrationForm registrationForm = new RegistrationForm();

            // Show the registration form as a dialog box.
            registrationForm.ShowDialog();
        }

        private void btnLogut_Click(object sender, EventArgs e)
        {
            // Reset logged in status.
            currentUser = null;
            txtLoggedInAs.Text = string.Empty;

            // Reset login form.
            loginForm.verifiedUser = null;
            // These fields are 'protected internal' so we can manipulate them here.
            loginForm.txtUsername.Text = string.Empty;
            loginForm.txtPassword.Text = string.Empty;
            loginForm.txtUsername.Focus();

            // Clear all main form inputs.
            ClearFilterForm();
            ClearMovieForm();
            ClearReviewForm();
            lstMovies.SelectedIndex = -1;

            // Show login form again.
            loginForm.ShowDialog();
        }

        private void btnViewFavorites_Click(object sender, EventArgs e)
        {
            // Create a new favorites list form and display it
            FavoritesListForm frmFavorites = new FavoritesListForm();
            frmFavorites.Show();
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem is not null && currentUser is not null)
            {
                // Add the selected item to the favorites list
                currentUser.Favorites.Add((Movie)lstMovies.SelectedItem);
            }
        }
    }
}