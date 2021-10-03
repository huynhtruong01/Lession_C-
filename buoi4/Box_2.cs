using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Box_2
    {
        private double chieu_dai;
        private double chieu_rong;
        private double chieu_cao;

        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }

        public void setChieuRong(double bre)
        {
            chieu_rong = bre;
        }

        public void setChieuCao(double hei)
        {
            chieu_cao = hei;
        }

        public double tinhTheTich()
        {
            return chieu_dai * chieu_cao * chieu_rong;
        }
    }
}
