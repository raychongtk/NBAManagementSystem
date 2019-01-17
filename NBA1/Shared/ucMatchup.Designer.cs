namespace NBA1.Shared
{
    partial class ucMatchup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.picTeamAway = new System.Windows.Forms.PictureBox();
            this.lblTeamAway = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTeamHome = new System.Windows.Forms.Label();
            this.picTeamHome = new System.Windows.Forms.PictureBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 28);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Not Start";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(159, 15);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(93, 20);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "00/00 00:00";
            // 
            // picTeamAway
            // 
            this.picTeamAway.Location = new System.Drawing.Point(283, 7);
            this.picTeamAway.Name = "picTeamAway";
            this.picTeamAway.Size = new System.Drawing.Size(36, 33);
            this.picTeamAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamAway.TabIndex = 2;
            this.picTeamAway.TabStop = false;
            // 
            // lblTeamAway
            // 
            this.lblTeamAway.AutoSize = true;
            this.lblTeamAway.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTeamAway.Location = new System.Drawing.Point(325, 15);
            this.lblTeamAway.Name = "lblTeamAway";
            this.lblTeamAway.Size = new System.Drawing.Size(0, 20);
            this.lblTeamAway.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(539, 15);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "000-000";
            // 
            // lblTeamHome
            // 
            this.lblTeamHome.AutoSize = true;
            this.lblTeamHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTeamHome.Location = new System.Drawing.Point(681, 15);
            this.lblTeamHome.Name = "lblTeamHome";
            this.lblTeamHome.Size = new System.Drawing.Size(51, 20);
            this.lblTeamHome.TabIndex = 12;
            this.lblTeamHome.Text = "label1";
            // 
            // picTeamHome
            // 
            this.picTeamHome.Location = new System.Drawing.Point(639, 7);
            this.picTeamHome.Name = "picTeamHome";
            this.picTeamHome.Size = new System.Drawing.Size(36, 33);
            this.picTeamHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamHome.TabIndex = 11;
            this.picTeamHome.TabStop = false;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(938, 15);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(0, 20);
            this.lblLoc.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1104, 10);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 30);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ucMatchup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblTeamHome);
            this.Controls.Add(this.picTeamHome);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTeamAway);
            this.Controls.Add(this.picTeamAway);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMatchup";
            this.Size = new System.Drawing.Size(1188, 48);
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.PictureBox picTeamAway;
        private System.Windows.Forms.Label lblTeamAway;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTeamHome;
        private System.Windows.Forms.PictureBox picTeamHome;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Button btnView;
    }
}
