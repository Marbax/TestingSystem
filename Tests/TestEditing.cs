using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClass;

namespace Tests
{
    public partial class TestEditing : Form
    {
        Test _peekedTest;
        public TestEditing(ref Test peekedTest)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _peekedTest = peekedTest;
            textBox1NameEdit.Text = peekedTest.Name;
            richTextBoxTestDescription.Text = peekedTest.Description;
        }

        private void TestEditing_Load(object sender, EventArgs e)
        {
            Owner.Visible = false;
            InitQuestionsCount();
            UpdateForm();
        }

        private void textBox1NameEdit_TextChanged(object sender, EventArgs e)
        {
        }

        private void TestEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void TestEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
        private void richTextBox1TestDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1SaveAndExit_Click(object sender, EventArgs e)
        {

            if (textBox1NameEdit.Text.Trim(' ') != "")
            {
                _peekedTest.Name = textBox1NameEdit.Text;
                _peekedTest.Description = richTextBoxTestDescription.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Test's name can't be empty");
        }

        private void UpdateForm()
        {
            labelQuestionNum.Text = $"Question - {hScrollBar1QuestionChng.Value.ToString()}";

            if (_peekedTest.QuestionList.Count > 0)
            {
                richTextBoxQuestionText.Text = _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].QuestionText;
                textBoxQuestionValue.Text = _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].QuestionValue.ToString();


                panelAnswers.Controls.Clear();
                panelBoolValues.Controls.Clear();
                int index = 0;
                bool answerFlag = false;
                foreach (var item in _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].Answers)
                {
                    answerFlag = item.Value;
                    panelAnswers.Controls.Add(new TextBox() { Text = item.Key, Dock = DockStyle.Top, Name = $"Answer_{index}" });
                    panelBoolValues.Controls.Add(new CheckBox() { Dock = DockStyle.Top, Name = $"CheckBox_{index}", Checked = answerFlag });
                    index++;
                }
            }
        }

        private void InitQuestionsCount()
        {
            hScrollBar1QuestionChng.Maximum = _peekedTest.QuestionList.Count > 0 ? _peekedTest.QuestionList.Count - 1 : 0;
        }

        private void hScrollBar1QuestionChng_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateForm();
        }

        private void buttonPreveous_Click(object sender, EventArgs e)
        {
            if (hScrollBar1QuestionChng.Value > hScrollBar1QuestionChng.Minimum)
            {
                hScrollBar1QuestionChng.Value--;
                UpdateForm();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (hScrollBar1QuestionChng.Value < hScrollBar1QuestionChng.Maximum)
            {
                hScrollBar1QuestionChng.Value++;
                UpdateForm();
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            double newQuestValue = 0;
            SortedList<string, bool> newAnswers = new SortedList<string, bool>();
            string errorMessage = "";
            if (richTextBoxQuestionText.Text.Trim(' ') != "")
            {
                if (textBoxQuestionValue.Text.Trim(' ') != "")
                {
                    try
                    {
                        newQuestValue = double.Parse(textBoxQuestionValue.Text.Trim(' '));
                    }
                    catch (Exception)
                    {
                        errorMessage += "\nIncorrect Question Value";
                        MessageBox.Show(errorMessage, "Icnorrect Data");
                    }

                    for (int i = panelAnswers.Controls.Count - 1; i >= 0; i--)
                    {
                        if (panelAnswers.Controls[i].Text.Trim(' ') != "")
                        {
                            if (((CheckBox)panelBoolValues.Controls[i]).Checked)
                                newAnswers.Add(panelAnswers.Controls[i].Text.Trim(' '), true);
                            else
                                newAnswers.Add(panelAnswers.Controls[i].Text.Trim(' '), false);
                        }
                    }
                    _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].Answers.Clear();
                    _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].Answers = newAnswers;
                    _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].QuestionText = richTextBoxQuestionText.Text;
                    _peekedTest.QuestionList[hScrollBar1QuestionChng.Value].QuestionValue = newQuestValue;
                    MessageBox.Show("Changes successfully applied.", "Saved");
                    UpdateForm();
                }
                else
                {
                    errorMessage += "\nQuestion Value can't be empty.";
                    MessageBox.Show(errorMessage, "Icnorrect Data");
                }
            }
            else
            {
                errorMessage += "Question Text can't be empty.";
                MessageBox.Show(errorMessage, "Icnorrect Data");
            }
        }
    }
}
