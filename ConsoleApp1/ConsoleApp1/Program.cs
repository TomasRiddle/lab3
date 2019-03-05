using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

            ConsoleKeyInfo key = Console.ReadKey();

            char ch = key.KeyChar;



            switch (ch)

            {

                case '+':

                    A = A + B;

                    break;

                default:

                    break;
            }
    }
}
