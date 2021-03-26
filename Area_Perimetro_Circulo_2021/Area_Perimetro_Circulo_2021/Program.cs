/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 25/03/2021
 * Time: 10:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Area_Perimetro_Circulo_2021
{
	class Program
	{
		public static void Main(string[] args)
		{
			double radio;
			try {
				Console.Write("Escribe el Radio: ");
				radio = double.Parse(Console.ReadLine());
				Circulo circulito = new Circulo(radio);
				Console.WriteLine("El area del circulo es: " + circulito.area());
				Console.WriteLine("El perimetro del circulo es: " + circulito.perimetro());
				
			} catch {
				Console.Write("El numero que ingresaste no es correcto");
				
			}finally{
				Console.ReadKey(true);
			}
			
		}
	}
}