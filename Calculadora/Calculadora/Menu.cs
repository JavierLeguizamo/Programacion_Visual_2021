/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 06/04/2021
 * Time: 11:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Calculadora
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		Operaciones operacion = new Operaciones();
		public Menu()
		{
			
			
		}
		
		public void mostrar(){
			Console.WriteLine("Selecciona la opcion");
			Console.WriteLine("1. Suma");
		}
		public double seleccion(int seleccion){
			double num1,num2;
			Console.Write("numero 1:");
			num1 =  double.Parse(Console.ReadLine());
			Console.Write("numero 2:");
			num2 =  double.Parse(Console.ReadLine());
			switch(seleccion){
				case 1: 
					return operacion.suma(num1, num2);
					
				default:
					return 0;
			}
		}
		
		
	}
}
