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
    public partial class Testing : Form
    {

        private Test _currentTest;

        private double[] _score;


        private void InitQuestionsCount()
        {
            hScrollBarQuestChng.Maximum = _currentTest.QuestionList.Count - 1;
            _score = new double[_currentTest.QuestionList.Count];
        }

        private void UpdateForm()
        {
            richTextBoxQuestionText.Text = _currentTest.QuestionList[hScrollBarQuestChng.Value].QuestionText;
            label1QuestionNum.Text = $"Question - {hScrollBarQuestChng.Value.ToString()}";
            label1QuestionValue.Text = $"Question Value - {_currentTest.QuestionList[hScrollBarQuestChng.Value].QuestionValue}";

            checkedListBox1Answers.Items.Clear();
            foreach (var item in _currentTest.QuestionList[hScrollBarQuestChng.Value].Answers)
                checkedListBox1Answers.Items.Add(item.Key);

        }
        public Testing(Test current)
        {
            _currentTest = current;

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxQuestionText.ReadOnly = true;
            richTextBoxQuestionText.BackColor = System.Drawing.SystemColors.Window;
            Owner.Visible = false;
            InitQuestionsCount();
            UpdateForm();
        }

        private void hScrollBarQuestChng_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateForm();
        }

        private void button1Next_Click(object sender, EventArgs e)
        {
            if (hScrollBarQuestChng.Value < hScrollBarQuestChng.Maximum)
                hScrollBarQuestChng.Value++;
            UpdateForm();
        }

        private void button1Previous_Click(object sender, EventArgs e)
        {
            if (hScrollBarQuestChng.Value > hScrollBarQuestChng.Minimum)
                hScrollBarQuestChng.Value--;
            UpdateForm();

        }

        private void button1SaveAnswer_Click(object sender, EventArgs e)
        {

            bool[] checkedItems = new bool[checkedListBox1Answers.Items.Count];

            for (int i = 0; i < checkedListBox1Answers.Items.Count; i++)
            {
                if (checkedListBox1Answers.CheckedItems.Contains(checkedListBox1Answers.Items[i]))
                    checkedItems[i] = true;
                else
                    checkedItems[i] = false;
            }

            Question _currentQuestion = _currentTest.QuestionList[hScrollBarQuestChng.Value];

            _score[hScrollBarQuestChng.Value] = _currentQuestion.Answer(checkedItems);
        }

        private void button1Finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Maximum Test's value = {_currentTest.QuestionList.Sum(x => x.QuestionValue)}\nYour score = {_score.Sum()}", "Test Result");
        }

        private void Testing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
