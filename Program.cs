using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace phanso
{
    class PhanSo
    {
        public int tuSo;
        public int mauSo;

        public void nhapPhanSo()
        {
            Console.Write("Tu so = ");
            this.tuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so = ");
            do
                this.mauSo = int.Parse(Console.ReadLine());
            while (this.mauSo == 0);
        }
        public int ucln(int a, int b)
        {
            while (a != b && a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        public PhanSo toiGian()
        {
            PhanSo ps3 = new PhanSo();
            int uoc = ucln(tuSo, mauSo);
            if (uoc != 0)
            {
                ps3.tuSo = tuSo / uoc;
                ps3.mauSo = mauSo / uoc;
            }
            else
            {
                ps3.tuSo = tuSo;
                ps3.mauSo = mauSo;
            }
            return ps3;
        }
        public void InPhanSo()
        {
            System.Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }
        public PhanSo tichHaiPhanSo(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.tuSo;
            ps3.mauSo = ps1.mauSo * ps2.mauSo;
            return ps3;
        }
        public PhanSo tongHaiphanso(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            ps3.mauSo = ps1.mauSo * ps2.mauSo;
            return ps3;
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                PhanSo ps1 = new PhanSo();
                PhanSo ps2 = new PhanSo();
                PhanSo ps3 = new PhanSo();

                Console.WriteLine("Nhap phan so 1: ");
                ps1.nhapPhanSo();

                Console.WriteLine("Nhap phan so 2: ");
                ps2.nhapPhanSo();
                
                ps3 = ps3.tongHaiphanso(ps1, ps2);
                Console.WriteLine("Tong 2 phan so la: ");
                ps3 = ps3.toiGian();
                ps3.InPhanSo();

                ps3 = ps3.tichHaiPhanSo(ps1, ps2);
                Console.WriteLine("\nTich 2 phan so la: ");
                ps3 = ps3.toiGian();
                ps3.InPhanSo();

                Console.ReadKey();

            }
        }
    }