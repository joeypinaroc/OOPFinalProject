namespace FinalProject
{
    partial class GameStoryIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStoryIntro));
            this.lbl_Intro = new FinalProject.Properties.TextHolder();
            this.btn_IntroNext = new System.Windows.Forms.Button();
            this.pb_MrMustard = new System.Windows.Forms.PictureBox();
            this.lbl_MrMustard = new FinalProject.Properties.TextHolder();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MrMustard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_Intro.BackgroundImage")));
            this.lbl_Intro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_Intro.Content = "Text Placeholder";
            this.lbl_Intro.FontSize = 36;
            this.lbl_Intro.Location = new System.Drawing.Point(11, 11);
            this.lbl_Intro.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(643, 189);
            this.lbl_Intro.TabIndex = 0;
            this.lbl_Intro.WrapWidth = 0;
            // 
            // btn_IntroNext
            // 
            this.btn_IntroNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IntroNext.BackgroundImage")));
            this.btn_IntroNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IntroNext.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.btn_IntroNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_IntroNext.Location = new System.Drawing.Point(426, 270);
            this.btn_IntroNext.Name = "btn_IntroNext";
            this.btn_IntroNext.Size = new System.Drawing.Size(213, 79);
            this.btn_IntroNext.TabIndex = 1;
            this.btn_IntroNext.Text = "NEXT";
            this.btn_IntroNext.UseVisualStyleBackColor = false;
            this.btn_IntroNext.Click += new System.EventHandler(this.btn_IntroNext_Click);
            // 
            // pb_MrMustard
            // 
            this.pb_MrMustard.Image = global::FinalProject.Properties.Resources.MrMustard;
            this.pb_MrMustard.Location = new System.Drawing.Point(93, 236);
            this.pb_MrMustard.Name = "pb_MrMustard";
            this.pb_MrMustard.Size = new System.Drawing.Size(133, 135);
            this.pb_MrMustard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MrMustard.TabIndex = 2;
            this.pb_MrMustard.TabStop = false;
            // 
            // lbl_MrMustard
            // 
            this.lbl_MrMustard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_MrMustard.BackgroundImage")));
            this.lbl_MrMustard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_MrMustard.Content = "Text Placeholder";
            this.lbl_MrMustard.FontSize = 36;
            this.lbl_MrMustard.Location = new System.Drawing.Point(93, 204);
            this.lbl_MrMustard.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_MrMustard.Name = "lbl_MrMustard";
            this.lbl_MrMustard.Size = new System.Drawing.Size(133, 27);
            this.lbl_MrMustard.TabIndex = 3;
            this.lbl_MrMustard.WrapWidth = 0;
            // 
            // GameStoryIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 383);
            this.Controls.Add(this.lbl_MrMustard);
            this.Controls.Add(this.pb_MrMustard);
            this.Controls.Add(this.btn_IntroNext);
            this.Controls.Add(this.lbl_Intro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameStoryIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DUNGEON GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pb_MrMustard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Properties.TextHolder lbl_Intro;
        private System.Windows.Forms.Button btn_IntroNext;
        private System.Windows.Forms.PictureBox pb_MrMustard;
        private Properties.TextHolder lbl_MrMustard;
    }
}