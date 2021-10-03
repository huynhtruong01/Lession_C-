using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            while (true)
            {
                Console.WriteLine("1. Class trong C# p1");
                Console.WriteLine("2. Class trong C# p2");
                Console.WriteLine("3. Tinh ke thua trong C# p1");
                Console.WriteLine("4. Tinh ke thua trong C# p2");
                Console.WriteLine("5. Interface trong C#");
                Console.WriteLine("6. Da hinh trong C#");
                Console.WriteLine("7. Nap chong toan tu trong C#");
                Console.Write("Nhap gia tri tu [1-7]: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        a.Slide52();
                        break;
                    case 2:
                        a.Slide55();
                        break;
                    case 3:
                        a.Slide6();
                        break;

                    case 4:
                        a.Slide9();
                        break;
                    case 5:
                        a.Slide15();
                        break;
                    case 6:
                        a.Slide19();
                        break;
                    case 7:
                        a.Slide31();
                        break;
                    default:
                        Console.WriteLine("Khong co gia tri nay!");
                        break;
                }
            }
        }

        void Slide52()
        {
            Box_2 box1 = new Box_2();
            Box_2 box2 = new Box_2();
            double the_tich;

            //box1
            box1.setChieuDai(5.0);
            box1.setChieuRong(6.0);
            box1.setChieuCao(7.0);

            //box2
            box2.setChieuDai(10.0);
            box2.setChieuRong(11.0);
            box2.setChieuCao(12.0);

            the_tich = box1.tinhTheTich();
            Console.WriteLine("BOX 1: {0}", the_tich);

            the_tich = box2.tinhTheTich();
            Console.WriteLine("BOX 2: {0}", the_tich);
        }

        void Slide55()
        {
             Console.WriteLine("Class trong C#: ");
             Console.WriteLine("----------------");
             Box box1 = new Box();
             Box box2 = new Box();
             double the_tich = 0.0; 

            //thong tin box1
             box1.chieu_dai = 5.0;
             box1.chieu_rong = 6.0;
             box1.chieu_cao = 7.0;

             //thong tin box2
             box2.chieu_dai = 10.0;
             box2.chieu_rong = 12.0;
             box2.chieu_cao = 13.0;

             //tinh the tich box1
             the_tich = box1.chieu_dai * box1.chieu_rong * box1.chieu_cao;
             Console.WriteLine("The tich box1: {0}", the_tich);

             //tinh the tich box2
             the_tich = box2.chieu_dai * box2.chieu_rong * box2.chieu_cao;
             Console.WriteLine("The tich box2: {0}", the_tich);

             Console.ReadKey();
        }

        void Slide6()
        {
            Console.WriteLine("Tinh ke thua");
            Console.WriteLine("--------------");
            Rectangle t = new Rectangle();
            t.setChieuCao(4);
            t.setChieuRong(8);
            double dien_tich;
            dien_tich = t.tinhDienTich();
            Console.WriteLine("Dien tich hcn: {0}", dien_tich);
            Console.ReadKey();
        }

        void Slide9()
        {
            Console.WriteLine("Tinh ke thua");
            ChiPhiXayDung t = new ChiPhiXayDung(10, 7);
            t.HeThongThongTin();
            Console.ReadLine();
            Console.ReadKey();
        }

        void Slide15()
        {
            Console.WriteLine("Interface trong C#");
            HCN t = new HCN(3,5);
            int dien_tich = t.tinhDT();
            Console.WriteLine("Tinh dien tich {0}", t.tinhDT());
            Console.WriteLine("Tinh chi phi son {0}", t.tinhChiPhi(dien_tich));
        }

        void Slide19()
        {
            Console.WriteLine("Tinh da hinh trong C#");
            TestCsharp t = new TestCsharp();
            t.print(12);
            t.print(500.45);
            t.print("Tinh da hinh trong C#");
            Console.ReadKey();
        }
        void Slide31()
        {
            Console.WriteLine("Nap chong toan tu trong C#");
            Console.WriteLine("--------------------------");

            Box_3 b1 = new Box_3();
            Box_3 b2 = new Box_3();
            Box_3 b3 = new Box_3();

            double the_tich;

            b1.setChieuDai(7.0);
            b1.setChieuRong(4.5);
            b1.setChieuCao(2.0);

            b2.setChieuDai(9.0);
            b2.setChieuRong(5.0);
            b2.setChieuCao(3.5);

            b1.tinhThe_Tich();
            b2.tinhThe_Tich();

            b3 = b1 + b2;
            the_tich = b3.tinhThe_Tich();

            Console.WriteLine("The tich cua b3 la: {0}", the_tich);
            Console.ReadKey();
        }
    }
}
