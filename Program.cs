namespace zgaduj
{
	class Program
	{
		static void Main(string[] args)
		{
			int r, g;
		
			Random rand = new Random();
			int min = 1;
			int max = 10;
			r = rand.Next(min, max);
			Console.WriteLine("Zgadnij liczbe, bo wpierdol");
			do
			{
				g = Convert.ToInt32(Console.ReadLine());
				if (r != g)
					Console.WriteLine(((r < g) ? "za duza" : "za mala"));
			} while (r != g);
			Console.WriteLine("zgadles");
			Console.ReadKey();
		}
	}
}