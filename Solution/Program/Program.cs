﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * this is the first thing i added to main
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * asdf
             */

            // and the second thing
            Random rand = new Random();
            if (rand.NextDouble() - 0.5 < 0)
            {
                Foo(3.14159);
            }
        }
        
        private static void Foo(double dub)
        {
            Console.WriteLine("here's the first method " + dub);
        }
    }
}
