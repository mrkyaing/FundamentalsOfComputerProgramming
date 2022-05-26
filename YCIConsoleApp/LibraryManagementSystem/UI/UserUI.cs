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
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }
        public int selectedUserId { get; set; }
        public bool isUpdateProcess = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text.Equals("Save"))
                {
                    string username = txtUserName.Text;
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;
                    string confirmpassword = txtConfirmPassword.Text;
                    string role = null;
                    if (password != confirmpassword)
                    {
                        MessageBox.Show("password and confirm password does not match");
                        return;
                    }
                    if (rdoAdmin.Checked)
                    {
                        role = "admin";
                    }
                    else if (rdoStaff.Checked)
                    {
                        role = "staff";
                    }
                    IUserDAO userDAO = new UserService();
                    int maxUserId = userDAO.GetMaxUserId();//4
                    maxUserId++;//5
                    UserModel user = new UserModel()
                    {
                        Id = maxUserId,
                        UserName = username,
                        Email = email,
                        Password = password,
                        Role = role
                    };

                    userDAO.SaveUser(user);
                    MessageBox.Show("Save Success");
                }
                else
                {
                    string username = txtUserName.Text;
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;
                    string confirmpassword = txtConfirmPassword.Text;
                    string role = null;
                    if (password != confirmpassword)
                    {
                        MessageBox.Show("password and confirm password does not match");
                        return;
                    }
                    if (rdoAdmin.Checked)
                    {
                        role = "admin";
                    }
                    else if (rdoStaff.Checked)
                    {
                        role = "staff";
                    }
                    IUserDAO userDAO = new UserService();
                    UserModel user = new UserModel()
                    {
                        Id = selectedUserId,
                        UserName = username,
                        Email = email,
                        Password = password,
                        Role = role
                    };

                    userDAO.UpdateUser(user);
                    MessageBox.Show("Update Success");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error when saving user record.");
            }
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            if (isUpdateProcess)
            {
                IUserDAO userDAO = new UserService();
                btnSave.Text = "Update";
                UserModel user = userDAO.GetUserModelByUserId(selectedUserId);//12
                txtUserName.Text = user.UserName;
                txtEmail.Text = user.Email;
                if (user.Role.Equals("admin"))
                    rdoAdmin.Checked=true;
                else if (user.Role.Equals("staff"))
                    rdoStaff.Checked = true;
            }
        }
    }
}
