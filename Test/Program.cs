using System;
using System.Linq;

class Program
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToList();
        int y = input[0];
        int x = input[1];
        char[,] yx = new Char[y, x];

        for (int i = 0; i < y; i++)
        {
            var line = Console.ReadLine().Select(e => (char)e).ToList();
            for (int j = 0; j < x; j++)
            {
                yx[i, j] = line[j];
            }
        }

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (yx[i, j] == '#')
                {
                    Console.WriteLine($"{i} {j}");
                }
            }
        }
    }
}