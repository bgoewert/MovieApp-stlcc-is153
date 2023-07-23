using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class RegistrationForm : Form
    {
        internal bool registered = false;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Register()
        {
            try
            {
                // If not registered, add new user.
                if (!registered)
                {
                    if (txtUsername.Text != "" && txtPassword.Text != "" && txtPasswordConfirm.Text != "")
                    {
                        // If passwords do not match, try again.
                        if (txtPassword.Text != txtPasswordConfirm.Text)
                        {
                            txtLoginMessage.ForeColor = Color.DarkRed;
                            txtLoginMessage.Text = "Passwords do not match, try again.";
                        }
                        else
                        {
                            // Create new user object.
                            User newUser = new User(txtUsername.Text, txtPassword.Text);

                            // Check to see of the user already exists.
                            if (User.UserList.FindIndex(0,u => u.Username.ToLower() == newUser.Username.ToLower()) >= 0) throw new Exception("User already exists.");

                            // If not already existing, add the new user.
                            User.UserList.Add(newUser);
                            
                            // Update registration status.
                            registered = true;

                            // Close the registration form.
                            Close();
                        }
                    }
                    else
                    {
                        txtLoginMessage.ForeColor = Color.DarkRed;
                        txtLoginMessage.Text = "Please enter a username and password.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void txtPasswordConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Register();
        }

        private void UserRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registered)
            {
                // Display a success message with the user's username.
                MessageBox.Show($"New user account added successfully. \n\nNew User: {User.UserList.Last().Username}");
            }
        }
    }
}
