Here is a C# console application that solves the problem:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Minimum number of flips: " + MinFlips(input));
    }

    static int MinFlips(string input)
    {
        int flipCount = 0;
        int oneCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '0')
            {
                if (oneCount == 0)
                    continue;
                else
                    flipCount++;
            }
            else
            {
                oneCount++;
            }

            if (flipCount > oneCount)
            {
                flipCount = oneCount;
            }
        }

        return flipCount;
    }
}
```

This program reads a binary string from the console, then it calls the `MinFlips` function to calculate the minimum number of flips to make the binary string monotone increasing. The `MinFlips` function iterates over the binary string, counting the number of '1's and the number of flips needed to make the string monotone increasing. If the number of flips is greater than the number of '1's, it sets the number of flips to the number of '1's. Finally, it returns the minimum number of flips.