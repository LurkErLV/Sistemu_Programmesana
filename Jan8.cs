using System;

namespace Sistemu_Programmesana
{
    public class Jan8 {
        public static void main()
        {
            // uzd1();
            // uzd2();
        }

        private static void uzd1()
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

        private static void uzd2()
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
    }
}