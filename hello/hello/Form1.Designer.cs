namespace hello
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
            this.myLabel = new System.Windows.Forms.Label();
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel.Location = new System.Drawing.Point(117, 61);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(138, 25);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Nothing Here";
            this.myLabel.Visible = false;
            // 
            // myButton
            // 
            this.myButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.myButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton.Location = new System.Drawing.Point(86, 146);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(208, 81);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "Change it Mah Dude";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.Button myButton;
    }
}

