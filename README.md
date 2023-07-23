# IS 153 Movie Application

This WinForms application was submitted for the exam of Modules 3 and 4.

## Program Specification

### Overview

Create a Movie Listing Application that allows users to explore a vast array of movies, each detailed with essential information such as title, genre, release date, duration, rating, and a brief synopsis.

### Key Features

#### User Authentication

- Users can register, log in, and log out. This feature will require user data management and security measures to protect user information. Admins can add, delete, or update any movie in the collection. Admins can also create user accounts.

#### Movie Listing

- Display a list of movies. Each movie will have details like title, genre, release date, duration, rating, and a brief synopsis.

#### Search and Filter

- Users can search for movies by title or genre. They can also filter movies based on release date or rating.

#### User Reviews and Ratings

- Users can rate and review movies. Each movie will display an average rating and user reviews.

#### Favorites List

- Users can add movies to a favorites list for easy access in the future. This could also be known as a watchlist.

## Exam 3

View release: https://github.com/bgoewert/MovieApp-stlcc-is153/releases/tag/Exam-3

## Exam 4

This version required a login form. So, test users were created. Passwords for each are the same as the username. The test users are:

- admin
- test

### Requirements

1. Main Form
    - [x] User login/registration.
    - [x] After login, close and show menu form.
2. Menu Form.
    - [x] ListBox (lstMovies).
    - Movie management.
      - [x] Fields to view, create, and update movie details.
      - [x] ComboBox for movie rating 1-5.
      - Button actions.
        - [x] "Add a Movie" (admin).
        - [x] "Update/Edit Existing Movie" (admin).
        - [x] "Add a New User Account" (admin).
        - [x] "View All Movies".
          - This button will add the movie titles to the ListBox (lstMovies).
        - [x] "View My Favorites List".
          - [x] Opens another form with a ListBox.
          - [x] "Add Movie to My Favorites List".
            - [x] Update the list of movies in the ListBox.
3. Movie collection
    - [x] Collection (list or array) of movies
    - [x] methods to add new movies
4. Functionality to display movies
    - [x] Bind movies to ListBox or DataGridView
    - [x] Handle events to update the movie details when selected
5. Search and filter
    - [x] Search/filter buttons
6. Favorites List
    - [x] Handle events for adding to favorites list
    - [x] Logic to add selected movies
    - [x] Display as separate form
7. Test and refine
    - [x] Test the app thoroughly

#### Not Defined but added for usability

- Check if movie was already added.
- Check if user already exists.
- Logut button so that you can switch users without needing to re-run the application.
