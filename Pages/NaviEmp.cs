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

namespace WindowsFormsApp1.Pages
{
    public partial class NaviEmp : Form
    {
        public NaviEmp()
        {
            InitializeComponent();
            iconButton1.Visible = false;
            iconButton2.Visible = false;
        }

        private IconButton currentButton;
        private Form activeForm;

        // btn TOP RIGHT
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // btn log out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogon newFormLogin = new FormLogon();
            newFormLogin.Show();
            this.Hide();
        }

        //btn Emp
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton1.Height - 4;
            panel2.Top = iconButton1.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeEmployee(), sender);
        }

        //btn Cus
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton4.Height - 4;
            panel2.Top = iconButton4.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeCustomer(), sender);
        }

        //btn pd
        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel2.Height = iconButton3.Height - 4;
            panel2.Top = iconButton3.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeProduct(), sender);
        }

        //btn set
        private void iconButton2_Click(object sender, EventArgs e)
        {
            //iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton2.Height - 4;
            panel2.Top = iconButton2.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeSetting(), sender);
        }

        private void ActiveForm(Form childForm, object btn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btn);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(childForm);
            this.panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Name;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (IconButton)btnSender;
                    currentButton.ForeColor = color;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.IconColor = color;
                    currentButton.IconSize = 28;
                }
            }
        }

        private Color SelectThemeColor()
        {
            string color = "#ffffff";
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in panel1.Controls)
            {
                if (prevBtn.GetType() == typeof(IconButton))
                {
                    prevBtn.ForeColor = Color.FromArgb(190, 190, 190);
                    prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


    }
}
