/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 25/03/2021
 * Time: 10:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Area_Perimetro_Circulo_2021
{
	/// <summary>
	/// Description of Circulo.
	/// </summary>
	public class Circulo
	{
		double radio;
		public Circulo(double r)
		{
			radio = r;
		}
		
		public double area(){
			double pi =3.15926;
			return pi*radio*radio;
		}
		
		public double perimetro(){
			double pi =3.15926;
			return 2*pi*radio;
		}
		
	}
}
