namespace Tests
{
    partial class Testing
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
            this.hScrollBarQuestChng = new System.Windows.Forms.HScrollBar();
            this.panel1AnswerField = new System.Windows.Forms.Panel();
            this.checkedListBox1Answers = new System.Windows.Forms.CheckedListBox();
            this.panel2QuestFied = new System.Windows.Forms.Panel();
            this.label1Question = new System.Windows.Forms.Label();
            this.button1Next = new System.Windows.Forms.Button();
            this.button1Previous = new System.Windows.Forms.Button();
            this.panel1AnswerField.SuspendLayout();
            this.panel2QuestFied.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBarQuestChng
            // 
            this.hScrollBarQuestChng.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBarQuestChng.LargeChange = 1;
            this.hScrollBarQuestChng.Location = new System.Drawing.Point(0, 0);
            this.hScrollBarQuestChng.Name = "hScrollBarQuestChng";
            this.hScrollBarQuestChng.Size = new System.Drawing.Size(800, 17);
            this.hScrollBarQuestChng.TabIndex = 1;
            this.hScrollBarQuestChng.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarQuestChng_Scroll);
            // 
            // panel1AnswerField
            // 
            this.panel1AnswerField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1AnswerField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1AnswerField.Controls.Add(this.button1Previous);
            this.panel1AnswerField.Controls.Add(this.button1Next);
            this.panel1AnswerField.Controls.Add(this.checkedListBox1Answers);
            this.panel1AnswerField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1AnswerField.Location = new System.Drawing.Point(0, 238);
            this.panel1AnswerField.Name = "panel1AnswerField";
            this.panel1AnswerField.Size = new System.Drawing.Size(800, 212);
            this.panel1AnswerField.TabIndex = 2;
            // 
            // checkedListBox1Answers
            // 
            this.checkedListBox1Answers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1Answers.FormattingEnabled = true;
            this.checkedListBox1Answers.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1Answers.Name = "checkedListBox1Answers";
            this.checkedListBox1Answers.Size = new System.Drawing.Size(798, 210);
            this.checkedListBox1Answers.TabIndex = 0;
            // 
            // panel2QuestFied
            // 
            this.panel2QuestFied.Controls.Add(this.label1Question);
            this.panel2QuestFied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2QuestFied.Location = new System.Drawing.Point(0, 17);
            this.panel2QuestFied.Name = "panel2QuestFied";
            this.panel2QuestFied.Size = new System.Drawing.Size(800, 221);
            this.panel2QuestFied.TabIndex = 3;
            // 
            // label1Question
            // 
            this.label1Question.AutoSize = true;
            this.label1Question.Location = new System.Drawing.Point(336, 159);
            this.label1Question.Name = "label1Question";
            this.label1Question.Size = new System.Drawing.Size(77, 13);
            this.label1Question.TabIndex = 0;
            this.label1Question.Text = "label1Question";
            // 
            // button1Next
            // 
            this.button1Next.Location = new System.Drawing.Point(690, 176);
            this.button1Next.Name = "button1Next";
            this.button1Next.Size = new System.Drawing.Size(109, 35);
            this.button1Next.TabIndex = 1;
            this.button1Next.Text = "Next";
            this.button1Next.UseVisualStyleBackColor = true;
            this.button1Next.Click += new System.EventHandler(this.button1Next_Click);
            // 
            // button1Previous
            // 
            this.button1Previous.Location = new System.Drawing.Point(-1, 176);
            this.button1Previous.Name = "button1Previous";
            this.button1Previous.Size = new System.Drawing.Size(115, 35);
            this.button1Previous.TabIndex = 2;
            this.button1Previous.Text = "Previous";
            this.button1Previous.UseVisualStyleBackColor = true;
            this.button1Previous.Click += new System.EventHandler(this.button1Previous_Click);
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2QuestFied);
            this.Controls.Add(this.panel1AnswerField);
            this.Controls.Add(this.hScrollBarQuestChng);
            this.Name = "Testing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1AnswerField.ResumeLayout(false);
            this.panel2QuestFied.ResumeLayout(false);
            this.panel2QuestFied.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarQuestChng;
        private System.Windows.Forms.Panel panel1AnswerField;
        private System.Windows.Forms.Panel panel2QuestFied;
        private System.Windows.Forms.Label label1Question;
        private System.Windows.Forms.CheckedListBox checkedListBox1Answers;
        private System.Windows.Forms.Button button1Next;
        private System.Windows.Forms.Button button1Previous;
    }
}

