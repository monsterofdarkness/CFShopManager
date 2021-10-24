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
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Pages
{
    public partial class NavigationForm : Form
    {
        private IconButton currentButton;
        private Form activeForm;
        public NavigationForm()
        {
            InitializeComponent();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton1.Height - 4;
            panel2.Top = iconButton1.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeEmployee(), sender);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton4.Height - 4;
            panel2.Top = iconButton4.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeCustomer(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel2.Height = iconButton3.Height - 4;
            panel2.Top = iconButton3.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeProduct(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel2.Height = iconButton2.Height - 4;
            panel2.Top = iconButton2.Top + 2;
            ActiveButton(sender);
            ActiveForm(new Components.HomeSetting(), sender);
        }        
         private void iconButton5_Click(object sender, EventArgs e)
        {
            FormLogon newFormLogin = new FormLogon();
            newFormLogin.Show();
            this.Hide();
        }       
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
            this.panelPage.Controls.Add(childForm);
            this.panelPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
