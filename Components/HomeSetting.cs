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
    public partial class HomeSetting : Form
    {
        public HomeSetting()
        {
            InitializeComponent();
        }

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Visible = false;
            signup.ShowDialog();
            this.Visible = true;
        }
    }
}
