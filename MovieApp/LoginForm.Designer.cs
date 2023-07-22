namespace MovieApp
{
    partial class LoginForm
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
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            txtLoginMessage = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(84, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 59);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(84, 85);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(189, 85);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtLoginMessage
            // 
            txtLoginMessage.BackColor = SystemColors.Control;
            txtLoginMessage.BorderStyle = BorderStyle.None;
            txtLoginMessage.Location = new Point(18, 114);
            txtLoginMessage.Multiline = true;
            txtLoginMessage.Name = "txtLoginMessage";
            txtLoginMessage.ReadOnly = true;
            txtLoginMessage.Size = new Size(266, 29);
            txtLoginMessage.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(84, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(306, 155);
            Controls.Add(txtPassword);
            Controls.Add(txtLoginMessage);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login or Register";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblLoginMessage;
        private TextBox txtLoginMessage;
        private TextBox txtPassword;
    }
}