namespace Readogwrite_fra_en_fil
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
            this.bntRead = new System.Windows.Forms.Button();
            this.bntwrite = new System.Windows.Forms.Button();
            this.textText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(601, 387);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(84, 51);
            this.bntRead.TabIndex = 0;
            this.bntRead.Text = "Readfile";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // bntwrite
            // 
            this.bntwrite.Location = new System.Drawing.Point(691, 387);
            this.bntwrite.Name = "bntwrite";
            this.bntwrite.Size = new System.Drawing.Size(86, 51);
            this.bntwrite.TabIndex = 1;
            this.bntwrite.Text = "WriteFile";
            this.bntwrite.UseVisualStyleBackColor = true;
            this.bntwrite.Click += new System.EventHandler(this.bntwrite_Click);
            // 
            // textText
            // 
            this.textText.Location = new System.Drawing.Point(12, 12);
            this.textText.Multiline = true;
            this.textText.Name = "textText";
            this.textText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textText.Size = new System.Drawing.Size(765, 328);
            this.textText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textText);
            this.Controls.Add(this.bntwrite);
            this.Controls.Add(this.bntRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.Button bntwrite;
        private System.Windows.Forms.TextBox textText;
    }
}

