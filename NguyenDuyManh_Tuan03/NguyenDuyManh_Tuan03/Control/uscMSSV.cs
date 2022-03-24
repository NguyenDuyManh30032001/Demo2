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
    public partial class uscMSSV : UserControl
    {
        public uscMSSV()
        {
            InitializeComponent();
        }

        private void uscMSSV_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str;
            DocFile doc = new DocFile(textBox2.Text);
            string[] lines = File.ReadAllLines(doc.Dd);
            foreach (string s in lines)
            {
                str = s.Split(',');
                if (textBox1.Text == str[0].ToString())
                {
                    lb_tensv.Text = str[1].ToString();
                    lb_malop.Text = str[2].ToString();
                    lb_ngaysinh.Text = str[3].ToString();
                    lb_gioitinh.Text = str[4].ToString();
                    lb_cmnd.Text = str[5].ToString();
                    return;
                }
                
            }
            MessageBox.Show("Khong tim thay thong tin sv!!!","Thong bao");
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog d = new OpenFileDialog())
            {
                d.Filter = "Chon file (txt) | *.txt;";
                d.Multiselect = false;
                if(d.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = d.FileName;
                }
            }
        }
    }
}
