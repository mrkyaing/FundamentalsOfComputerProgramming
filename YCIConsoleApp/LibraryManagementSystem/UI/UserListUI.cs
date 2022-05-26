using LibraryManagementSystem.DAO;
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
    public partial class UserListUI : Form
    {
        public UserListUI()
        {
            InitializeComponent();
        }
        public int userId { get; set; }//to use when update and delete process 

        private void UserListUI_Load(object sender, EventArgs e)
        {
            GetUserListFromDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IUserDAO userDAO = new UserService();
            DialogResult result= MessageBox.Show("are you sure to delete this record?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                if (userDAO.DeleteByUserId(userId))
                {
                    MessageBox.Show("Delete success");
                }
            }
            GetUserListFromDB();
        }
        private void GetUserListFromDB()
        {
            IUserDAO userDAO = new UserService();
            gvUserList.DataSource = userDAO.GetAllUser();//getting all of record from the database and then biding to grid view.
        }
        private void gvUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = gvUserList.Rows[e.RowIndex];
                userId = int.Parse(row.Cells["Id"].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserUI userUI = new UserUI();//create object to call user ui
            userUI.selectedUserId = userId;//set the user selected id
            userUI.isUpdateProcess = true;
            userUI.Show();//show the user ui form
        }
    }
}
