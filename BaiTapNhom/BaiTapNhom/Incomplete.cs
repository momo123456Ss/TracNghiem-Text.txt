using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class Incomplete
    {
        string noiDung;
        string[] dapAn;
        string[] dapAnDung;
        string doKho;
        public Incomplete(string noiDung, string[] dapAn, string[] dapAnDung, string doKho)
        {
            this.noiDung = noiDung;
            this.dapAn = dapAn;
            this.dapAnDung = dapAnDung;
            this.doKho = doKho;
        }

        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string[] DapAn { get => dapAn; set => dapAn = value; }
        public string[] DapAnDung { get => dapAnDung; set => dapAnDung = value; }
        public string DoKho { get => doKho; set => doKho = value; }
    }
}
