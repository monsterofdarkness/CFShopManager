namespace WindowsFormsApp1.Pages
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Myprogress = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.PercentageLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 175;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(39, -12);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(350, 350);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Myprogress
            // 
            this.Myprogress.AllowAnimations = false;
            this.Myprogress.Animation = 0;
            this.Myprogress.AnimationSpeed = 220;
            this.Myprogress.AnimationStep = 10;
            this.Myprogress.BackColor = System.Drawing.Color.White;
            this.Myprogress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Myprogress.BackgroundImage")));
            this.Myprogress.BorderColor = System.Drawing.Color.White;
            this.Myprogress.BorderRadius = 9;
            this.Myprogress.BorderThickness = 1;
            this.Myprogress.Location = new System.Drawing.Point(39, 323);
            this.Myprogress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Myprogress.Maximum = 100;
            this.Myprogress.MaximumValue = 100;
            this.Myprogress.Minimum = 0;
            this.Myprogress.MinimumValue = 0;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Myprogress.ProgressBackColor = System.Drawing.Color.White;
            this.Myprogress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Myprogress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Myprogress.Size = new System.Drawing.Size(350, 15);
            this.Myprogress.TabIndex = 4;
            this.Myprogress.Value = 50;
            this.Myprogress.ValueByTransition = 50;
            // 
            // PercentageLbl
            // 
            this.PercentageLbl.AllowParentOverrides = false;
            this.PercentageLbl.AutoEllipsis = false;
            this.PercentageLbl.CursorType = null;
            this.PercentageLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLbl.Location = new System.Drawing.Point(189, 280);
            this.PercentageLbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PercentageLbl.Name = "PercentageLbl";
            this.PercentageLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PercentageLbl.Size = new System.Drawing.Size(38, 30);
            this.PercentageLbl.TabIndex = 5;
            this.PercentageLbl.Text = "%%";
            this.PercentageLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PercentageLbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(430, 384);
            this.Controls.Add(this.PercentageLbl);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuProgressBar Myprogress;
        private Bunifu.UI.WinForms.BunifuLabel PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}