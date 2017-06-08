using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        delegate int Operation(int y, int z); 
       static int Sum(int a, int b)
        {
            return a + b; 
        }
        static int Minus (int a, int b)
        {
            return a - b;
        }
        static int Delenie(int a, int b)
        {
            return a / b;
        }
        static int Multyply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Operation c = new Operation(Sum);

            Console.WriteLine("Введите строку");
            string expreshan = Console.ReadLine();
          string [] listexp =  expreshan.Split(' ');
            if (listexp.Length > 3 || listexp.Length<3)
            {
                Console.WriteLine("Не верный ввод");
                return; 
            }
            int left = Convert.ToInt32(listexp[0]);
            int right = Convert.ToInt32(listexp[2]);

            if(listexp[1] == "+")
            {
                c = new Operation(Sum);
            }
            else if (listexp[1] == "-")
            {
                c = new Operation(Minus);
            }
            else if (listexp[1] == "/")
            {
                c = new Operation(Delenie);
            }
            else if (listexp[1] == "*")
            {
                c = new Operation(Multyply);
            }
            Console.WriteLine(c(left, right));
            Console.ReadKey(); 
            
        }
    }
}