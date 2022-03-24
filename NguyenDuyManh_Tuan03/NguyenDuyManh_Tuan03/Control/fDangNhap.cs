using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class fDangNhap : UserControl
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDangNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui long nhap tai khoan mat khau!!!");
            }
        }
    }
}
