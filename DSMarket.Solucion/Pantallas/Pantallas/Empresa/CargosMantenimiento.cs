﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class CargosMantenimiento : Form
    {
        public CargosMantenimiento()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosConsulta Consulta = new CargosConsulta();
            Consulta.ShowDialog();
        }

        private void CargosMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtCargo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarDepartamento.BackColor = Color.WhiteSmoke;

        }
    }
}
