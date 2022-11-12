using System;

class vehicle
{
    int pri_passengers;
    int pri_fuelcap;
    int pri_mpg;
    public vehicle(int p, int f, int m)
    {
        passengers = p;
        fuelcap = f;
        mpg = m;
    }
    public double fueln(int li)
    {
        return (double)li / mpg;
    }
    public int passengers
    {
        get { return pri_passengers; }
        set { pri_passengers = value; }
    }
    public int fuelcap
    {
        get { return pri_fuelcap; }
        set { pri_fuelcap = value; }
    }
    public int mpg
    {
        get { return pri_mpg; }
        set { pri_mpg = value; }
    }
}
class truck:vehicle
{
    int pri_capacity;
    public truck(int p, int f, int m, int c) : base(p, f, m)
    {
        pri_capacity = c;
    }
    public int capacity
    {
        get { return pri_capacity; }
        set { pri_capacity = value; }
    }
}
class truck_demo
{
    public static void Main()
    {
        truck furgon = new truck(3, 70, 4, 3000);
        truck pickup = new truck(3, 70, 8, 725);
        double li;
        int dist = 100;
        li = furgon.fueln(dist);
        Console.WriteLine("ГРУЗОПОДЪЁМНОСТЬ ФУРГОНА СОСТАВЛЯЕТ "+furgon.capacity+" КГ. КОЛЛИЧЕСТВО ЧЕЛОВЕК: "+furgon.passengers);
        Console.WriteLine("РАСХОД: НА " +dist+" КИЛОМЕТРОВ ТРЕБУЕТСЯ "+li+" ЛИТРОВ.\n");
        Console.WriteLine("ГРУЗОПОДЪЁМНОСТЬ ПИКАПА СОСТАВЛЯЕТ " + pickup.capacity + " КГ. КОЛЛИЧЕСТВО ЧЕЛОВЕК: " + pickup.passengers);
        Console.WriteLine("РАСХОД: НА " + dist + " КИЛОМЕТРОВ ТРЕБУЕТСЯ " + li + " ЛИТРОВ.\n");
    }
}












