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
    public partial class FormLogon : Form
    {
        Boolean Active = true;
        Boolean Active1 = true;

        public FormLogon()
        {
            InitializeComponent();
            login = new Login();
        }

        public bool CheckInput(object sender)
        {
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void iconButton2_Click(object sender, EventArgs e)
        //{
        //    SignUp newFormSignUp = new SignUp();
        //    newFormSignUp.Show();
        //    this.Hide();
        //}

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private Model1 db = new Model1();
        private Login login;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPwd.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all information!");
                return;
            }
            Account account = login.CheckLogin(username, password, db);
            if (account!= null)
            {
                MessageBox.Show("Login success!\n");
                if (account.TypeUser == 1)
                {
                    NavigationForm frmMain = new NavigationForm();
                    this.Visible = false;
                    frmMain.ShowDialog();
                }
                else if (account.TypeUser == 0)
                {
                    NaviEmp frmMain = new NaviEmp();
                    this.Visible = false;
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error!");
                }

                this.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail!");
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogon_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
