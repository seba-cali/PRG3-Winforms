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
		public partial class frmPrincipal : Form
		{
				public frmPrincipal()
				{
						InitializeComponent();
				}

				private void frmPrincipal_Load(object sender, EventArgs e)
				{

				}

				private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
				{
						//validacion para que solo haya una de estas ventanas abiertas
						foreach (var item in Application.OpenForms)
						{
								if(item.GetType() == typeof(Form1))
								{
										MessageBox.Show("Ya hay una ventana de este tipo abierta");
										return;
								}
						}

						Form1 ventana = new Form1();
						ventana.MdiParent = this;//instancio un objeto de la ventana q quiero traer segun el boton que toco
						ventana.Show();
				}

				private void tsbPerfilPersona_Click(object sender, EventArgs e)
				{
						Form1 ventana = new Form1();
						ventana.ShowDialog();
				}
		}
}
