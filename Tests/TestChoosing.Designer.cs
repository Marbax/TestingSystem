namespace Tests
{
    partial class TestChoosing
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
            this.groupBox1TestCollection = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1TestCollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1TestCollection
            // 
            this.groupBox1TestCollection.Controls.Add(this.menuStrip1);
            this.groupBox1TestCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1TestCollection.Location = new System.Drawing.Point(0, 0);
            this.groupBox1TestCollection.Name = "groupBox1TestCollection";
            this.groupBox1TestCollection.Size = new System.Drawing.Size(800, 450);
            this.groupBox1TestCollection.TabIndex = 0;
            this.groupBox1TestCollection.TabStop = false;
            this.groupBox1TestCollection.Text = "Tests";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // TestChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1TestCollection);
            this.Name = "TestChoosing";
            this.Text = "TestChoosing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestChoosing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestChoosing_FormClosed);
            this.Load += new System.EventHandler(this.TestChoosing_Load);
            this.groupBox1TestCollection.ResumeLayout(false);
            this.groupBox1TestCollection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1TestCollection;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}