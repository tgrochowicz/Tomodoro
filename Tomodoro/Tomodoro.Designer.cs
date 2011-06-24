namespace Tomodoro
{
    partial class Tomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tomodoro));
            this.clbGoals = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearGoal = new System.Windows.Forms.Button();
            this.btnDeleteGoal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearTomodori = new System.Windows.Forms.Button();
            this.btnDeleteTomodori = new System.Windows.Forms.Button();
            this.btnUpdateTomodori = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clbTomodori = new System.Windows.Forms.CheckedListBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTomodori = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clndrBrowser = new System.Windows.Forms.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbGoals
            // 
            this.clbGoals.FormattingEnabled = true;
            this.clbGoals.Location = new System.Drawing.Point(6, 19);
            this.clbGoals.Name = "clbGoals";
            this.clbGoals.Size = new System.Drawing.Size(617, 94);
            this.clbGoals.TabIndex = 0;
            this.clbGoals.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGoals_ItemCheck);
            this.clbGoals.SelectedIndexChanged += new System.EventHandler(this.clbGoals_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearGoal);
            this.groupBox1.Controls.Add(this.btnDeleteGoal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdateGoal);
            this.groupBox1.Controls.Add(this.txtGoal);
            this.groupBox1.Controls.Add(this.btnAddGoal);
            this.groupBox1.Controls.Add(this.clbGoals);
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Goals";
            // 
            // btnClearGoal
            // 
            this.btnClearGoal.BackgroundImage = global::Tomodoro.Properties.Resources.Clear;
            this.btnClearGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearGoal.Location = new System.Drawing.Point(598, 119);
            this.btnClearGoal.Name = "btnClearGoal";
            this.btnClearGoal.Size = new System.Drawing.Size(25, 25);
            this.btnClearGoal.TabIndex = 18;
            this.btnClearGoal.UseVisualStyleBackColor = true;
            this.btnClearGoal.Click += new System.EventHandler(this.btnClearGoal_Click);
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.BackgroundImage = global::Tomodoro.Properties.Resources.Minus;
            this.btnDeleteGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteGoal.Location = new System.Drawing.Point(90, 145);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteGoal.TabIndex = 17;
            this.btnDeleteGoal.UseVisualStyleBackColor = true;
            this.btnDeleteGoal.Click += new System.EventHandler(this.btnDeleteGoal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Goal:";
            // 
            // btnUpdateGoal
            // 
            this.btnUpdateGoal.BackgroundImage = global::Tomodoro.Properties.Resources.Apply;
            this.btnUpdateGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateGoal.Location = new System.Drawing.Point(552, 145);
            this.btnUpdateGoal.Name = "btnUpdateGoal";
            this.btnUpdateGoal.Size = new System.Drawing.Size(40, 40);
            this.btnUpdateGoal.TabIndex = 11;
            this.btnUpdateGoal.UseVisualStyleBackColor = true;
            this.btnUpdateGoal.Click += new System.EventHandler(this.btnUpdateGoal_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(44, 119);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(548, 20);
            this.txtGoal.TabIndex = 10;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackgroundImage = global::Tomodoro.Properties.Resources.Plus;
            this.btnAddGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGoal.Location = new System.Drawing.Point(44, 145);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(40, 40);
            this.btnAddGoal.TabIndex = 8;
            this.btnAddGoal.UseVisualStyleBackColor = true;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearTomodori);
            this.groupBox2.Controls.Add(this.btnDeleteTomodori);
            this.groupBox2.Controls.Add(this.btnUpdateTomodori);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.clbTomodori);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAddTomodori);
            this.groupBox2.Location = new System.Drawing.Point(302, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 252);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tomodori";
            // 
            // btnClearTomodori
            // 
            this.btnClearTomodori.BackgroundImage = global::Tomodoro.Properties.Resources.Clear;
            this.btnClearTomodori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearTomodori.Location = new System.Drawing.Point(582, 13);
            this.btnClearTomodori.Name = "btnClearTomodori";
            this.btnClearTomodori.Size = new System.Drawing.Size(25, 25);
            this.btnClearTomodori.TabIndex = 17;
            this.btnClearTomodori.UseVisualStyleBackColor = true;
            this.btnClearTomodori.Click += new System.EventHandler(this.btnClearTomodori_Click);
            // 
            // btnDeleteTomodori
            // 
            this.btnDeleteTomodori.BackgroundImage = global::Tomodoro.Properties.Resources.Minus;
            this.btnDeleteTomodori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTomodori.Location = new System.Drawing.Point(205, 65);
            this.btnDeleteTomodori.Name = "btnDeleteTomodori";
            this.btnDeleteTomodori.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteTomodori.TabIndex = 16;
            this.btnDeleteTomodori.UseVisualStyleBackColor = true;
            this.btnDeleteTomodori.Click += new System.EventHandler(this.btnDeleteTomodori_Click);
            // 
            // btnUpdateTomodori
            // 
            this.btnUpdateTomodori.BackgroundImage = global::Tomodoro.Properties.Resources.Apply;
            this.btnUpdateTomodori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateTomodori.Location = new System.Drawing.Point(205, 206);
            this.btnUpdateTomodori.Name = "btnUpdateTomodori";
            this.btnUpdateTomodori.Size = new System.Drawing.Size(40, 40);
            this.btnUpdateTomodori.TabIndex = 15;
            this.btnUpdateTomodori.UseVisualStyleBackColor = true;
            this.btnUpdateTomodori.Click += new System.EventHandler(this.btnUpdateTomodori_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(272, 44);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(335, 202);
            this.txtNotes.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Notes:";
            // 
            // clbTomodori
            // 
            this.clbTomodori.FormattingEnabled = true;
            this.clbTomodori.Location = new System.Drawing.Point(6, 19);
            this.clbTomodori.Name = "clbTomodori";
            this.clbTomodori.Size = new System.Drawing.Size(193, 229);
            this.clbTomodori.TabIndex = 11;
            this.clbTomodori.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTomodori_ItemCheck);
            this.clbTomodori.SelectedIndexChanged += new System.EventHandler(this.clbTomodori_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(351, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(213, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Topic:";
            // 
            // btnAddTomodori
            // 
            this.btnAddTomodori.BackgroundImage = global::Tomodoro.Properties.Resources.Plus;
            this.btnAddTomodori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTomodori.Location = new System.Drawing.Point(205, 19);
            this.btnAddTomodori.Name = "btnAddTomodori";
            this.btnAddTomodori.Size = new System.Drawing.Size(40, 40);
            this.btnAddTomodori.TabIndex = 7;
            this.btnAddTomodori.UseVisualStyleBackColor = true;
            this.btnAddTomodori.Click += new System.EventHandler(this.btnAddTomodori_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTimeRemaining);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 190);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Status";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(58, 19);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(175, 25);
            this.lblTimeRemaining.TabIndex = 9;
            this.lblTimeRemaining.Text = "25 Minutes Left";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(181, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(181, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 32);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(181, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(29, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "WORKING";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tomodoro.Properties.Resources.Tomato;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // clndrBrowser
            // 
            this.clndrBrowser.Location = new System.Drawing.Point(29, 45);
            this.clndrBrowser.Name = "clndrBrowser";
            this.clndrBrowser.TabIndex = 9;
            this.clndrBrowser.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.clndrBrowser_DateChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clndrBrowser);
            this.groupBox4.Location = new System.Drawing.Point(12, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 252);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Browse";
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "Tomodoro";
            this.notificationIcon.Visible = true;
            // 
            // Tomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tomodoro";
            this.Text = "Tomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tomodoro_FormClosing);
            this.Load += new System.EventHandler(this.Tomodoro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbGoals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTomodori;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar clndrBrowser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbTomodori;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateTomodori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateGoal;
        private System.Windows.Forms.Button btnDeleteTomodori;
        private System.Windows.Forms.Button btnDeleteGoal;
        private System.Windows.Forms.Button btnClearGoal;
        private System.Windows.Forms.Button btnClearTomodori;
        private System.Windows.Forms.NotifyIcon notificationIcon;
    }
}

