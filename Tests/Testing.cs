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

        private void InitQuestionsCount()
        {
            hScrollBarQuestChng.Maximum = _currentTest.QuestionList.Count - 1;
        }

        private void PeekQuestion()
        {
            label1Question.Text = _currentTest.QuestionList[hScrollBarQuestChng.Value].QuestionText;

            checkedListBox1Answers.Items.Clear();
            foreach (var item in _currentTest.QuestionList[hScrollBarQuestChng.Value].Answers)
                checkedListBox1Answers.Items.Add(item.Key);

        }
        public Testing(Test current)
        {
            _currentTest = current;
            //checkedListBox1Answers.MultiColumn = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitQuestionsCount();
            PeekQuestion();
        }

        private void hScrollBarQuestChng_Scroll(object sender, ScrollEventArgs e)
        {
            PeekQuestion();
        }

        private void button1Next_Click(object sender, EventArgs e)
        {
            if (hScrollBarQuestChng.Value < hScrollBarQuestChng.Maximum)
                hScrollBarQuestChng.Value++;
            PeekQuestion();
        }

        private void button1Previous_Click(object sender, EventArgs e)
        {
            if (hScrollBarQuestChng.Value > hScrollBarQuestChng.Minimum)
                hScrollBarQuestChng.Value--;
            PeekQuestion();

        }
    }
}
