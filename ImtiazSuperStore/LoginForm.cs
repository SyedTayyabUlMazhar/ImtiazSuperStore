using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImtiazSuperStore
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //events attachments 
            {
                this.userNameTextBox.MouseDown += UserNameTextBox_MouseDown;
                this.userNameTextBox.Leave += UserNameTextBox_Leave;

                this.passwordTextBox.MouseDown += PasswordTextBox_MouseDown;
                this.passwordTextBox.Leave += PasswordTextBox_Leave;


                this.loginButton.MouseDown += LoginButton_MouseDown;
                this.loginButton.MouseUp += LoginButton_MouseUp;

            }
        }      
        
        private void LoginButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            LoginButtonReleaseEffect();


            string username = this.userNameTextBox.Text.ToString();
            string password = this.passwordTextBox.Text.ToString();
            if (User.Connect(username, password))
            {
                this.loginFailedLabel.Visible = false;
                DataForm dataForm = new DataForm();
                dataForm.Show();
                
            }
            else
            {
                this.loginFailedLabel.Visible = true;
            }
        }

        
    }
}

