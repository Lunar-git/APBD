// See https://aka.ms/new-console-template for more information

using System;

public class MathUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return -1;
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }
}