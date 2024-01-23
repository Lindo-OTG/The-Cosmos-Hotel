namespace ProjectTake1PRG282
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageCust = new System.Windows.Forms.Button();
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.btnManageR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBee Hotel";
            // 
            // btnManageCust
            // 
            this.btnManageCust.Location = new System.Drawing.Point(107, 85);
            this.btnManageCust.Name = "btnManageCust";
            this.btnManageCust.Size = new System.Drawing.Size(112, 41);
            this.btnManageCust.TabIndex = 1;
            this.btnManageCust.Text = "Manage Customers";
            this.btnManageCust.UseVisualStyleBackColor = true;
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.Location = new System.Drawing.Point(107, 132);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(112, 41);
            this.btnManageRooms.TabIndex = 2;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.UseVisualStyleBackColor = true;
            // 
            // btnManageR
            // 
            this.btnManageR.Location = new System.Drawing.Point(106, 179);
            this.btnManageR.Name = "btnManageR";
            this.btnManageR.Size = new System.Drawing.Size(112, 41);
            this.btnManageR.TabIndex = 3;
            this.btnManageR.Text = "ManageBookings";
            this.btnManageR.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(107, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManageR);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.btnManageCust);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageCust;
        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Button btnManageR;
        private System.Windows.Forms.Button btnExit;
    }
}

