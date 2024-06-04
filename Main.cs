using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePassword().ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
             Program.Logout();
        }

        private void loginHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Program.RecordLogin();
            BindingSource bs = Program.GetLoginHistory();
            loginHistory.DataSource = bs;
        }
    }
}
