namespace SL_Postal_HRMS
{
    partial class UcAttendance
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "My Attendance";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Location = new System.Drawing.Point(30, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(261, 28);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: Not Clocked In Today";
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.Color.Green;
            this.btnClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockIn.ForeColor = System.Drawing.Color.White;
            this.btnClockIn.Location = new System.Drawing.Point(30, 100);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(200, 40);
            this.btnClockIn.TabIndex = 5;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.Color.Red;
            this.btnClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockOut.ForeColor = System.Drawing.Color.White;
            this.btnClockOut.Location = new System.Drawing.Point(250, 100);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(200, 40);
            this.btnClockOut.TabIndex = 4;
            this.btnClockOut.Text = "Clock Out";
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(30, 160);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(520, 250);
            this.dgvAttendance.TabIndex = 3;
            // 
            // UcAttendance
            // 
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnClockOut);
            this.Controls.Add(this.btnClockIn);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcAttendance";
            this.Size = new System.Drawing.Size(600, 440);
            this.Load += new System.EventHandler(this.UcAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}