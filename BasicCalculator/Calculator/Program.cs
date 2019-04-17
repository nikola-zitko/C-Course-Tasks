using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            string input;
            double a, b;
            string op;
            do
            {
                do
                {
                    Console.WriteLine("a. Kalkulator\nb. Izlaz\n");
                    input = Console.ReadLine();
                    if(input!= "a" && input != "b")
                    {
                        Console.WriteLine("Izaberite ili a ili b.");
                    }
                    else if(input == "b")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                } while (input != "a");

                if(input == "a") {
                    Console.WriteLine("Unesi prvi operand: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (double.IsNaN(a)) {
                        Console.WriteLine("Nije unesen broj!");
                        break;
                    }
                    Console.WriteLine("Unesi drugi operand: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    if (double.IsNaN(b)) {
                        Console.WriteLine("Nije unesen broj!");
                        break;
                    }
                    Console.WriteLine("Unesi operator('+'(sum), '-'(sub), '*'(mul), '/'(div): ");
                    op = Console.ReadLine();

                    if (op == "+" || op == "sum") {
                        Console.WriteLine("Suma je: {0}", a + b);

                    }
                    else if (op == "-" || op == "sub") {
                        Console.WriteLine("Razlike je: {0}", a - b);
                    }
                    else if (op == "*" || op == "mul") {
                        Console.WriteLine("Umnozak je: {0}", a * b);
                    }
                    else if (op == "/" || op == "div") {
                        Console.WriteLine("Kvocijent je: {0}", a / b);
                    }
                    else {
                        Console.WriteLine("Neispravan operator!");
                        break;
                    }
                }
                else {
                    menu = false;
                }
                
            }
            while (menu == true);
            Console.WriteLine("Kraj programa!");
            Console.ReadLine();
        }
    }
}
