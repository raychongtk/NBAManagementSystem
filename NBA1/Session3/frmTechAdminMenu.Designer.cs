namespace NBA1
{
    partial class frmTechAdminMenu
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
            this.header1 = new NBA1.Shared.header();
            this.footer1 = new NBA1.Shared.footer();
            this.btnTeamReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecutions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AllowLogout = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1020, 78);
            this.header1.TabIndex = 3;
            this.header1.Title = "Technical Administrator Menu";
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer1.Location = new System.Drawing.Point(0, 569);
            this.footer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1020, 37);
            this.footer1.TabIndex = 2;
            // 
            // btnTeamReport
            // 
            this.btnTeamReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnTeamReport.FlatAppearance.BorderSize = 0;
            this.btnTeamReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamReport.ForeColor = System.Drawing.Color.White;
            this.btnTeamReport.Location = new System.Drawing.Point(594, 274);
            this.btnTeamReport.Name = "btnTeamReport";
            this.btnTeamReport.Size = new System.Drawing.Size(276, 77);
            this.btnTeamReport.TabIndex = 11;
            this.btnTeamReport.Text = "Team Report";
            this.btnTeamReport.UseVisualStyleBackColor = false;
            this.btnTeamReport.Click += new System.EventHandler(this.btnTeamReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to use this system , you can click the buttons below to navigate to the c" +
    "orresponding page.";
            // 
            // btnExecutions
            // 
            this.btnExecutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnExecutions.FlatAppearance.BorderSize = 0;
            this.btnExecutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutions.ForeColor = System.Drawing.Color.White;
            this.btnExecutions.Location = new System.Drawing.Point(197, 274);
            this.btnExecutions.Name = "btnExecutions";
            this.btnExecutions.Size = new System.Drawing.Size(279, 77);
            this.btnExecutions.TabIndex = 9;
            this.btnExecutions.Text = "Manage Executions";
            this.btnExecutions.UseVisualStyleBackColor = false;
            // 
            // frmTechAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 606);
            this.Controls.Add(this.btnTeamReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecutions);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.footer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTechAdminMenu";
            this.Text = "Technical Administrator Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.header header1;
        private Shared.footer footer1;
        private System.Windows.Forms.Button btnTeamReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecutions;
    }
}

