/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 11/03/2021
 * Time: 09:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hola_mundo_2021
{
	class Program
	{
		public static void Main(string[] args)
		{
			Perritos pikachu = new Perritos("pokemon","amarillo",5);
			Perritos odie = new Perritos("Chihuahua","blanco",8);
			Console.WriteLine("Picachu esta ladrando " + 
			                  pikachu.ladrar());
			Console.WriteLine("La raza del perrito es:" + 
			                  pikachu.getRaza());
			Console.WriteLine("el color de odie es: "+
			                  odie.getColor());
			Console.ReadKey(true);
		}
	}
}