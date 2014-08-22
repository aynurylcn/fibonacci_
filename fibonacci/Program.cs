using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç elemanı gösterilsin:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            b[0] = 1;
            b[1] = 1;
            Console.Write(b[0] + "\t");
            Console.Write(b[1] + "\t");
            for (int i = 2; i <a; i++)
            {
                b[i] = b[i - 1] + b[i - 2];
               Console.Write(b[i]+"\t");
               
            } 
            Console.ReadKey();
        }
    }
}
