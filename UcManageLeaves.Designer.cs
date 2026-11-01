namespace SL_Postal_HRMS
{
    partial class UcManageLeaves
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
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Manage Leave Requests";
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AllowUserToAddRows = false;
            this.dgvLeaves.AllowUserToDeleteRows = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Location = new System.Drawing.Point(30, 70);
            this.dgvLeaves.MultiSelect = false;
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.ReadOnly = true;
            this.dgvLeaves.RowHeadersWidth = 51;
            this.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaves.Size = new System.Drawing.Size(520, 250);
            this.dgvLeaves.TabIndex = 1;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(30, 340);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(160, 40);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve Selected";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(210, 340);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(160, 40);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject Selected";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(390, 340);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UcManageLeaves
            // 
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvLeaves);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcManageLeaves";
            this.Size = new System.Drawing.Size(600, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
    }
}