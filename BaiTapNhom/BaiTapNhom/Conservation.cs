using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class Conservation : Incomplete
    {
        public Conservation(string noiDung, string[] dapAn, string[] dapAnDung, string doKho) : base(noiDung, dapAn, dapAnDung, doKho)
        {
        }
    }
}
