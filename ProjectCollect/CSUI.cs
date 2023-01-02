using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCollect
{
    public partial class CSUI : Form
    {
        public CSUI(StartUp up)
        {
            this.up = up;
            search = new CSSearch(null);
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ClsBox.DoubleClick += ClsBox_DoubleClick;
            IteBox.DoubleClick += IteBox_DoubleClick;
            EnuBox.DoubleClick += EnuBox_DoubleClick;
            AnoBox.DoubleClick += AnoBox_DoubleClick;
            RecBox.DoubleClick += RecBox_DoubleClick;
            base.OnLoad(e);
        }

        private void RecBox_DoubleClick(object sender, EventArgs e)
        {
            if (RecBox.SelectedIndex == -1)
                return;
            Process.Start(search.RecoedNamseFile[RecBox.SelectedIndex]);
        }

        private void AnoBox_DoubleClick(object sender, EventArgs e)
        {
            if (AnoBox.SelectedIndex == -1)
                return;
          //  Process.Start(search.AnnotationNamseFile[AnoBox.SelectedIndex]);
        }

        private void EnuBox_DoubleClick(object sender, EventArgs e)
        {
            if (EnuBox.SelectedIndex == -1)
                return;
            Process.Start(search.EnumNamseFile[EnuBox.SelectedIndex]);
        }

        private void IteBox_DoubleClick(object sender, EventArgs e)
        {
            if (IteBox.SelectedIndex == -1)
                return;
            Process.Start(search.InterfaceNamseFile[IteBox.SelectedIndex]);
        }

        private void ClsBox_DoubleClick(object sender, EventArgs e)
        {
            if (ClsBox.SelectedIndex == -1)
                return;
            Process.Start(search.ClassNamseFile[ClsBox.SelectedIndex]);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            up.Show();
            GC.Collect();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "Choose You Root Dir"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    Path.Text = dialog.SelectedPath;
            }
            GC.Collect();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Path.Text is null || Path.Text.Length is 0)
            {
                MessageBox.Show("Empty Or Null Path (=^=)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!Directory.Exists(Path.Text))
            {
                MessageBox.Show("Path Can't Found xD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime time = DateTime.Now;
            await search.OnSearch(Path.Text);
            TimeSpan bt = DateTime.Now - time;
            DisplayInfo();
            MessageBox.Show(string.Format(
                "Search Done! (In {0}h.{1}m.{2}s.{3}ms)",
                bt.Hours,
                bt.Minutes,
                bt.Seconds,
                bt.Milliseconds
            ), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayInfo()
        {
            ClsBox.Items.Clear();
            IteBox.Items.Clear();
            EnuBox.Items.Clear();
            AnoBox.Items.Clear();
            RecBox.Items.Clear();

            Display.Text = string.Format(
                " Class Count {0} \n Code Lines {1} \n Exception Using {2} \n Instance Create(Using new) {3} \n TryCatch Using {4} \n Interface Count {5} \n Enum Class Count {6} \n Annotation Class Count {7} \n Stuct Class Count {8} \n Using Count {9}",
                search.count,
                search.len,
                search.ecount,
                search.ncount,
                search.tcount,
                search.itecount,
                search.enucount,
                search.anocount,
                search.rcocount,
                search.icount
            );

            ClsBox.Items.AddRange(search.ClassNamse.ToArray());
            IteBox.Items.AddRange(search.InterfaceNamse.ToArray());
            EnuBox.Items.AddRange(search.EnumNamse.ToArray());
           // AnoBox.Items.AddRange(search.AnnotationNamse.ToArray());
            RecBox.Items.AddRange(search.RecoedNamse.ToArray());
            GC.Collect();
        }

        private readonly StartUp up;
        private readonly CSSearch search;
    }
}
