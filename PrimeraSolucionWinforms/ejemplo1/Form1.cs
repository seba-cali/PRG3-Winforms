using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
		public partial class Form1 : Form  //esta clase esta dividida en 2 partes. Partial te permite dividir una clase en 2 partes
		{
				public Form1()
				{
						InitializeComponent();
				}

				private void btnSaludar_Click(object sender, EventArgs e)
				{
						//MessageBox.Show("Hola mundo");
						string texto = txtNombre.Text;
						lblSaludo.Text = "HOLA " + texto;
				}

				private void Form1_Load(object sender, EventArgs e)
				{
						//MessageBox.Show("te doy la bienvenida...");
				}

				private void Form1_FormClosing(object sender, FormClosingEventArgs e)
				{
					//MessageBox.Show("adios...");
				}

		}
}
