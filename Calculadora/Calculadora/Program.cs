
using System;

namespace Calculadora
{
	class Program
	{
		public static void Main(string[] args)
		{
			int seleccion;
			double	resultado;
			Menu menu = new Menu();
			menu.mostrar();
			seleccion = int.Parse(Console.ReadLine());
			resultado = menu.seleccion(seleccion);
			Console.Write("Resultado: " + resultado);
			Console.ReadKey(true);
		}
	}
}

