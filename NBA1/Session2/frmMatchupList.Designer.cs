namespace NBA1
{
    partial class frmMatachupList
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picTeamAway = new System.Windows.Forms.PictureBox();
            this.lblTeamAway = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeamHome = new System.Windows.Forms.Label();
            this.picTeamHome = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamHome)).BeginInit();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AllowLogout = false;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1337, 78);
            this.header1.TabIndex = 3;
            this.header1.Title = "Matchup List";
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer1.Location = new System.Drawing.Point(0, 751);
            this.footer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1337, 37);
            this.footer1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(209, 105);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 34);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picTeamAway
            // 
            this.picTeamAway.Location = new System.Drawing.Point(318, 162);
            this.picTeamAway.Name = "picTeamAway";
            this.picTeamAway.Size = new System.Drawing.Size(104, 97);
            this.picTeamAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamAway.TabIndex = 7;
            this.picTeamAway.TabStop = false;
            // 
            // lblTeamAway
            // 
            this.lblTeamAway.AutoSize = true;
            this.lblTeamAway.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTeamAway.Location = new System.Drawing.Point(439, 162);
            this.lblTeamAway.Name = "lblTeamAway";
            this.lblTeamAway.Size = new System.Drawing.Size(51, 20);
            this.lblTeamAway.TabIndex = 8;
            this.lblTeamAway.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(439, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "(Away)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(921, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "(Home)";
            // 
            // lblTeamHome
            // 
            this.lblTeamHome.AutoSize = true;
            this.lblTeamHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTeamHome.Location = new System.Drawing.Point(921, 162);
            this.lblTeamHome.Name = "lblTeamHome";
            this.lblTeamHome.Size = new System.Drawing.Size(51, 20);
            this.lblTeamHome.TabIndex = 11;
            this.lblTeamHome.Text = "label1";
            // 
            // picTeamHome
            // 
            this.picTeamHome.Location = new System.Drawing.Point(800, 162);
            this.picTeamHome.Name = "picTeamHome";
            this.picTeamHome.Size = new System.Drawing.Size(104, 97);
            this.picTeamHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamHome.TabIndex = 10;
            this.picTeamHome.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "VS";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(591, 206);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(125, 25);
            this.lblStartTime.TabIndex = 14;
            this.lblStartTime.Text = "00:00 Start";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1313, 428);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // frmMatachupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 788);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTeamHome);
            this.Controls.Add(this.picTeamHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeamAway);
            this.Controls.Add(this.picTeamAway);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.footer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMatachupList";
            this.Text = "Matchup List";
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.header header1;
        private Shared.footer footer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picTeamAway;
        private System.Windows.Forms.Label lblTeamAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeamHome;
        private System.Windows.Forms.PictureBox picTeamHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

