namespace WindowsFormsMVC.Views
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
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(13, 13);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(75, 23);
            this.buttonIncrement.TabIndex = 0;
            this.buttonIncrement.Text = "Increment";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Location = new System.Drawing.Point(94, 18);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(13, 13);
            this.labelIncrement.TabIndex = 1;
            this.labelIncrement.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 81);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.buttonIncrement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MVC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Label labelIncrement;
    }
}

