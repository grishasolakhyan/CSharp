using System;

class Destruct
{
    public int x;
    public Destruct(int i)
    {
        x = i;
    }
    ~Destruct()
    { Console.WriteLine("УНИЧТОЖЕНИЕ" + x); }
    public void gen(int i)
    {
        Destruct a = new Destruct(i);
    }
}
class DestructDemo
{
    public static void Main()
    {
        int j;
        Destruct ob = new Destruct(0);
        for (j = 1; j < 100000; j++)
            ob.gen(j);
        Console.WriteLine("ВСЁ!");
    }
}