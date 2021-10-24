using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pages;

namespace WindowsFormsApp1.Components
{
    public partial class HomeEmployee : Form
    {
        public HomeEmployee()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            elListEmployee frlemp = new elListEmployee();
            this.Visible = false;
            frlemp.ShowDialog();
            this.Visible = true;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            elEmployeePayroll frlemppay = new elEmployeePayroll();
            this.Visible = false;
            frlemppay.ShowDialog();
            this.Visible = true;
        }
    }
}
