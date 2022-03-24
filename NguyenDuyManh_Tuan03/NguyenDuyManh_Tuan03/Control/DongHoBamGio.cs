using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Control
{
    public partial class DongHoBamGio : UserControl
    {
        public DongHoBamGio()
        {
            InitializeComponent();
        }
        DateTime sttime;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button1.Text = timer1.Enabled ? "Stop" : "Start";
            sttime = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DongHoBamGio_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan giochay = DateTime.Now - sttime; //gio hien tai - gio hien tai
            string text = "";
         
            int miligay = giochay.Milliseconds;
            text += giochay.Hours.ToString() + ":" +
                    giochay.Minutes.ToString() + ":" +
                    giochay.Seconds.ToString();
            label1.Text = text;
            label2.Text = miligay.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (StreamWriter ghi = File.AppendText(@"E:\LuuDuLieuSinhVien\NguyenDuyManh_Tuan03\NguyenDuyManh_Tuan03\Gio.txt")) 
            {
                ghi.WriteLine(label1.Text + Environment.NewLine);
            }
           
        }
    }
}
