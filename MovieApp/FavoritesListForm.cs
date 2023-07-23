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
    }
}
