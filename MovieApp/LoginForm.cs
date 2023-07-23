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
        internal User? verifiedUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                while (verifiedUser is null)
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
                        else Close();
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



        private void btnLogin_Click(object sender, EventArgs e) { Login(); }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Create registration form object.
                RegistrationForm registrationForm = new RegistrationForm();

                // Create event handler to check if sucessfully registered and update text notifcation if so.
                registrationForm.FormClosing += new FormClosingEventHandler(delegate (object sender, FormClosingEventArgs e)
                {
                    if (registrationForm.registered)
                    {
                        txtLoginMessage.ForeColor = Color.DarkGreen;
                        txtLoginMessage.Text = "Registration succesfull. Please login using your new username and password.";
                    }

                });

                // Show registraion form as a dialog box.
                registrationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If Enter is pressed after entering a password, try logging in.
            if (e.KeyChar == (char)Keys.Enter) Login();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Make login a requirement to access the application.
            try
            {
                if (verifiedUser is null) throw new Exception("Login Required");
                MainForm.currentUser = verifiedUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
