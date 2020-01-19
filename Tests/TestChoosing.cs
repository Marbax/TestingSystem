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

    public partial class TestChoosing : Form
    {
        private DataManager _dm = new DataManager();

        private void InitTestList()
        {
            Test testTest = new Test("Testing Test", "Test for testing");

            testTest.QuestionList.Add(new Question("Что есть жизнь?",
                new KeyValuePair<string, bool>("Еда", false),
                new KeyValuePair<string, bool>("Кекс", false),
                new KeyValuePair<string, bool>("Котики", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            testTest.QuestionList.Add(new Question("What is love?",
                new KeyValuePair<string, bool>("Games", false),
                new KeyValuePair<string, bool>("Baby dont hurt me", false),
                new KeyValuePair<string, bool>("Dev", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            testTest.QuestionList.Add(new Question("Akhuna matata?",
                new KeyValuePair<string, bool>("Dont worry", false),
                new KeyValuePair<string, bool>("Be happy", false),
                new KeyValuePair<string, bool>("Life is simple", false),
                new KeyValuePair<string, bool>("There are three simple words", true)));

            _dm.TestList.Add(testTest);
            _dm.TestList.Add(new Test("tmp", "tmp"));
            _dm.TestList.Add(new Test("tmp", "tmp"));
            _dm.TestList.Add(new Test("tmp", "tmp"));
            _dm.TestList.Add(new Test("tmp", "tmp"));
        }
        public TestChoosing()
        {
            InitializeComponent();
        }

        private void TestChoosing_Load(object sender, EventArgs e)
        {
            InitTestList();

            //_dm.TestList.ForEach(z => groupBox1TestCollection.Controls.Add(new RadioButton() { Text = z.Name, Dock = DockStyle.Top }));
            _dm.TestList.ForEach(z => menuStrip1.Items.Add(z.Name));
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;

        }


        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

            Form frm = new Testing(_dm.TestList.Where(x => x.Name == e.ClickedItem.Text).FirstOrDefault());

            frm.ShowDialog();

        }
    }
}
