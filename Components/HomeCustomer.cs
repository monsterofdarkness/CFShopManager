using FontAwesome.Sharp;
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
    public partial class HomeCustomer : Form
    {
        public HomeCustomer()
        {
            InitializeComponent();
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            ctListCustomer frcus = new ctListCustomer();
            this.Visible = false;
            frcus.ShowDialog();
            this.Visible = true;
        }
    }
}
