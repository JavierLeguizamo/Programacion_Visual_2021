/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 08/04/2021
 * Time: 09:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Primera_Ventana
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
		void BtnAceptarClick(object sender, EventArgs e)
		{
			MessageBox.Show("Mensaje","Nombre de Ventana");
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			btnAceptar.Enabled = false;
			MessageBox.Show("Se ejecuto el evento Load","Evento Load");
		}
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			btnAceptar.Enabled = (txtNombre.Text != "");
		}
		void BtnAceptarEnabledChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Se ejecuto el evento de cambio habilitado","EnabledChanged");
		}
		
	}
}
