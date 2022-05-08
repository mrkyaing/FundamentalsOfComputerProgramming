using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorGUI
{
    public partial class frmSimpleCalculatorGUI : Form
    {
        public frmSimpleCalculatorGUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int addResult = num1 + num2;
                txtResult.Text = addResult.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur:" + ex.Message);
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtNumber2.Clear();
            txtNumber1.Clear();
        }
    }
}
