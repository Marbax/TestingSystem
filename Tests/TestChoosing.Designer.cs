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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestChoosing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelTestsList = new System.Windows.Forms.Panel();
            this.panelEdditingTools = new System.Windows.Forms.Panel();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.labelNewTestDescription = new System.Windows.Forms.Label();
            this.richTextBoxNewTestDescription = new System.Windows.Forms.RichTextBox();
            this.labelTestNameAdd = new System.Windows.Forms.Label();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.textBoxNameToAdd = new System.Windows.Forms.TextBox();
            this.labelRemoveTesName = new System.Windows.Forms.Label();
            this.buttonRemoveTest = new System.Windows.Forms.Button();
            this.textBoxRemoveTestName = new System.Windows.Forms.TextBox();
            this.labelTestChoose = new System.Windows.Forms.Label();
            this.panelTestsList.SuspendLayout();
            this.panelEdditingTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 416);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // panelTestsList
            // 
            this.panelTestsList.Controls.Add(this.menuStrip1);
            this.panelTestsList.Location = new System.Drawing.Point(-1, 39);
            this.panelTestsList.Name = "panelTestsList";
            this.panelTestsList.Size = new System.Drawing.Size(555, 416);
            this.panelTestsList.TabIndex = 2;
            // 
            // panelEdditingTools
            // 
            this.panelEdditingTools.Controls.Add(this.buttonSaveToFile);
            this.panelEdditingTools.Controls.Add(this.labelNewTestDescription);
            this.panelEdditingTools.Controls.Add(this.richTextBoxNewTestDescription);
            this.panelEdditingTools.Controls.Add(this.labelTestNameAdd);
            this.panelEdditingTools.Controls.Add(this.buttonAddTest);
            this.panelEdditingTools.Controls.Add(this.textBoxNameToAdd);
            this.panelEdditingTools.Controls.Add(this.labelRemoveTesName);
            this.panelEdditingTools.Controls.Add(this.buttonRemoveTest);
            this.panelEdditingTools.Controls.Add(this.textBoxRemoveTestName);
            this.panelEdditingTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdditingTools.Location = new System.Drawing.Point(560, 0);
            this.panelEdditingTools.Name = "panelEdditingTools";
            this.panelEdditingTools.Size = new System.Drawing.Size(240, 450);
            this.panelEdditingTools.TabIndex = 3;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(12, 397);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(216, 41);
            this.buttonSaveToFile.TabIndex = 8;
            this.buttonSaveToFile.Text = "Save to File";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // labelNewTestDescription
            // 
            this.labelNewTestDescription.AutoSize = true;
            this.labelNewTestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewTestDescription.Location = new System.Drawing.Point(23, 177);
            this.labelNewTestDescription.Name = "labelNewTestDescription";
            this.labelNewTestDescription.Size = new System.Drawing.Size(180, 20);
            this.labelNewTestDescription.TabIndex = 7;
            this.labelNewTestDescription.Text = "Description for new Test";
            // 
            // richTextBoxNewTestDescription
            // 
            this.richTextBoxNewTestDescription.Location = new System.Drawing.Point(12, 200);
            this.richTextBoxNewTestDescription.Name = "richTextBoxNewTestDescription";
            this.richTextBoxNewTestDescription.Size = new System.Drawing.Size(216, 145);
            this.richTextBoxNewTestDescription.TabIndex = 6;
            this.richTextBoxNewTestDescription.Text = "";
            // 
            // labelTestNameAdd
            // 
            this.labelTestNameAdd.AutoSize = true;
            this.labelTestNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNameAdd.Location = new System.Drawing.Point(8, 119);
            this.labelTestNameAdd.Name = "labelTestNameAdd";
            this.labelTestNameAdd.Size = new System.Drawing.Size(182, 20);
            this.labelTestNameAdd.TabIndex = 5;
            this.labelTestNameAdd.Text = "Name of the Test to Add";
            this.labelTestNameAdd.Click += new System.EventHandler(this.labelTestNameAdd_Click);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(149, 143);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(79, 31);
            this.buttonAddTest.TabIndex = 4;
            this.buttonAddTest.Text = "Add Test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // textBoxNameToAdd
            // 
            this.textBoxNameToAdd.Location = new System.Drawing.Point(12, 149);
            this.textBoxNameToAdd.Name = "textBoxNameToAdd";
            this.textBoxNameToAdd.Size = new System.Drawing.Size(131, 20);
            this.textBoxNameToAdd.TabIndex = 3;
            // 
            // labelRemoveTesName
            // 
            this.labelRemoveTesName.AutoSize = true;
            this.labelRemoveTesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRemoveTesName.Location = new System.Drawing.Point(8, 9);
            this.labelRemoveTesName.Name = "labelRemoveTesName";
            this.labelRemoveTesName.Size = new System.Drawing.Size(212, 20);
            this.labelRemoveTesName.TabIndex = 2;
            this.labelRemoveTesName.Text = "Name of the Test to Remove";
            // 
            // buttonRemoveTest
            // 
            this.buttonRemoveTest.Location = new System.Drawing.Point(149, 33);
            this.buttonRemoveTest.Name = "buttonRemoveTest";
            this.buttonRemoveTest.Size = new System.Drawing.Size(79, 31);
            this.buttonRemoveTest.TabIndex = 1;
            this.buttonRemoveTest.Text = "Remove Test";
            this.buttonRemoveTest.UseVisualStyleBackColor = true;
            this.buttonRemoveTest.Click += new System.EventHandler(this.buttonRemoveTest_Click);
            // 
            // textBoxRemoveTestName
            // 
            this.textBoxRemoveTestName.Location = new System.Drawing.Point(12, 39);
            this.textBoxRemoveTestName.Name = "textBoxRemoveTestName";
            this.textBoxRemoveTestName.Size = new System.Drawing.Size(131, 20);
            this.textBoxRemoveTestName.TabIndex = 0;
            // 
            // labelTestChoose
            // 
            this.labelTestChoose.AutoSize = true;
            this.labelTestChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestChoose.Location = new System.Drawing.Point(216, 19);
            this.labelTestChoose.Name = "labelTestChoose";
            this.labelTestChoose.Size = new System.Drawing.Size(126, 20);
            this.labelTestChoose.TabIndex = 4;
            this.labelTestChoose.Text = "Choose the Test";
            // 
            // TestChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTestChoose);
            this.Controls.Add(this.panelEdditingTools);
            this.Controls.Add(this.panelTestsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestChoosing";
            this.Text = "TestChoosing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestChoosing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestChoosing_FormClosed);
            this.Load += new System.EventHandler(this.TestChoosing_Load);
            this.panelTestsList.ResumeLayout(false);
            this.panelTestsList.PerformLayout();
            this.panelEdditingTools.ResumeLayout(false);
            this.panelEdditingTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelTestsList;
        private System.Windows.Forms.Panel panelEdditingTools;
        private System.Windows.Forms.Label labelTestChoose;
        private System.Windows.Forms.Button buttonRemoveTest;
        private System.Windows.Forms.TextBox textBoxRemoveTestName;
        private System.Windows.Forms.Label labelRemoveTesName;
        private System.Windows.Forms.Label labelNewTestDescription;
        private System.Windows.Forms.RichTextBox richTextBoxNewTestDescription;
        private System.Windows.Forms.Label labelTestNameAdd;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.TextBox textBoxNameToAdd;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}