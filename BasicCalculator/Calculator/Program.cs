using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator{
    class Program{
        static void Main(string[] args) {
            bool opFlag = false, op1Flag = false, op2Flag = false, exit = false ;
            string input;
            int option = 0;
            double a = 0, b = 0;
            string op, exit_;
            PrintProgramVersion();
            do {
                do {
                    PrintMenu();
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out option)) {
                        PrintColoredMessage(ConsoleColor.Red, "Odaberite opciju pod 1. ili pod 2.");
                    }
                    else {
                        if (option == 2) {
                            return;
                        }
                        else {
                            continue;
                        }

                    }

                } while (option != 1);

                do {
                    Console.WriteLine("Unesi prvi operand: ");
                    string prvi = Console.ReadLine();
                    op1Flag = false;
                    if (!double.TryParse(prvi, out double optionPrvi)) {
                        PrintColoredMessage(ConsoleColor.Red, "Unesite ispravan broj!");
                    }
                    else {
                        a = optionPrvi;
                        op1Flag = true;
                    }
                }
                while (op1Flag == false);
                do {
                    Console.WriteLine("Unesi drugi operand: ");
                    string drugi = Console.ReadLine();
                    op2Flag = false;
                    if (!double.TryParse(drugi, out double optionDrugi)) {
                        PrintColoredMessage(ConsoleColor.Red, "Unesite ispravan broj!");
                    }
                    else {
                        b = optionDrugi;
                        op2Flag = true;
                    }
                }
                while (op2Flag == false);
                do {
                    Console.WriteLine("Unesi operator('+'(sum), '-'(sub), '*'(mul), '/'(div): ");
                    op = Console.ReadLine();
                    opFlag = false;

                    if (op == "+" || op == "sum") {
                        Console.WriteLine("Suma je: {0}", a + b);
                        opFlag = true;
                    }
                    else if (op == "-" || op == "sub") {
                        Console.WriteLine("Razlike je: {0}", a - b);
                        opFlag = true;
                    }
                    else if (op == "*" || op == "mul") {
                        Console.WriteLine("Umnozak je: {0}", a * b);
                        opFlag = true;
                    }
                    else if (op == "/" || op == "div") {
                        Console.WriteLine("Kvocijent je: {0}", a / b);
                        opFlag = true;
                    }
                    else {
                        PrintColoredMessage(ConsoleColor.Red, "Neispravan operator!");
                    }
                }
                while (opFlag == false);
                do {
                    Console.WriteLine("Izlaz? [Y/N]");
                    exit_ = Console.ReadLine();
                    if (exit_ == "Y" || exit_ == "y") {
                        exit = true;
                    }
                    else if(exit_ == "N" || exit_ == "n"){
                        Console.Clear();
                    }
                }
                while (exit_ != "Y" && exit_ != "N" && exit_ != "y" && exit_ != "n");
            }
            while (exit == false);
                Console.WriteLine();
        }

        static void PrintProgramVersion() {
            string appAuthor = "Nikola Žitko";
            string appVersion = "1.1";
            string appName = "Calculator";
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}: Version {1} made by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void PrintColoredMessage(ConsoleColor Color, string Message) {
            Console.ForegroundColor = Color;
            Console.WriteLine(Message);
            Console.ResetColor();
        }

        static void PrintMenu() {
            Console.WriteLine("----------------------");
            Console.WriteLine("Calculator");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Calculate");
            Console.WriteLine("2. Exit");
            Console.WriteLine("----------------------");
        }

    }
}
