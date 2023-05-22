using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giai_phuong_trinh_bac_nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("giai_phuong_trinh_bac_nhat");
            Console.WriteLine("nhap gia tri a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap gia tri b");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double ketqua = -b / a;
                Console.Write("ket qua phuong trinh la: {0}!", ketqua);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("phuong trinh vo so nghiem");
                }
                else
                {
                    Console.Write("phuong trinh vo nghiem");
                }
            }
            Console.ReadKey();
        }
    }
}
