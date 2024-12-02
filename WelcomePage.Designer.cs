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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_WelcomeCreatePlayer = new System.Windows.Forms.Button();
            this.panel_CreatePlayer = new System.Windows.Forms.Panel();
            this.btn_CreatePlayer = new System.Windows.Forms.Button();
            this.cb_Job = new System.Windows.Forms.ComboBox();
            this.lbl_CPJob = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_CPName = new System.Windows.Forms.Label();
            this.panel_CreatePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Location = new System.Drawing.Point(466, 217);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(114, 13);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome to the game!";
            // 
            // btn_WelcomeCreatePlayer
            // 
            this.btn_WelcomeCreatePlayer.Location = new System.Drawing.Point(469, 245);
            this.btn_WelcomeCreatePlayer.Name = "btn_WelcomeCreatePlayer";
            this.btn_WelcomeCreatePlayer.Size = new System.Drawing.Size(111, 23);
            this.btn_WelcomeCreatePlayer.TabIndex = 1;
            this.btn_WelcomeCreatePlayer.Text = "Create your player";
            this.btn_WelcomeCreatePlayer.UseVisualStyleBackColor = true;
            this.btn_WelcomeCreatePlayer.Click += new System.EventHandler(this.btn_WelcomeCreatePlayer_Click);
            // 
            // panel_CreatePlayer
            // 
            this.panel_CreatePlayer.Controls.Add(this.btn_CreatePlayer);
            this.panel_CreatePlayer.Controls.Add(this.cb_Job);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPJob);
            this.panel_CreatePlayer.Controls.Add(this.tb_Name);
            this.panel_CreatePlayer.Controls.Add(this.lbl_CPName);
            this.panel_CreatePlayer.Location = new System.Drawing.Point(426, 301);
            this.panel_CreatePlayer.Name = "panel_CreatePlayer";
            this.panel_CreatePlayer.Size = new System.Drawing.Size(200, 134);
            this.panel_CreatePlayer.TabIndex = 2;
            this.panel_CreatePlayer.Visible = false;
            // 
            // btn_CreatePlayer
            // 
            this.btn_CreatePlayer.Location = new System.Drawing.Point(65, 93);
            this.btn_CreatePlayer.Name = "btn_CreatePlayer";
            this.btn_CreatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_CreatePlayer.TabIndex = 4;
            this.btn_CreatePlayer.Text = "Create";
            this.btn_CreatePlayer.UseVisualStyleBackColor = true;
            this.btn_CreatePlayer.Click += new System.EventHandler(this.btn_CreatePlayer_Click);
            // 
            // cb_Job
            // 
            this.cb_Job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Job.FormattingEnabled = true;
            this.cb_Job.Location = new System.Drawing.Point(55, 56);
            this.cb_Job.Name = "cb_Job";
            this.cb_Job.Size = new System.Drawing.Size(121, 21);
            this.cb_Job.TabIndex = 3;
            // 
            // lbl_CPJob
            // 
            this.lbl_CPJob.AutoSize = true;
            this.lbl_CPJob.Location = new System.Drawing.Point(14, 59);
            this.lbl_CPJob.Name = "lbl_CPJob";
            this.lbl_CPJob.Size = new System.Drawing.Size(30, 13);
            this.lbl_CPJob.TabIndex = 2;
            this.lbl_CPJob.Text = "Job: ";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(55, 15);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(121, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_CPName
            // 
            this.lbl_CPName.AutoSize = true;
            this.lbl_CPName.Location = new System.Drawing.Point(14, 18);
            this.lbl_CPName.Name = "lbl_CPName";
            this.lbl_CPName.Size = new System.Drawing.Size(41, 13);
            this.lbl_CPName.TabIndex = 0;
            this.lbl_CPName.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel_CreatePlayer);
            this.Controls.Add(this.btn_WelcomeCreatePlayer);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_CreatePlayer.ResumeLayout(false);
            this.panel_CreatePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_WelcomeCreatePlayer;
        private System.Windows.Forms.Panel panel_CreatePlayer;
        private System.Windows.Forms.Button btn_CreatePlayer;
        private System.Windows.Forms.ComboBox cb_Job;
        private System.Windows.Forms.Label lbl_CPJob;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_CPName;
    }
}

