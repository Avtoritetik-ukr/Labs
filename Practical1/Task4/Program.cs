using System;
namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                double perimeter = GetPerimeter(a, b, c);
                double area = GetArea(a, b, c);
                string type = GetTriangleType(a, b, c);

                Console.WriteLine($"Периметр: {perimeter}");
                Console.WriteLine($"Площа: {area}");
                Console.WriteLine($"Тип: {type}");
            }
            else
            {
                Console.WriteLine("Це не трикутник!");
            }
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "рівносторонній";
            if (a == b || b == c || a == c)
                return "рівнобедрений";
            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 0.0001 ||
                Math.Abs(a2 + c2 - b2) < 0.0001 ||
                Math.Abs(b2 + c2 - a2) < 0.0001)
                return "прямокутний";
            return "довільний";
        }
    }
}