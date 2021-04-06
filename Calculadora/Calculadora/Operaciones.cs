
using System;

namespace Calculadora
{
	/// <summary>
	/// Description of Operaciones.
	/// </summary>
	public class Operaciones
	{
		public Operaciones()
		{
		}
		
		public double suma(double num1, double num2){
			return num1+num2;
		}
		public double resta(double num1, double num2){
			return num1-num2;
		}
		public double multi(double num1, double num2){
			return num1*num2;
		}
		public double divi(double num1, double num2){
			return num1/num2;
		}
	}
}
