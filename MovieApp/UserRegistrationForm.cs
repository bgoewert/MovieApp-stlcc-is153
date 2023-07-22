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
    public partial class UserRegistrationForm : Form
    {
        internal bool registered = false;

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void Register()
        {
            try
            {
                // TODO: Check if user is not already registered.
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
                            UserList.Users.Add(new User(txtUsername.Text, txtPassword.Text));
                            registered = true;
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
                MessageBox.Show(ex.Message, "Error");
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
                MessageBox.Show($"New user account added succesfully. \n\nNew User: {UserList.Users.Last().Username}");
            }
        }
    }
}
