using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionNS;

namespace Tests
{
    public partial class Testing : Form
    {
        private DataManager _dm = new DataManager();

        private void InitQuestList()
        {

            _dm.Test.Add(new Question("Что есть жизнь?",
                new KeyValuePair<string, bool>("Еда", false),
                new KeyValuePair<string, bool>("Кекс", false),
                new KeyValuePair<string, bool>("Котики", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            _dm.Test.Add(new Question("What is love?",
                new KeyValuePair<string, bool>("Games", false),
                new KeyValuePair<string, bool>("Baby dont hurt me", false),
                new KeyValuePair<string, bool>("Dev", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            _dm.Test.Add(new Question("Akhuna matata?",
                new KeyValuePair<string, bool>("Dont worry", false),
                new KeyValuePair<string, bool>("Be happy", false),
                new KeyValuePair<string, bool>("Life is simple", false),
                new KeyValuePair<string, bool>("There are three simple words", true)));

        }

        private void InitQuestionsCount()
        {
            hScrollBarQuestChng.Maximum = _dm.Test.Count - 1;
        }

        private void PeekQuestion()
        {
            label1Question.Text = _dm.Test[hScrollBarQuestChng.Value].QuestionText;

            checkedListBox1Answers.Items.Clear();
            foreach (var item in _dm.Test[hScrollBarQuestChng.Value].Answers)
                checkedListBox1Answers.Items.Add(item.Key);

        }
        public Testing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitQuestList();
            InitQuestionsCount();
            PeekQuestion();
        }

        private void hScrollBarQuestChng_Scroll(object sender, ScrollEventArgs e)
        {
            PeekQuestion();



        }
    }
}
