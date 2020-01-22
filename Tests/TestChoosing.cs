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

            try
            {
                _dm.LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Can't load Data");
            }

            _formMode = mode;

        }

        private void TestChoosing_Load(object sender, EventArgs e)
        {
            Owner.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;

            UpdateChoosingMenu();

            if (_formMode != "edit")
                HideEditMenu();
        }

        private void HideEditMenu()
        {
            textBoxRemoveTestName.Visible = false;
            buttonRemoveTest.Visible = false;
            labelRemoveTesName.Visible = false;
            labelTestNameAdd.Visible = false;
            labelNewTestDescription.Visible = false;
            buttonAddTest.Visible = false;
            textBoxNameToAdd.Visible = false;
            richTextBoxNewTestDescription.Visible = false;
            buttonSaveToFile.Visible = false;
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
            menuStrip1.Items.Clear();
            _dm.TestList.ForEach(z => menuStrip1.Items.Add(z.Name));
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

        private void buttonRemoveTest_Click(object sender, EventArgs e)
        {
            try
            {
                _dm.TestList.RemoveAt(_dm.TestList.FindIndex(x => x.Name == textBoxRemoveTestName.Text));
                UpdateChoosingMenu();
            }
            catch (Exception)
            {
                MessageBox.Show($"Nothing to remove", "Error");
            }

        }

        private void labelTestNameAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            if (textBoxNameToAdd.Text != "")
            {
                _dm.TestList.Add(new Test(textBoxNameToAdd.Text, richTextBoxNewTestDescription.Text));
                UpdateChoosingMenu();
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                _dm.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't save");
            }
        }
    }
}
