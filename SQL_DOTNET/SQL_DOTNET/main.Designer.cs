
namespace SQL_DOTNET
{
    partial class main
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
            this.mALOAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tENLOAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mALOAIToolStripMenuItem,
            this.tENLOAIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mALOAIToolStripMenuItem
            // 
            this.mALOAIToolStripMenuItem.Name = "mALOAIToolStripMenuItem";
            this.mALOAIToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.mALOAIToolStripMenuItem.Text = "MA LOAI";
            this.mALOAIToolStripMenuItem.Click += new System.EventHandler(this.mALOAIToolStripMenuItem_Click);
            // 
            // tENLOAIToolStripMenuItem
            // 
            this.tENLOAIToolStripMenuItem.Name = "tENLOAIToolStripMenuItem";
            this.tENLOAIToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tENLOAIToolStripMenuItem.Text = "TEN LOAI";
            this.tENLOAIToolStripMenuItem.Click += new System.EventHandler(this.tENLOAIToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAN LY TOI PHAM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mALOAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tENLOAIToolStripMenuItem;
    }
}

