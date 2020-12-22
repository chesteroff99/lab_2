using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{

        class Program
        {
            static void Main(string[] args)
        {
            
            bool check = true;
            double a = 0, b = 0, c = 0;
               
                while (check == true)
                {
                    Console.WriteLine("1.Сложение");
                    Console.WriteLine("2.Вычитание");
                    Console.WriteLine("3.Умножение");
                    Console.WriteLine("4.Деление");

                    switch (Console.ReadLine())
                    {

                        case "1"://сложение
                        
                            ReadParams();
                            c = a + b;
                            Console.WriteLine(a + "+" + b + "=" + c);
                            break;

                        case "2"://вычит
                            ReadParams();
                            c = a - b;
                            Console.WriteLine(a + "-" + b + "=" + c);

                            break;

                        case "3"://умнож
                            ReadParams();
                            c = a * b;
                            Console.WriteLine(a + "*" + b + "=" + c);

                            break;

                        case "4"://дел
                            ReadParams();
                        if (b != 0) { 
                        c = a / b;
                            Console.WriteLine(a + "/" + b + "=" + c);
                        }
                        else Console.WriteLine("Ошибка! Деление на 0");



                        break;

                    default:
                            Console.WriteLine("Нет такой операции!");
                            Console.WriteLine();
                            break;

                    }

                    void ReadParams()
                    {
                        Console.WriteLine("a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToDouble(Console.ReadLine());
                    }

               
            }

        }
        }
    }




   

