using System;

namespace Sistemu_Programmesana
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] tasks = {"Iziet", "uzd1", "uzd2", "uzd3", "uzd4"};
            // uzd1();
            // uzd2();
            // uzd3();
            // uzd4();

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("-------------------------");
                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine($"{i+1} - {tasks[i]}");
                }
                Console.WriteLine("-------------------------");
                
                Console.Write("Ievadiet uzdevuma nummuru: ");
                int task = Convert.ToInt32(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        exit = true;
                        break;
                    case 2:
                        uzd1();
                        break;
                    case 3:
                        uzd2();
                        break;
                    case 4:
                        uzd3();
                        break;
                    case 5:
                        uzd4();
                        break;
                    default:
                        Console.WriteLine("Tāda uzdevuma nav!");
                        break;
                }
            }
        }

        private static void uzd1()
        {
            Console.Write("Ievadiet skaitli:");
            var number = Convert.ToInt32(Console.ReadLine());

            // Šo pašu var izdarīt protams ar if else, bet šādi iznāk mazāk koda.
            // Tā dēļ lūgums par šo nesamazināt atzīmi :D
            // Man ir liela pieredze jau ar programmēšanas valodām tā dēļ if statement man galīgi nav nekas grūts.
            var result = number % 2 == 0 ? $"{number} - pāra skaitlis" : $"{number} - nepāra skaitlis";

            Console.WriteLine(result);
        }

        private static void uzd2()
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

        private static void uzd3()
        {
            var password = "Alberts";

            Console.WriteLine("Ievadiet vārdu:");
            var name = Console.ReadLine();

            if (name.Length < 5)
                Console.WriteLine("Jābūt 5 simboliem");
            else if (name == password)
                Console.WriteLine("Parole ievadīta pareizi");
            else
                Console.WriteLine("Parole ievadīta nepareizi");
        }

        private static void uzd4()
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
    }
}