namespace TheCosmosHotel
{
    partial class frmLogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picboxHide = new System.Windows.Forms.PictureBox();
            this.picboxEye = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new MetroFramework.Controls.MetroButton();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::TheCosmosHotel.Properties.Resources.Prepared_by__Dorothy_Mitchell__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.panel28);
            this.panel1.Controls.Add(this.pictureBox25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 377);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(474, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.picboxHide);
            this.panel2.Controls.Add(this.picboxEye);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSignIn);
            this.panel2.Location = new System.Drawing.Point(100, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 197);
            this.panel2.TabIndex = 13;
            // 
            // picboxHide
            // 
            this.picboxHide.BackColor = System.Drawing.Color.Black;
            this.picboxHide.BackgroundImage = global::TheCosmosHotel.Properties.Resources.appbar_eye_hide;
            this.picboxHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxHide.InitialImage = null;
            this.picboxHide.Location = new System.Drawing.Point(237, 99);
            this.picboxHide.Name = "picboxHide";
            this.picboxHide.Size = new System.Drawing.Size(20, 20);
            this.picboxHide.TabIndex = 25;
            this.picboxHide.TabStop = false;
            this.picboxHide.Visible = false;
            this.picboxHide.Click += new System.EventHandler(this.picboxHide_Click);
            // 
            // picboxEye
            // 
            this.picboxEye.BackColor = System.Drawing.Color.Black;
            this.picboxEye.BackgroundImage = global::TheCosmosHotel.Properties.Resources.appbar_eye;
            this.picboxEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxEye.InitialImage = null;
            this.picboxEye.Location = new System.Drawing.Point(237, 99);
            this.picboxEye.Name = "picboxEye";
            this.picboxEye.Size = new System.Drawing.Size(20, 20);
            this.picboxEye.TabIndex = 20;
            this.picboxEye.TabStop = false;
            this.picboxEye.Click += new System.EventHandler(this.picboxEye_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Location = new System.Drawing.Point(63, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Enter Password";
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Location = new System.Drawing.Point(63, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PromptText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(200, 29);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username:";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(60, 149);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(203, 30);
            this.btnSignIn.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSignIn.TabIndex = 15;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.BackgroundImage = global::TheCosmosHotel.Properties.Resources.line;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(276, 59);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(99, 10);
            this.pictureBox24.TabIndex = 40;
            this.pictureBox24.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Location = new System.Drawing.Point(187, 82);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 29);
            this.label25.TabIndex = 39;
            this.label25.Text = "The lab of luxury";
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.BackgroundImage = global::TheCosmosHotel.Properties.Resources.Diamond;
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel28.Location = new System.Drawing.Point(250, 54);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(23, 25);
            this.panel28.TabIndex = 38;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.BackgroundImage = global::TheCosmosHotel.Properties.Resources.line;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(146, 59);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(102, 10);
            this.pictureBox25.TabIndex = 37;
            this.pictureBox25.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(141, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(236, 34);
            this.label26.TabIndex = 36;
            this.label26.Text = "The Cosmos Hotel";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 377);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogIn";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnSignIn;
        private System.Windows.Forms.Button btnClose;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.PictureBox picboxEye;
        private System.Windows.Forms.PictureBox picboxHide;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Label label26;
    }
}