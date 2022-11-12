using System;
class Mars
{
    public static void Main(string[] args)
    {
        double dist, c, del, del_min;
        dist = 3.4 * 1e+7;
        c = 1.86 * 1e+5;
        del = dist / c;
        del_min = (dist / c) / 60;
        Console.WriteLine("The signal delay time is " + del + " s");
        Console.WriteLine("The signal delay time is " + del_min + " min");
        Console.ReadLine();
    }
}