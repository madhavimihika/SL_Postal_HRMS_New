using System;
using System.Windows.Forms;

namespace SL_Postal_HRMS
{
    public partial class DashboardForm : Form
    {
        private string userRole;
        private string userNic;

        public DashboardForm(string role, string nic)
        {
            InitializeComponent();
            userRole = role;
            userNic = nic;

            lblWelcome.Text = $"Welcome, {nic} ({role})";

            // 1. Hide all buttons first
            btnAddEmployee.Visible = false;
            btnViewEmployees.Visible = false;
            btnManageLeaves.Visible = false;
            btnApplyLeave.Visible = false;
            btnAttendance.Visible = false;
            btnSalary.Visible = false;
            btnProcessSalary.Visible = false;
            btnMyLeaves.Visible = false;
            btnViewFeedback.Visible = false;

            // Profile and Feedback submission are visible to everyone
            btnProfile.Visible = true;
            btnFeedback.Visible = true;

            // 2. Show buttons based on role
            if (userRole == "Employee" || userRole == "Postal Assistant")
            {
                btnApplyLeave.Visible = true;
                btnMyLeaves.Visible = true;
                btnAttendance.Visible = true;
                btnSalary.Visible = true;
            }
            else if (userRole == "Accountant")
            {
                btnSalary.Visible = true;
                btnProcessSalary.Visible = true;
            }
            else if (userRole == "Superintendent")
            {
                btnAddEmployee.Visible = true;
                btnViewEmployees.Visible = true;
                btnManageLeaves.Visible = true;
                btnViewFeedback.Visible = true; 
            }

            RepositionSidebarButtons();
        }

        private void RepositionSidebarButtons()
        {
            int currentTop = 50;
            int spacing = 60;

            if (btnAddEmployee.Visible) { btnAddEmployee.Top = currentTop; currentTop += spacing; }
            if (btnViewEmployees.Visible) { btnViewEmployees.Top = currentTop; currentTop += spacing; }
            if (btnApplyLeave.Visible) { btnApplyLeave.Top = currentTop; currentTop += spacing; }
            if (btnMyLeaves.Visible) { btnMyLeaves.Top = currentTop; currentTop += spacing; }
            if (btnAttendance.Visible) { btnAttendance.Top = currentTop; currentTop += spacing; }
            if (btnSalary.Visible) { btnSalary.Top = currentTop; currentTop += spacing; }
            if (btnProcessSalary.Visible) { btnProcessSalary.Top = currentTop; currentTop += spacing; }
            if (btnManageLeaves.Visible) { btnManageLeaves.Top = currentTop; currentTop += spacing; }

            if (btnViewFeedback.Visible) { btnViewFeedback.Top = currentTop; currentTop += spacing; } // <--- ADDED THIS!

            // Stack the Profile and Feedback submission buttons at the bottom
            if (btnProfile.Visible) { btnProfile.Top = currentTop; currentTop += spacing; }
            if (btnFeedback.Visible) { btnFeedback.Top = currentTop; currentTop += spacing; }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignInForm login = new SignInForm();
            login.Show();
            this.Close();
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcApplyLeave page = new UcApplyLeave();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void btnMyLeaves_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcMyLeaves page = new UcMyLeaves();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.LoadMyLeaves();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcAttendance page = new UcAttendance();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcViewSalary page = new UcViewSalary();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.LoadSalaryData();
        }

        private void btnProcessSalary_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcProcessSalary page = new UcProcessSalary();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.LoadEmployees();
        }

        private void btnManageLeaves_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcManageLeaves page = new UcManageLeaves();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcViewEmployees page = new UcViewEmployees();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcProfile page = new UcProfile();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.LoadProfile();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcFeedback page = new UcFeedback();
            page.LoggedInNic = this.userNic;
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcViewFeedback page = new UcViewFeedback();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.LoadFeedback();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcAddEmployee page = new UcAddEmployee();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        // Empty stubs for Visual Studio auto-generated events
        private void DashboardForm_Load(object sender, EventArgs e) { }
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}