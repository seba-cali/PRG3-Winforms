using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Varios_y_Operador_Ternario
{
		public partial class Form1 : Form
		{
				public Form1()
				{
						InitializeComponent();
				}

				private void btnAgregar_Click(object sender, EventArgs e)
				{
						string elem = txtNombre.Text;
						lwElementos.Items.Add(elem);
				}

				private void Form1_Load(object sender, EventArgs e)
				{
						cboColorFavorito.Items.Add("Rojo");
						cboColorFavorito.Items.Add("Verde");
						cboColorFavorito.Items.Add("Negro");
				}

				private void btnVerPerfil_Click(object sender, EventArgs e)
				{
						string nombre = txtNombre.Text;
						DateTime fecha = dtpFechaNacimiento.Value;
						//operador ternario "?" (if en una sola linea)
						string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
						string tipo;
						if (rbtMuggle.Checked)
								tipo = "Muggle";
						else if (rbtWizard.Checked)
								tipo = "Wizard";
						else
								tipo = "Squibs";
						//el combo box me carga cualquier tipo de objeto, le pongo el TOSTRING porque me trae un objeto
						string colorFavorito = cboColorFavorito.SelectedItem.ToString();
						string numeroFavorito = numNumeroFavorito.Value.ToString();
						string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + numeroFavorito;
						MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);

				}


		}
}
