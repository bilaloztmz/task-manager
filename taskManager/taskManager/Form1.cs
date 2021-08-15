using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] prosesler;

        void prosesleriListele()
        {
            prosesler = Process.GetProcesses();
            proseslerlistesi.Items.Clear();
            foreach (Process p in prosesler)
            {
                proseslerlistesi.Items.Add(p.ProcessName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            secilenProses.Enabled = false;
            prosesleriListele();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void öldürToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(proseslerlistesi.SelectedIndex < 0)
            {
                MessageBox.Show("Proses seçiniz");
            }
            else
            {
                try
                {
                    string silinecek = prosesler[proseslerlistesi.SelectedIndex].ProcessName;
                    prosesler[proseslerlistesi.SelectedIndex].Kill();
                    MessageBox.Show(silinecek + "  öldürüldü");
                    prosesleriListele();

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    prosesleriListele();
                }
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            secilenProses.Text = proseslerlistesi.SelectedItem.ToString();

        }

        private void threadSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(prosesler[proseslerlistesi.SelectedIndex].ProcessName + " Thread sayısı: " + prosesler[proseslerlistesi.SelectedIndex].Threads.Count.ToString());
                prosesleriListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Proses seçiniz.");
            }
        
        }

        private void kullandığıBellekMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double toplamByte = prosesler[proseslerlistesi.SelectedIndex].PagedMemorySize64 / 1048576;
                MessageBox.Show(prosesler[proseslerlistesi.SelectedIndex].ProcessName + " Kullandığı bellek miktarı:  " + toplamByte.ToString() + "MB");
                //1 mb = 1.048.576 byte
                prosesleriListele();
            }
            catch (Exception)
            {

                MessageBox.Show("Proses seçiniz.");
            }



        }

        private void kullandığıİşlemciYüzdesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyarı.Visible = true;
            try
            {
                PerformanceCounter işlemcideProses = new PerformanceCounter("Process", "% Processor Time", prosesler[proseslerlistesi.SelectedIndex].ProcessName, true);
                double işlemciYüzdesi = işlemcideProses.NextValue();
                Thread.Sleep(1500);
                işlemciYüzdesi = işlemcideProses.NextValue();
                uyarı.Visible = false;
                MessageBox.Show(prosesler[proseslerlistesi.SelectedIndex].ProcessName + " Kullandığı işlemci yüzdesi %" + işlemciYüzdesi.ToString());
                prosesleriListele();
            }
            catch (Exception)
            {

                MessageBox.Show("Proses seçiniz.");

            }





        }
    }
}
