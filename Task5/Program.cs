using System;
namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int groupsCount = rnd.Next(3, 6);
            int[][] groups = new int[groupsCount][];

            for (int i = 0; i < groupsCount; i++)
            {
                int studentsCount = rnd.Next(10, 31);
                groups[i] = new int[studentsCount];
                for (int j = 0; j < studentsCount; j++)
                    groups[i][j] = rnd.Next(50, 101);
            }

            PrintGroupStatistics(groups);
        }

        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int m in marks)
                sum += m;
            return (int)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int m in marks)
                if (m < min) min = m;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int m in marks)
                if (m > max) max = m;
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double avg = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);
                Console.WriteLine(
                    $"Група {i + 1}: Середній = {avg:F1}, Мінімальний = {min}, Максимальний = {max}");
            }
        }
    }
}