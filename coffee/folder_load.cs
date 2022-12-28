using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee
{
    public partial class folder_load : Form
    {
        Timer timer;
        int counter = 0;

        DateTime Startime;
        public folder_load()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 120000;
            timer.Tick += RunEvent;
            timer.Start();

            //timer1.Interval = 500;
            //timer1.Start();


            Startime = DateTime.Now;
        }

        private void RunEvent(object sender, EventArgs e)
        {
            SendKeys.Send("{F15}");
        }

        private void folder_load_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var time = DateTime.Now - Startime;
            //label1.Text = time.Hours + ":" + time.Minutes + ":" + time.Seconds + ":"  + time.Milliseconds;
        }
    }
}
