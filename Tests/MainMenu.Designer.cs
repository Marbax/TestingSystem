namespace Tests
{
    partial class MainMenu
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
            this.button2PassTest = new System.Windows.Forms.Button();
            this.button1CreateEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2PassTest
            // 
            this.button2PassTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2PassTest.Location = new System.Drawing.Point(3, -1);
            this.button2PassTest.Name = "button2PassTest";
            this.button2PassTest.Size = new System.Drawing.Size(318, 106);
            this.button2PassTest.TabIndex = 0;
            this.button2PassTest.Text = "Pass The Test";
            this.button2PassTest.UseVisualStyleBackColor = true;
            this.button2PassTest.Click += new System.EventHandler(this.button2PassTest_Click);
            // 
            // button1CreateEdit
            // 
            this.button1CreateEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1CreateEdit.Location = new System.Drawing.Point(3, 111);
            this.button1CreateEdit.Name = "button1CreateEdit";
            this.button1CreateEdit.Size = new System.Drawing.Size(318, 106);
            this.button1CreateEdit.TabIndex = 0;
            this.button1CreateEdit.Text = "Edit Test";
            this.button1CreateEdit.UseVisualStyleBackColor = true;
            this.button1CreateEdit.Click += new System.EventHandler(this.button1CreateEdit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 216);
            this.Controls.Add(this.button2PassTest);
            this.Controls.Add(this.button1CreateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2PassTest;
        private System.Windows.Forms.Button button1CreateEdit;
    }
}