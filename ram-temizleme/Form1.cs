using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace ram_temizleme
{
    public partial class Form1 : Form
    {
        private PerformanceCounter ramCounter;
        private PerformanceCounter committedBytesCounter;
        private PerformanceCounter availableBytesCounter;
        private PerformanceCounter commitLimitCounter;

        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EmptyWorkingSet(IntPtr hProcess);

        public Form1()
        {
            InitializeComponent();
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", null, true);
            committedBytesCounter = new PerformanceCounter("Memory", "Committed Bytes", null, true);
            availableBytesCounter = new PerformanceCounter("Memory", "Available Bytes", null, true);
            commitLimitCounter = new PerformanceCounter("Memory", "Commit Limit", null, true);

            timer1.Interval = 1000; // 1 saniye
            timer2.Interval = 1000; // 1 saniye
            timer3.Interval = 1000; // 1 saniye
            timer4.Interval = 1000; // 1 saniye
            timer5.Interval = 1000; // 1 saniye
            timer6.Interval = 1000; // 1 saniye

            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            timer3.Tick += timer3_Tick;
            timer4.Tick += timer4_Tick;
            timer5.Tick += timer5_Tick;
            timer6.Tick += timer6_Tick;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();

            btnTemizle.Click += BtnTemizle_Click;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float availableRam = ramCounter.NextValue();
            float totalRam = GetTotalMemoryInMB();
            float usedRam = totalRam - availableRam;

            lblKullanýlan.Text = $"{usedRam:F0} MB";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            float availableRam = ramCounter.NextValue();
            lblKullanýlabilir.Text = $"{availableRam:F0} MB";
        }

        private float GetTotalMemoryInMB()
        {
            var computerInfo = new ComputerInfo();
            return computerInfo.TotalPhysicalMemory / (1024 * 1024);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblToplam.Text = $"{GetTotalMemoryInMB():F0} MB";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    try
                    {
                        EmptyWorkingSet(process.Handle);
                    }
                    catch
                    {
                        // Bireysel süreçler için istisnalarý yoksay
                    }
                }
                MessageBox.Show("Bellek temizlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Bireysel süreçler için istisnalarý yoksay
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                float usedVirtualMemoryBytes = committedBytesCounter.NextValue();
                float usedVirtualMemoryMB = usedVirtualMemoryBytes / 1024f / 1024f;

                lblSanalKullanýlan.Text = $"{usedVirtualMemoryMB:F0} MB";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"timer4_Tick hatasý: {ex.Message}");
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                // Toplam sanal bellek miktarýný al
                float totalVirtualMemoryMB = GetTotalVirtualMemoryInMB();

                // Kullanýlan sanal bellek miktarýný al
                float usedVirtualMemoryMB = GetUsedVirtualMemoryInMB();

                // Kullanýlabilir sanal bellek miktarýný hesapla
                float availableVirtualMemoryMB = totalVirtualMemoryMB - usedVirtualMemoryMB;

                // Kullanýlabilir sanal bellek miktarýný ekrana yazdýr
                lblSanalKullanýlabilir.Text = $"{availableVirtualMemoryMB:F0} MB";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"timer5_Tick hatasý: {ex.Message}");
            }
        }

        private float GetTotalVirtualMemoryInMB()
        {
            // Toplam sanal bellek miktarýný almak için commitLimitCounter'ý kullan
            float totalVirtualMemoryBytes = commitLimitCounter.NextValue();
            return totalVirtualMemoryBytes / 1024f / 1024f;
        }

        private float GetUsedVirtualMemoryInMB()
        {
            // Kullanýlan sanal bellek miktarýný almak için committedBytesCounter'ý kullan
            float usedVirtualMemoryBytes = committedBytesCounter.NextValue();
            return usedVirtualMemoryBytes / 1024f / 1024f;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            try
            {
                float totalVirtualMemoryBytes = commitLimitCounter.NextValue();
                float totalVirtualMemoryMB = totalVirtualMemoryBytes / 1024f / 1024f;

                lblSanalToplam.Text = $"{totalVirtualMemoryMB:F0} MB";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }

    }
}