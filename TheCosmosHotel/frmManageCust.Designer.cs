namespace ProjectTake1PRG282
{
    partial class frmManageCust
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveCust = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(94, 217);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(112, 41);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(93, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search For Customer";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCust
            // 
            this.btnRemoveCust.Location = new System.Drawing.Point(94, 123);
            this.btnRemoveCust.Name = "btnRemoveCust";
            this.btnRemoveCust.Size = new System.Drawing.Size(112, 41);
            this.btnRemoveCust.TabIndex = 7;
            this.btnRemoveCust.Text = "Remove Customer";
            this.btnRemoveCust.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(94, 76);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(112, 41);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "CBee Hotel";
            // 
            // frmManageCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 341);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemoveCust);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmManageCust";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveCust;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
    }
}