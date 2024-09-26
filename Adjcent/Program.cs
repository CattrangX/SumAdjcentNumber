using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("nhap so khoang trang: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ');
        List<decimal> numbers = new List<decimal>();

        foreach (var item in inputArray)
        {
            if (decimal.TryParse(item, out decimal number))
            {
                numbers.Add(number);
            }
        }

        List<decimal> result = SumUntilNoAdjacentEqual(numbers);

        Console.WriteLine("tong= " + string.Join(" ", result));
    }

    static List<decimal> SumUntilNoAdjacentEqual(List<decimal> numbers)
    {
        bool canSum = true;

        
        while (canSum)
        {
            canSum = false;  
            for (int i = 0; i < numbers.Count - 1; i++)
            {
               
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];  
                    numbers.RemoveAt(i + 1);       
                    canSum = true;
                    break;                         
                }
            }
        }

        return numbers;
    }
}
