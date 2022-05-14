using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            IUserDAO userService = new UserService();
            UserModel user = userService.GetUser(userName, password);//1,2,3
            if (user.Id>0)
            {
                this.Hide();//Hiding Login UI frm 
                DashboardUI dashboardUI = new DashboardUI();
                dashboardUI.Show();             
            }
            else
            {
                MessageBox.Show("User name or password is incorrect", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
