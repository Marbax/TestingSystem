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

        private string _formMode;
        public TestChoosing(string mode)
        {
            InitializeComponent();
            _formMode = mode;
        }

        private void TestChoosing_Load(object sender, EventArgs e)
        {

            _dm.TestList.ForEach(z => menuStrip1.Items.Add(z.Name));
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
        }


        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

            Test peekedTest = _dm.TestList.Where(x => x.Name == e.ClickedItem.Text).FirstOrDefault();

            if (_formMode == "pass")
                if (peekedTest.QuestionList.Count > 0)
                {
                    Form frm = new Testing(peekedTest) { Text = peekedTest.Name};
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Empty test", "Unresolveable task");

            if (_formMode == "edit")
            {
                //Form frm = new Testing(peekedTest);
                //frm.ShowDialog();
                MessageBox.Show("Development in progress");
            }
        }
    }
}
