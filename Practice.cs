using System;
using System.Runtime.InteropServices;
using System.Xml;
class Program
{
    static void Main()
    {
        //1
        int a = 0;
        int[] b = { 1, 2, 3, 4, 5 };
        for (int i = 0; i <= b[4]; ++i)
        {
            Console.WriteLine(a += i);
        }

        //2 
        int[] q = { 1, 2, 3 };
        int max = q.Max();
        Console.WriteLine(max);

        //3 я не понял почему это не выводится
        int[] w = { 1, 2, 3 };
        for (int e = w[2]; e <= w[0]; --e)
        {
            Console.WriteLine(e);
        }

        //4
        int p = 2;
        int[] r = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 1; i <= r[9]; i++)
            if (i % 2 == 0)
                Console.WriteLine(i);

        //5
        int[] o = { 1, -2, 3, -5 };

        int count = 0;

        if (o[0] < 1)
        {
            count++;
            
        }
        if (o[1] < 1)
        {
            count++;
            
        }
        if (o[2] < 1)
        {
            count++;
            
        }
        if (o[3] < 1)
        {
            count++;
            Console.WriteLine(count);
        }

    }
}    