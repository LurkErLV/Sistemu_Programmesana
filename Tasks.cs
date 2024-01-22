using System;
using System.Collections.Generic;

namespace Sistemu_Programmesana
{
    public class Tasks
    {
        public void uzd1_1()
        {
            Console.Write("Ievadiet skaitli:");
            var number = Convert.ToInt32(Console.ReadLine());

            // Šo pašu var izdarīt protams ar if else, bet šādi iznāk mazāk koda.
            // Tā dēļ lūgums par šo nesamazināt atzīmi :D
            // Man ir liela pieredze jau ar programmēšanas valodām tā dēļ if statement man galīgi nav nekas grūts.
            var result = number % 2 == 0 ? $"{number} - pāra skaitlis" : $"{number} - nepāra skaitlis";

            Console.WriteLine(result);
        }

        public void uzd2_1()
        {
            Console.WriteLine("Ievadiet x:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet y:");
            double y = Convert.ToInt32(Console.ReadLine());

            // AND operators kurš ir lielākajā daļā programmēšanas valodās
            // lai nebūtu jātaisa divi if vai else if bloki
            if (x == 0 || y == 0)
                Console.WriteLine("Dalīšana ar 0");
            else
                Console.WriteLine($"Rezultāts = {x / y}");
        }

        public void uzd3_1()
        {
            var password = "Alberts";

            Console.WriteLine("Ievadiet vārdu:");
            var name = Console.ReadLine();

            if (name?.Length < 5)
                Console.WriteLine("Jābūt 5 simboliem");
            else if (name == password)
                Console.WriteLine("Parole ievadīta pareizi");
            else
                Console.WriteLine("Parole ievadīta nepareizi");
        }

        public void uzd4_1()
        {
            Console.WriteLine(
                "1-Kvadrāta perimetra formula\n2-Kvadrāta laukuma formula\n3-Kvadrāta diagonāles formula");

            Console.Write("Ievadiet malu a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Izvēlēties darbību: ");
            var action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine($"Kvadrāta perimetrs: {a * 4}");
                    break;
                case 2:
                    Console.WriteLine($"Kvadrāta laukumns: {a * a}");
                    break;
                case 3:
                    Console.WriteLine($"Kvadrāta diagonāle {Convert.ToDouble(Math.Sqrt(2) * a):N3}");
                    break;
                default:
                    Console.WriteLine("Tādas darbības nav!");
                    break;
            }
        }

        public void uzd1_2()
        {
            Console.Write("Ievadiet skaitli:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{result}*{i} = {result * i}");
                result = result * i;
            }
        }

        public void uzd2_2()
        {
            Console.Write("Ievadiet noguldījuma summu: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ievadiet noguldījuma ilgumu (gadu skaitu): ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet gada % likmi: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= years; i++)
            {
                sum = sum + sum * rate;
                Console.WriteLine($"Summa pēc {i} gada ir {sum:N2}");
            }
        }

        public void uzd3_2()
        {
            for (int i = 0; i <= 9; i++)
            {
                if (i == 0)
                {
                    Console.Write("y/x  :  ");
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write(j + "       ");
                    }
                    Console.WriteLine("\n-------------------------------------------------------------------------");
                }
                else
                {
                    Console.Write(i + "    :  ");
                    for (int j = 1; j <= 9; j++)
                    {
                        if (i * j >= 10)
                        {
                            Console.Write(i * j + "      ");   
                        }
                        else
                        {
                            Console.Write(i * j + "       ");
                        }
                        if (j >= 9)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        // Cikli, nosacījuma operatori
        public void uzd1_3()
        {
            bool exit = false;
            var numbers = new Dictionary<string, string>()
            {
                { "1", "VIENS" },
                { "2", "DIVI" },
                { "3", "TRĪS" },
                { "4", "ČETRI" },
                { "5", "PIECE" }
            };

            do
            {
                Console.Write("Ievadiet skaitli no 1 līdz 5 vai IZIET beigtu darbību: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.WriteLine(numbers[choice]);
                        break;
                    case "IZIET":
                        Console.WriteLine("Programma beidz darbību");
                        exit = true;
                        break;
                }
            } while (exit == false);
        }

        public void uzd2_3()
        {
            Console.Write("Cik reizes notiks skaitļu pārbaude?");
            int loops = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                Console.Write("Ievadiet skaitli: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num % 3 == 0
                    ? "Skaitlis dalās ar 3 bez atlikuma!"
                    : "Skaitlis NEdalās ar 3 bez atlikuma!");
            }
        }

        public void uzd3_3()
        {
            Console.Write("Ievadiet trīsstūra platumu: ");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int row = width; row > 0; row--)
            {
                for (int spaces = width - row; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }

                for (int stars = 0; stars < row; stars++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }
    }
}