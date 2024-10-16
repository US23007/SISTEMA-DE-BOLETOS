﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave2_Grupo3_US23007_
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
            Imagen imagen = new Imagen();
            imagen.CargarImagenes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            BuscarVuelo buscar = new BuscarVuelo();
            buscar.Show();
            this.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccion Completada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Para continuar debe de Iniciar Sesion o Registrarse", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            IngresoAdministrador ingreso = new IngresoAdministrador();
            ingreso.Show();
            this.Hide();
        }
    }
}
