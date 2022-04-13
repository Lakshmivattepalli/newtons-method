using System;

namespace Newtonmethod
{
	class Newtonmethod
	{
		static double SquareRoot(double c)
		{
		// initialising the value of c to t
			double t = c;
			double Epsilon = 1e-15;
			
			

			int count = 0;

			while (true)
			{
				count++;

				//here,replaced t with average of t and c/t
				t = 0.5 * (t + (c/t));
				//applied the logic given i.e.,
				if (Math.Abs(t-c/t) < (Epsilon * t))
				{
					break;
				}
		
				
			}
			Console.WriteLine(t);
			return t;
		}
		public static void Main()
		{
		   
			Console.WriteLine("square root");
			SquareRoot(125);

		
		}
	}
}


