using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class CauHoi
    {
        string noiDung;
        string[] dapAn;
        string dapAnDung;
        public CauHoi(string noiDung, string[] dapAn, string dapAnDung)
        {
            this.noiDung = noiDung;
            this.dapAn = dapAn;
            this.dapAnDung = dapAnDung;
        }

        public string DapAnDung { get => dapAnDung; set => dapAnDung = value; }
        public string[] DapAn { get => dapAn; set => dapAn = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        
    }
}
