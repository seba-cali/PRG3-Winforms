﻿namespace _02_Varios_y_Operador_Ternario
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
						this.txtNombre = new System.Windows.Forms.TextBox();
						this.btnAgregar = new System.Windows.Forms.Button();
						this.lwElementos = new System.Windows.Forms.ListView();
						this.lblNombre = new System.Windows.Forms.Label();
						this.lblFecha = new System.Windows.Forms.Label();
						this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
						this.ckbChocolate = new System.Windows.Forms.CheckBox();
						this.lblTitulo = new System.Windows.Forms.Label();
						this.rbtWizard = new System.Windows.Forms.RadioButton();
						this.rbtMuggle = new System.Windows.Forms.RadioButton();
						this.rbtSquibs = new System.Windows.Forms.RadioButton();
						this.gbxTipo = new System.Windows.Forms.GroupBox();
						this.lblColor = new System.Windows.Forms.Label();
						this.cboColorFavorito = new System.Windows.Forms.ComboBox();
						this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
						this.lblNumeroFavorito = new System.Windows.Forms.Label();
						this.btnVerPerfil = new System.Windows.Forms.Button();
						this.gbxTipo.SuspendLayout();
						((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
						this.SuspendLayout();
						// 
						// txtNombre
						// 
						this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.txtNombre.Location = new System.Drawing.Point(158, 99);
						this.txtNombre.Name = "txtNombre";
						this.txtNombre.Size = new System.Drawing.Size(278, 22);
						this.txtNombre.TabIndex = 0;
						// 
						// btnAgregar
						// 
						this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.btnAgregar.Location = new System.Drawing.Point(12, 643);
						this.btnAgregar.Name = "btnAgregar";
						this.btnAgregar.Size = new System.Drawing.Size(75, 43);
						this.btnAgregar.TabIndex = 1;
						this.btnAgregar.Text = "Agregar";
						this.btnAgregar.UseVisualStyleBackColor = true;
						this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
						// 
						// lwElementos
						// 
						this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.lwElementos.HideSelection = false;
						this.lwElementos.Location = new System.Drawing.Point(39, 473);
						this.lwElementos.Name = "lwElementos";
						this.lwElementos.Size = new System.Drawing.Size(397, 148);
						this.lwElementos.TabIndex = 2;
						this.lwElementos.UseCompatibleStateImageBehavior = false;
						this.lwElementos.View = System.Windows.Forms.View.List;
						// 
						// lblNombre
						// 
						this.lblNombre.AutoSize = true;
						this.lblNombre.Location = new System.Drawing.Point(96, 102);
						this.lblNombre.Name = "lblNombre";
						this.lblNombre.Size = new System.Drawing.Size(56, 16);
						this.lblNombre.TabIndex = 3;
						this.lblNombre.Text = "Nombre";
						// 
						// lblFecha
						// 
						this.lblFecha.AutoSize = true;
						this.lblFecha.Location = new System.Drawing.Point(36, 135);
						this.lblFecha.Name = "lblFecha";
						this.lblFecha.Size = new System.Drawing.Size(116, 16);
						this.lblFecha.TabIndex = 4;
						this.lblFecha.Text = "Fecha Nacimiento";
						// 
						// dtpFechaNacimiento
						// 
						this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.dtpFechaNacimiento.Location = new System.Drawing.Point(159, 135);
						this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
						this.dtpFechaNacimiento.Size = new System.Drawing.Size(277, 22);
						this.dtpFechaNacimiento.TabIndex = 5;
						// 
						// ckbChocolate
						// 
						this.ckbChocolate.Anchor = System.Windows.Forms.AnchorStyles.Top;
						this.ckbChocolate.AutoSize = true;
						this.ckbChocolate.Location = new System.Drawing.Point(159, 182);
						this.ckbChocolate.Name = "ckbChocolate";
						this.ckbChocolate.Size = new System.Drawing.Size(165, 20);
						this.ckbChocolate.TabIndex = 6;
						this.ckbChocolate.Text = "Te gusta el chocolate?";
						this.ckbChocolate.UseVisualStyleBackColor = true;
						// 
						// lblTitulo
						// 
						this.lblTitulo.AutoSize = true;
						this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.lblTitulo.Location = new System.Drawing.Point(85, 13);
						this.lblTitulo.Name = "lblTitulo";
						this.lblTitulo.Size = new System.Drawing.Size(165, 29);
						this.lblTitulo.TabIndex = 7;
						this.lblTitulo.Text = "Perfil Persona";
						// 
						// rbtWizard
						// 
						this.rbtWizard.AutoSize = true;
						this.rbtWizard.Checked = true;
						this.rbtWizard.Location = new System.Drawing.Point(46, 30);
						this.rbtWizard.Name = "rbtWizard";
						this.rbtWizard.Size = new System.Drawing.Size(70, 20);
						this.rbtWizard.TabIndex = 8;
						this.rbtWizard.TabStop = true;
						this.rbtWizard.Text = "Wizard";
						this.rbtWizard.UseVisualStyleBackColor = true;
						// 
						// rbtMuggle
						// 
						this.rbtMuggle.AutoSize = true;
						this.rbtMuggle.Location = new System.Drawing.Point(166, 30);
						this.rbtMuggle.Name = "rbtMuggle";
						this.rbtMuggle.Size = new System.Drawing.Size(73, 20);
						this.rbtMuggle.TabIndex = 9;
						this.rbtMuggle.Text = "Muggle";
						this.rbtMuggle.UseVisualStyleBackColor = true;
						// 
						// rbtSquibs
						// 
						this.rbtSquibs.AutoSize = true;
						this.rbtSquibs.Location = new System.Drawing.Point(290, 30);
						this.rbtSquibs.Name = "rbtSquibs";
						this.rbtSquibs.Size = new System.Drawing.Size(70, 20);
						this.rbtSquibs.TabIndex = 10;
						this.rbtSquibs.Text = "Squibs";
						this.rbtSquibs.UseVisualStyleBackColor = true;
						// 
						// gbxTipo
						// 
						this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
						this.gbxTipo.Controls.Add(this.rbtWizard);
						this.gbxTipo.Controls.Add(this.rbtSquibs);
						this.gbxTipo.Controls.Add(this.rbtMuggle);
						this.gbxTipo.Location = new System.Drawing.Point(85, 208);
						this.gbxTipo.Name = "gbxTipo";
						this.gbxTipo.Size = new System.Drawing.Size(365, 73);
						this.gbxTipo.TabIndex = 11;
						this.gbxTipo.TabStop = false;
						this.gbxTipo.Text = "Tipo";
						// 
						// lblColor
						// 
						this.lblColor.AutoSize = true;
						this.lblColor.Location = new System.Drawing.Point(47, 333);
						this.lblColor.Name = "lblColor";
						this.lblColor.Size = new System.Drawing.Size(91, 16);
						this.lblColor.TabIndex = 12;
						this.lblColor.Text = "Color Favorito";
						// 
						// cboColorFavorito
						// 
						this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.cboColorFavorito.FormattingEnabled = true;
						this.cboColorFavorito.Location = new System.Drawing.Point(158, 325);
						this.cboColorFavorito.Name = "cboColorFavorito";
						this.cboColorFavorito.Size = new System.Drawing.Size(278, 24);
						this.cboColorFavorito.TabIndex = 13;
						// 
						// numNumeroFavorito
						// 
						this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.numNumeroFavorito.Location = new System.Drawing.Point(158, 359);
						this.numNumeroFavorito.Name = "numNumeroFavorito";
						this.numNumeroFavorito.Size = new System.Drawing.Size(278, 22);
						this.numNumeroFavorito.TabIndex = 14;
						// 
						// lblNumeroFavorito
						// 
						this.lblNumeroFavorito.AutoSize = true;
						this.lblNumeroFavorito.Location = new System.Drawing.Point(47, 365);
						this.lblNumeroFavorito.Name = "lblNumeroFavorito";
						this.lblNumeroFavorito.Size = new System.Drawing.Size(107, 16);
						this.lblNumeroFavorito.TabIndex = 15;
						this.lblNumeroFavorito.Text = "Numero Favorito";
						// 
						// btnVerPerfil
						// 
						this.btnVerPerfil.Location = new System.Drawing.Point(50, 423);
						this.btnVerPerfil.Name = "btnVerPerfil";
						this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
						this.btnVerPerfil.TabIndex = 16;
						this.btnVerPerfil.Text = "Ver Perfil";
						this.btnVerPerfil.UseVisualStyleBackColor = true;
						this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.MistyRose;
						this.ClientSize = new System.Drawing.Size(493, 715);
						this.Controls.Add(this.btnVerPerfil);
						this.Controls.Add(this.lblNumeroFavorito);
						this.Controls.Add(this.numNumeroFavorito);
						this.Controls.Add(this.cboColorFavorito);
						this.Controls.Add(this.lblColor);
						this.Controls.Add(this.gbxTipo);
						this.Controls.Add(this.lblTitulo);
						this.Controls.Add(this.ckbChocolate);
						this.Controls.Add(this.dtpFechaNacimiento);
						this.Controls.Add(this.lblFecha);
						this.Controls.Add(this.lblNombre);
						this.Controls.Add(this.lwElementos);
						this.Controls.Add(this.btnAgregar);
						this.Controls.Add(this.txtNombre);
						this.MaximumSize = new System.Drawing.Size(805, 833);
						this.MinimumSize = new System.Drawing.Size(511, 762);
						this.Name = "Form1";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						this.gbxTipo.ResumeLayout(false);
						this.gbxTipo.PerformLayout();
						((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.TextBox txtNombre;
				private System.Windows.Forms.Button btnAgregar;
				private System.Windows.Forms.ListView lwElementos;
				private System.Windows.Forms.Label lblNombre;
				private System.Windows.Forms.Label lblFecha;
				private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
				private System.Windows.Forms.CheckBox ckbChocolate;
				private System.Windows.Forms.Label lblTitulo;
				private System.Windows.Forms.RadioButton rbtWizard;
				private System.Windows.Forms.RadioButton rbtMuggle;
				private System.Windows.Forms.RadioButton rbtSquibs;
				private System.Windows.Forms.GroupBox gbxTipo;
				private System.Windows.Forms.Label lblColor;
				private System.Windows.Forms.ComboBox cboColorFavorito;
				private System.Windows.Forms.NumericUpDown numNumeroFavorito;
				private System.Windows.Forms.Label lblNumeroFavorito;
				private System.Windows.Forms.Button btnVerPerfil;
		}
}

