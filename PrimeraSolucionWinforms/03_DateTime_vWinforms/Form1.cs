﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_DateTime_vWinforms
{
		public partial class Form1 : Form
		{
				public Form1()
				{
						InitializeComponent();
				}

				private void btnPrueba1_Click(object sender, EventArgs e)
				{
						DateTime fecha1;
						fecha1 = dtPfecha.Value;
						MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dd/MM/yyyy"));
				}


				private void btnPrueba2_Click(object sender, EventArgs e)
				{
						MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("dd/MM/yyyy"));
						DateTime fecha2;
				}
		}
}
