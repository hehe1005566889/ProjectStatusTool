using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCollect
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UI(this).Show();
            Hide();
            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CSUI(this).Show();
            Hide();
            GC.Collect();
        }
    }
}
