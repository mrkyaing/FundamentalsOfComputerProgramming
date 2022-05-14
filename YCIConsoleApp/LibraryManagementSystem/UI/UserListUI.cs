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

        private void UserListUI_Load(object sender, EventArgs e)
        {
            IUserDAO userDAO = new UserService();
            gvUserList.DataSource = userDAO.GetAllUser();//getting all of record from the database and then biding to grid view.
        }
    }
}
