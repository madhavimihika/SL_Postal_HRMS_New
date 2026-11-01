using System;

namespace SL_Postal_HRMS
{
    partial class UcProcessSalary
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblAllowances = new System.Windows.Forms.Label();
            this.txtAllowances = new System.Windows.Forms.TextBox();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 37);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Process Employee Salary";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_2);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(30, 60);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(520, 180);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(30, 260);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(133, 16);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Month (e.g. Oct 2026):";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(30, 280);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(150, 22);
            this.txtMonth.TabIndex = 7;
            // 
            // lblAllowances
            // 
            this.lblAllowances.AutoSize = true;
            this.lblAllowances.Location = new System.Drawing.Point(200, 260);
            this.lblAllowances.Name = "lblAllowances";
            this.lblAllowances.Size = new System.Drawing.Size(79, 16);
            this.lblAllowances.TabIndex = 6;
            this.lblAllowances.Text = "Allowances:";
            // 
            // txtAllowances
            // 
            this.txtAllowances.Location = new System.Drawing.Point(200, 280);
            this.txtAllowances.Name = "txtAllowances";
            this.txtAllowances.Size = new System.Drawing.Size(100, 22);
            this.txtAllowances.TabIndex = 5;
            this.txtAllowances.Text = "0";
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Location = new System.Drawing.Point(320, 260);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(78, 16);
            this.lblDeductions.TabIndex = 4;
            this.lblDeductions.Text = "Deductions:";
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(320, 280);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(100, 22);
            this.txtDeductions.TabIndex = 3;
            this.txtDeductions.Text = "0";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNet.ForeColor = System.Drawing.Color.Green;
            this.lblNet.Location = new System.Drawing.Point(30, 330);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(206, 28);
            this.lblNet.TabIndex = 1;
            this.lblNet.Text = "Net Salary: LKR 0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Gray;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(440, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 25);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(30, 370);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(520, 40);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process and Save Salary";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(440, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // UcProcessSalary
            // 
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.lblDeductions);
            this.Controls.Add(this.txtAllowances);
            this.Controls.Add(this.lblAllowances);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcProcessSalary";
            this.Size = new System.Drawing.Size(600, 440);
            this.Load += new System.EventHandler(this.UcProcessSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblAllowances;
        private System.Windows.Forms.TextBox txtAllowances;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnRefresh;
    }
}