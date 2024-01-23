namespace ProjectTake1PRG282
{
    partial class frmRoomStatus
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustNotFound = new System.Windows.Forms.Label();
            this.lblCustFound = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(185, 134);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 48);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(104, 134);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(75, 48);
            this.btnPrintReport.TabIndex = 28;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 48);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search For Room";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblCustNotFound
            // 
            this.lblCustNotFound.AutoSize = true;
            this.lblCustNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblCustNotFound.Location = new System.Drawing.Point(67, 54);
            this.lblCustNotFound.Name = "lblCustNotFound";
            this.lblCustNotFound.Size = new System.Drawing.Size(145, 20);
            this.lblCustNotFound.TabIndex = 26;
            this.lblCustNotFound.Text = "Room Not Found";
            this.lblCustNotFound.Click += new System.EventHandler(this.lblCustNotFound_Click);
            // 
            // lblCustFound
            // 
            this.lblCustFound.AutoSize = true;
            this.lblCustFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCustFound.Location = new System.Drawing.Point(59, 48);
            this.lblCustFound.Name = "lblCustFound";
            this.lblCustFound.Size = new System.Drawing.Size(163, 29);
            this.lblCustFound.TabIndex = 25;
            this.lblCustFound.Text = "Room Found";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(84, 105);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Please Enter Room No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "CBee Hotel";
            // 
            // frmRoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 205);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCustNotFound);
            this.Controls.Add(this.lblCustFound);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRoomStatus";
            this.Text = "frmRoomStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCustNotFound;
        private System.Windows.Forms.Label lblCustFound;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}