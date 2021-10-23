namespace WindoesDataReader
{
    partial class frmCustomers
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
            this.lblCustomers = new System.Windows.Forms.Label();
            this.grdCstomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCstomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCustomers.Location = new System.Drawing.Point(340, 75);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(107, 25);
            this.lblCustomers.TabIndex = 3;
            this.lblCustomers.Text = "Customers";
            // 
            // grdCstomers
            // 
            this.grdCstomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCstomers.Location = new System.Drawing.Point(131, 132);
            this.grdCstomers.Name = "grdCstomers";
            this.grdCstomers.Size = new System.Drawing.Size(538, 243);
            this.grdCstomers.TabIndex = 2;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.grdCstomers);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCstomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.DataGridView grdCstomers;
    }
}