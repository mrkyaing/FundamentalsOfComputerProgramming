using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginGUI
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "admin@123")
            {
                MessageBox.Show("Hi,Admin,Welcome!", "Login successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("User Name or Passwrod is incorrect.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtsuccessed.Text = username;
          
        }
    }
}
