using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButtonOnClick(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            Console.WriteLine(username);
            Console.WriteLine(password);
            bool success = Program.Login(username, password);
            if (success)
            {
                usernameField.Text = "";
                passwordField.Text = "";
                responseLabel.Visible = false;
            }
            else
            {
                responseLabel.Visible = true;
            }

        }
    }
}
