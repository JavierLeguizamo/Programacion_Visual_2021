/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 13/05/2021
 * Time: 09:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Serial_Arduino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try {
				serialPort.Open();
				MessageBox.Show("Conectado Correctamente",
				                "Conexion Exitosa");
				
			} catch (Exception) {
				MessageBox.Show("Error, no se pudo conectar",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			try {
				serialPort.Close();
			} catch (Exception) {
				
				MessageBox.Show("Hubo un error al cerrar el puerto",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			}
		}
		void BtnEncenderClick(object sender, EventArgs e)
		{
			try {
				serialPort.WriteLine("A");
				MessageBox.Show("Se encendio el LED");
			} catch (Exception) {
				MessageBox.Show("Hubo un error al encender el LED",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
		void BtnApagarClick(object sender, EventArgs e)
		{
			try {
				serialPort.WriteLine("B");
				MessageBox.Show("Se apago el LED");
			} catch (Exception) {
				
				MessageBox.Show("Hubo un error al apagar el LED",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
	
		
		
	}
}
