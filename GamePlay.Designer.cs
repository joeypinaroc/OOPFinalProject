namespace FinalProject
{
    partial class GamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.characterAvtar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Choice1 = new System.Windows.Forms.Button();
            this.btn_Choice2 = new System.Windows.Forms.Button();
            this.btn_Choice3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ConflictText = new FinalProject.Properties.TextHolder();
            this.statusBar = new FinalProject.Stats();
            ((System.ComponentModel.ISupportInitialize)(this.characterAvtar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterAvtar
            // 
            this.characterAvtar.Image = global::FinalProject.Properties.Resources.avatar_farmer;
            this.characterAvtar.Location = new System.Drawing.Point(41, 408);
            this.characterAvtar.Name = "characterAvtar";
            this.characterAvtar.Size = new System.Drawing.Size(162, 148);
            this.characterAvtar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterAvtar.TabIndex = 3;
            this.characterAvtar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Choice1
            // 
            this.btn_Choice1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Choice1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Choice1.BackgroundImage")));
            this.btn_Choice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Choice1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Choice1.Location = new System.Drawing.Point(8, 17);
            this.btn_Choice1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Choice1.Name = "btn_Choice1";
            this.btn_Choice1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Choice1.Size = new System.Drawing.Size(556, 60);
            this.btn_Choice1.TabIndex = 13;
            this.btn_Choice1.Text = "<CHOICE 1 PLACEHOLDER>";
            this.btn_Choice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Choice1.UseVisualStyleBackColor = false;
            this.btn_Choice1.Click += new System.EventHandler(this.btn_Choice1_Click);
            // 
            // btn_Choice2
            // 
            this.btn_Choice2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Choice2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Choice2.BackgroundImage")));
            this.btn_Choice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Choice2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Choice2.Location = new System.Drawing.Point(8, 100);
            this.btn_Choice2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Choice2.Name = "btn_Choice2";
            this.btn_Choice2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Choice2.Size = new System.Drawing.Size(556, 60);
            this.btn_Choice2.TabIndex = 14;
            this.btn_Choice2.Text = "<CHOICE 2 PLACEHOLDER>";
            this.btn_Choice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Choice2.UseVisualStyleBackColor = false;
            this.btn_Choice2.Click += new System.EventHandler(this.btn_Choice2_Click);
            // 
            // btn_Choice3
            // 
            this.btn_Choice3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Choice3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Choice3.BackgroundImage")));
            this.btn_Choice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Choice3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Choice3.Location = new System.Drawing.Point(8, 183);
            this.btn_Choice3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Choice3.Name = "btn_Choice3";
            this.btn_Choice3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Choice3.Size = new System.Drawing.Size(556, 60);
            this.btn_Choice3.TabIndex = 15;
            this.btn_Choice3.Text = "<CHOICE 3 PLACEHOLDER>";
            this.btn_Choice3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Choice3.UseVisualStyleBackColor = false;
            this.btn_Choice3.Click += new System.EventHandler(this.btn_Choice3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Choice2);
            this.panel1.Controls.Add(this.btn_Choice3);
            this.panel1.Controls.Add(this.btn_Choice1);
            this.panel1.Location = new System.Drawing.Point(270, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 265);
            this.panel1.TabIndex = 16;
            // 
            // lbl_ConflictText
            // 
            this.lbl_ConflictText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_ConflictText.BackgroundImage")));
            this.lbl_ConflictText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_ConflictText.Content = "Text Placeholder";
            this.lbl_ConflictText.FontSize = 36;
            this.lbl_ConflictText.Location = new System.Drawing.Point(27, 12);
            this.lbl_ConflictText.Name = "lbl_ConflictText";
            this.lbl_ConflictText.Size = new System.Drawing.Size(1029, 133);
            this.lbl_ConflictText.TabIndex = 8;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.statusBar.Location = new System.Drawing.Point(270, 460);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(475, 109);
            this.statusBar.TabIndex = 1;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.characterAvtar);
            this.Controls.Add(this.lbl_ConflictText);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUNGEON GAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePlay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.characterAvtar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Stats statusBar;
        private System.Windows.Forms.PictureBox characterAvtar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Properties.TextHolder lbl_ConflictText;
        private System.Windows.Forms.Button btn_Choice1;
        private System.Windows.Forms.Button btn_Choice2;
        private System.Windows.Forms.Button btn_Choice3;
        private System.Windows.Forms.Panel panel1;
    }
}