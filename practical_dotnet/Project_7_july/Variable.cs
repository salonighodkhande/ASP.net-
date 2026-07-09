using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int i = 1; i <= 30; i++)
        {
            int power = 80 + (i * 5);

            Console.Write("Light " + i + " = " + power + " W : ");

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenance++;
            }
            else if (power >= 140)
            {
                Console.WriteLine("Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficient++;
            }

            total = total + power;
        }

        double average = total / 30.0;

        Console.WriteLine("\nTotal Power = " + total + " W");
        Console.WriteLine("Average Power = " + average + " W");
        Console.WriteLine("Maintenance Required = " + maintenance);
        Console.WriteLine("Normal Operation = " + normal);
        Console.WriteLine("Energy Efficient = " + efficient);
    }
}