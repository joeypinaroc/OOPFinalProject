namespace FinalProject
{
    partial class PlayerPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPreview));
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Job = new System.Windows.Forms.Label();
            this.lbl_Name_Value = new System.Windows.Forms.Label();
            this.lbl_Job_Value = new System.Windows.Forms.Label();
            this.statusBar = new FinalProject.Stats();
            this.textHolder_Title = new FinalProject.Properties.TextHolder();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // characterImg
            // 
            this.characterImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterImg.Image = ((System.Drawing.Image)(resources.GetObject("characterImg.Image")));
            this.characterImg.Location = new System.Drawing.Point(675, 54);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(360, 505);
            this.characterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImg.TabIndex = 8;
            this.characterImg.TabStop = false;
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Play.BackgroundImage")));
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Play.Location = new System.Drawing.Point(236, 393);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(256, 70);
            this.btn_Play.TabIndex = 12;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Cancel.Location = new System.Drawing.Point(236, 482);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(256, 70);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Name.Location = new System.Drawing.Point(161, 203);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 28);
            this.lbl_Name.TabIndex = 14;
            this.lbl_Name.Text = "NAME:";
            // 
            // lbl_Job
            // 
            this.lbl_Job.AutoSize = true;
            this.lbl_Job.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Job.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Job.Location = new System.Drawing.Point(184, 232);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(54, 28);
            this.lbl_Job.TabIndex = 15;
            this.lbl_Job.Text = "JOB:";
            // 
            // lbl_Name_Value
            // 
            this.lbl_Name_Value.AutoSize = true;
            this.lbl_Name_Value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Name_Value.Location = new System.Drawing.Point(236, 203);
            this.lbl_Name_Value.Name = "lbl_Name_Value";
            this.lbl_Name_Value.Size = new System.Drawing.Size(244, 28);
            this.lbl_Name_Value.TabIndex = 16;
            this.lbl_Name_Value.Text = "<NAME PLACEHOLDER>";
            // 
            // lbl_Job_Value
            // 
            this.lbl_Job_Value.AutoSize = true;
            this.lbl_Job_Value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Job_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Job_Value.Location = new System.Drawing.Point(236, 232);
            this.lbl_Job_Value.Name = "lbl_Job_Value";
            this.lbl_Job_Value.Size = new System.Drawing.Size(221, 28);
            this.lbl_Job_Value.TabIndex = 17;
            this.lbl_Job_Value.Text = "<JOB PLACEHOLDER>";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Transparent;
            this.statusBar.Location = new System.Drawing.Point(72, 253);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(503, 131);
            this.statusBar.TabIndex = 11;
            // 
            // textHolder_Title
            // 
            this.textHolder_Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textHolder_Title.BackgroundImage")));
            this.textHolder_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textHolder_Title.Content = "Text Placeholder";
            this.textHolder_Title.FontSize = 36;
            this.textHolder_Title.Location = new System.Drawing.Point(76, 52);
            this.textHolder_Title.Name = "textHolder_Title";
            this.textHolder_Title.Size = new System.Drawing.Size(583, 107);
            this.textHolder_Title.TabIndex = 7;
            // 
            // PlayerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.lbl_Job_Value);
            this.Controls.Add(this.lbl_Name_Value);
            this.Controls.Add(this.lbl_Job);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.characterImg);
            this.Controls.Add(this.textHolder_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUNGEON GAME";
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Properties.TextHolder textHolder_Title;
        private System.Windows.Forms.PictureBox characterImg;
        private Stats statusBar;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Job;
        private System.Windows.Forms.Label lbl_Name_Value;
        private System.Windows.Forms.Label lbl_Job_Value;
    }
}