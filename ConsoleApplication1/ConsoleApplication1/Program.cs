﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Square
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            var str = new String('*', 5);
            Console.WriteLine(str);
            int i = 0;
            while (i != n - 2)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
                i++;
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }

    class Circle
    {
        static void Main()
        {
      
      Console.Write(
         "   *   \n" +
         " *   * \n" +
         "*     *\n" +
         "*     *\n" +
         "*     *\n" +
         " *   * \n" +
         "   *   \n");
            Console.ReadKey();
            }
       }
