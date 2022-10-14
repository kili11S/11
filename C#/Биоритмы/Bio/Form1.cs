using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            double Physic, Intel, Emot;
            DateTime birth = dtpickerBirth.Value;
            DateTime current = DateTime.Today;
            TimeSpan IntrevalOfDates = dtpick2.Value - dtpick1.Value;
            TimeSpan IntervalCurrentBirth = DateTime.Today - dtpickerBirth.Value;

            chart1.Series[0].Points.Clear(); chart1.Series[1].Points.Clear(); chart1.Series[2].Points.Clear();

            if (rbWeek.Checked) { n = 7; }
            if (rbMounth.Checked) { n = 30; }
            if (rbChoice.Checked) { n = IntrevalOfDates.Days; }

            for (int i = 0; i < n; i++)
            {
                Physic = Math.Sin(2 * Math.PI * (IntervalCurrentBirth.Days + i) / 23);
                Emot = Math.Sin(2 * Math.PI * (IntervalCurrentBirth.Days + i) / 28);
                Intel = Math.Sin(2 * Math.PI * (IntervalCurrentBirth.Days + i) / 33);
                if (checkBox1.Checked == Enabled) { chart1.Series["Series1"].Points.AddXY(i, Physic); }
                if (checkBox2.Checked == Enabled) { chart1.Series["Series2"].Points.AddXY(i, Emot); }
                if (checkBox3.Checked == Enabled) { chart1.Series["Series3"].Points.AddXY(i, Intel); }
                    
            }

        }
        
    }
}
