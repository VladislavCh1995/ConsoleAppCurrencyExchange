using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rub = 10000;
            int rubToChange = 0;
            int usd = 100;
            int usdToChange = 0;
            int euro = 100;
            int euroToChange = 0;
            bool isOpen = true;
            while (isOpen) 
            {
                Console.WriteLine($"{rub} - рублей на счету.");
                Console.WriteLine($"{usd} - долларов на счету.");
                Console.WriteLine($"{euro} - евро на счету.");
                string userInput = "0";
                Console.WriteLine("Меню: 1)Обмен рубля. 2)Обмен доллара. 3) Обмен евро. 4)Выйти.");
                userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1": // rub to usd or euro
                        {
                            Console.WriteLine("1 - Обмен на доллары. 2 - Обмен на рубли.");
                            string userInput2 = Console.ReadLine();
                            if(userInput2 == "1")
                            {
                                Console.WriteLine("Введите кол - во рублей которое вы хотите поменять на доллары.");
                                rubToChange = int.Parse(Console.ReadLine());
                                if (rubToChange > 0 && rubToChange < rub)
                                {
                                    usd += rubToChange / 50;
                                    rub = (rub - (rubToChange / 50) * 50);
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else if(userInput2 == "2")
                            {
                                Console.WriteLine("Введите кол - во рублей которое вы хотите поменять на евро.");
                                rubToChange = int.Parse(Console.ReadLine());
                                if (rubToChange > 0 && rubToChange < rub)
                                {
                                    euro += rubToChange / 100;
                                    rub = (rub - (rubToChange / 100) * 100);
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное число.");
                            }
                            break;
                        }
                    case "2": //usd to rub or euro
                        {
                            Console.WriteLine("1 - Обмен на рубли. 2 - Обмен на евро.");
                            string userInput2 = Console.ReadLine();
                            if (userInput2 == "1")
                            {
                                Console.WriteLine("Введите кол - во долларов которое вы хотите поменять на рубли.");
                                usdToChange = int.Parse(Console.ReadLine());
                                if (usdToChange > 0 && usdToChange < usd)
                                {
                                    rub += usdToChange * 50;
                                    usd = usd - usdToChange;
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else if (userInput2 == "2")
                            {
                                Console.WriteLine("Введите кол - во долларов которое вы хотите поменять на евро.");
                                usdToChange = int.Parse(Console.ReadLine());
                                if (usdToChange > 0 && usdToChange < usd)
                                {
                                    euro += usdToChange / 2;
                                    usd = (usd - (rubToChange / 2) * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное число.");
                            }
                            break;
                        }
                    case "3": //euro to rub to usd
                        {
                            Console.WriteLine("1 - Обмен на рубли. 2 - Обмен на доллары.");
                            string userInput2 = Console.ReadLine();
                            if (userInput2 == "1")
                            {
                                Console.WriteLine("Введите кол - во евро которое вы хотите поменять на рубли.");
                                euroToChange = int.Parse(Console.ReadLine());
                                if (euroToChange > 0 && euroToChange < euro)
                                {
                                    rub += euroToChange * 100;
                                    euro -= euroToChange;
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else if (userInput2 == "2")
                            {
                                Console.WriteLine("Введите кол - во евро которое вы хотите поменять на доллары.");
                                euroToChange = int.Parse(Console.ReadLine());
                                if (euroToChange > 0 && euroToChange < euro)
                                {
                                    usd += euroToChange * 2;
                                    euro = -euroToChange;
                                }
                                else
                                {
                                    Console.WriteLine("Введено неверное число.");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное число.");
                            }
                            break;
                        }
                    case "4":
                        {
                            isOpen = false;
                            break;
                        }
                }
                //Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
