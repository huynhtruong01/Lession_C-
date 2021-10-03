using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class HCN:Shape, ChiPhiSon
    {
        protected int chieu_dai;
        protected int chieu_rong;

        public HCN(int d, int r)
        {
            chieu_dai = d;
            chieu_rong = r;
        }

        public int tinhDT()
        {
            return chieu_dai * chieu_rong;
        }

        public void Display()
        {
            Console.WriteLine("Chieu dai {0}", chieu_dai);
            Console.WriteLine("Chieu rong {0}", chieu_rong);
            Console.WriteLine("Dien tich HCN {0}", tinhDT());
        }

        public int tinhChiPhi(int dien_tich)
        {
            return dien_tich * 70;
        }
    }

    class ChiPhiXayDung : HCN
    {
        private double cost;
        public ChiPhiXayDung(int d, int r) : base(d, r) { }
        public double tinhChiPhi()
        {
            double chi_phi;
            chi_phi = tinhDT() * 70;
            return chi_phi;
        }

        public void HeThongThongTin()
        {
            base.Display();
            Console.WriteLine("Tinh chi phi: {0}", tinhChiPhi());

        }

    }
}
