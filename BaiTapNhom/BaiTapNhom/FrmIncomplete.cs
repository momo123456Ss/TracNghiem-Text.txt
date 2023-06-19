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
    public partial class FrmIncomplete : Form
    {
        List<Incomplete> incompletes = new List<Incomplete>();
        public FrmIncomplete()
        {
            InitializeComponent();
        }

        private void FrmIncomplete_Load(object sender, EventArgs e)
        {
            //listViewDeThi2.Clear();
            //listViewDeThi2.View = View.Details;
            //listViewDeThi2.Columns.Add("Noi Dung", 200, HorizontalAlignment.Center);
            ////listViewDeThi2.Columns.Add("Danh sach DapAn", 200, HorizontalAlignment.Center);
            ////listViewDeThi2.Columns.Add("Danh sach DapAn Dung", 200, HorizontalAlignment.Center);
            //listViewDeThi2.Columns.Add("Do kho", 200, HorizontalAlignment.Center);
           
                try
                {
                    using (StreamReader reader = new StreamReader(@"DeThi2.txt"))
                    {
                        richDeThi2.Text = reader.ReadToEnd();
                        //while (!reader.EndOfStream)
                        //{
                        //    string noiDung = reader.ReadLine();
                        //    string[] dapAn = new string[15];
                        //    for (int i = 0; i < 15; i++)
                        //    {

                        //        dapAn[i] = reader.ReadLine();
                        //    }
                        //    string[] dapAnDung = new string[15];
                        //    for (int i = 0; i < 15; i++)
                        //    {

                        //        dapAnDung[i] = reader.ReadLine();
                        //    }
                        //    string doKho = reader.ReadLine();
                        //    Incomplete ch = new Incomplete(noiDung, dapAn, dapAnDung, doKho);
                        //    incompletes.Add(ch);
                        //}
                    }
                }
                catch
                {

                }
            //foreach(Incomplete ch in incompletes)
            //{
            //    ListViewItem item = new ListViewItem(ch.NoiDung);
               
            //    item.SubItems.Add(ch.DoKho);
            //    listViewDeThi2.Items.Add(item);
            //}
        }
    }
}
