﻿using Day6Assignment;
Console.WriteLine("\t\t((((((Enter y to run and n to stop)))))))");
char c = Convert.ToChar(Console.ReadLine());
while (c != 'n')
{
    Console.WriteLine("\t\t((((((Please select any one   ))))))");
    Console.WriteLine("\t\t((((((1.Fibbo Series          ))))))");
    Console.WriteLine("\t\t((((((2.Perfect Number        ))))))");
    int Aloo = Convert.ToInt32(Console.ReadLine());
    switch (Aloo)
    {
        case 1:
            FibbonacciSeries fs = new FibbonacciSeries();
            fs.Fibbo();
            break;
        case 2:
            PerfectNumber pf = new PerfectNumber();
            pf.Perfect();
            break;

    }
}