namespace FinalProject
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.panel_CreatePlayer = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Job = new System.Windows.Forms.ComboBox();
            this.lbl_CPJob = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_CPName = new System.Windows.Forms.Label();
            this.btn_WelcomeCreatePlayer = new System.Windows.Forms.Button();
            this.textHolder1 = new FinalProject.Properties.TextHolder();
            this.stats1 = new FinalProject.Stats();
            this.panel_CreatePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_CreatePlayer
            // 
            this.panel_CreatePlayer.BackColor = System.Drawing.Color.Transparent;
            this.panel_CreatePlayer.Controls.Add(this.stats1);
            this.panel_CreatePlayer.Controls.Add(this.hScrollBar1);
            this.panel_CreatePlayer.Controls.Add(this.characterImg);
            this.panel_CreatePlayer.Controls.Add(this.button1);
            this.panel_CreatePlayer.Controls.Add(this.cb_Job);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPJob);
            this.panel_CreatePlayer.Controls.Add(this.tb_Name);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPName);
            this.panel_CreatePlayer.Location = new System.Drawing.Point(76, 159);
            this.panel_CreatePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.panel_CreatePlayer.Name = "panel_CreatePlayer";
            this.panel_CreatePlayer.Size = new System.Drawing.Size(941, 437);
            this.panel_CreatePlayer.TabIndex = 2;
            this.panel_CreatePlayer.Visible = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(319, 218);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 9;
            // 
            // characterImg
            // 
            this.characterImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterImg.Image = global::FinalProject.Properties.Resources.farmer;
            this.characterImg.Location = new System.Drawing.Point(654, 22);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(282, 384);
            this.characterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImg.TabIndex = 7;
            this.characterImg.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImage = global::FinalProject.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(164, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_CreatePlayer_Click);
            // 
            // cb_Job
            // 
            this.cb_Job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Job.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Job.FormattingEnabled = true;
            this.cb_Job.Location = new System.Drawing.Point(162, 94);
            this.cb_Job.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Job.Name = "cb_Job";
            this.cb_Job.Size = new System.Drawing.Size(270, 49);
            this.cb_Job.TabIndex = 3;
            this.cb_Job.SelectedIndexChanged += new System.EventHandler(this.cb_Job_SelectedIndexChanged);
            // 
            // lbl_CPJob
            // 
            this.lbl_CPJob.AutoSize = true;
            this.lbl_CPJob.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_CPJob.Location = new System.Drawing.Point(58, 91);
            this.lbl_CPJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CPJob.Name = "lbl_CPJob";
            this.lbl_CPJob.Size = new System.Drawing.Size(96, 50);
            this.lbl_CPJob.TabIndex = 2;
            this.lbl_CPJob.Text = "JOB:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(162, 22);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(347, 47);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_CPName
            // 
            this.lbl_CPName.AutoSize = true;
            this.lbl_CPName.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_CPName.Location = new System.Drawing.Point(18, 22);
            this.lbl_CPName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CPName.Name = "lbl_CPName";
            this.lbl_CPName.Size = new System.Drawing.Size(137, 50);
            this.lbl_CPName.TabIndex = 0;
            this.lbl_CPName.Text = "NAME:";
            // 
            // btn_WelcomeCreatePlayer
            // 
            this.btn_WelcomeCreatePlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_WelcomeCreatePlayer.BackgroundImage = global::FinalProject.Properties.Resources.button;
            this.btn_WelcomeCreatePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_WelcomeCreatePlayer.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WelcomeCreatePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_WelcomeCreatePlayer.Location = new System.Drawing.Point(344, 287);
            this.btn_WelcomeCreatePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WelcomeCreatePlayer.Name = "btn_WelcomeCreatePlayer";
            this.btn_WelcomeCreatePlayer.Size = new System.Drawing.Size(414, 91);
            this.btn_WelcomeCreatePlayer.TabIndex = 5;
            this.btn_WelcomeCreatePlayer.Text = "CREATE YOUR PLAYER";
            this.btn_WelcomeCreatePlayer.UseVisualStyleBackColor = false;
            this.btn_WelcomeCreatePlayer.Click += new System.EventHandler(this.btn_WelcomeCreatePlayer_Click);
            // 
            // textHolder1
            // 
            this.textHolder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textHolder1.BackgroundImage")));
            this.textHolder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textHolder1.Content = "Text Placeholder";
            this.textHolder1.Location = new System.Drawing.Point(76, 52);
            this.textHolder1.Name = "textHolder1";
            this.textHolder1.Size = new System.Drawing.Size(941, 107);
            this.textHolder1.TabIndex = 6;
            // 
            // stats1
            // 
            this.stats1.BackColor = System.Drawing.Color.Transparent;
            this.stats1.Location = new System.Drawing.Point(-7, 161);
            this.stats1.Name = "stats1";
            this.stats1.Size = new System.Drawing.Size(498, 123);
            this.stats1.TabIndex = 10;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panel_CreatePlayer);
            this.Controls.Add(this.textHolder1);
            this.Controls.Add(this.btn_WelcomeCreatePlayer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUNGEON GAME";
            this.panel_CreatePlayer.ResumeLayout(false);
            this.panel_CreatePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_CreatePlayer;
        private System.Windows.Forms.ComboBox cb_Job;
        private System.Windows.Forms.Label lbl_CPJob;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_CPName;
        private System.Windows.Forms.Button btn_WelcomeCreatePlayer;
        private Properties.TextHolder textHolder1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox characterImg;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private Stats stats1;
    }
}

