using System;
using System.Windows.Forms;

namespace ImtiazSuperStore
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
        private System.Windows.Forms.Label LendingLabel;
        private System.Windows.Forms.Splitter LibraryLendingSplitterBackground;
        private System.Windows.Forms.Button LendingLibrarySplittersShadow;
        //
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox UsernameTextBoxOutline1;
        private System.Windows.Forms.TextBox UsernameTextBoxOutline2;
        //
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBoxOutline1;
        private System.Windows.Forms.TextBox PasswordTextBoxOutline2;
        //
        public System.Windows.Forms.Label loginFailedLabel;

        private System.Windows.Forms.Button loginButton;       
        private System.Windows.Forms.Button LoginButtonShadow;
        //
        //
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LendingLabel = new System.Windows.Forms.Label();
            this.LibraryLendingSplitterBackground = new System.Windows.Forms.Splitter();
            this.LendingLibrarySplittersShadow = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBoxOutline1 = new System.Windows.Forms.TextBox();
            this.UsernameTextBoxOutline2 = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxOutline1 = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxOutline2 = new System.Windows.Forms.TextBox();
            this.loginFailedLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.LoginButtonShadow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LendingLabel
            // 
            this.LendingLabel.AutoSize = true;
            this.LendingLabel.BackColor = System.Drawing.Color.White;
            this.LendingLabel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendingLabel.ForeColor = System.Drawing.Color.Black;
            this.LendingLabel.Location = new System.Drawing.Point(29, 126);
            this.LendingLabel.Name = "LendingLabel";
            this.LendingLabel.Size = new System.Drawing.Size(220, 51);
            this.LendingLabel.TabIndex = 8;
            this.LendingLabel.Text = "Super Store";
            // 
            // LibraryLendingSplitterBackground
            // 
            this.LibraryLendingSplitterBackground.BackColor = System.Drawing.Color.White;
            this.LibraryLendingSplitterBackground.Location = new System.Drawing.Point(0, 0);
            this.LibraryLendingSplitterBackground.Name = "LibraryLendingSplitterBackground";
            this.LibraryLendingSplitterBackground.Size = new System.Drawing.Size(271, 352);
            this.LibraryLendingSplitterBackground.TabIndex = 7;
            this.LibraryLendingSplitterBackground.TabStop = false;
            // 
            // LendingLibrarySplittersShadow
            // 
            this.LendingLibrarySplittersShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.LendingLibrarySplittersShadow.Enabled = false;
            this.LendingLibrarySplittersShadow.FlatAppearance.BorderSize = 0;
            this.LendingLibrarySplittersShadow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendingLibrarySplittersShadow.Location = new System.Drawing.Point(203, 3);
            this.LendingLibrarySplittersShadow.Name = "LendingLibrarySplittersShadow";
            this.LendingLibrarySplittersShadow.Size = new System.Drawing.Size(75, 356);
            this.LendingLibrarySplittersShadow.TabIndex = 14;
            this.LendingLibrarySplittersShadow.UseVisualStyleBackColor = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(344, 77);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(85, 21);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(443, 80);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // UsernameTextBoxOutline1
            // 
            this.UsernameTextBoxOutline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.UsernameTextBoxOutline1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBoxOutline1.Enabled = false;
            this.UsernameTextBoxOutline1.Location = new System.Drawing.Point(442, 79);
            this.UsernameTextBoxOutline1.Name = "UsernameTextBoxOutline1";
            this.UsernameTextBoxOutline1.Size = new System.Drawing.Size(131, 13);
            this.UsernameTextBoxOutline1.TabIndex = 10;
            // 
            // UsernameTextBoxOutline2
            // 
            this.UsernameTextBoxOutline2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.UsernameTextBoxOutline2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBoxOutline2.Enabled = false;
            this.UsernameTextBoxOutline2.Location = new System.Drawing.Point(442, 88);
            this.UsernameTextBoxOutline2.Name = "UsernameTextBoxOutline2";
            this.UsernameTextBoxOutline2.Size = new System.Drawing.Size(131, 13);
            this.UsernameTextBoxOutline2.TabIndex = 11;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(348, 156);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(444, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(129, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // PasswordTextBoxOutline1
            // 
            this.PasswordTextBoxOutline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.PasswordTextBoxOutline1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBoxOutline1.Enabled = false;
            this.PasswordTextBoxOutline1.Location = new System.Drawing.Point(443, 157);
            this.PasswordTextBoxOutline1.Name = "PasswordTextBoxOutline1";
            this.PasswordTextBoxOutline1.Size = new System.Drawing.Size(131, 13);
            this.PasswordTextBoxOutline1.TabIndex = 12;
            this.PasswordTextBoxOutline1.Visible = false;
            // 
            // PasswordTextBoxOutline2
            // 
            this.PasswordTextBoxOutline2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.PasswordTextBoxOutline2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBoxOutline2.Enabled = false;
            this.PasswordTextBoxOutline2.Location = new System.Drawing.Point(443, 166);
            this.PasswordTextBoxOutline2.Name = "PasswordTextBoxOutline2";
            this.PasswordTextBoxOutline2.Size = new System.Drawing.Size(131, 13);
            this.PasswordTextBoxOutline2.TabIndex = 13;
            this.PasswordTextBoxOutline2.Visible = false;
            // 
            // loginFailedLabel
            // 
            this.loginFailedLabel.AutoSize = true;
            this.loginFailedLabel.ForeColor = System.Drawing.Color.Red;
            this.loginFailedLabel.Location = new System.Drawing.Point(409, 202);
            this.loginFailedLabel.Name = "loginFailedLabel";
            this.loginFailedLabel.Size = new System.Drawing.Size(207, 13);
            this.loginFailedLabel.TabIndex = 5;
            this.loginFailedLabel.Text = "Login failed. Invalid username or password";
            this.loginFailedLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(175)))), ((int)(((byte)(137)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(496, 242);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 33);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // LoginButtonShadow
            // 
            this.LoginButtonShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginButtonShadow.FlatAppearance.BorderSize = 0;
            this.LoginButtonShadow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(175)))));
            this.LoginButtonShadow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(175)))));
            this.LoginButtonShadow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButtonShadow.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButtonShadow.ForeColor = System.Drawing.Color.White;
            this.LoginButtonShadow.Location = new System.Drawing.Point(498, 244);
            this.LoginButtonShadow.Name = "LoginButtonShadow";
            this.LoginButtonShadow.Size = new System.Drawing.Size(75, 34);
            this.LoginButtonShadow.TabIndex = 9;
            this.LoginButtonShadow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 51);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imtiaz";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LendingLabel);
            this.Controls.Add(this.LibraryLendingSplitterBackground);
            this.Controls.Add(this.LendingLibrarySplittersShadow);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.UsernameTextBoxOutline1);
            this.Controls.Add(this.UsernameTextBoxOutline2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.PasswordTextBoxOutline1);
            this.Controls.Add(this.PasswordTextBoxOutline2);
            this.Controls.Add(this.loginFailedLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.LoginButtonShadow);
            this.Name = "LoginForm";
            this.Text = "Lending Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void AppClose(object sender, FormClosedEventArgs e) => this.Close();


        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {
            this.UsernameTextBoxOutline1.Visible = false;
            this.UsernameTextBoxOutline2.Visible = false;
        }

        private void UserNameTextBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.UsernameTextBoxOutline1.Visible = true;
            this.UsernameTextBoxOutline2.Visible = true;
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            this.PasswordTextBoxOutline1.Visible = false;
            this.PasswordTextBoxOutline2.Visible = false;
        }

        private void PasswordTextBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.PasswordTextBoxOutline1.Visible = true;
            this.PasswordTextBoxOutline2.Visible = true;
        }


        private void LoginButton_MouseDown(object sender, EventArgs e) => LoginButtonClickEffect();


        private void LoginButtonClickEffect() => this.loginButton.Location = new System.Drawing.Point(497, 243);
        private void LoginButtonReleaseEffect() => this.loginButton.Location = new System.Drawing.Point(496, 242);

        #endregion

        private Label label1;
        private Label label2;
    }
}

