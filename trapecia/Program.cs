class Programm
{

	public static void Main()
	{
		Trapezoid figure = new Trapezoid(10, 11, 21, 10, 26);

		figure.TrapezoidSquare();
        {
			float s = ;
			Console.Write("Площадь трапеции = ");
			Console.WriteLine($"{s}");
        }

		figure.TrapezoidPerimetr();
		{
			float p = ;
			Console.Write("Периметр трапеции = ");
			Console.WriteLine($"{p}");
		}
	}

	class Trapezoid
	{
		private int a;
		private int b;
		private int c;
		private int d;
		private int h;

        private float BC;
		private float AB;
		private float CD;
		private float AD;

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

			this.AB = AB;
			this.CD = CD;
			this.AD = AD;
			this.BC = BC;

			Console.Write("Сторона АВ = ");
			Console.WriteLine($"{AB}");

			Console.Write("Сторона BC = ");
			Console.WriteLine($"{BC}");

			Console.Write("Сторона CD = ");
			Console.WriteLine($"{CD}");

			Console.Write("Сторона AD = ");
			Console.WriteLine($"{AD}");
		}

		public float TrapezoidPerimetr()
        {
			return (AB + BC + CD + AD);
		}
       
		public float TrapezoidSquare()
        {
			return ((a + b) * h) / 2;
		}
	}
}
