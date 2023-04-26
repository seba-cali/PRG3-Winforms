namespace ejemplo1
{
		partial class Form1
		{
				/// <summary>
				/// Variable del diseñador necesaria.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Limpiar los recursos que se estén usando.
				/// </summary>
				/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Código generado por el Diseñador de Windows Forms

				/// <summary>
				/// Método necesario para admitir el Diseñador. No se puede modificar
				/// el contenido de este método con el editor de código.
				/// </summary>
				private void InitializeComponent()
				{
						this.btnSaludar = new System.Windows.Forms.Button();
						this.lblSaludo = new System.Windows.Forms.Label();
						this.txtNombre = new System.Windows.Forms.TextBox();
						this.lblNombre = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// btnSaludar
						// 
						this.btnSaludar.Location = new System.Drawing.Point(198, 141);
						this.btnSaludar.Name = "btnSaludar";
						this.btnSaludar.Size = new System.Drawing.Size(165, 56);
						this.btnSaludar.TabIndex = 0;
						this.btnSaludar.Text = "SALUDAR";
						this.btnSaludar.UseVisualStyleBackColor = true;
						this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
						// 
						// lblSaludo
						// 
						this.lblSaludo.AutoSize = true;
						this.lblSaludo.Location = new System.Drawing.Point(250, 221);
						this.lblSaludo.Name = "lblSaludo";
						this.lblSaludo.Size = new System.Drawing.Size(0, 16);
						this.lblSaludo.TabIndex = 1;
						this.lblSaludo.Click += new System.EventHandler(this.btnSaludar_Click);
						// 
						// txtNombre
						// 
						this.txtNombre.Location = new System.Drawing.Point(226, 94);
						this.txtNombre.Name = "txtNombre";
						this.txtNombre.Size = new System.Drawing.Size(137, 22);
						this.txtNombre.TabIndex = 2;
						// 
						// lblNombre
						// 
						this.lblNombre.AutoSize = true;
						this.lblNombre.Location = new System.Drawing.Point(144, 100);
						this.lblNombre.Name = "lblNombre";
						this.lblNombre.Size = new System.Drawing.Size(56, 16);
						this.lblNombre.TabIndex = 3;
						this.lblNombre.Text = "Nombre";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(605, 386);
						this.Controls.Add(this.lblNombre);
						this.Controls.Add(this.txtNombre);
						this.Controls.Add(this.lblSaludo);
						this.Controls.Add(this.btnSaludar);
						this.Name = "Form1";
						this.Text = "Primera App";
						this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
						this.Load += new System.EventHandler(this.Form1_Load);
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Button btnSaludar;
				private System.Windows.Forms.Label lblSaludo;
				private System.Windows.Forms.TextBox txtNombre;
				private System.Windows.Forms.Label lblNombre;
		}
}

