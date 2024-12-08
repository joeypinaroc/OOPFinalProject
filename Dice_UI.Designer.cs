namespace FinalProject
{
    partial class Dice_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice_UI));
            this.btn_Continue = new System.Windows.Forms.Button();
            this.media_RollingDice = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_ConflictResult = new FinalProject.Properties.TextHolder();
            ((System.ComponentModel.ISupportInitialize)(this.media_RollingDice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Continue.BackgroundImage")));
            this.btn_Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Continue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Continue.Location = new System.Drawing.Point(218, 282);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(230, 60);
            this.btn_Continue.TabIndex = 16;
            this.btn_Continue.Text = "CONTINUE";
            this.btn_Continue.UseVisualStyleBackColor = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // media_RollingDice
            // 
            this.media_RollingDice.Enabled = true;
            this.media_RollingDice.Location = new System.Drawing.Point(-188, 44);
            this.media_RollingDice.Name = "media_RollingDice";
            this.media_RollingDice.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_RollingDice.OcxState")));
            this.media_RollingDice.Size = new System.Drawing.Size(751, 310);
            this.media_RollingDice.TabIndex = 17;
            // 
            // lbl_ConflictResult
            // 
            this.lbl_ConflictResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_ConflictResult.BackgroundImage")));
            this.lbl_ConflictResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_ConflictResult.Content = "";
            this.lbl_ConflictResult.FontSize = 36;
            this.lbl_ConflictResult.Location = new System.Drawing.Point(12, 27);
            this.lbl_ConflictResult.Name = "lbl_ConflictResult";
            this.lbl_ConflictResult.Size = new System.Drawing.Size(434, 56);
            this.lbl_ConflictResult.TabIndex = 18;
            // 
            // Dice_UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 353);
            this.Controls.Add(this.lbl_ConflictResult);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.media_RollingDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dice_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONFLICT RESULT";
            ((System.ComponentModel.ISupportInitialize)(this.media_RollingDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Continue;
        private AxWMPLib.AxWindowsMediaPlayer media_RollingDice;
        private Properties.TextHolder lbl_ConflictResult;
    }
}