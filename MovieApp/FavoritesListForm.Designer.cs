﻿namespace MovieApp
{
    partial class FavoritesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFavorites = new ListBox();
            SuspendLayout();
            // 
            // lstFavorites
            // 
            lstFavorites.Dock = DockStyle.Fill;
            lstFavorites.FormattingEnabled = true;
            lstFavorites.ItemHeight = 15;
            lstFavorites.Location = new Point(0, 0);
            lstFavorites.Name = "lstFavorites";
            lstFavorites.Size = new Size(334, 161);
            lstFavorites.TabIndex = 0;
            lstFavorites.SelectedIndexChanged += lstFavorites_SelectedIndexChanged;
            // 
            // FavoritesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 161);
            Controls.Add(lstFavorites);
            Name = "FavoritesListForm";
            Text = "My Favorites List";
            ResumeLayout(false);
        }

        #endregion

        protected internal ListBox lstFavorites;
    }
}