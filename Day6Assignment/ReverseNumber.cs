﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}