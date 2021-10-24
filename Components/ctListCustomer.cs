using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Components
{
    public partial class ctListCustomer : Form
    {
        public ctListCustomer()
        {
            InitializeComponent();
            loadDTRV();
        }

        private void loadDTRV()
        {
            db.Customers.Load();
            dgvCustomer.DataSource = db.Customers.Local.ToBindingList();
            deleteTxt();
        }

        private Model1 db = new Model1();
        private Customer customer = new Customer();
        
        private void checkbMale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkbMale.Checked == true)
            {
                checkbFemale.Checked = false;
            }
        }

        private void checkbFemale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkbFemale.Checked == true)
            {
                checkbMale.Checked = false;
            }
        }

        private void checkbBasic_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(checkbBasic.Checked == true)
            {
                checkbVip.Checked = false;
            }
        }

        private void checkbVip_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkbVip.Checked == true)
            {
                checkbBasic.Checked = false;
            }
        }
        private void deleteTxt()
        {
            txtNameCus.Clear();
            checkbFemale.Checked = false;
            checkbMale.Checked = true;
            dpDobCus.Value = DateTime.Today;
            checkbBasic.Checked = true;
            checkbVip.Checked = false;
            txtNameCus.Focus();
            dgvCustomer.Columns["Bills"].Visible = false;
        }

        //add customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customer.NameCustomer = txtNameCus.Text.Trim();
                if(checkbFemale.Checked == true)
                {
                    customer.Sex = 0;
                }
                else if(checkbMale.Checked == true)
                {
                    customer.Sex = 1;
                }
                else
                {
                    MessageBox.Show("error");
                }

                customer.DoB = dpDobCus.Value;

                if (checkbBasic.Checked == true)
                {
                    customer.Classtify = 0;
                }
                else if (checkbVip.Checked == true)
                {
                    customer.Classtify = 1;
                }
                else
                {
                    MessageBox.Show("error");
                }

                db.Customers.Add(customer);
                db.SaveChanges();
                dgvCustomer.DataSource = db.Customers.Local.ToBindingList();
                deleteTxt();
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        //edit customer
        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["IDCus"].Value.ToString());
                customer = db.Customers.Where(x => x.id == id).FirstOrDefault();
                txtNameCus.Text = customer.NameCustomer;
                dpDobCus.Value = (DateTime)customer.DoB;
                if (customer.Sex == 1)
                {
                    checkbMale.Checked = true;
                }
                else if(customer.Sex == 0)
                {
                    checkbFemale.Checked = true;
                }

                if (customer.Classtify == 1)
                {
                    checkbVip.Checked = true;
                }
                else if (customer.Classtify == 0)
                {
                    checkbBasic.Checked = true;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            customer.NameCustomer = txtNameCus.Text.Trim();
            if (checkbFemale.Checked == true)
            {
                customer.Sex = 0;
            }
            else if (checkbMale.Checked == true)
            {
                customer.Sex = 1;
            }
            else
            {
                MessageBox.Show("error");
            }

            customer.DoB = dpDobCus.Value;

            if (checkbBasic.Checked == true)
            {
                customer.Classtify = 0;
            }
            else if (checkbVip.Checked == true)
            {
                customer.Classtify = 1;
            }
            else
            {
                MessageBox.Show("error");
            }

            if (customer.id == 0) //INSERT
                db.Customers.Add(customer);
            else // EDIT
                db.Entry(customer).State = EntityState.Modified;
            db.SaveChanges();
            dgvCustomer.DataSource = db.Customers.Local.ToBindingList();
            deleteTxt();
            MessageBox.Show("Sucess!");

        }

        //remove customer
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entry = db.Entry(customer);
                if (entry.State == EntityState.Detached)
                    db.Customers.Attach(customer);
                db.Customers.Remove(customer);
                db.SaveChanges();
                dgvCustomer.DataSource = db.Customers.Local.ToBindingList();

                deleteTxt();
                MessageBox.Show("Sucessfully!");
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //(dgvCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("NameCustomer LIKE '%{0}%'", txtSearch.Text);
            
        }

        private DataTable GetDataTableFromDGV(Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            var dt = ((DataTable)dgv.DataSource).Copy();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (!column.Visible)
                {
                    dt.Columns.Remove(column.Name);
                }
            }
            return dt;
        }
    }
}
