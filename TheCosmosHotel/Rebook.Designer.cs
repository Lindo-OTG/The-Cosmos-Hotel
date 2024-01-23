namespace TheCosmosHotel
{
    partial class Rebook
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnRebook = new MetroFramework.Controls.MetroButton();
            this.cmbRoomNo = new MetroFramework.Controls.MetroComboBox();
            this.cmbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEmail = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dtpPCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpPChekIn = new System.Windows.Forms.DateTimePicker();
            this.entryLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.cmbNumGuest = new MetroFramework.Controls.MetroComboBox();
            this.cmbFloor = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.metroLabel21);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.cmbNumGuest);
            this.metroPanel1.Controls.Add(this.cmbFloor);
            this.metroPanel1.Controls.Add(this.chkEmail);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.dtpPCheckOut);
            this.metroPanel1.Controls.Add(this.dtpPChekIn);
            this.metroPanel1.Controls.Add(this.entryLabel);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btnRebook);
            this.metroPanel1.Controls.Add(this.cmbRoomNo);
            this.metroPanel1.Controls.Add(this.cmbRoomType);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 38);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(345, 352);
            this.metroPanel1.TabIndex = 42;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(8, 7);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(99, 19);
            this.metroLabel17.TabIndex = 47;
            this.metroLabel17.Text = "Room Number";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(173, 8);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(77, 19);
            this.metroLabel15.TabIndex = 45;
            this.metroLabel15.Text = "Room Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(48, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 34);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRebook
            // 
            this.btnRebook.Highlight = true;
            this.btnRebook.Location = new System.Drawing.Point(48, 267);
            this.btnRebook.Name = "btnRebook";
            this.btnRebook.Size = new System.Drawing.Size(245, 34);
            this.btnRebook.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRebook.TabIndex = 42;
            this.btnRebook.Text = "Rebook";
            this.btnRebook.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRebook.Click += new System.EventHandler(this.btnRebook_Click);
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.ItemHeight = 23;
            this.cmbRoomNo.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "201",
            "202",
            "203",
            "204",
            "205",
            "301",
            "302",
            "303",
            "304",
            "305"});
            this.cmbRoomNo.Location = new System.Drawing.Point(8, 29);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(159, 29);
            this.cmbRoomNo.TabIndex = 24;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.ItemHeight = 23;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(173, 29);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(159, 29);
            this.cmbRoomType.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(36, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "New Booking Same ID";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.BackColor = System.Drawing.Color.Transparent;
            this.chkEmail.Location = new System.Drawing.Point(128, 238);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(86, 15);
            this.chkEmail.Style = MetroFramework.MetroColorStyle.Green;
            this.chkEmail.TabIndex = 58;
            this.chkEmail.Text = "Send email?";
            this.chkEmail.UseVisualStyleBackColor = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(13, 176);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(174, 19);
            this.metroLabel12.TabIndex = 57;
            this.metroLabel12.Text = "Proposed Check-out [date]";
            // 
            // dtpPCheckOut
            // 
            this.dtpPCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPCheckOut.CustomFormat = "MM-dd-yyyy";
            this.dtpPCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPCheckOut.Location = new System.Drawing.Point(13, 198);
            this.dtpPCheckOut.Name = "dtpPCheckOut";
            this.dtpPCheckOut.Size = new System.Drawing.Size(316, 26);
            this.dtpPCheckOut.TabIndex = 56;
            this.dtpPCheckOut.Value = new System.DateTime(2019, 5, 7, 0, 0, 0, 0);
            // 
            // dtpPChekIn
            // 
            this.dtpPChekIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPChekIn.CustomFormat = "MM-dd-yyyy";
            this.dtpPChekIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPChekIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPChekIn.Location = new System.Drawing.Point(13, 149);
            this.dtpPChekIn.Name = "dtpPChekIn";
            this.dtpPChekIn.Size = new System.Drawing.Size(314, 26);
            this.dtpPChekIn.TabIndex = 54;
            this.dtpPChekIn.Value = new System.DateTime(2019, 5, 6, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.entryLabel.Location = new System.Drawing.Point(13, 125);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(164, 19);
            this.entryLabel.TabIndex = 55;
            this.entryLabel.Text = "Proposed Check-in [date]";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(175, 63);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(40, 19);
            this.metroLabel21.TabIndex = 62;
            this.metroLabel21.Text = "Floor";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(8, 63);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(118, 19);
            this.metroLabel19.TabIndex = 61;
            this.metroLabel19.Text = "Number Of Guest";
            // 
            // cmbNumGuest
            // 
            this.cmbNumGuest.FormattingEnabled = true;
            this.cmbNumGuest.ItemHeight = 23;
            this.cmbNumGuest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNumGuest.Location = new System.Drawing.Point(8, 85);
            this.cmbNumGuest.Name = "cmbNumGuest";
            this.cmbNumGuest.Size = new System.Drawing.Size(159, 29);
            this.cmbNumGuest.TabIndex = 60;
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.ItemHeight = 23;
            this.cmbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbFloor.Location = new System.Drawing.Point(173, 85);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(159, 29);
            this.cmbFloor.TabIndex = 59;
            // 
            // Rebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rebook";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebook";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnRebook;
        private MetroFramework.Controls.MetroComboBox cmbRoomNo;
        private MetroFramework.Controls.MetroComboBox cmbRoomType;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroCheckBox chkEmail;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker dtpPCheckOut;
        private System.Windows.Forms.DateTimePicker dtpPChekIn;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroComboBox cmbNumGuest;
        private MetroFramework.Controls.MetroComboBox cmbFloor;
    }
}