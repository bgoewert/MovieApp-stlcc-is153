using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MovieApp
{
    public partial class FavoritesListForm : Form
    {
        public FavoritesListForm()
        {
            InitializeComponent();

            if (MainForm.currentUser is not null)
            {
                lstFavorites.DataSource = MainForm.currentUser.Favorites;
                lstFavorites.DisplayMember = "Title";
            }
        }

        private void lstFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change selected item on the main form when a different favorite is selected
            if (lstFavorites.SelectedItem is not null)
                Program.mainForm.lstMovies.SelectedItem = lstFavorites.SelectedItem;
        }
    }
}
