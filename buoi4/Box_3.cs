using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Box_3
    {
        private double chieu_dai;
        private double chieu_rong;
        private double chieu_cao;

        public double tinhThe_Tich()
        {
            return chieu_dai * chieu_rong * chieu_cao;
        }

        public void setChieuRong(double r)
        {
            chieu_rong = r;
        }

        public void setChieuDai(double d)
        {
            chieu_dai = d;
        }

        public void setChieuCao(double h)
        {
            chieu_cao = h;
        }

        public static Box_3 operator +(Box_3  b, Box_3 c)
        {
            Box_3 box = new Box_3();
            box.chieu_dai = b.chieu_dai + c.chieu_dai;
            box.chieu_rong = b.chieu_rong + c.chieu_rong;
            box.chieu_cao = b.chieu_cao + c.chieu_cao;
            return box;
        }
    }
}
