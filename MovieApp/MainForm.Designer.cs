namespace MovieApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMovies = new Panel();
            btnViewAllMovies = new Button();
            grpFilter = new GroupBox();
            btnFilterClear = new Button();
            btnFilter = new Button();
            txtFilterYearMin = new TextBox();
            lblFilterRating = new Label();
            txtFilterYearMax = new TextBox();
            lblFilterDate = new Label();
            txtFilterRatingMin = new TextBox();
            txtFilterRatingMax = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnCancelMovie = new Button();
            btnSaveMovie = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtAvgRating = new TextBox();
            lblAvgRating = new Label();
            txtDuration = new TextBox();
            lblDuration = new Label();
            txtReleaseYear = new TextBox();
            lblReleaseYear = new Label();
            txtGenre = new TextBox();
            lblGenre = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            btnDeleteMovie = new Button();
            btnEditMovie = new Button();
            btnAddMovie = new Button();
            lstMovies = new ListBox();
            label1 = new Label();
            panelReviews = new Panel();
            txtReviews = new TextBox();
            btnAddReview = new Button();
            txtUserReview = new TextBox();
            lblUserReview = new Label();
            txtUserRating = new TextBox();
            lblUserRating = new Label();
            label2 = new Label();
            lblLoggedInAs = new Label();
            txtLoggedInAs = new TextBox();
            btnRegisterNewUser = new Button();
            btnLogut = new Button();
            btnAddToFavorites = new Button();
            button1 = new Button();
            panelMovies.SuspendLayout();
            grpFilter.SuspendLayout();
            panelReviews.SuspendLayout();
            SuspendLayout();
            // 
            // panelMovies
            // 
            panelMovies.BorderStyle = BorderStyle.FixedSingle;
            panelMovies.Controls.Add(btnViewAllMovies);
            panelMovies.Controls.Add(grpFilter);
            panelMovies.Controls.Add(btnSearch);
            panelMovies.Controls.Add(txtSearch);
            panelMovies.Controls.Add(btnCancelMovie);
            panelMovies.Controls.Add(btnSaveMovie);
            panelMovies.Controls.Add(txtDescription);
            panelMovies.Controls.Add(lblDescription);
            panelMovies.Controls.Add(txtAvgRating);
            panelMovies.Controls.Add(lblAvgRating);
            panelMovies.Controls.Add(txtDuration);
            panelMovies.Controls.Add(lblDuration);
            panelMovies.Controls.Add(txtReleaseYear);
            panelMovies.Controls.Add(lblReleaseYear);
            panelMovies.Controls.Add(txtGenre);
            panelMovies.Controls.Add(lblGenre);
            panelMovies.Controls.Add(txtTitle);
            panelMovies.Controls.Add(lblTitle);
            panelMovies.Controls.Add(btnDeleteMovie);
            panelMovies.Controls.Add(btnEditMovie);
            panelMovies.Controls.Add(btnAddMovie);
            panelMovies.Controls.Add(lstMovies);
            panelMovies.Controls.Add(label1);
            panelMovies.Location = new Point(12, 12);
            panelMovies.Name = "panelMovies";
            panelMovies.Size = new Size(337, 707);
            panelMovies.TabIndex = 0;
            // 
            // btnViewAllMovies
            // 
            btnViewAllMovies.Location = new Point(21, 47);
            btnViewAllMovies.Name = "btnViewAllMovies";
            btnViewAllMovies.Size = new Size(101, 23);
            btnViewAllMovies.TabIndex = 1;
            btnViewAllMovies.Text = "View All Movies";
            btnViewAllMovies.UseVisualStyleBackColor = true;
            btnViewAllMovies.Click += btnViewAllMovies_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnFilterClear);
            grpFilter.Controls.Add(btnFilter);
            grpFilter.Controls.Add(txtFilterYearMin);
            grpFilter.Controls.Add(lblFilterRating);
            grpFilter.Controls.Add(txtFilterYearMax);
            grpFilter.Controls.Add(lblFilterDate);
            grpFilter.Controls.Add(txtFilterRatingMin);
            grpFilter.Controls.Add(txtFilterRatingMax);
            grpFilter.Location = new Point(21, 76);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(296, 107);
            grpFilter.TabIndex = 6;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // btnFilterClear
            // 
            btnFilterClear.Location = new Point(198, 71);
            btnFilterClear.Name = "btnFilterClear";
            btnFilterClear.Size = new Size(75, 23);
            btnFilterClear.TabIndex = 6;
            btnFilterClear.Text = "Clear";
            btnFilterClear.UseVisualStyleBackColor = true;
            btnFilterClear.Click += btnFilterClear_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(119, 71);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtFilterYearMin
            // 
            txtFilterYearMin.Location = new Point(121, 13);
            txtFilterYearMin.Name = "txtFilterYearMin";
            txtFilterYearMin.PlaceholderText = "Min";
            txtFilterYearMin.Size = new Size(73, 23);
            txtFilterYearMin.TabIndex = 1;
            // 
            // lblFilterRating
            // 
            lblFilterRating.AutoSize = true;
            lblFilterRating.Location = new Point(74, 45);
            lblFilterRating.Name = "lblFilterRating";
            lblFilterRating.Size = new Size(41, 15);
            lblFilterRating.TabIndex = 26;
            lblFilterRating.Text = "Rating";
            // 
            // txtFilterYearMax
            // 
            txtFilterYearMax.Location = new Point(200, 13);
            txtFilterYearMax.Name = "txtFilterYearMax";
            txtFilterYearMax.PlaceholderText = "Max";
            txtFilterYearMax.Size = new Size(73, 23);
            txtFilterYearMax.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            lblFilterDate.AutoSize = true;
            lblFilterDate.Location = new Point(42, 16);
            lblFilterDate.Name = "lblFilterDate";
            lblFilterDate.Size = new Size(71, 15);
            lblFilterDate.TabIndex = 25;
            lblFilterDate.Text = "Release Year";
            // 
            // txtFilterRatingMin
            // 
            txtFilterRatingMin.Location = new Point(121, 42);
            txtFilterRatingMin.Name = "txtFilterRatingMin";
            txtFilterRatingMin.PlaceholderText = "Min";
            txtFilterRatingMin.Size = new Size(73, 23);
            txtFilterRatingMin.TabIndex = 3;
            // 
            // txtFilterRatingMax
            // 
            txtFilterRatingMax.Location = new Point(200, 42);
            txtFilterRatingMax.Name = "txtFilterRatingMax";
            txtFilterRatingMax.PlaceholderText = "Max";
            txtFilterRatingMax.Size = new Size(73, 23);
            txtFilterRatingMax.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(264, 189);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(53, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 189);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Title or Genre...";
            txtSearch.Size = new Size(237, 23);
            txtSearch.TabIndex = 11;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnCancelMovie
            // 
            btnCancelMovie.Enabled = false;
            btnCancelMovie.Location = new Point(102, 662);
            btnCancelMovie.Name = "btnCancelMovie";
            btnCancelMovie.Size = new Size(75, 23);
            btnCancelMovie.TabIndex = 20;
            btnCancelMovie.Text = "Cancel";
            btnCancelMovie.UseVisualStyleBackColor = true;
            btnCancelMovie.Click += btnCancelMovie_Click;
            // 
            // btnSaveMovie
            // 
            btnSaveMovie.Enabled = false;
            btnSaveMovie.Location = new Point(21, 662);
            btnSaveMovie.Name = "btnSaveMovie";
            btnSaveMovie.Size = new Size(75, 23);
            btnSaveMovie.TabIndex = 19;
            btnSaveMovie.Text = "Save";
            btnSaveMovie.UseVisualStyleBackColor = true;
            btnSaveMovie.Click += btnSaveMovie_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(21, 490);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(294, 166);
            txtDescription.TabIndex = 18;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 472);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description";
            // 
            // txtAvgRating
            // 
            txtAvgRating.Location = new Point(115, 439);
            txtAvgRating.Name = "txtAvgRating";
            txtAvgRating.ReadOnly = true;
            txtAvgRating.Size = new Size(100, 23);
            txtAvgRating.TabIndex = 0;
            txtAvgRating.TabStop = false;
            // 
            // lblAvgRating
            // 
            lblAvgRating.AutoSize = true;
            lblAvgRating.Location = new Point(21, 442);
            lblAvgRating.Name = "lblAvgRating";
            lblAvgRating.Size = new Size(87, 15);
            lblAvgRating.TabIndex = 13;
            lblAvgRating.Text = "Average Rating";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(115, 410);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(100, 23);
            txtDuration.TabIndex = 17;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(21, 413);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(90, 15);
            lblDuration.TabIndex = 11;
            lblDuration.Text = "Duration (mins)";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(115, 381);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.ReadOnly = true;
            txtReleaseYear.Size = new Size(100, 23);
            txtReleaseYear.TabIndex = 16;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(21, 384);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(71, 15);
            lblReleaseYear.TabIndex = 9;
            lblReleaseYear.Text = "Release Year";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(115, 352);
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(200, 23);
            txtGenre.TabIndex = 15;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(21, 355);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "Genre";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(115, 323);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(21, 326);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Enabled = false;
            btnDeleteMovie.Location = new Point(252, 47);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(65, 23);
            btnDeleteMovie.TabIndex = 5;
            btnDeleteMovie.Text = "Delete";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // btnEditMovie
            // 
            btnEditMovie.Enabled = false;
            btnEditMovie.Location = new Point(187, 47);
            btnEditMovie.Name = "btnEditMovie";
            btnEditMovie.Size = new Size(65, 23);
            btnEditMovie.TabIndex = 4;
            btnEditMovie.Text = "Edit";
            btnEditMovie.UseVisualStyleBackColor = true;
            btnEditMovie.Click += btnEditMovie_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(122, 47);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(65, 23);
            btnAddMovie.TabIndex = 3;
            btnAddMovie.Text = "Add New";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // lstMovies
            // 
            lstMovies.FormattingEnabled = true;
            lstMovies.ItemHeight = 15;
            lstMovies.Location = new Point(21, 218);
            lstMovies.Name = "lstMovies";
            lstMovies.Size = new Size(294, 94);
            lstMovies.TabIndex = 2;
            lstMovies.SelectedIndexChanged += lstMovies_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 10);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Movies";
            // 
            // panelReviews
            // 
            panelReviews.BorderStyle = BorderStyle.FixedSingle;
            panelReviews.Controls.Add(txtReviews);
            panelReviews.Controls.Add(btnAddReview);
            panelReviews.Controls.Add(txtUserReview);
            panelReviews.Controls.Add(lblUserReview);
            panelReviews.Controls.Add(txtUserRating);
            panelReviews.Controls.Add(lblUserRating);
            panelReviews.Controls.Add(label2);
            panelReviews.Location = new Point(367, 131);
            panelReviews.Name = "panelReviews";
            panelReviews.Size = new Size(329, 588);
            panelReviews.TabIndex = 1;
            // 
            // txtReviews
            // 
            txtReviews.Location = new Point(17, 37);
            txtReviews.Multiline = true;
            txtReviews.Name = "txtReviews";
            txtReviews.ReadOnly = true;
            txtReviews.ScrollBars = ScrollBars.Vertical;
            txtReviews.Size = new Size(294, 387);
            txtReviews.TabIndex = 0;
            txtReviews.TabStop = false;
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(90, 544);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(75, 23);
            btnAddReview.TabIndex = 24;
            btnAddReview.Text = "Add New";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // txtUserReview
            // 
            txtUserReview.Location = new Point(90, 459);
            txtUserReview.Multiline = true;
            txtUserReview.Name = "txtUserReview";
            txtUserReview.ScrollBars = ScrollBars.Vertical;
            txtUserReview.Size = new Size(221, 79);
            txtUserReview.TabIndex = 23;
            // 
            // lblUserReview
            // 
            lblUserReview.AutoSize = true;
            lblUserReview.Location = new Point(17, 462);
            lblUserReview.Name = "lblUserReview";
            lblUserReview.Size = new Size(44, 15);
            lblUserReview.TabIndex = 19;
            lblUserReview.Text = "Review";
            // 
            // txtUserRating
            // 
            txtUserRating.Location = new Point(90, 430);
            txtUserRating.Name = "txtUserRating";
            txtUserRating.Size = new Size(100, 23);
            txtUserRating.TabIndex = 22;
            // 
            // lblUserRating
            // 
            lblUserRating.AutoSize = true;
            lblUserRating.Location = new Point(17, 433);
            lblUserRating.Name = "lblUserRating";
            lblUserRating.Size = new Size(41, 15);
            lblUserRating.TabIndex = 5;
            lblUserRating.Text = "Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Reviews";
            // 
            // lblLoggedInAs
            // 
            lblLoggedInAs.AutoSize = true;
            lblLoggedInAs.Location = new Point(367, 12);
            lblLoggedInAs.Name = "lblLoggedInAs";
            lblLoggedInAs.Size = new Size(63, 15);
            lblLoggedInAs.TabIndex = 2;
            lblLoggedInAs.Text = "Logged In:";
            // 
            // txtLoggedInAs
            // 
            txtLoggedInAs.BackColor = SystemColors.Control;
            txtLoggedInAs.BorderStyle = BorderStyle.None;
            txtLoggedInAs.Location = new Point(436, 12);
            txtLoggedInAs.Name = "txtLoggedInAs";
            txtLoggedInAs.ReadOnly = true;
            txtLoggedInAs.Size = new Size(265, 16);
            txtLoggedInAs.TabIndex = 3;
            // 
            // btnRegisterNewUser
            // 
            btnRegisterNewUser.Location = new Point(452, 30);
            btnRegisterNewUser.Name = "btnRegisterNewUser";
            btnRegisterNewUser.Size = new Size(157, 23);
            btnRegisterNewUser.TabIndex = 4;
            btnRegisterNewUser.Text = "Add a New User Account";
            btnRegisterNewUser.UseVisualStyleBackColor = true;
            btnRegisterNewUser.Click += btnRegisterNewUser_Click;
            // 
            // btnLogut
            // 
            btnLogut.Location = new Point(367, 30);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(79, 23);
            btnLogut.TabIndex = 4;
            btnLogut.Text = "Logut";
            btnLogut.UseVisualStyleBackColor = true;
            btnLogut.Click += btnLogut_Click;
            // 
            // btnAddToFavorites
            // 
            btnAddToFavorites.Location = new Point(367, 89);
            btnAddToFavorites.Name = "btnAddToFavorites";
            btnAddToFavorites.Size = new Size(242, 23);
            btnAddToFavorites.TabIndex = 21;
            btnAddToFavorites.Text = "Add Movie to My Favorites List";
            btnAddToFavorites.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(367, 60);
            button1.Name = "button1";
            button1.Size = new Size(242, 23);
            button1.TabIndex = 22;
            button1.Text = "View My Favorites List";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 731);
            Controls.Add(button1);
            Controls.Add(btnAddToFavorites);
            Controls.Add(btnLogut);
            Controls.Add(btnRegisterNewUser);
            Controls.Add(txtLoggedInAs);
            Controls.Add(lblLoggedInAs);
            Controls.Add(panelReviews);
            Controls.Add(panelMovies);
            Name = "MainForm";
            Text = "Movie Application";
            Shown += MainForm_Shown;
            panelMovies.ResumeLayout(false);
            panelMovies.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            panelReviews.ResumeLayout(false);
            panelReviews.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMovies;
        private Panel panelReviews;
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtAvgRating;
        private Label lblAvgRating;
        private TextBox txtDuration;
        private Label lblDuration;
        private TextBox txtReleaseYear;
        private Label lblReleaseYear;
        private TextBox txtGenre;
        private Label lblGenre;
        private TextBox txtTitle;
        private Label lblTitle;
        private Button btnDeleteMovie;
        private Button btnEditMovie;
        private Button btnAddMovie;
        private ListBox lstMovies;
        private Button btnCancelMovie;
        private Button btnSaveMovie;
        private TextBox txtUserRating;
        private Label lblUserRating;
        private TextBox txtUserReview;
        private Label lblUserReview;
        private Button btnAddReview;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtFilterYearMin;
        private Label lblFilterDate;
        private TextBox txtFilterRatingMax;
        private TextBox txtFilterRatingMin;
        private TextBox txtFilterYearMax;
        private Label lblFilterRating;
        private GroupBox grpFilter;
        private Button btnFilter;
        private Button btnFilterClear;
        private TextBox txtReviews;
        private Label lblLoggedInAs;
        private TextBox txtLoggedInAs;
        private Button btnRegisterNewUser;
        private Button btnViewAllMovies;
        private Button btnLogut;
        private Button btnAddToFavorites;
        private Button button1;
    }
}