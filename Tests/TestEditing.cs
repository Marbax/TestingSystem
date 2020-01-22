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
            try
            {
                _peekedTest.QuestionList[hScrollBar1QuestionChng.Value] = ChangeQuestion();
                MessageBox.Show("Changes successfully applied.", "Complete");
                UpdateForm();
            }
            catch (ApplicationException app_ex)
            {
                MessageBox.Show(app_ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown Error \n{ex.Message}", "ERROR");
            }
        }

        private void buttonAddNewAnswer_Click(object sender, EventArgs e)
        {
            panelAnswers.Controls.Add(new TextBox() { Text = "", Dock = DockStyle.Bottom, Name = $"Answer_{panelAnswers.Controls.Count}" });
            panelBoolValues.Controls.Add(new CheckBox() { Dock = DockStyle.Bottom, Name = $"CheckBox_{panelBoolValues.Controls.Count}" });
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _peekedTest.QuestionList.Add(ChangeQuestion());
                hScrollBar1QuestionChng.Maximum++;
                hScrollBar1QuestionChng.Value = hScrollBar1QuestionChng.Maximum;
                MessageBox.Show("Question successfully added.", "Complete");
                UpdateForm();
            }
            catch (ApplicationException app_ex)
            {
                MessageBox.Show(app_ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown Error \n{ex.Message}", "ERROR");
            }
        }

        private Question ChangeQuestion()
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
                        if (newQuestValue < 1)
                            throw new ApplicationException(errorMessage += "\nQuestion value can't be lover than 1.");
                    }
                    catch (Exception)
                    {
                        errorMessage += "\nIncorrect Question Value";
                        throw new ApplicationException(errorMessage);
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
                    return new Question(richTextBoxQuestionText.Text, newQuestValue, newAnswers.ToArray());
                }
                else
                    errorMessage += "\nQuestion Value can't be empty.";
            }
            else
                errorMessage += "Question Text can't be empty.";

            throw new ApplicationException(errorMessage);
        }

        private void buttonRemoveCurQuestion_Click(object sender, EventArgs e)
        {
            if (hScrollBar1QuestionChng.Maximum > 0)
            {
                _peekedTest.QuestionList.RemoveAt(hScrollBar1QuestionChng.Value);
                hScrollBar1QuestionChng.Maximum--;
                UpdateForm();
            }
            else if (hScrollBar1QuestionChng.Maximum == 0 && _peekedTest.QuestionList.Count > 0)
            {
                _peekedTest.QuestionList.RemoveAt(hScrollBar1QuestionChng.Value);
                richTextBoxQuestionText.Clear();
                textBoxQuestionValue.Clear();
                panelAnswers.Controls.Clear();
                panelBoolValues.Controls.Clear();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Nothing to remove", "Error");
            }
        }
    }
}
