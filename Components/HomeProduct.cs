using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{
    public partial class HomeProduct : Form
    {
        public HomeProduct()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            pdListProduct frproduct = new pdListProduct();
            this.Visible = false;
            frproduct.ShowDialog();
            this.Visible = true;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            pdBill frbill = new pdBill();
            this.Visible = false;
            frbill.ShowDialog();
            this.Visible = true;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            pdListTable frtable = new pdListTable();
            this.Visible = false;
            frtable.ShowDialog();
            this.Visible = true;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            pdCamera frcamera = new pdCamera();
            this.Visible = false;
            frcamera.ShowDialog();
            this.Visible = true;
        }

        private void HomeProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
