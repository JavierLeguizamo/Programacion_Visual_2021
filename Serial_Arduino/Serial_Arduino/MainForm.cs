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
using System.IO.Ports;
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
		
		void BtnLED1Click(object sender, EventArgs e)
		{
			try {
				serialPort.WriteLine("A");
				MessageBox.Show("Ok");
			} catch (Exception) {
				MessageBox.Show("Hubo un error al encender el LED",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
		void BtnLED2Click(object sender, EventArgs e)
		{
			try {
				serialPort.WriteLine("B");
				MessageBox.Show("Ok");
			} catch (Exception) {
				MessageBox.Show("Hubo un error al encender el LED",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
		void BtnLED3Click(object sender, EventArgs e)
		{
			try {
				serialPort.WriteLine("C");
				MessageBox.Show("Ok");
			} catch (Exception) {
				MessageBox.Show("Hubo un error al encender el LED",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			} 
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			try{
			String [] puertos = SerialPort.GetPortNames();//[COM1 COM2]
			cmbPuertos.Items.Clear();
				foreach(string port in puertos){
					//Primer ciclo port = "COM1"
					//Segundo ciclo port = "COM2"
					cmbPuertos.Items.Add(port);
				}
			}catch{
				MessageBox.Show("Hubo un error buscar los puertos",
				                "Error",MessageBoxButtons.OK,
				               MessageBoxIcon.Error);
			}
			
		}
		void BtnConectarClick(object sender, EventArgs e)
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
		void CmbPuertosSelectedIndexChanged(object sender, EventArgs e)
		{
			btnConectar.Enabled = true;
		}
	
		
		
	}
}
