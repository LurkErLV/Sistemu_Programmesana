using System;

namespace Sistemu_Programmesana
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] taskList = { "Iziet", "uzd1", "uzd2", "uzd3" };
            Tasks tasks = new Tasks();
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("-------------------------");
                for (int i = 0; i < taskList.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {taskList[i]}");
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
                        tasks.uzd1_4();
                        break;
                    case 3:
                        tasks.uzd2_4();
                        break;
                    case 4:
                        tasks.uzd3_4();
                        break;
                    default:
                        Console.WriteLine("Tāda uzdevuma nav!");
                        break;
                }
            }
        }
    }
}