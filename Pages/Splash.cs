﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int starP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starP += 10;
            Myprogress.Value = starP;
            PercentageLbl.Text = starP + "%";
            if(Myprogress.Value == 100){
                Myprogress.Value = 0;
                FormLogon Obj = new FormLogon();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
