using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int sum = 0;
        float average = 0;
        int largestNumber = 0;

        List<int> listNumber = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished: ");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            listNumber.Add(number);

        } while (number != 0);

        for (int i = 0; i < listNumber.Count; i++)
        {
            Console.WriteLine(listNumber[i]);
            sum += listNumber[i];
            average = (float)sum / listNumber.Count;

            

            
            if (listNumber[i] > largestNumber)
            {
                largestNumber = listNumber[i];
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
