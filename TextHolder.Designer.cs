namespace FinalProject.Properties
{
    partial class TextHolder
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
            this.TextContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextContent
            // 
            this.TextContent.AutoSize = true;
            this.TextContent.BackColor = System.Drawing.Color.Transparent;
            this.TextContent.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextContent.Location = new System.Drawing.Point(22, 10);
            this.TextContent.Name = "TextContent";
            this.TextContent.Size = new System.Drawing.Size(387, 65);
            this.TextContent.TabIndex = 1;
            this.TextContent.Text = "Text Placeholder";
            this.TextContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Textholder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TextContent);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TextHolder";
            this.Size = new System.Drawing.Size(718, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextContent;
    }
}
