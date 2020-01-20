using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            button2PassTest.Height = button1CreateEdit.Height;
            button2PassTest.Width = button1CreateEdit.Width;



        }

        private void button2PassTest_Click(object sender, EventArgs e)
        {
            Form frm = new TestChoosing("pass");
            //Form frm = new Testing();
            //this.Visible = false;

            frm.ShowDialog();
        }

        private void button1CreateEdit_Click(object sender, EventArgs e)
        {
            Form frm = new TestChoosing("edit");
            frm.ShowDialog();
        }
    }
}
