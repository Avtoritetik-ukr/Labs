using System;
using System.Text;
namespace Task2
{
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        int[] numbers = GenerateRandomArray(10, 1, 100);
        Console.WriteLine("Згенерований масив:");
        foreach (int num in numbers)
            Console.Write(num + " ");
        Console.WriteLine("\n============");
        int sum = GetSum(numbers);
        double average = GetAverage(numbers);
        int max = GetMax(numbers);
        int min = GetMin(numbers);
        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Середнє: {average}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Мінімум: {min}");
    }
    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            array[i] = rand.Next(minValue, maxValue + 1);
        return array;
    }
    public static int GetSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
            sum += num;
        return sum;
    }
    public static double GetAverage(int[] array)
    {
        return (double)GetSum(array) / array.Length;
    }
    public static int GetMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
            if (num > max)
                max = num;
        return max;
    }
    public static int GetMin(int[] array)
    {
        int min = array[0];
        foreach (int num in array)
            if (num < min)
                min = num;
        return min;
    }

}
}
