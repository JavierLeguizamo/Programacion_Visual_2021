/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 13/05/2021
 * Time: 09:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Serial_Arduino
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnLED1;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.Button btnLED2;
		private System.Windows.Forms.Button btnLED3;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ComboBox cmbPuertos;
		private System.Windows.Forms.Button btnConectar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnLED1 = new System.Windows.Forms.Button();
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.btnLED2 = new System.Windows.Forms.Button();
			this.btnLED3 = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cmbPuertos = new System.Windows.Forms.ComboBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLED1
			// 
			this.btnLED1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnLED1.Enabled = false;
			this.btnLED1.Location = new System.Drawing.Point(12, 258);
			this.btnLED1.Name = "btnLED1";
			this.btnLED1.Size = new System.Drawing.Size(131, 60);
			this.btnLED1.TabIndex = 0;
			this.btnLED1.Text = " LED 1";
			this.btnLED1.UseVisualStyleBackColor = false;
			this.btnLED1.Click += new System.EventHandler(this.BtnLED1Click);
			// 
			// btnLED2
			// 
			this.btnLED2.Enabled = false;
			this.btnLED2.Location = new System.Drawing.Point(329, 258);
			this.btnLED2.Name = "btnLED2";
			this.btnLED2.Size = new System.Drawing.Size(131, 60);
			this.btnLED2.TabIndex = 1;
			this.btnLED2.Text = "LED 2";
			this.btnLED2.UseVisualStyleBackColor = true;
			this.btnLED2.Click += new System.EventHandler(this.BtnLED2Click);
			// 
			// btnLED3
			// 
			this.btnLED3.Enabled = false;
			this.btnLED3.Location = new System.Drawing.Point(168, 258);
			this.btnLED3.Name = "btnLED3";
			this.btnLED3.Size = new System.Drawing.Size(131, 60);
			this.btnLED3.TabIndex = 2;
			this.btnLED3.Text = "LED 3";
			this.btnLED3.UseVisualStyleBackColor = true;
			this.btnLED3.Click += new System.EventHandler(this.BtnLED3Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(12, 62);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(116, 48);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar Puertos";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// cmbPuertos
			// 
			this.cmbPuertos.FormattingEnabled = true;
			this.cmbPuertos.Location = new System.Drawing.Point(134, 77);
			this.cmbPuertos.Name = "cmbPuertos";
			this.cmbPuertos.Size = new System.Drawing.Size(121, 21);
			this.cmbPuertos.TabIndex = 4;
			this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.CmbPuertosSelectedIndexChanged);
			// 
			// btnConectar
			// 
			this.btnConectar.Enabled = false;
			this.btnConectar.Location = new System.Drawing.Point(12, 116);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(116, 50);
			this.btnConectar.TabIndex = 5;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.BtnConectarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 348);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.cmbPuertos);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnLED3);
			this.Controls.Add(this.btnLED2);
			this.Controls.Add(this.btnLED1);
			this.Name = "MainForm";
			this.Text = "Serial_Arduino";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
