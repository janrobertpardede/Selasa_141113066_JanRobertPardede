using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime now = DateTime.Now;
        private void vermin_Scroll(object sender, ScrollEventArgs e)
        {
            minteks.Text = (vermin.Maximum - vermin.Value).ToString();
            if (vermax.Value > vermin.Value)
            {
                vermax.Value = vermin.Value;
                minteks.Text = (vermax.Maximum - vermax.Value).ToString();
            }
            tanggal.MinDate = now.AddYears(vermax.Value - vermax.Maximum);
            tanggal.MaxDate = now.AddYears(vermin.Value - vermin.Maximum);
        }

        private void vermax_Scroll(object sender, ScrollEventArgs e)
        {
            maxteks.Text = (vermax.Maximum - vermax.Value).ToString();
            if (vermax.Value > vermin.Value)
            {
                vermin.Value = vermax.Value;
                minteks.Text = (vermin.Maximum - vermin.Value).ToString();
            }
            tanggal.MaxDate = now.AddYears(vermin.Value - vermin.Maximum);
            tanggal.MinDate = now.AddYears(vermax.Value - vermax.Maximum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tanggal.MaxDate = now.AddYears(vermin.Value - vermin.Maximum);
            tanggal.MinDate = now.AddYears(vermax.Value - vermax.Maximum);
        }
    }
}
