namespace FinalProject
{
    partial class GameResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResult));
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_GameResult = new FinalProject.Properties.TextHolder();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_PlayAgain.BackgroundImage = global::FinalProject.Properties.Resources.button;
            this.btn_PlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_PlayAgain.Location = new System.Drawing.Point(566, 351);
            this.btn_PlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(324, 70);
            this.btn_PlayAgain.TabIndex = 9;
            this.btn_PlayAgain.Text = "PLAY AGAIN";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // characterImg
            // 
            this.characterImg.BackColor = System.Drawing.SystemColors.Control;
            this.characterImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterImg.Image = ((System.Drawing.Image)(resources.GetObject("characterImg.Image")));
            this.characterImg.Location = new System.Drawing.Point(64, 45);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(339, 505);
            this.characterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImg.TabIndex = 11;
            this.characterImg.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Exit.BackgroundImage = global::FinalProject.Properties.Resources.button;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Exit.Location = new System.Drawing.Point(566, 454);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(324, 70);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_GameResult
            // 
            this.lbl_GameResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_GameResult.BackgroundImage")));
            this.lbl_GameResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_GameResult.Content = "Text Placeholder";
            this.lbl_GameResult.FontSize = 36;
            this.lbl_GameResult.Location = new System.Drawing.Point(439, 42);
            this.lbl_GameResult.Name = "lbl_GameResult";
            this.lbl_GameResult.Size = new System.Drawing.Size(585, 257);
            this.lbl_GameResult.TabIndex = 7;
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.characterImg);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.lbl_GameResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUNGEON GAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameResult_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Properties.TextHolder lbl_GameResult;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.PictureBox characterImg;
        private System.Windows.Forms.Button btn_Exit;
    }
}