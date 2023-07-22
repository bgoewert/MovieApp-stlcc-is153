namespace MovieApp
{
    partial class UserRegistrationForm
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
            txtPassword = new TextBox();
            btnRegister = new Button();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPasswordConfirm = new TextBox();
            label1 = new Label();
            txtLoginMessage = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(122, 109);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 54);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 25);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Location = new Point(122, 80);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.Size = new Size(200, 23);
            txtPasswordConfirm.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 16;
            label1.Text = "Confirm Password";
            // 
            // txtLoginMessage
            // 
            txtLoginMessage.BackColor = SystemColors.Control;
            txtLoginMessage.BorderStyle = BorderStyle.None;
            txtLoginMessage.Location = new Point(59, 138);
            txtLoginMessage.Multiline = true;
            txtLoginMessage.Name = "txtLoginMessage";
            txtLoginMessage.ReadOnly = true;
            txtLoginMessage.Size = new Size(266, 29);
            txtLoginMessage.TabIndex = 18;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 177);
            Controls.Add(txtLoginMessage);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserRegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserRegistrationForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnRegister;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPasswordConfirm;
        private Label label1;
        private TextBox txtLoginMessage;
    }
}