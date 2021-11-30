using Day6Assignment;
Console.WriteLine("\t\t((((((Enter y to run and n to stop)))))))");
char c = Convert.ToChar(Console.ReadLine());
while (c != 'n')
{
    Console.WriteLine("\t\t((((((Please select any one   ))))))");
    Console.WriteLine("\t\t((((((1.Fibbo Series          ))))))");
    Console.WriteLine("\t\t((((((2.Perfect Number        ))))))");
    Console.WriteLine("\t\t((((((4.Reverse Number        ))))))");
    Console.WriteLine("\t\t((((((5.Coupon Number         ))))))");

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
        case 3:
            PrimeNumber p = new PrimeNumber();
            p.prime();
            break;
        case 4:
            ReverseNumber r = new ReverseNumber();
            r.Reverse();
            break;
        case 5:
            CouponNum cn = new CouponNum();
            cn.ReadNumOfCoupons();
            break;
    }
}