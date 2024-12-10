namespace FinalProject
{
    partial class Stats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar_Str = new System.Windows.Forms.ProgressBar();
            this.lbl_Str = new System.Windows.Forms.Label();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.lbl_Chr = new System.Windows.Forms.Label();
            this.progressBar_Int = new System.Windows.Forms.ProgressBar();
            this.progressBar_Chr = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar_Str
            // 
            this.progressBar_Str.BackColor = System.Drawing.Color.White;
            this.progressBar_Str.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Str.Location = new System.Drawing.Point(170, 12);
            this.progressBar_Str.Maximum = 20;
            this.progressBar_Str.Name = "progressBar_Str";
            this.progressBar_Str.Size = new System.Drawing.Size(295, 28);
            this.progressBar_Str.Step = 1;
            this.progressBar_Str.TabIndex = 9;
            this.progressBar_Str.Value = 10;
            // 
            // lbl_Str
            // 
            this.lbl_Str.AutoSize = true;
            this.lbl_Str.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Str.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Str.Location = new System.Drawing.Point(46, 11);
            this.lbl_Str.Name = "lbl_Str";
            this.lbl_Str.Size = new System.Drawing.Size(121, 28);
            this.lbl_Str.TabIndex = 10;
            this.lbl_Str.Text = "STRENGTH:";
            // 
            // lbl_Int
            // 
            this.lbl_Int.AutoSize = true;
            this.lbl_Int.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Int.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Int.Location = new System.Drawing.Point(15, 46);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(152, 28);
            this.lbl_Int.TabIndex = 11;
            this.lbl_Int.Text = "INTELLIGENCE:";
            // 
            // lbl_Chr
            // 
            this.lbl_Chr.AutoSize = true;
            this.lbl_Chr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Chr.Location = new System.Drawing.Point(46, 79);
            this.lbl_Chr.Name = "lbl_Chr";
            this.lbl_Chr.Size = new System.Drawing.Size(121, 28);
            this.lbl_Chr.TabIndex = 12;
            this.lbl_Chr.Text = "CHARISMA:";
            // 
            // progressBar_Int
            // 
            this.progressBar_Int.BackColor = System.Drawing.Color.White;
            this.progressBar_Int.Location = new System.Drawing.Point(170, 46);
            this.progressBar_Int.Maximum = 20;
            this.progressBar_Int.Name = "progressBar_Int";
            this.progressBar_Int.Size = new System.Drawing.Size(295, 28);
            this.progressBar_Int.Step = 1;
            this.progressBar_Int.TabIndex = 13;
            this.progressBar_Int.Value = 10;
            // 
            // progressBar_Chr
            // 
            this.progressBar_Chr.BackColor = System.Drawing.Color.White;
            this.progressBar_Chr.ForeColor = System.Drawing.Color.Lime;
            this.progressBar_Chr.Location = new System.Drawing.Point(170, 80);
            this.progressBar_Chr.Maximum = 20;
            this.progressBar_Chr.Name = "progressBar_Chr";
            this.progressBar_Chr.Size = new System.Drawing.Size(295, 28);
            this.progressBar_Chr.Step = 1;
            this.progressBar_Chr.TabIndex = 14;
            this.progressBar_Chr.Value = 10;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.progressBar_Chr);
            this.Controls.Add(this.progressBar_Int);
            this.Controls.Add(this.lbl_Chr);
            this.Controls.Add(this.lbl_Int);
            this.Controls.Add(this.lbl_Str);
            this.Controls.Add(this.progressBar_Str);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(498, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Str;
        private System.Windows.Forms.Label lbl_Str;
        private System.Windows.Forms.Label lbl_Int;
        private System.Windows.Forms.Label lbl_Chr;
        private System.Windows.Forms.ProgressBar progressBar_Int;
        private System.Windows.Forms.ProgressBar progressBar_Chr;
    }
}
