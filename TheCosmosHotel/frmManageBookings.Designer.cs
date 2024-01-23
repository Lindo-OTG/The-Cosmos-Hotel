namespace ProjectTake1PRG282
{
    partial class frmManageBookings
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
            this.btnCheckOutCust = new System.Windows.Forms.Button();
            this.btnCheckInCustomer = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(86, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 41);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back To Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCheckOutCust
            // 
            this.btnCheckOutCust.Location = new System.Drawing.Point(85, 151);
            this.btnCheckOutCust.Name = "btnCheckOutCust";
            this.btnCheckOutCust.Size = new System.Drawing.Size(112, 41);
            this.btnCheckOutCust.TabIndex = 23;
            this.btnCheckOutCust.Text = "Check Out Customer";
            this.btnCheckOutCust.UseVisualStyleBackColor = true;
            // 
            // btnCheckInCustomer
            // 
            this.btnCheckInCustomer.Location = new System.Drawing.Point(86, 104);
            this.btnCheckInCustomer.Name = "btnCheckInCustomer";
            this.btnCheckInCustomer.Size = new System.Drawing.Size(112, 41);
            this.btnCheckInCustomer.TabIndex = 22;
            this.btnCheckInCustomer.Text = "Check In Customer";
            this.btnCheckInCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(86, 57);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(112, 41);
            this.btnAddBooking.TabIndex = 21;
            this.btnAddBooking.Text = "Add New Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "CBee Hotel";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(86, 198);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(112, 41);
            this.btnCancelBooking.TabIndex = 25;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // frmManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckOutCust);
            this.Controls.Add(this.btnCheckInCustomer);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.label1);
            this.Name = "frmManageBookings";
            this.Text = "frmManageBookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckOutCust;
        private System.Windows.Forms.Button btnCheckInCustomer;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelBooking;
    }
}