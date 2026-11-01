namespace SL_Postal_HRMS
{
    partial class UcViewFeedback
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
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Employee Feedback";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AllowUserToAddRows = false;
            this.dgvFeedback.AllowUserToDeleteRows = false;
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(30, 70);
            this.dgvFeedback.MultiSelect = false;
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.ReadOnly = true;
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedback.Size = new System.Drawing.Size(520, 300);
            this.dgvFeedback.TabIndex = 1;
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
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UcViewFeedback
            // 
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcViewFeedback";
            this.Size = new System.Drawing.Size(600, 651);
            this.Load += new System.EventHandler(this.UcViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Button btnRefresh;
    }
}