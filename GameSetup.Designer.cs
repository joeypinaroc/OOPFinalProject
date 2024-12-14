namespace FinalProject
{
    partial class GameSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSetup));
            this.panel_CreatePlayer = new System.Windows.Forms.Panel();
            this.statusBar = new FinalProject.Stats();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Job = new System.Windows.Forms.ComboBox();
            this.lbl_CPJob = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_CPName = new System.Windows.Forms.Label();
            this.btn_WelcomeCreatePlayer = new System.Windows.Forms.Button();
            this.textHolder_Title = new FinalProject.Properties.TextHolder();
            this.btn_About = new System.Windows.Forms.Button();
            this.panel_CreatePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_CreatePlayer
            // 
            this.panel_CreatePlayer.BackColor = System.Drawing.Color.Transparent;
            this.panel_CreatePlayer.Controls.Add(this.statusBar);
            this.panel_CreatePlayer.Controls.Add(this.hScrollBar1);
            this.panel_CreatePlayer.Controls.Add(this.characterImg);
            this.panel_CreatePlayer.Controls.Add(this.button1);
            this.panel_CreatePlayer.Controls.Add(this.cb_Job);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPJob);
            this.panel_CreatePlayer.Controls.Add(this.tb_Name);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPName);
            this.panel_CreatePlayer.Location = new System.Drawing.Point(61, 128);
            this.panel_CreatePlayer.Name = "panel_CreatePlayer";
            this.panel_CreatePlayer.Size = new System.Drawing.Size(753, 350);
            this.panel_CreatePlayer.TabIndex = 2;
            this.panel_CreatePlayer.Visible = false;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Transparent;
            this.statusBar.Location = new System.Drawing.Point(-6, 129);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(398, 98);
            this.statusBar.TabIndex = 10;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(255, 174);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(6, 8);
            this.hScrollBar1.TabIndex = 9;
            // 
            // characterImg
            // 
            this.characterImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterImg.Image = global::FinalProject.Properties.Resources.farmer;
            this.characterImg.Location = new System.Drawing.Point(523, 18);
            this.characterImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(226, 308);
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
            this.button1.Location = new System.Drawing.Point(131, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 56);
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
            this.cb_Job.Location = new System.Drawing.Point(130, 75);
            this.cb_Job.Name = "cb_Job";
            this.cb_Job.Size = new System.Drawing.Size(238, 40);
            this.cb_Job.TabIndex = 3;
            this.cb_Job.SelectedIndexChanged += new System.EventHandler(this.cb_Job_SelectedIndexChanged);
            // 
            // lbl_CPJob
            // 
            this.lbl_CPJob.AutoSize = true;
            this.lbl_CPJob.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_CPJob.Location = new System.Drawing.Point(46, 73);
            this.lbl_CPJob.Name = "lbl_CPJob";
            this.lbl_CPJob.Size = new System.Drawing.Size(78, 41);
            this.lbl_CPJob.TabIndex = 2;
            this.lbl_CPJob.Text = "JOB:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(130, 18);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(278, 39);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_CPName
            // 
            this.lbl_CPName.AutoSize = true;
            this.lbl_CPName.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_CPName.Location = new System.Drawing.Point(14, 18);
            this.lbl_CPName.Name = "lbl_CPName";
            this.lbl_CPName.Size = new System.Drawing.Size(112, 41);
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
            this.btn_WelcomeCreatePlayer.Location = new System.Drawing.Point(256, 195);
            this.btn_WelcomeCreatePlayer.Name = "btn_WelcomeCreatePlayer";
            this.btn_WelcomeCreatePlayer.Size = new System.Drawing.Size(331, 73);
            this.btn_WelcomeCreatePlayer.TabIndex = 5;
            this.btn_WelcomeCreatePlayer.Text = "CREATE YOUR PLAYER";
            this.btn_WelcomeCreatePlayer.UseVisualStyleBackColor = false;
            this.btn_WelcomeCreatePlayer.Click += new System.EventHandler(this.btn_WelcomeCreatePlayer_Click);
            // 
            // textHolder_Title
            // 
            this.textHolder_Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textHolder_Title.BackgroundImage")));
            this.textHolder_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textHolder_Title.Content = "Text Placeholder";
            this.textHolder_Title.FontSize = 36;
            this.textHolder_Title.Location = new System.Drawing.Point(61, 42);
            this.textHolder_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textHolder_Title.Name = "textHolder_Title";
            this.textHolder_Title.Size = new System.Drawing.Size(753, 86);
            this.textHolder_Title.TabIndex = 6;
            this.textHolder_Title.WrapWidth = 0;
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_About.BackgroundImage = global::FinalProject.Properties.Resources.button;
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_About.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_About.Location = new System.Drawing.Point(256, 299);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(331, 73);
            this.btn_About.TabIndex = 7;
            this.btn_About.Text = "ABOUT";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 482);
            this.Controls.Add(this.panel_CreatePlayer);
            this.Controls.Add(this.textHolder_Title);
            this.Controls.Add(this.btn_WelcomeCreatePlayer);
            this.Controls.Add(this.btn_About);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameSetup";
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
        private Properties.TextHolder textHolder_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox characterImg;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private Stats statusBar;
        private System.Windows.Forms.Button btn_About;
    }
}

