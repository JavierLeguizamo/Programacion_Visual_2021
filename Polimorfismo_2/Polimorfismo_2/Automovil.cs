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
	/// <summary>
	/// Description of Automovil.
	/// </summary>
	public class Automovil
	{
		String modelo, marca, tipo;
		
		public Automovil(String modelo,
		                 String marca,
		                 String tipo)
		{
			this.modelo = modelo;
			this.marca  = marca;
			this.tipo   = tipo;
		}
		
		public Automovil(String tipo)
		{
			this.modelo = "Reciente";
			this.marca  = "Generica";
			this.tipo   = tipo;
		}
		
		public void acelerar(int velocidad, int tiempo){
			Console.WriteLine("Acelerando a " + 
			                  velocidad + " Km/h " +
			                  "por " + tiempo + " minutos");
		}
		public void acelerar(int velocidad){
			Console.WriteLine("Acelerando a " + 
			                  velocidad + " Km/h " +
			                  "por tiempo indefinido");
		}
		
	}
}
