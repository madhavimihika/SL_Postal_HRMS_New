namespace SL_Postal_HRMS
{
    partial class UcFeedback
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "System Feedback";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.Location = new System.Drawing.Point(30, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(550, 23);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Please share any issues, suggestions, or feedback about the HR system:";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(30, 100);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedback.Size = new System.Drawing.Size(520, 200);
            this.txtFeedback.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(30, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(520, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Feedback";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UcFeedback
            // 
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "UcFeedback";
            this.Size = new System.Drawing.Size(600, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
    }
}