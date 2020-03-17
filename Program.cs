using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入运算符号：");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "+":
                        Console.WriteLine("输入计算类型：1、数字   2、字符串");
                        leixing.lei();
                        break;
                    case "-":
                        Console.WriteLine("输入计算类型：1、数字   2、字符串");
                        leixing2.lei();
                        break;
                    case "*":
                        chengfa.Chengfa();
                        break;
                    case "/":
                        chufa.Chufa();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }
    }
    class leixing
    {
        public static void lei()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                jiafa.Jiafa();
            }
            else
            {
                Console.WriteLine("输入第一个字符：");
                string s1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("输入第二个字符：");
                string s2 = Convert.ToString(Console.ReadLine());
                string s3 = s1 + s2;
                Console.WriteLine("和 =" + s3);
            }
        }
    }
    class leixing2
    {
        public static void lei()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                jiafa.Jiafa();
            }
            else
            {
                Console.WriteLine("输入第一个字符：");
                string s1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("输入第二个字符：");
                string s2 = Convert.ToString(Console.ReadLine());
                int s3 = s1.Length - s2.Length;
                Console.WriteLine("差 =" + s3);
            }
        }
    }
    class jiafa
    {
        public static void Jiafa()
        {
            Console.WriteLine("输入第一个数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数：");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("和 =" + c);
        }
    }
    class jiefa
    {
        public static void Jiefa()
        {
            Console.WriteLine("输入第一个数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数：");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("差 =" + c);
        }
    }
    class chengfa
    {
        public static void Chengfa()
        {
            Console.WriteLine("输入第一个数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数：");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("积 =" + c);
        }
    }
    class chufa
    {
        public static void Chufa()
        {
            Console.WriteLine("输入第一个数：");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数：");
            double b = Convert.ToInt32(Console.ReadLine());
            double c = a / b;
            Console.WriteLine("商 =" + c);
        }
    }
    class equ
    {
        public static bool Equals(object a, object b)
        {
            if (a != b)
            {
                return true;
            }
            else
                return false;
        }
    }
}
}
