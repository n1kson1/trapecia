class Programm
{
    public static void Main()
    {
        Trapezoid figure = new Trapezoid(10, 11, 21, 10, 26);

        float TrapezoidSquare(float a, float b, float h)
        {
            return ((a + b) * h) / 2;
        }

        Console.Write("Площадь трапеции  : ");
        Console.WriteLine($"{TrapezoidSquare}");

        float TrapezoidPerimetr(float AB, float BC, float CD, float AD)
        {
            return (AB + BC + CD + AD);
        }

        Console.Write("Периметр трапеции : ");
        Console.WriteLine($"{TrapezoidPerimetr}");
    }

    class Trapezoid
    {
        private int a;
        private int b;
        private int c;
        private int d;
        private int h;

        public Trapezoid(int a, int b, int c, int d, int h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
            
            float AB = a + b;
            float BC = b + c;
            float CD = c + d;
            float AD = a + d;

            //float TrapezoidPerimetr = AB + BC + CD + AD;
            //float TrapezoidSquare = ((a + b) * h) / 2;

            //Console.Write("Площадь трапеции  : ");
            //Console.WriteLine($"{TrapezoidSquare}");

            //Console.Write("Периметр трапеции : ");
            //Console.WriteLine($"{TrapezoidPerimetr}");

            Console.Write("Сторона АВ = ");
            Console.WriteLine($"{AB}");

            Console.Write("Сторона BC = ");
            Console.WriteLine($"{BC}");

            Console.Write("Сторона CD = ");
            Console.WriteLine($"{CD}");

            Console.Write("Сторона AD = ");
            Console.WriteLine($"{AD}");
        }
    }
}
