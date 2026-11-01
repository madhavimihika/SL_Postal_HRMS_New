namespace SL_Postal_HRMS
{
    partial class UcMyLeaves
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMyLeaves = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "My Leave Status";
            // 
            // dgvMyLeaves
            // 
            this.dgvMyLeaves.AllowUserToAddRows = false;
            this.dgvMyLeaves.AllowUserToDeleteRows = false;
            this.dgvMyLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyLeaves.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyLeaves.Location = new System.Drawing.Point(30, 70);
            this.dgvMyLeaves.MultiSelect = false;
            this.dgvMyLeaves.Name = "dgvMyLeaves";
            this.dgvMyLeaves.ReadOnly = true;
            this.dgvMyLeaves.RowHeadersWidth = 51;
            this.dgvMyLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyLeaves.Size = new System.Drawing.Size(520, 300);
            this.dgvMyLeaves.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(520, 40);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh Status";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // UcMyLeaves
            // 
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvMyLeaves);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcMyLeaves";
            this.Size = new System.Drawing.Size(600, 440);
            this.Load += new System.EventHandler(this.UcMyLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMyLeaves;
        private System.Windows.Forms.Button btnRefresh;
    }
}