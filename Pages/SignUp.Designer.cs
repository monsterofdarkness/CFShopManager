
namespace WindowsFormsApp1.Pages
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.txtDplayName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSignUp = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbAdmin = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEmployee = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Peru;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Peru;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(85, 297);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Peru;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(131, 297);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 32);
            this.txtUser.TabIndex = 13;
            this.txtUser.Text = "Username";
            this.txtUser.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Peru;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(85, 360);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Peru;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPwd.ForeColor = System.Drawing.Color.White;
            this.txtPwd.Location = new System.Drawing.Point(131, 360);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(209, 32);
            this.txtPwd.TabIndex = 15;
            this.txtPwd.Text = "Password";
            this.txtPwd.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Peru;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(85, 237);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 16;
            this.iconPictureBox3.TabStop = false;
            // 
            // txtDplayName
            // 
            this.txtDplayName.BackColor = System.Drawing.Color.Peru;
            this.txtDplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDplayName.ForeColor = System.Drawing.Color.White;
            this.txtDplayName.Location = new System.Drawing.Point(131, 236);
            this.txtDplayName.Multiline = true;
            this.txtDplayName.Name = "txtDplayName";
            this.txtDplayName.Size = new System.Drawing.Size(209, 32);
            this.txtDplayName.TabIndex = 17;
            this.txtDplayName.Text = "Display Name";
            this.txtDplayName.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel1.Location = new System.Drawing.Point(131, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 4);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel2.Location = new System.Drawing.Point(131, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 4);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel3.Location = new System.Drawing.Point(131, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 4);
            this.panel3.TabIndex = 19;
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignUp.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSignUp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSignUp.IconSize = 50;
            this.btnSignUp.Location = new System.Drawing.Point(76, 483);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSignUp.Size = new System.Drawing.Size(264, 50);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "  Confirm";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(363, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(413, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AllowBindingControlAnimation = true;
            this.cbAdmin.AllowBindingControlColorChanges = false;
            this.cbAdmin.AllowBindingControlLocation = true;
            this.cbAdmin.AllowCheckBoxAnimation = false;
            this.cbAdmin.AllowCheckmarkAnimation = true;
            this.cbAdmin.AllowOnHoverStates = true;
            this.cbAdmin.AutoCheck = true;
            this.cbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbAdmin.BackgroundImage")));
            this.cbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbAdmin.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbAdmin.BorderRadius = 12;
            this.cbAdmin.Checked = false;
            this.cbAdmin.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.cbAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAdmin.CustomCheckmarkImage = null;
            this.cbAdmin.Location = new System.Drawing.Point(90, 418);
            this.cbAdmin.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbAdmin.OnCheck.BorderRadius = 12;
            this.cbAdmin.OnCheck.BorderThickness = 2;
            this.cbAdmin.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbAdmin.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbAdmin.OnCheck.CheckmarkThickness = 2;
            this.cbAdmin.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbAdmin.OnDisable.BorderRadius = 12;
            this.cbAdmin.OnDisable.BorderThickness = 2;
            this.cbAdmin.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbAdmin.OnDisable.CheckmarkThickness = 2;
            this.cbAdmin.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbAdmin.OnHoverChecked.BorderRadius = 12;
            this.cbAdmin.OnHoverChecked.BorderThickness = 2;
            this.cbAdmin.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbAdmin.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbAdmin.OnHoverChecked.CheckmarkThickness = 2;
            this.cbAdmin.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbAdmin.OnHoverUnchecked.BorderRadius = 12;
            this.cbAdmin.OnHoverUnchecked.BorderThickness = 1;
            this.cbAdmin.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbAdmin.OnUncheck.BorderRadius = 12;
            this.cbAdmin.OnUncheck.BorderThickness = 1;
            this.cbAdmin.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.Size = new System.Drawing.Size(27, 27);
            this.cbAdmin.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbAdmin.TabIndex = 23;
            this.cbAdmin.ThreeState = false;
            this.cbAdmin.ToolTipText = null;
            this.cbAdmin.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.cbAdmin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(123, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(236, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Employee";
            // 
            // cbEmployee
            // 
            this.cbEmployee.AllowBindingControlAnimation = true;
            this.cbEmployee.AllowBindingControlColorChanges = false;
            this.cbEmployee.AllowBindingControlLocation = true;
            this.cbEmployee.AllowCheckBoxAnimation = false;
            this.cbEmployee.AllowCheckmarkAnimation = true;
            this.cbEmployee.AllowOnHoverStates = true;
            this.cbEmployee.AutoCheck = true;
            this.cbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEmployee.BackgroundImage")));
            this.cbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbEmployee.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbEmployee.BorderRadius = 12;
            this.cbEmployee.Checked = false;
            this.cbEmployee.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.cbEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEmployee.CustomCheckmarkImage = null;
            this.cbEmployee.Location = new System.Drawing.Point(203, 418);
            this.cbEmployee.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbEmployee.OnCheck.BorderRadius = 12;
            this.cbEmployee.OnCheck.BorderThickness = 2;
            this.cbEmployee.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbEmployee.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbEmployee.OnCheck.CheckmarkThickness = 2;
            this.cbEmployee.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbEmployee.OnDisable.BorderRadius = 12;
            this.cbEmployee.OnDisable.BorderThickness = 2;
            this.cbEmployee.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbEmployee.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbEmployee.OnDisable.CheckmarkThickness = 2;
            this.cbEmployee.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbEmployee.OnHoverChecked.BorderRadius = 12;
            this.cbEmployee.OnHoverChecked.BorderThickness = 2;
            this.cbEmployee.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbEmployee.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbEmployee.OnHoverChecked.CheckmarkThickness = 2;
            this.cbEmployee.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbEmployee.OnHoverUnchecked.BorderRadius = 12;
            this.cbEmployee.OnHoverUnchecked.BorderThickness = 1;
            this.cbEmployee.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbEmployee.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbEmployee.OnUncheck.BorderRadius = 12;
            this.cbEmployee.OnUncheck.BorderThickness = 1;
            this.cbEmployee.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbEmployee.Size = new System.Drawing.Size(27, 27);
            this.cbEmployee.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbEmployee.TabIndex = 27;
            this.cbEmployee.ThreeState = false;
            this.cbEmployee.ToolTipText = null;
            this.cbEmployee.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.cbEmployee_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(438, 585);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDplayName);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(438, 585);
            this.MinimumSize = new System.Drawing.Size(438, 585);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox txtPwd;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox txtDplayName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private Bunifu.UI.WinForms.BunifuCheckBox cbAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuCheckBox cbEmployee;
    }
}