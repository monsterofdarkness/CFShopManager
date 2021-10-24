namespace WindowsFormsApp1.Components
{
    partial class pdCamera
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdCamera));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gradientPanel1 = new WindowsFormsApp1.Components.GradientPanel();
            this.gradientPanel3 = new WindowsFormsApp1.Components.GradientPanel();
            this.pbCamera2 = new System.Windows.Forms.PictureBox();
            this.cbCamera2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new WindowsFormsApp1.Components.GradientPanel();
            this.pbCamera1 = new System.Windows.Forms.PictureBox();
            this.BtnStart1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbCamera1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStop1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnStop2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnStart2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gradientPanel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Location = new System.Drawing.Point(-8, 1);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1463, 839);
            this.gradientPanel1.TabIndex = 4;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.ColorLeft = System.Drawing.Color.Empty;
            this.gradientPanel3.ColorRight = System.Drawing.Color.Empty;
            this.gradientPanel3.Controls.Add(this.BtnStop2);
            this.gradientPanel3.Controls.Add(this.BtnStart2);
            this.gradientPanel3.Controls.Add(this.pbCamera2);
            this.gradientPanel3.Controls.Add(this.cbCamera2);
            this.gradientPanel3.Controls.Add(this.label2);
            this.gradientPanel3.Location = new System.Drawing.Point(767, 78);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(638, 668);
            this.gradientPanel3.TabIndex = 3;
            // 
            // pbCamera2
            // 
            this.pbCamera2.Location = new System.Drawing.Point(23, 97);
            this.pbCamera2.Name = "pbCamera2";
            this.pbCamera2.Size = new System.Drawing.Size(596, 551);
            this.pbCamera2.TabIndex = 4;
            this.pbCamera2.TabStop = false;
            // 
            // cbCamera2
            // 
            this.cbCamera2.FormattingEnabled = true;
            this.cbCamera2.Location = new System.Drawing.Point(177, 30);
            this.cbCamera2.Name = "cbCamera2";
            this.cbCamera2.Size = new System.Drawing.Size(283, 21);
            this.cbCamera2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CAMERA:";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorLeft = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorRight = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.BtnStop1);
            this.gradientPanel2.Controls.Add(this.pbCamera1);
            this.gradientPanel2.Controls.Add(this.BtnStart1);
            this.gradientPanel2.Controls.Add(this.cbCamera1);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Location = new System.Drawing.Point(43, 78);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(638, 668);
            this.gradientPanel2.TabIndex = 0;
            // 
            // pbCamera1
            // 
            this.pbCamera1.Location = new System.Drawing.Point(21, 97);
            this.pbCamera1.Name = "pbCamera1";
            this.pbCamera1.Size = new System.Drawing.Size(596, 551);
            this.pbCamera1.TabIndex = 3;
            this.pbCamera1.TabStop = false;
            // 
            // BtnStart1
            // 
            this.BtnStart1.AllowAnimations = true;
            this.BtnStart1.AllowMouseEffects = true;
            this.BtnStart1.AllowToggling = false;
            this.BtnStart1.AnimationSpeed = 200;
            this.BtnStart1.AutoGenerateColors = false;
            this.BtnStart1.AutoRoundBorders = false;
            this.BtnStart1.AutoSizeLeftIcon = true;
            this.BtnStart1.AutoSizeRightIcon = true;
            this.BtnStart1.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnStart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart1.BackgroundImage")));
            this.BtnStart1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart1.ButtonText = "Start";
            this.BtnStart1.ButtonTextMarginLeft = 0;
            this.BtnStart1.ColorContrastOnClick = 45;
            this.BtnStart1.ColorContrastOnHover = 45;
            this.BtnStart1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.BtnStart1.CustomizableEdges = borderEdges4;
            this.BtnStart1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnStart1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStart1.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnStart1.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnStart1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnStart1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStart1.ForeColor = System.Drawing.Color.White;
            this.BtnStart1.IconLeft = null;
            this.BtnStart1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStart1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStart1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnStart1.IconMarginLeft = 11;
            this.BtnStart1.IconPadding = 10;
            this.BtnStart1.IconRight = null;
            this.BtnStart1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStart1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStart1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnStart1.IconSize = 25;
            this.BtnStart1.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnStart1.IdleBorderRadius = 0;
            this.BtnStart1.IdleBorderThickness = 0;
            this.BtnStart1.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnStart1.IdleIconLeftImage = null;
            this.BtnStart1.IdleIconRightImage = null;
            this.BtnStart1.IndicateFocus = false;
            this.BtnStart1.Location = new System.Drawing.Point(492, 18);
            this.BtnStart1.Name = "BtnStart1";
            this.BtnStart1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStart1.OnDisabledState.BorderRadius = 1;
            this.BtnStart1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart1.OnDisabledState.BorderThickness = 1;
            this.BtnStart1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnStart1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnStart1.OnDisabledState.IconLeftImage = null;
            this.BtnStart1.OnDisabledState.IconRightImage = null;
            this.BtnStart1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnStart1.onHoverState.BorderRadius = 1;
            this.BtnStart1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart1.onHoverState.BorderThickness = 1;
            this.BtnStart1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnStart1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStart1.onHoverState.IconLeftImage = null;
            this.BtnStart1.onHoverState.IconRightImage = null;
            this.BtnStart1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnStart1.OnIdleState.BorderRadius = 1;
            this.BtnStart1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart1.OnIdleState.BorderThickness = 1;
            this.BtnStart1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnStart1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnStart1.OnIdleState.IconLeftImage = null;
            this.BtnStart1.OnIdleState.IconRightImage = null;
            this.BtnStart1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnStart1.OnPressedState.BorderRadius = 1;
            this.BtnStart1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart1.OnPressedState.BorderThickness = 1;
            this.BtnStart1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnStart1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnStart1.OnPressedState.IconLeftImage = null;
            this.BtnStart1.OnPressedState.IconRightImage = null;
            this.BtnStart1.Size = new System.Drawing.Size(50, 48);
            this.BtnStart1.TabIndex = 2;
            this.BtnStart1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStart1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnStart1.TextMarginLeft = 0;
            this.BtnStart1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnStart1.UseDefaultRadiusAndThickness = true;
            this.BtnStart1.Click += new System.EventHandler(this.BtnStart1_Click);
            // 
            // cbCamera1
            // 
            this.cbCamera1.FormattingEnabled = true;
            this.cbCamera1.Location = new System.Drawing.Point(177, 30);
            this.cbCamera1.Name = "cbCamera1";
            this.cbCamera1.Size = new System.Drawing.Size(283, 21);
            this.cbCamera1.TabIndex = 1;
            this.cbCamera1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA:";
            // 
            // BtnStop1
            // 
            this.BtnStop1.AllowAnimations = true;
            this.BtnStop1.AllowMouseEffects = true;
            this.BtnStop1.AllowToggling = false;
            this.BtnStop1.AnimationSpeed = 200;
            this.BtnStop1.AutoGenerateColors = false;
            this.BtnStop1.AutoRoundBorders = false;
            this.BtnStop1.AutoSizeLeftIcon = true;
            this.BtnStop1.AutoSizeRightIcon = true;
            this.BtnStop1.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnStop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop1.BackgroundImage")));
            this.BtnStop1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop1.ButtonText = "Stop";
            this.BtnStop1.ButtonTextMarginLeft = 0;
            this.BtnStop1.ColorContrastOnClick = 45;
            this.BtnStop1.ColorContrastOnHover = 45;
            this.BtnStop1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnStop1.CustomizableEdges = borderEdges3;
            this.BtnStop1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnStop1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStop1.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnStop1.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnStop1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnStop1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStop1.ForeColor = System.Drawing.Color.White;
            this.BtnStop1.IconLeft = null;
            this.BtnStop1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStop1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStop1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnStop1.IconMarginLeft = 11;
            this.BtnStop1.IconPadding = 10;
            this.BtnStop1.IconRight = null;
            this.BtnStop1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStop1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStop1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnStop1.IconSize = 25;
            this.BtnStop1.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnStop1.IdleBorderRadius = 0;
            this.BtnStop1.IdleBorderThickness = 0;
            this.BtnStop1.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnStop1.IdleIconLeftImage = null;
            this.BtnStop1.IdleIconRightImage = null;
            this.BtnStop1.IndicateFocus = false;
            this.BtnStop1.Location = new System.Drawing.Point(567, 18);
            this.BtnStop1.Name = "BtnStop1";
            this.BtnStop1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStop1.OnDisabledState.BorderRadius = 1;
            this.BtnStop1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop1.OnDisabledState.BorderThickness = 1;
            this.BtnStop1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnStop1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnStop1.OnDisabledState.IconLeftImage = null;
            this.BtnStop1.OnDisabledState.IconRightImage = null;
            this.BtnStop1.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.BtnStop1.onHoverState.BorderRadius = 1;
            this.BtnStop1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop1.onHoverState.BorderThickness = 1;
            this.BtnStop1.onHoverState.FillColor = System.Drawing.Color.Red;
            this.BtnStop1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStop1.onHoverState.IconLeftImage = null;
            this.BtnStop1.onHoverState.IconRightImage = null;
            this.BtnStop1.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.BtnStop1.OnIdleState.BorderRadius = 1;
            this.BtnStop1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop1.OnIdleState.BorderThickness = 1;
            this.BtnStop1.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.BtnStop1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnStop1.OnIdleState.IconLeftImage = null;
            this.BtnStop1.OnIdleState.IconRightImage = null;
            this.BtnStop1.OnPressedState.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnStop1.OnPressedState.BorderRadius = 1;
            this.BtnStop1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop1.OnPressedState.BorderThickness = 1;
            this.BtnStop1.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.BtnStop1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnStop1.OnPressedState.IconLeftImage = null;
            this.BtnStop1.OnPressedState.IconRightImage = null;
            this.BtnStop1.Size = new System.Drawing.Size(50, 48);
            this.BtnStop1.TabIndex = 5;
            this.BtnStop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStop1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnStop1.TextMarginLeft = 0;
            this.BtnStop1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnStop1.UseDefaultRadiusAndThickness = true;
            this.BtnStop1.Click += new System.EventHandler(this.BtnStop1_Click);
            // 
            // BtnStop2
            // 
            this.BtnStop2.AllowAnimations = true;
            this.BtnStop2.AllowMouseEffects = true;
            this.BtnStop2.AllowToggling = false;
            this.BtnStop2.AnimationSpeed = 200;
            this.BtnStop2.AutoGenerateColors = false;
            this.BtnStop2.AutoRoundBorders = false;
            this.BtnStop2.AutoSizeLeftIcon = true;
            this.BtnStop2.AutoSizeRightIcon = true;
            this.BtnStop2.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnStop2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop2.BackgroundImage")));
            this.BtnStop2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop2.ButtonText = "Stop";
            this.BtnStop2.ButtonTextMarginLeft = 0;
            this.BtnStop2.ColorContrastOnClick = 45;
            this.BtnStop2.ColorContrastOnHover = 45;
            this.BtnStop2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnStop2.CustomizableEdges = borderEdges1;
            this.BtnStop2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnStop2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStop2.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnStop2.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnStop2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnStop2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStop2.ForeColor = System.Drawing.Color.White;
            this.BtnStop2.IconLeft = null;
            this.BtnStop2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStop2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStop2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnStop2.IconMarginLeft = 11;
            this.BtnStop2.IconPadding = 10;
            this.BtnStop2.IconRight = null;
            this.BtnStop2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStop2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStop2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnStop2.IconSize = 25;
            this.BtnStop2.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnStop2.IdleBorderRadius = 0;
            this.BtnStop2.IdleBorderThickness = 0;
            this.BtnStop2.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnStop2.IdleIconLeftImage = null;
            this.BtnStop2.IdleIconRightImage = null;
            this.BtnStop2.IndicateFocus = false;
            this.BtnStop2.Location = new System.Drawing.Point(569, 18);
            this.BtnStop2.Name = "BtnStop2";
            this.BtnStop2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStop2.OnDisabledState.BorderRadius = 1;
            this.BtnStop2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop2.OnDisabledState.BorderThickness = 1;
            this.BtnStop2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnStop2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnStop2.OnDisabledState.IconLeftImage = null;
            this.BtnStop2.OnDisabledState.IconRightImage = null;
            this.BtnStop2.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.BtnStop2.onHoverState.BorderRadius = 1;
            this.BtnStop2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop2.onHoverState.BorderThickness = 1;
            this.BtnStop2.onHoverState.FillColor = System.Drawing.Color.Red;
            this.BtnStop2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStop2.onHoverState.IconLeftImage = null;
            this.BtnStop2.onHoverState.IconRightImage = null;
            this.BtnStop2.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.BtnStop2.OnIdleState.BorderRadius = 1;
            this.BtnStop2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop2.OnIdleState.BorderThickness = 1;
            this.BtnStop2.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.BtnStop2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnStop2.OnIdleState.IconLeftImage = null;
            this.BtnStop2.OnIdleState.IconRightImage = null;
            this.BtnStop2.OnPressedState.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnStop2.OnPressedState.BorderRadius = 1;
            this.BtnStop2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStop2.OnPressedState.BorderThickness = 1;
            this.BtnStop2.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.BtnStop2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnStop2.OnPressedState.IconLeftImage = null;
            this.BtnStop2.OnPressedState.IconRightImage = null;
            this.BtnStop2.Size = new System.Drawing.Size(50, 48);
            this.BtnStop2.TabIndex = 7;
            this.BtnStop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStop2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnStop2.TextMarginLeft = 0;
            this.BtnStop2.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnStop2.UseDefaultRadiusAndThickness = true;
            this.BtnStop2.Click += new System.EventHandler(this.BtnStop2_Click);
            // 
            // BtnStart2
            // 
            this.BtnStart2.AllowAnimations = true;
            this.BtnStart2.AllowMouseEffects = true;
            this.BtnStart2.AllowToggling = false;
            this.BtnStart2.AnimationSpeed = 200;
            this.BtnStart2.AutoGenerateColors = false;
            this.BtnStart2.AutoRoundBorders = false;
            this.BtnStart2.AutoSizeLeftIcon = true;
            this.BtnStart2.AutoSizeRightIcon = true;
            this.BtnStart2.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnStart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart2.BackgroundImage")));
            this.BtnStart2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart2.ButtonText = "Start";
            this.BtnStart2.ButtonTextMarginLeft = 0;
            this.BtnStart2.ColorContrastOnClick = 45;
            this.BtnStart2.ColorContrastOnHover = 45;
            this.BtnStart2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnStart2.CustomizableEdges = borderEdges2;
            this.BtnStart2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnStart2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStart2.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnStart2.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnStart2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnStart2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStart2.ForeColor = System.Drawing.Color.White;
            this.BtnStart2.IconLeft = null;
            this.BtnStart2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStart2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStart2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnStart2.IconMarginLeft = 11;
            this.BtnStart2.IconPadding = 10;
            this.BtnStart2.IconRight = null;
            this.BtnStart2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStart2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnStart2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnStart2.IconSize = 25;
            this.BtnStart2.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnStart2.IdleBorderRadius = 0;
            this.BtnStart2.IdleBorderThickness = 0;
            this.BtnStart2.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnStart2.IdleIconLeftImage = null;
            this.BtnStart2.IdleIconRightImage = null;
            this.BtnStart2.IndicateFocus = false;
            this.BtnStart2.Location = new System.Drawing.Point(494, 18);
            this.BtnStart2.Name = "BtnStart2";
            this.BtnStart2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnStart2.OnDisabledState.BorderRadius = 1;
            this.BtnStart2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart2.OnDisabledState.BorderThickness = 1;
            this.BtnStart2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnStart2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnStart2.OnDisabledState.IconLeftImage = null;
            this.BtnStart2.OnDisabledState.IconRightImage = null;
            this.BtnStart2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnStart2.onHoverState.BorderRadius = 1;
            this.BtnStart2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart2.onHoverState.BorderThickness = 1;
            this.BtnStart2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnStart2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStart2.onHoverState.IconLeftImage = null;
            this.BtnStart2.onHoverState.IconRightImage = null;
            this.BtnStart2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnStart2.OnIdleState.BorderRadius = 1;
            this.BtnStart2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart2.OnIdleState.BorderThickness = 1;
            this.BtnStart2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnStart2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnStart2.OnIdleState.IconLeftImage = null;
            this.BtnStart2.OnIdleState.IconRightImage = null;
            this.BtnStart2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnStart2.OnPressedState.BorderRadius = 1;
            this.BtnStart2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnStart2.OnPressedState.BorderThickness = 1;
            this.BtnStart2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnStart2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnStart2.OnPressedState.IconLeftImage = null;
            this.BtnStart2.OnPressedState.IconRightImage = null;
            this.BtnStart2.Size = new System.Drawing.Size(50, 48);
            this.BtnStart2.TabIndex = 6;
            this.BtnStart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStart2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnStart2.TextMarginLeft = 0;
            this.BtnStart2.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnStart2.UseDefaultRadiusAndThickness = true;
            this.BtnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
            // 
            // pdCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 841);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "pdCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pdCamera";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnStart1;
        private System.Windows.Forms.ComboBox cbCamera1;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel3;
        private System.Windows.Forms.ComboBox cbCamera2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCamera2;
        private System.Windows.Forms.PictureBox pbCamera1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnStop2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnStart2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnStop1;
    }
}