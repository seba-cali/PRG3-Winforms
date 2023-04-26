using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DateTime
{
		internal class Program
		{
				static void Main(string[] args)
				{
						DateTime fecha = DateTime.Now;//llamo al constructor por defecto

						Console.WriteLine("La fecha es: " + fecha.ToString("dddd MM/yy"));



						//---------------------------------------------------//
						Console.ReadKey();
				}
		}
}
