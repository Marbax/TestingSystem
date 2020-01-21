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
            Owner.Visible = false;
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
                    Form frm = new Testing(peekedTest) { Text = peekedTest.Name };
                    frm.ShowDialog(this);
                }
                else
                    MessageBox.Show("Empty test", "Unresolveable task");

            if (_formMode == "edit")
            {
                Form frm = new TestEditing(ref peekedTest) { Text = $"Editting the {peekedTest.Name}" };
                if (frm.ShowDialog(this) == DialogResult.OK)
                    UpdateChoosingMenu();
            }
        }

        public void UpdateChoosingMenu()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Text = _dm.TestList[i].Name;
            }
        }
        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
        }

        private void TestChoosing_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void TestChoosing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
