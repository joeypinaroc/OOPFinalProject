namespace FinalProject
{
    partial class Form1
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
            this.rtb_Attributes = new System.Windows.Forms.RichTextBox();
            this.pb_PlayerImage = new System.Windows.Forms.PictureBox();
            this.pb_Background = new System.Windows.Forms.PictureBox();
            this.panel_TextPanel = new System.Windows.Forms.Panel();
            this.lbl_Choice3 = new System.Windows.Forms.Label();
            this.lbl_Choice2 = new System.Windows.Forms.Label();
            this.lbl_Choice1 = new System.Windows.Forms.Label();
            this.btn_Choice3 = new System.Windows.Forms.Button();
            this.btn_Choice2 = new System.Windows.Forms.Button();
            this.btn_Choice1 = new System.Windows.Forms.Button();
            this.rtb_ConflictText = new System.Windows.Forms.RichTextBox();
            this.panel_CreatePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).BeginInit();
            this.panel_TextPanel.SuspendLayout();
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
            // rtb_Attributes
            // 
            this.rtb_Attributes.Location = new System.Drawing.Point(34, 201);
            this.rtb_Attributes.Name = "rtb_Attributes";
            this.rtb_Attributes.Size = new System.Drawing.Size(199, 172);
            this.rtb_Attributes.TabIndex = 3;
            this.rtb_Attributes.Text = "";
            this.rtb_Attributes.Visible = false;
            // 
            // pb_PlayerImage
            // 
            this.pb_PlayerImage.Location = new System.Drawing.Point(34, 74);
            this.pb_PlayerImage.Name = "pb_PlayerImage";
            this.pb_PlayerImage.Size = new System.Drawing.Size(199, 108);
            this.pb_PlayerImage.TabIndex = 4;
            this.pb_PlayerImage.TabStop = false;
            this.pb_PlayerImage.Visible = false;
            // 
            // pb_Background
            // 
            this.pb_Background.Location = new System.Drawing.Point(269, 78);
            this.pb_Background.Name = "pb_Background";
            this.pb_Background.Size = new System.Drawing.Size(718, 365);
            this.pb_Background.TabIndex = 5;
            this.pb_Background.TabStop = false;
            this.pb_Background.Visible = false;
            // 
            // panel_TextPanel
            // 
            this.panel_TextPanel.BackColor = System.Drawing.SystemColors.Window;
            this.panel_TextPanel.Controls.Add(this.lbl_Choice3);
            this.panel_TextPanel.Controls.Add(this.lbl_Choice2);
            this.panel_TextPanel.Controls.Add(this.lbl_Choice1);
            this.panel_TextPanel.Controls.Add(this.btn_Choice3);
            this.panel_TextPanel.Controls.Add(this.btn_Choice2);
            this.panel_TextPanel.Controls.Add(this.btn_Choice1);
            this.panel_TextPanel.Controls.Add(this.rtb_ConflictText);
            this.panel_TextPanel.Location = new System.Drawing.Point(34, 480);
            this.panel_TextPanel.Name = "panel_TextPanel";
            this.panel_TextPanel.Size = new System.Drawing.Size(953, 171);
            this.panel_TextPanel.TabIndex = 6;
            this.panel_TextPanel.Visible = false;
            // 
            // lbl_Choice3
            // 
            this.lbl_Choice3.AutoSize = true;
            this.lbl_Choice3.Location = new System.Drawing.Point(246, 144);
            this.lbl_Choice3.Name = "lbl_Choice3";
            this.lbl_Choice3.Size = new System.Drawing.Size(49, 13);
            this.lbl_Choice3.TabIndex = 6;
            this.lbl_Choice3.Text = "Choice 3";
            // 
            // lbl_Choice2
            // 
            this.lbl_Choice2.AutoSize = true;
            this.lbl_Choice2.Location = new System.Drawing.Point(246, 114);
            this.lbl_Choice2.Name = "lbl_Choice2";
            this.lbl_Choice2.Size = new System.Drawing.Size(49, 13);
            this.lbl_Choice2.TabIndex = 5;
            this.lbl_Choice2.Text = "Choice 2";
            // 
            // lbl_Choice1
            // 
            this.lbl_Choice1.AutoSize = true;
            this.lbl_Choice1.Location = new System.Drawing.Point(246, 84);
            this.lbl_Choice1.Name = "lbl_Choice1";
            this.lbl_Choice1.Size = new System.Drawing.Size(46, 13);
            this.lbl_Choice1.TabIndex = 4;
            this.lbl_Choice1.Text = "Choice1";
            // 
            // btn_Choice3
            // 
            this.btn_Choice3.Location = new System.Drawing.Point(203, 139);
            this.btn_Choice3.Name = "btn_Choice3";
            this.btn_Choice3.Size = new System.Drawing.Size(28, 23);
            this.btn_Choice3.TabIndex = 3;
            this.btn_Choice3.Text = "3";
            this.btn_Choice3.UseVisualStyleBackColor = true;
            this.btn_Choice3.Click += new System.EventHandler(this.btn_Choice3_Click);
            // 
            // btn_Choice2
            // 
            this.btn_Choice2.Location = new System.Drawing.Point(203, 109);
            this.btn_Choice2.Name = "btn_Choice2";
            this.btn_Choice2.Size = new System.Drawing.Size(28, 23);
            this.btn_Choice2.TabIndex = 2;
            this.btn_Choice2.Text = "2";
            this.btn_Choice2.UseVisualStyleBackColor = true;
            this.btn_Choice2.Click += new System.EventHandler(this.btn_Choice2_Click);
            // 
            // btn_Choice1
            // 
            this.btn_Choice1.Location = new System.Drawing.Point(203, 79);
            this.btn_Choice1.Name = "btn_Choice1";
            this.btn_Choice1.Size = new System.Drawing.Size(28, 23);
            this.btn_Choice1.TabIndex = 1;
            this.btn_Choice1.Text = "1";
            this.btn_Choice1.UseVisualStyleBackColor = true;
            this.btn_Choice1.Click += new System.EventHandler(this.btn_Choice1_Click);
            // 
            // rtb_ConflictText
            // 
            this.rtb_ConflictText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtb_ConflictText.Location = new System.Drawing.Point(68, 15);
            this.rtb_ConflictText.Name = "rtb_ConflictText";
            this.rtb_ConflictText.Size = new System.Drawing.Size(807, 48);
            this.rtb_ConflictText.TabIndex = 0;
            this.rtb_ConflictText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel_TextPanel);
            this.Controls.Add(this.pb_PlayerImage);
            this.Controls.Add(this.rtb_Attributes);
            this.Controls.Add(this.panel_CreatePlayer);
            this.Controls.Add(this.btn_WelcomeCreatePlayer);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pb_Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_CreatePlayer.ResumeLayout(false);
            this.panel_CreatePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).EndInit();
            this.panel_TextPanel.ResumeLayout(false);
            this.panel_TextPanel.PerformLayout();
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
        private System.Windows.Forms.RichTextBox rtb_Attributes;
        private System.Windows.Forms.PictureBox pb_PlayerImage;
        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Panel panel_TextPanel;
        private System.Windows.Forms.Label lbl_Choice3;
        private System.Windows.Forms.Label lbl_Choice2;
        private System.Windows.Forms.Label lbl_Choice1;
        private System.Windows.Forms.Button btn_Choice3;
        private System.Windows.Forms.Button btn_Choice2;
        private System.Windows.Forms.Button btn_Choice1;
        private System.Windows.Forms.RichTextBox rtb_ConflictText;
    }
}

