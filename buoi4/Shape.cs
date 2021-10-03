using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Shape
    {
        protected int chieu_rong;
        protected int chieu_cao;

        public void setChieuRong(int w)
        {
            chieu_rong = w;
        }

        public void setChieuCao(int h)
        {
            chieu_cao = h;
        }
    }

    class Rectangle : Shape
    {
        public int tinhDienTich()
        {
            return (chieu_cao * chieu_rong);
        }
    }

    interface ChiPhiSon
    {
        int tinhChiPhi(int dien_tich);
    }
}
