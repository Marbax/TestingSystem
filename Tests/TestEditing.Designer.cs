﻿namespace Tests
{
    partial class TestEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestEditing));
            this.textBox1NameEdit = new System.Windows.Forms.TextBox();
            this.panel1StaticFields = new System.Windows.Forms.Panel();
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.labelTestDescription = new System.Windows.Forms.Label();
            this.richTextBoxTestDescription = new System.Windows.Forms.RichTextBox();
            this.labelTestName = new System.Windows.Forms.Label();
            this.panel1DynamicFields = new System.Windows.Forms.Panel();
            this.panelBoolsOuter = new System.Windows.Forms.Panel();
            this.panelBoolValues = new System.Windows.Forms.Panel();
            this.panelAnswersOuter = new System.Windows.Forms.Panel();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.panelQuestionButtons = new System.Windows.Forms.Panel();
            this.buttonRemoveCurQuestion = new System.Windows.Forms.Button();
            this.buttonAddNewAnswer = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPreveous = new System.Windows.Forms.Button();
            this.panelQuestionText = new System.Windows.Forms.Panel();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.labelQuestionValue = new System.Windows.Forms.Label();
            this.textBoxQuestionValue = new System.Windows.Forms.TextBox();
            this.richTextBoxQuestionText = new System.Windows.Forms.RichTextBox();
            this.hScrollBar1QuestionChng = new System.Windows.Forms.HScrollBar();
            this.panel1StaticFields.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel1DynamicFields.SuspendLayout();
            this.panelBoolsOuter.SuspendLayout();
            this.panelAnswersOuter.SuspendLayout();
            this.panelQuestionButtons.SuspendLayout();
            this.panelQuestionText.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1NameEdit
            // 
            this.textBox1NameEdit.Location = new System.Drawing.Point(12, 59);
            this.textBox1NameEdit.Name = "textBox1NameEdit";
            this.textBox1NameEdit.Size = new System.Drawing.Size(157, 20);
            this.textBox1NameEdit.TabIndex = 0;
            this.textBox1NameEdit.TextChanged += new System.EventHandler(this.textBox1NameEdit_TextChanged);
            // 
            // panel1StaticFields
            // 
            this.panel1StaticFields.Controls.Add(this.labelQuestionNum);
            this.panel1StaticFields.Controls.Add(this.panel1);
            this.panel1StaticFields.Controls.Add(this.labelTestDescription);
            this.panel1StaticFields.Controls.Add(this.richTextBoxTestDescription);
            this.panel1StaticFields.Controls.Add(this.labelTestName);
            this.panel1StaticFields.Controls.Add(this.textBox1NameEdit);
            this.panel1StaticFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1StaticFields.Location = new System.Drawing.Point(0, 0);
            this.panel1StaticFields.Name = "panel1StaticFields";
            this.panel1StaticFields.Size = new System.Drawing.Size(800, 185);
            this.panel1StaticFields.TabIndex = 1;
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.Location = new System.Drawing.Point(325, 169);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionNum.TabIndex = 1;
            this.labelQuestionNum.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveAndExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 185);
            this.panel1.TabIndex = 5;
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaveAndExit.Location = new System.Drawing.Point(0, 0);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(100, 60);
            this.buttonSaveAndExit.TabIndex = 4;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.button1SaveAndExit_Click);
            // 
            // labelTestDescription
            // 
            this.labelTestDescription.AutoSize = true;
            this.labelTestDescription.Location = new System.Drawing.Point(276, 43);
            this.labelTestDescription.Name = "labelTestDescription";
            this.labelTestDescription.Size = new System.Drawing.Size(84, 13);
            this.labelTestDescription.TabIndex = 3;
            this.labelTestDescription.Text = "Test Description";
            this.labelTestDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxTestDescription
            // 
            this.richTextBoxTestDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxTestDescription.Location = new System.Drawing.Point(194, 59);
            this.richTextBoxTestDescription.Name = "richTextBoxTestDescription";
            this.richTextBoxTestDescription.Size = new System.Drawing.Size(256, 73);
            this.richTextBoxTestDescription.TabIndex = 2;
            this.richTextBoxTestDescription.Text = "";
            this.richTextBoxTestDescription.TextChanged += new System.EventHandler(this.richTextBox1TestDescription_TextChanged);
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Location = new System.Drawing.Point(56, 43);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(59, 13);
            this.labelTestName.TabIndex = 1;
            this.labelTestName.Text = "Test Name";
            this.labelTestName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1DynamicFields
            // 
            this.panel1DynamicFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1DynamicFields.Controls.Add(this.panelBoolsOuter);
            this.panel1DynamicFields.Controls.Add(this.panelAnswersOuter);
            this.panel1DynamicFields.Controls.Add(this.panelQuestionButtons);
            this.panel1DynamicFields.Controls.Add(this.panelQuestionText);
            this.panel1DynamicFields.Controls.Add(this.hScrollBar1QuestionChng);
            this.panel1DynamicFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1DynamicFields.Location = new System.Drawing.Point(0, 185);
            this.panel1DynamicFields.Name = "panel1DynamicFields";
            this.panel1DynamicFields.Size = new System.Drawing.Size(800, 265);
            this.panel1DynamicFields.TabIndex = 2;
            // 
            // panelBoolsOuter
            // 
            this.panelBoolsOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoolsOuter.Controls.Add(this.panelBoolValues);
            this.panelBoolsOuter.Location = new System.Drawing.Point(698, 20);
            this.panelBoolsOuter.Name = "panelBoolsOuter";
            this.panelBoolsOuter.Size = new System.Drawing.Size(100, 205);
            this.panelBoolsOuter.TabIndex = 6;
            // 
            // panelBoolValues
            // 
            this.panelBoolValues.Location = new System.Drawing.Point(9, 14);
            this.panelBoolValues.Name = "panelBoolValues";
            this.panelBoolValues.Size = new System.Drawing.Size(90, 186);
            this.panelBoolValues.TabIndex = 5;
            // 
            // panelAnswersOuter
            // 
            this.panelAnswersOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnswersOuter.Controls.Add(this.panelAnswers);
            this.panelAnswersOuter.Location = new System.Drawing.Point(278, 20);
            this.panelAnswersOuter.Name = "panelAnswersOuter";
            this.panelAnswersOuter.Size = new System.Drawing.Size(414, 205);
            this.panelAnswersOuter.TabIndex = 6;
            // 
            // panelAnswers
            // 
            this.panelAnswers.Location = new System.Drawing.Point(21, 14);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(369, 185);
            this.panelAnswers.TabIndex = 2;
            // 
            // panelQuestionButtons
            // 
            this.panelQuestionButtons.Controls.Add(this.buttonRemoveCurQuestion);
            this.panelQuestionButtons.Controls.Add(this.buttonAddNewAnswer);
            this.panelQuestionButtons.Controls.Add(this.buttonAddQuestion);
            this.panelQuestionButtons.Controls.Add(this.buttonSaveChanges);
            this.panelQuestionButtons.Controls.Add(this.buttonNext);
            this.panelQuestionButtons.Controls.Add(this.buttonPreveous);
            this.panelQuestionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelQuestionButtons.Location = new System.Drawing.Point(0, 230);
            this.panelQuestionButtons.Name = "panelQuestionButtons";
            this.panelQuestionButtons.Size = new System.Drawing.Size(796, 31);
            this.panelQuestionButtons.TabIndex = 4;
            // 
            // buttonRemoveCurQuestion
            // 
            this.buttonRemoveCurQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemoveCurQuestion.Location = new System.Drawing.Point(410, 0);
            this.buttonRemoveCurQuestion.Name = "buttonRemoveCurQuestion";
            this.buttonRemoveCurQuestion.Size = new System.Drawing.Size(132, 31);
            this.buttonRemoveCurQuestion.TabIndex = 5;
            this.buttonRemoveCurQuestion.Text = "Remove Cur Question";
            this.buttonRemoveCurQuestion.UseVisualStyleBackColor = true;
            this.buttonRemoveCurQuestion.Click += new System.EventHandler(this.buttonRemoveCurQuestion_Click);
            // 
            // buttonAddNewAnswer
            // 
            this.buttonAddNewAnswer.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddNewAnswer.Location = new System.Drawing.Point(263, 0);
            this.buttonAddNewAnswer.Name = "buttonAddNewAnswer";
            this.buttonAddNewAnswer.Size = new System.Drawing.Size(147, 31);
            this.buttonAddNewAnswer.TabIndex = 4;
            this.buttonAddNewAnswer.Text = "Add New Answer";
            this.buttonAddNewAnswer.UseVisualStyleBackColor = true;
            this.buttonAddNewAnswer.Click += new System.EventHandler(this.buttonAddNewAnswer_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddQuestion.Location = new System.Drawing.Point(113, 0);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(150, 31);
            this.buttonAddQuestion.TabIndex = 3;
            this.buttonAddQuestion.Text = "Add New Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveChanges.Location = new System.Drawing.Point(542, 0);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(144, 31);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save Question Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.Location = new System.Drawing.Point(686, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(110, 31);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPreveous
            // 
            this.buttonPreveous.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPreveous.Location = new System.Drawing.Point(0, 0);
            this.buttonPreveous.Name = "buttonPreveous";
            this.buttonPreveous.Size = new System.Drawing.Size(113, 31);
            this.buttonPreveous.TabIndex = 0;
            this.buttonPreveous.Text = "Previous";
            this.buttonPreveous.UseVisualStyleBackColor = true;
            this.buttonPreveous.Click += new System.EventHandler(this.buttonPreveous_Click);
            // 
            // panelQuestionText
            // 
            this.panelQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestionText.Controls.Add(this.labelQuestionText);
            this.panelQuestionText.Controls.Add(this.labelQuestionValue);
            this.panelQuestionText.Controls.Add(this.textBoxQuestionValue);
            this.panelQuestionText.Controls.Add(this.richTextBoxQuestionText);
            this.panelQuestionText.Location = new System.Drawing.Point(-2, 20);
            this.panelQuestionText.Name = "panelQuestionText";
            this.panelQuestionText.Size = new System.Drawing.Size(273, 205);
            this.panelQuestionText.TabIndex = 3;
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(98, 53);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(70, 13);
            this.labelQuestionText.TabIndex = 6;
            this.labelQuestionText.Text = "QuestionText";
            // 
            // labelQuestionValue
            // 
            this.labelQuestionValue.AutoSize = true;
            this.labelQuestionValue.Location = new System.Drawing.Point(11, 6);
            this.labelQuestionValue.Name = "labelQuestionValue";
            this.labelQuestionValue.Size = new System.Drawing.Size(79, 13);
            this.labelQuestionValue.TabIndex = 5;
            this.labelQuestionValue.Text = "Question Value";
            // 
            // textBoxQuestionValue
            // 
            this.textBoxQuestionValue.Location = new System.Drawing.Point(113, 3);
            this.textBoxQuestionValue.Name = "textBoxQuestionValue";
            this.textBoxQuestionValue.Size = new System.Drawing.Size(158, 20);
            this.textBoxQuestionValue.TabIndex = 4;
            // 
            // richTextBoxQuestionText
            // 
            this.richTextBoxQuestionText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxQuestionText.Location = new System.Drawing.Point(0, 69);
            this.richTextBoxQuestionText.Name = "richTextBoxQuestionText";
            this.richTextBoxQuestionText.Size = new System.Drawing.Size(271, 134);
            this.richTextBoxQuestionText.TabIndex = 3;
            this.richTextBoxQuestionText.Text = "";
            // 
            // hScrollBar1QuestionChng
            // 
            this.hScrollBar1QuestionChng.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1QuestionChng.LargeChange = 1;
            this.hScrollBar1QuestionChng.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar1QuestionChng.Name = "hScrollBar1QuestionChng";
            this.hScrollBar1QuestionChng.Size = new System.Drawing.Size(796, 17);
            this.hScrollBar1QuestionChng.TabIndex = 0;
            this.hScrollBar1QuestionChng.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1QuestionChng_Scroll);
            // 
            // TestEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1DynamicFields);
            this.Controls.Add(this.panel1StaticFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestEditing";
            this.Text = "TestEditing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestEditing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestEditing_FormClosed);
            this.Load += new System.EventHandler(this.TestEditing_Load);
            this.panel1StaticFields.ResumeLayout(false);
            this.panel1StaticFields.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1DynamicFields.ResumeLayout(false);
            this.panelBoolsOuter.ResumeLayout(false);
            this.panelAnswersOuter.ResumeLayout(false);
            this.panelQuestionButtons.ResumeLayout(false);
            this.panelQuestionText.ResumeLayout(false);
            this.panelQuestionText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1NameEdit;
        private System.Windows.Forms.Panel panel1StaticFields;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.Panel panel1DynamicFields;
        private System.Windows.Forms.Label labelTestDescription;
        private System.Windows.Forms.RichTextBox richTextBoxTestDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.HScrollBar hScrollBar1QuestionChng;
        private System.Windows.Forms.Label labelQuestionNum;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Panel panelQuestionText;
        private System.Windows.Forms.RichTextBox richTextBoxQuestionText;
        private System.Windows.Forms.Panel panelBoolValues;
        private System.Windows.Forms.Panel panelQuestionButtons;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPreveous;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Label labelQuestionValue;
        private System.Windows.Forms.TextBox textBoxQuestionValue;
        private System.Windows.Forms.Button buttonAddNewAnswer;
        private System.Windows.Forms.Panel panelAnswersOuter;
        private System.Windows.Forms.Panel panelBoolsOuter;
        private System.Windows.Forms.Button buttonRemoveCurQuestion;
    }
}