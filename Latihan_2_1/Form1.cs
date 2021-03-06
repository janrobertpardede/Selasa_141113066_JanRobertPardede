﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCSharpLanjutanLatihan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime SetTahunAwal = new DateTime(2016, 1, 1);
            for (int i = SetTahunAwal.DayOfYear; i <=SetTahunAwal.DayOfYear; i++)
            {
                if (SetTahunAwal.DayOfWeek.ToString() == "Sunday" || SetTahunAwal.DayOfWeek.ToString() == "Saturday")
                {
                    monthCalendar1.AddBoldedDate(SetTahunAwal);
                    
                }

                SetTahunAwal = SetTahunAwal.AddDays(1);
            }
            DateTime TanggalLahir = new DateTime(1995, 06, 08);
            monthCalendar1.AddAnnuallyBoldedDate(TanggalLahir);
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if ((int)NuPBulan.Value == 0 || (int)NuPTanggal.Value == 0)
            {
                MessageBox.Show("Inputan Tidak Valid");

            }
            else
            {
                DateTime Tanggal = new DateTime(2016, (int)NuPBulan.Value, (int)NuPTanggal.Value);
                monthCalendar1.AddBoldedDate(Tanggal);
            }
            
        }

        private void NuPBulan_ValueChanged(object sender, EventArgs e)
        {
            if ((int)NuPBulan.Value == 1)
            { LblBulan.Text = "Januari"; }
            else if ((int)NuPBulan.Value == 2)
            { LblBulan.Text = "Februari"; }
            else if ((int)NuPBulan.Value == 3)
            { LblBulan.Text = "Maret"; }
            else if ((int)NuPBulan.Value == 4)
            { LblBulan.Text = "April"; }
            else if ((int)NuPBulan.Value == 5)
            { LblBulan.Text = "Mei"; }
            else if ((int)NuPBulan.Value == 6)
            { LblBulan.Text = "Juni"; }
            else if ((int)NuPBulan.Value == 7)
            { LblBulan.Text = "Juli"; }
            else if ((int)NuPBulan.Value == 8)
            { LblBulan.Text = "Agustus"; }
            else if ((int)NuPBulan.Value == 9)
            { LblBulan.Text = "September"; }
            else if ((int)NuPBulan.Value == 10)
            { LblBulan.Text = "Oktober"; }
            else if ((int)NuPBulan.Value == 11)
            { LblBulan.Text = "November"; }
            else if ((int)NuPBulan.Value == 12)
            { LblBulan.Text = "Desember"; }
            else
            { LblBulan.Text = "Bulan"; }
            NuPTanggal.Maximum = DateTime.DaysInMonth(2016, (int)NuPBulan.Value);
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DateTime Tanggal = new DateTime(2016, (int)NuPBulan.Value, (int)NuPTanggal.Value);
            monthCalendar1.RemoveBoldedDate(Tanggal);
        }

       
    }
}
