/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 16/03/2021
 * Time: 11:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hola_mundo_2021
{
	/// <summary>
	/// Description of Perritos.
	/// </summary>
	public class Perritos// Declaración de la clase
	{
		String raza;
		String color;
		float peso;
		
		public Perritos(String raz, String col, float pes)//Constructor
		{
			raza  = raz;
			color = col;
			peso  = pes;
		}
		
		//métodos: ladrar, olfatear
		public String getRaza(){
			return raza;
		}
		
		public String getColor(){
			return color;
		}
		public float getPeso(){
			return peso*5;
		}
		
		public String ladrar(){
			return "guaw guaw";
		}
		
		public String olfatear(){
			return "snif snif";
		}
		
	}
}
