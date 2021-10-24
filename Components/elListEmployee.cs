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
    public partial class elListEmployee : Form
    {
        public elListEmployee()
        {
            InitializeComponent();
            loadDTRV();
        }

        private Model1 db = new Model1();
        private Employee employee = new Employee();

        private void loadDTRV()
        {
            db.Employees.Load();
            dgvEmployee.DataSource = db.Employees.Local.ToBindingList();
            deleteTxt();
        }

        

        private void deleteTxt()
        {
            txtNameEmployee.Clear();
            checkbMale.Checked = true;
            checkbFemale.Checked = false;
            dpDob.Value = DateTime.Today;
            txtBasicSalary.Clear();
            cbPosition.Text = "";
            txtNameEmployee.Focus();
            dgvEmployee.Columns["Bills"].Visible = false;
            dgvEmployee.Columns["EmployeePayrolls"].Visible = false;

        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                employee.NameEmployee = txtNameEmployee.Text.Trim();
                if (checkbFemale.Checked == true)
                {
                    employee.Sex = 0;
                }
                else if (checkbMale.Checked == true)
                {
                    employee.Sex = 1;
                }
                else
                {
                    MessageBox.Show("error");
                }

                employee.DoB = dpDob.Value;

                employee.BasicSalary = double.Parse(txtBasicSalary.Text.Trim());

                employee.Position = cbPosition.Text;

                db.Employees.Add(employee);
                db.SaveChanges();
                dgvEmployee.DataSource = db.Employees.Local.ToBindingList();
                deleteTxt();
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            employee.NameEmployee = txtNameEmployee.Text.Trim();
            if (checkbFemale.Checked == true)
            {
                employee.Sex = 0;
            }
            else if (checkbMale.Checked == true)
            {
                employee.Sex = 1;
            }
            else
            {
                MessageBox.Show("error");
            }

            employee.DoB = dpDob.Value;

            employee.BasicSalary = double.Parse(txtBasicSalary.Text.Trim());

            employee.Position = cbPosition.Text;

            if (employee.id == 0) //INSERT
                db.Employees.Add(employee);
            else // EDIT
                db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            dgvEmployee.DataSource = db.Employees.Local.ToBindingList();
            deleteTxt();
            MessageBox.Show("Sucess!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entry = db.Entry(employee);
                if (entry.State == EntityState.Detached)
                    db.Employees.Attach(employee);
                db.Employees.Remove(employee);
                db.SaveChanges();
                dgvEmployee.DataSource = db.Employees.Local.ToBindingList();

                deleteTxt();
                MessageBox.Show("Sucessfully!");
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["IDEmployee"].Value.ToString());
                employee = db.Employees.Where(x => x.id == id).FirstOrDefault();
                txtNameEmployee.Text = employee.NameEmployee;
                dpDob.Value = (DateTime)employee.DoB;
                if (employee.Sex == 1)
                {
                    checkbMale.Checked = true;
                }
                else if (employee.Sex == 0)
                {
                    checkbFemale.Checked = true;
                }

                dpDob.Value = (DateTime)employee.DoB;

                txtBasicSalary.Text = employee.BasicSalary.ToString();

                cbPosition.Text = employee.Position;
            }
        }
    }
}
