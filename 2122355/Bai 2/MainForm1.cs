using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Bạn chọn giới tính là Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            MessageBox.Show("Bạn chọn giới tính là Nữ", "Thông báo");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor= Color.Green;
        }
    }
}
