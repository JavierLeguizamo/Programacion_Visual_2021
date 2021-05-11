/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 11/05/2021
 * Time: 11:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Polimorfismo_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Automovil bocho = new Automovil("1234","WV","Aut");
			Automovil copper = new Automovil("Manual");
			
			bocho.acelerar(20,10);
			copper.acelerar(100);
			
			Console.ReadKey(true);
		}
	}
}