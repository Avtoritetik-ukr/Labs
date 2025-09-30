using System;
using System.Text;
namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Введіть ваш вік: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                string category = ClassifyAge(age);
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Некоректне введення!");
            }
        }
        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            if (age < 12)
                return "Ви дитина";
            else if (age <= 17)
                return "Підліток";
            else if (age <= 59)
                return "Дорослий";
            else
                return "Пенсіонер";
        }
    }
}