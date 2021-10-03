using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Line
    {
        private double chieu_dai;
        public Line(double len)
        {
            Console.WriteLine("Doi tuong dang duoc tao, chieu dai = {0}", len);
            chieu_dai = len;
        }

        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }

        public double getChieuDai()
        {
            return chieu_dai;
        }

        
    }
}
