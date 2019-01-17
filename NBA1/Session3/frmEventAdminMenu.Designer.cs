namespace NBA1
{
    partial class frmEventAdminMenu
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
            this.btnSeasons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatchups = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
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
            this.header1.Size = new System.Drawing.Size(1058, 78);
            this.header1.TabIndex = 3;
            this.header1.Title = "Event Administrator Menu";
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer1.Location = new System.Drawing.Point(0, 582);
            this.footer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1058, 37);
            this.footer1.TabIndex = 2;
            // 
            // btnSeasons
            // 
            this.btnSeasons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnSeasons.FlatAppearance.BorderSize = 0;
            this.btnSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeasons.ForeColor = System.Drawing.Color.White;
            this.btnSeasons.Location = new System.Drawing.Point(216, 226);
            this.btnSeasons.Name = "btnSeasons";
            this.btnSeasons.Size = new System.Drawing.Size(231, 77);
            this.btnSeasons.TabIndex = 4;
            this.btnSeasons.Text = "Manage Seasons";
            this.btnSeasons.UseVisualStyleBackColor = false;
            this.btnSeasons.Click += new System.EventHandler(this.btnSeasons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to use this system , you can click the buttons below to navigate to the c" +
    "orresponding page.";
            // 
            // btnMatchups
            // 
            this.btnMatchups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnMatchups.FlatAppearance.BorderSize = 0;
            this.btnMatchups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchups.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchups.ForeColor = System.Drawing.Color.White;
            this.btnMatchups.Location = new System.Drawing.Point(632, 226);
            this.btnMatchups.Name = "btnMatchups";
            this.btnMatchups.Size = new System.Drawing.Size(235, 77);
            this.btnMatchups.TabIndex = 6;
            this.btnMatchups.Text = "Manage Matchups";
            this.btnMatchups.UseVisualStyleBackColor = false;
            this.btnMatchups.Click += new System.EventHandler(this.btnMatchups_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnTeams.FlatAppearance.BorderSize = 0;
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeams.ForeColor = System.Drawing.Color.White;
            this.btnTeams.Location = new System.Drawing.Point(216, 361);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(231, 77);
            this.btnTeams.TabIndex = 7;
            this.btnTeams.Text = "Manage Teams";
            this.btnTeams.UseVisualStyleBackColor = false;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnPlayers.FlatAppearance.BorderSize = 0;
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.ForeColor = System.Drawing.Color.White;
            this.btnPlayers.Location = new System.Drawing.Point(632, 361);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(235, 77);
            this.btnPlayers.TabIndex = 8;
            this.btnPlayers.Text = "Manage Players";
            this.btnPlayers.UseVisualStyleBackColor = false;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // frmEventAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 619);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnMatchups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeasons);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.footer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEventAdminMenu";
            this.Text = "Event Administrator Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.header header1;
        private Shared.footer footer1;
        private System.Windows.Forms.Button btnSeasons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatchups;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnPlayers;
    }
}

