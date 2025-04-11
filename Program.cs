using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int k = int.Parse(input[2]);
        string s = Console.ReadLine();

        int dx = 0, dy = 0, dz = 0;
        int minDx = 0, maxDx = 0;
        int minDy = 0, maxDy = 0;
        int minDz = 0, maxDz = 0;

        foreach (char c in s)
        {
            if (c == 'l') dx--;
            if (c == 'r') dx++;
            if (c == 'd') dy--;
            if (c == 'u') dy++;
            if (c == 'b') dz--;
            if (c == 'f') dz++;

            minDx = Math.Min(minDx, dx);
            maxDx = Math.Max(maxDx, dx);
            minDy = Math.Min(minDy, dy);
            maxDy = Math.Max(maxDy, dy);
            minDz = Math.Min(minDz, dz);
            maxDz = Math.Max(maxDz, dz);
        }

        long possibleX = Math.Max(1, n - (maxDx - minDx));
        long possibleY = Math.Max(1, m - (maxDy - minDy));
        long possibleZ = Math.Max(1, k - (maxDz - minDz));

        Console.WriteLine(possibleX * possibleY * possibleZ);
    }
}
