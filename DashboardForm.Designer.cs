namespace SL_Postal_HRMS
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnViewFeedback = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMyLeaves = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageLeaves = new System.Windows.Forms.Button();
            this.btnProcessSalary = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Brown;
            this.panelSidebar.Controls.Add(this.btnViewFeedback);
            this.panelSidebar.Controls.Add(this.btnFeedback);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnMyLeaves);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnManageLeaves);
            this.panelSidebar.Controls.Add(this.btnProcessSalary);
            this.panelSidebar.Controls.Add(this.btnSalary);
            this.panelSidebar.Controls.Add(this.btnAttendance);
            this.panelSidebar.Controls.Add(this.btnApplyLeave);
            this.panelSidebar.Controls.Add(this.btnViewEmployees);
            this.panelSidebar.Controls.Add(this.btnAddEmployee);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 575);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnViewFeedback.FlatAppearance.BorderSize = 0;
            this.btnViewFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFeedback.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewFeedback.ForeColor = System.Drawing.Color.White;
            this.btnViewFeedback.Location = new System.Drawing.Point(0, 401);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(200, 50);
            this.btnViewFeedback.TabIndex = 11;
            this.btnViewFeedback.Text = "View Feedback";
            this.btnViewFeedback.UseVisualStyleBackColor = false;
            this.btnViewFeedback.Click += new System.EventHandler(this.btnViewFeedback_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(0, 354);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(200, 50);
            this.btnFeedback.TabIndex = 10;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(130)))), ((int)(((byte)(223)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(3, 309);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMyLeaves
            // 
            this.btnMyLeaves.BackColor = System.Drawing.Color.Transparent;
            this.btnMyLeaves.FlatAppearance.BorderSize = 0;
            this.btnMyLeaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyLeaves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMyLeaves.ForeColor = System.Drawing.Color.White;
            this.btnMyLeaves.Location = new System.Drawing.Point(0, 156);
            this.btnMyLeaves.Name = "btnMyLeaves";
            this.btnMyLeaves.Size = new System.Drawing.Size(200, 50);
            this.btnMyLeaves.TabIndex = 8;
            this.btnMyLeaves.Text = "My Leaves";
            this.btnMyLeaves.UseVisualStyleBackColor = false;
            this.btnMyLeaves.Click += new System.EventHandler(this.btnMyLeaves_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 504);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageLeaves
            // 
            this.btnManageLeaves.BackColor = System.Drawing.Color.Transparent;
            this.btnManageLeaves.FlatAppearance.BorderSize = 0;
            this.btnManageLeaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLeaves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageLeaves.ForeColor = System.Drawing.Color.White;
            this.btnManageLeaves.Location = new System.Drawing.Point(0, 156);
            this.btnManageLeaves.Name = "btnManageLeaves";
            this.btnManageLeaves.Size = new System.Drawing.Size(200, 50);
            this.btnManageLeaves.TabIndex = 5;
            this.btnManageLeaves.Text = "Manage Leaves";
            this.btnManageLeaves.UseVisualStyleBackColor = false;
            this.btnManageLeaves.Click += new System.EventHandler(this.btnManageLeaves_Click);
            // 
            // btnProcessSalary
            // 
            this.btnProcessSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessSalary.FlatAppearance.BorderSize = 0;
            this.btnProcessSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProcessSalary.ForeColor = System.Drawing.Color.White;
            this.btnProcessSalary.Location = new System.Drawing.Point(3, 448);
            this.btnProcessSalary.Name = "btnProcessSalary";
            this.btnProcessSalary.Size = new System.Drawing.Size(200, 50);
            this.btnProcessSalary.TabIndex = 7;
            this.btnProcessSalary.Text = "Process Salary";
            this.btnProcessSalary.UseVisualStyleBackColor = false;
            this.btnProcessSalary.Click += new System.EventHandler(this.btnProcessSalary_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Location = new System.Drawing.Point(3, 253);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(200, 50);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "My Salary";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 212);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 50);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyLeave.FlatAppearance.BorderSize = 0;
            this.btnApplyLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyLeave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplyLeave.ForeColor = System.Drawing.Color.White;
            this.btnApplyLeave.Location = new System.Drawing.Point(0, 100);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(200, 50);
            this.btnApplyLeave.TabIndex = 2;
            this.btnApplyLeave.Text = "Apply for Leave";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnViewEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployees.Location = new System.Drawing.Point(0, 100);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(200, 50);
            this.btnViewEmployees.TabIndex = 1;
            this.btnViewEmployees.Text = "View Employees";
            this.btnViewEmployees.UseVisualStyleBackColor = false;
            this.btnViewEmployees.Click += new System.EventHandler(this.btnViewEmployees_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 40);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 50);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 150);
            this.panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Brown;
            this.lblWelcome.Location = new System.Drawing.Point(6, 105);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(192, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 150);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 425);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 102);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postal HRMS - Dashboard";
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnProcessSalary;
        private System.Windows.Forms.Button btnManageLeaves;
        private System.Windows.Forms.Button btnMyLeaves;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnViewFeedback;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}