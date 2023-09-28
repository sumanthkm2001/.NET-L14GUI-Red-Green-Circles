namespace L14GUI
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
            this.cmdGreen = new System.Windows.Forms.Button();
            this.cmdRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGreen
            // 
            this.cmdGreen.Location = new System.Drawing.Point(13, 13);
            this.cmdGreen.Name = "cmdGreen";
            this.cmdGreen.Size = new System.Drawing.Size(75, 23);
            this.cmdGreen.TabIndex = 0;
            this.cmdGreen.Text = "Green";
            this.cmdGreen.UseVisualStyleBackColor = true;
            this.cmdGreen.Click += new System.EventHandler(this.cmdGreen_Click);
            // 
            // cmdRed
            // 
            this.cmdRed.Location = new System.Drawing.Point(13, 53);
            this.cmdRed.Name = "cmdRed";
            this.cmdRed.Size = new System.Drawing.Size(75, 23);
            this.cmdRed.TabIndex = 1;
            this.cmdRed.Text = "Red";
            this.cmdRed.UseVisualStyleBackColor = true;
            this.cmdRed.Click += new System.EventHandler(this.cmdRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdRed);
            this.Controls.Add(this.cmdGreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGreen;
        private System.Windows.Forms.Button cmdRed;
    }
}

