/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 23/03/2021
 * Time: 11:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Try_Catch
{
	class Program
	{
		public static void Main(string[] args)
		{
			try{
				float numero;
				Console.WriteLine("Escribe un numero");
				numero = float.Parse(Console.ReadLine());
				Console.WriteLine("Número ingresado: " + numero);
				
			}catch{
				Console.WriteLine("No escribiste un número válido");
				
			}finally{
				Console.WriteLine("Ejecutando el finally");
				Console.ReadKey(true);
			
			}
		}
	}
}