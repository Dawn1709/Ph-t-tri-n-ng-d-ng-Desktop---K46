using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212355
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                txtHinh.Text = path;
                pictureBox1.Image = Image.FromFile(path);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtHvT.Clear    ();
            txtEmail.Clear ();
            txtDC.Clear ();
            maskedTextBox1.Clear ();
            maskedTextBox2.Clear ();
            dtpNgaySinh.Value=DateTime.Now;
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtHinh.Clear ();
            pictureBox1.Image = null;
        }
    }
}
