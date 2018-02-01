namespace counter
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
            this.countLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.resetTo0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.Color.Fuchsia;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.Yellow;
            this.countLabel.Location = new System.Drawing.Point(120, 33);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(39, 42);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "0";
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.Red;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countButton.ForeColor = System.Drawing.Color.Lime;
            this.countButton.Location = new System.Drawing.Point(76, 98);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(124, 78);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Add One";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.click_addOne);
            // 
            // resetTo0
            // 
            this.resetTo0.BackColor = System.Drawing.Color.Lime;
            this.resetTo0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTo0.ForeColor = System.Drawing.Color.Red;
            this.resetTo0.Location = new System.Drawing.Point(76, 182);
            this.resetTo0.Name = "resetTo0";
            this.resetTo0.Size = new System.Drawing.Size(124, 78);
            this.resetTo0.TabIndex = 2;
            this.resetTo0.Text = "Reset to 0";
            this.resetTo0.UseVisualStyleBackColor = false;
            this.resetTo0.Click += new System.EventHandler(this.click_reset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetTo0);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.countLabel);
            this.Name = "Form1";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button resetTo0;
    }
}

