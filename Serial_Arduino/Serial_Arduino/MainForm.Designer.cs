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
		private System.Windows.Forms.Button btnEncender;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.Button btnApagar;
		
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
			this.btnEncender = new System.Windows.Forms.Button();
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.btnApagar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEncender
			// 
			this.btnEncender.Location = new System.Drawing.Point(12, 85);
			this.btnEncender.Name = "btnEncender";
			this.btnEncender.Size = new System.Drawing.Size(131, 60);
			this.btnEncender.TabIndex = 0;
			this.btnEncender.Text = "Encender LED";
			this.btnEncender.UseVisualStyleBackColor = true;
			this.btnEncender.Click += new System.EventHandler(this.BtnEncenderClick);
			// 
			// serialPort
			// 
			this.serialPort.PortName = "COM5";
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(168, 85);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(131, 60);
			this.btnApagar.TabIndex = 1;
			this.btnApagar.Text = "Apagar LED";
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 261);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.btnEncender);
			this.Name = "MainForm";
			this.Text = "Serial_Arduino";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
