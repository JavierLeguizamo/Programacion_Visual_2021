/*
 * Created by SharpDevelop.
 * User: jimmy
 * Date: 08/04/2021
 * Time: 09:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Primera_Ventana
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.CheckBox chkAceptar;
		private System.Windows.Forms.ComboBox cmbElementos;
		
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.chkAceptar = new System.Windows.Forms.CheckBox();
			this.cmbElementos = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(32, 47);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(48, 20);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(86, 44);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(62, 178);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(277, 125);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.EnabledChanged += new System.EventHandler(this.BtnAceptarEnabledChanged);
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// chkAceptar
			// 
			this.chkAceptar.Location = new System.Drawing.Point(52, 90);
			this.chkAceptar.Name = "chkAceptar";
			this.chkAceptar.Size = new System.Drawing.Size(111, 28);
			this.chkAceptar.TabIndex = 3;
			this.chkAceptar.Text = "Acepto";
			this.chkAceptar.UseVisualStyleBackColor = true;
			this.chkAceptar.CheckedChanged += new System.EventHandler(this.ChkAceptarCheckedChanged);
			// 
			// cmbElementos
			// 
			this.cmbElementos.FormattingEnabled = true;
			this.cmbElementos.Items.AddRange(new object[] {
			"Elemento A",
			"Elemento B",
			"Elemento C",
			"Elemento D",
			"Elemento E",
			"Elemento F",
			"Elemento G",
			"Elemento H"});
			this.cmbElementos.Location = new System.Drawing.Point(218, 47);
			this.cmbElementos.Name = "cmbElementos";
			this.cmbElementos.Size = new System.Drawing.Size(121, 21);
			this.cmbElementos.TabIndex = 4;
			this.cmbElementos.Text = "Letras";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(427, 333);
			this.Controls.Add(this.cmbElementos);
			this.Controls.Add(this.chkAceptar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Name = "MainForm";
			this.Text = "Primer Programa con Ventanas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
