class Trapezoid
{

    public static float TrapezoidSquare(float a, float b, float h)
    {
        return ((a + b) * h) / 2;
    }

    public static float TrapezoidPerimetr(float AB, float BC, float CD, float AD)
    {
        return (AB + BC + CD + AD);
    }

    public static void Main()
    {
        float a = 9;
        float b = 6;
        float c = 16;
        float d = 4;
        float h = 14;

        float AB = a + b;
        float BC = b + c;
        float CD = c + d;
        float AD = a + d;

        Console.Write("Площадь трапеции : ");
        Console.WriteLine(TrapezoidSquare(a, b, h));

        Console.Write("Периметр трапеции : ");
        Console.WriteLine(TrapezoidPerimetr(AB,BC,CD,AD));

        Console.Write("Сторона АВ = ");
        Console.WriteLine($"{AB}");

        Console.Write("Сторона BC = ");
        Console.WriteLine($"{BC}");

        Console.Write("Сторона CD = ");
        Console.WriteLine($"{CD}");

        Console.Write("Сторона AD = ");
        Console.WriteLine($"{AD}");

        if (AB == CD)
        {
            Console.WriteLine("Это равнобокая трапеция");
        }
        else
        {
            Console.WriteLine("Это не равнобокая трапеция");
        }
    }

}