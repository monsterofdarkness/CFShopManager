using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Components
{
    public partial class pdListTable : Form
    {
        public pdListTable()
        {
            InitializeComponent();
        }



        Model1 db = new Model1();

        // Change status  

        //table 1
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id ==1)
                {
                    btnTable1.BackColor = Color.OrangeRed;
                    btnTable1.color = Color.OrangeRed;
                    btnTable1.BackColor = Color.OrangeRed;
                    btnTable1.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 1)
                {
                    btnTable1.BackColor = Color.SeaGreen;
                    btnTable1.color = Color.SeaGreen;
                    btnTable1.BackColor = Color.SeaGreen;
                    btnTable1.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 2
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 2)
                {
                    btnTable2.BackColor = Color.OrangeRed;
                    btnTable2.color = Color.OrangeRed;
                    btnTable2.BackColor = Color.OrangeRed;
                    btnTable2.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 2)
                {
                    btnTable2.BackColor = Color.SeaGreen;
                    btnTable2.color = Color.SeaGreen;
                    btnTable2.BackColor = Color.SeaGreen;
                    btnTable2.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 3
        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 3)
                {
                    btnTable3.BackColor = Color.OrangeRed;
                    btnTable3.color = Color.OrangeRed;
                    btnTable3.BackColor = Color.OrangeRed;
                    btnTable3.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 3)
                {
                    btnTable3.BackColor = Color.SeaGreen;
                    btnTable3.color = Color.SeaGreen;
                    btnTable3.BackColor = Color.SeaGreen;
                    btnTable3.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 4
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 4)
                {
                    btnTable4.BackColor = Color.OrangeRed;
                    btnTable4.color = Color.OrangeRed;
                    btnTable4.BackColor = Color.OrangeRed;
                    btnTable4.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 4)
                {
                    btnTable4.BackColor = Color.SeaGreen;
                    btnTable4.color = Color.SeaGreen;
                    btnTable4.BackColor = Color.SeaGreen;
                    btnTable4.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 5
        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 5)
                {
                    btnTable5.BackColor = Color.OrangeRed;
                    btnTable5.color = Color.OrangeRed;
                    btnTable5.BackColor = Color.OrangeRed;
                    btnTable5.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 5)
                {
                    btnTable5.BackColor = Color.SeaGreen;
                    btnTable5.color = Color.SeaGreen;
                    btnTable5.BackColor = Color.SeaGreen;
                    btnTable5.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 6
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 6)
                {
                    btnTable6.BackColor = Color.OrangeRed;
                    btnTable6.color = Color.OrangeRed;
                    btnTable6.BackColor = Color.OrangeRed;
                    btnTable6.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 6)
                {
                    btnTable6.BackColor = Color.SeaGreen;
                    btnTable6.color = Color.SeaGreen;
                    btnTable6.BackColor = Color.SeaGreen;
                    btnTable6.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 7
        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 7)
                {
                    btnTable7.BackColor = Color.OrangeRed;
                    btnTable7.color = Color.OrangeRed;
                    btnTable7.BackColor = Color.OrangeRed;
                    btnTable7.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 7)
                {
                    btnTable7.BackColor = Color.SeaGreen;
                    btnTable7.color = Color.SeaGreen;
                    btnTable7.BackColor = Color.SeaGreen;
                    btnTable7.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 8
        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 8)
                {
                    btnTable8.BackColor = Color.OrangeRed;
                    btnTable8.color = Color.OrangeRed;
                    btnTable8.BackColor = Color.OrangeRed;
                    btnTable8.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 8)
                {
                    btnTable8.BackColor = Color.SeaGreen;
                    btnTable8.color = Color.SeaGreen;
                    btnTable8.BackColor = Color.SeaGreen;
                    btnTable8.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 9
        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 9)
                {
                    btnTable9.BackColor = Color.OrangeRed;
                    btnTable9.color = Color.OrangeRed;
                    btnTable9.BackColor = Color.OrangeRed;
                    btnTable9.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 9)
                {
                    btnTable9.BackColor = Color.SeaGreen;
                    btnTable9.color = Color.SeaGreen;
                    btnTable9.BackColor = Color.SeaGreen;
                    btnTable9.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }
            //table 10
        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            foreach (TableCF item in db.TableCFs)
            {
                if (item.status == "0" && item.id == 10)
                {
                    btnTable10.BackColor = Color.OrangeRed;
                    btnTable10.color = Color.OrangeRed;
                    btnTable10.BackColor = Color.OrangeRed;
                    btnTable10.colorActive = Color.Pink;
                    item.status = "1";
                }
                else if (item.status == "1" && item.id == 10)
                {
                    btnTable10.BackColor = Color.SeaGreen;
                    btnTable10.color = Color.SeaGreen;
                    btnTable10.BackColor = Color.SeaGreen;
                    btnTable10.colorActive = Color.MediumSeaGreen;
                    item.status = "0";
                }
            }
        }       
        
        //end table
        
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
        }
    } 
