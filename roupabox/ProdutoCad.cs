using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ProdutoCad
    {
        public ProdutoCad(string pro)
        {
            descPro = pro;
        }
        public string descPro { get; set; }
        public string marcaPro { get; set; }
        public string tamPro { get; set; }
        public string corPro { get; set; }
        public string catPro { get; set; }
        public double valPro { get; set; }
        public double pesoPro { get; set; }
    }
}
