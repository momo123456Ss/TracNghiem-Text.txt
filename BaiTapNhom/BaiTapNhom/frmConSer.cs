using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BaiTapNhom
{
    public partial class frmConSer : Form
    {
        public frmConSer()
        {
            InitializeComponent();
        }

        private void frmConSer_Load(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader reader = new StreamReader(@"DeThi3.txt"))
                {
                    richDeThi3.Text = reader.ReadToEnd();
                }
            }
            catch
            {
                MessageBox.Show("Khong tim thay DeThi3","Thong Bao");
            }
        }
    }
}
