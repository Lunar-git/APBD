// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1;

public class Program
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return -1;
        double sum1 = 0;
        foreach (int num in numbers)
        {
            sum1 += num;
        }
        return sum1 / numbers.Length;
    }
}

public class Program2
{
    public static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return -1;
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}

