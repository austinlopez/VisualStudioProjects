namespace Shape_Maker
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb = new System.Windows.Forms.PictureBox();
            this.tools = new System.Windows.Forms.GroupBox();
            this.setup = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.RadioButton();
            this.rButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Black;
            this.pb.Location = new System.Drawing.Point(148, 28);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(600, 600);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // tools
            // 
            this.tools.Controls.Add(this.setup);
            this.tools.Controls.Add(this.cButton);
            this.tools.Controls.Add(this.rButton);
            this.tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tools.Location = new System.Drawing.Point(13, 28);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(129, 589);
            this.tools.TabIndex = 2;
            this.tools.TabStop = false;
            this.tools.Text = "Tools";
            // 
            // setup
            // 
            this.setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setup.Location = new System.Drawing.Point(6, 522);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(117, 61);
            this.setup.TabIndex = 2;
            this.setup.Text = "Setup Tool";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // cButton
            // 
            this.cButton.AutoSize = true;
            this.cButton.Location = new System.Drawing.Point(7, 44);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(76, 28);
            this.cButton.TabIndex = 1;
            this.cButton.TabStop = true;
            this.cButton.Text = "Circle";
            this.cButton.UseVisualStyleBackColor = true;
            // 
            // rButton
            // 
            this.rButton.AutoSize = true;
            this.rButton.Location = new System.Drawing.Point(7, 20);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(113, 28);
            this.rButton.TabIndex = 0;
            this.rButton.TabStop = true;
            this.rButton.Text = "Rectangle";
            this.rButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 629);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Drawing Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.GroupBox tools;
        private System.Windows.Forms.RadioButton cButton;
        private System.Windows.Forms.RadioButton rButton;
        private System.Windows.Forms.Button setup;
    }
}

