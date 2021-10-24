using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Acc;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Pages
{
    public partial class SignUp : Form
    {
        Boolean Active = true;
        Boolean Active1 = true;
        Boolean Active2 = true;
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogon newForm = new FormLogon();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (Active1)
            {
                txtUser.Clear();
                Active1 = false;
            }
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));

            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtDplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                txtPwd.Clear();
                Active = false;
            }
            txtPwd.PasswordChar = '*';
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));

            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtDplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (Active2)
            {
                txtDplayName.Clear();
                Active2 = false;
            }
            txtDplayName.PasswordChar = '*';
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            txtDplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));

            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        Model1 db = new Model1();
        private LogUp logup = new LogUp();
        string error;
        //ashCode hashpass = new HashCode();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = HashCode.HashPassword(txtPwd.Text);
            string displayname = txtDplayName.Text;
            int type;

            if(!cbAdmin.Checked == true)
            {
                type = 0; //0 is employee
            }
            else
            {
                type = 1; //0 is admin
            }

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all information!");
                return;
            }

            if (logup.CheckUser(username))
            {
                MessageBox.Show("User Name used! \n");
            }
            else
            {
                Account newAc = new Account(username, displayname, password, type);
                db.Accounts.Add(newAc);
                db.SaveChanges();
                MessageBox.Show("Sign up success!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAdmin_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbAdmin.Checked == true) {
                cbEmployee.Checked = false;
            }
        }

        private void cbEmployee_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbEmployee.Checked == true)
            {
                cbAdmin.Checked = false;
            }
        }
    }
}
