using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CTDLGT_Buoi01_31251021088
{
    internal class Bai1
    {
        //Bài 1: Nhập xuất và xử lý điều kiện
        public static void Main233(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a bất kỳ: " );
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b bất kỳ: " );
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c bất kỳ: " );
            int c = int.Parse(Console.ReadLine());
            int max = a;
            int min = c;
            if (a < b)
            {
                max = b;
                if (c < a)
                {
                    Console.WriteLine($"Số lớn nhất là: {b}");
                    Console.WriteLine($"Số nhỏ nhất là: {c}");
                }
                else if (c > a)
                {
                    min = a;
                    Console.WriteLine($"Số lớn nhất là: {b}");
                    Console.WriteLine($"Số nhỏ nhất là: {a}");
                }
            }
            else if (a < c)
            {
                max = c;
                if (b < a)
                {
                    Console.WriteLine($"Số lớn nhất là: {c}");
                    Console.WriteLine($"Số nhỏ nhất là: {b}");
                }
                else if (b > a)
                {
                    Console.WriteLine($"Số lớn nhất là: {c}");
                    Console.WriteLine($"Số nhỏ nhất là: {a}");
                }
                
            }
            else 
            {
                Console.WriteLine($"Số lớn nhất là: {a}");
                Console.WriteLine($"Số nhỏ nhất là: {c}");
            }

            int tong = a + b + c;
            float avg = tong / 3;
            Console.WriteLine($"Tổng 3 số trên là: {tong}" );
            Console.WriteLine($"Trung bình là: {avg}" );
        }
    }
}
