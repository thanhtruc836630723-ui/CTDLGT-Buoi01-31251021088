using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251021088
{
    internal class Bai2
    {
        //Bài 2: Hai giá trị lớn nhất phân biệt
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 100000)
            {
                Console.WriteLine("n KHÔNG hợp lệ");
                return;
            }
            Console.Write("Nhập mảng: " );
            string s = Console.ReadLine();
            int[] a = new int[n];
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-')
                {
                    i++;
                    a[dem] = -(s[i] - '0');
                    dem++;
                }
                else
                {
                    a[dem] = s[i] - '0';
                    dem++;
                }
            }

            if (dem != n)
            {
                Console.WriteLine("NO");
                return;
            }

           
            






        }
    }
}
