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
    public partial class LoginForm : Form
    {

        internal bool loggedIn = false;
        internal User? verifiedUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                while (!loggedIn && verifiedUser is null)
                {
                    if (txtUsername.Text != "" && txtPassword.Text != "")
                    {
                        verifiedUser = User.Login(txtUsername.Text, txtPassword.Text);
                        if (verifiedUser is null)
                        {
                            txtLoginMessage.ForeColor = Color.DarkRed;
                            txtLoginMessage.Text = "Username or Password is incorrect. Please login with a valid user or register as a new user.";
                            break;
                        }
                        else
                        {
                            loggedIn = true;
                            Close();
                        }
                    }
                    else
                    {
                        txtLoginMessage.ForeColor = Color.DarkRed;
                        txtLoginMessage.Text = "Please enter a username and password.";
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                UserRegistrationForm registrationForm = new UserRegistrationForm();
                registrationForm.FormClosing += new FormClosingEventHandler(delegate (object sender, FormClosingEventArgs e)
                {
                    if (registrationForm.registered)
                    {
                        txtLoginMessage.ForeColor = Color.DarkGreen;
                        txtLoginMessage.Text = "Registration succesfull. Please login using your new username and password.";
                    }

                });
                registrationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If enter is pressed, try logging in.
            if (e.KeyChar == (char)13) Login();
        }
    }
}
