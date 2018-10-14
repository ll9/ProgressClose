using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new Prog();
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                dialog.Invoke((Action)(() => dialog.Close()));
            });

            dialog.ShowDialog();
            dialog.progressBar1.Style = ProgressBarStyle.Marquee;
            dialog.progressBar1.MarqueeAnimationSpeed = 30;

        }
    }
}
