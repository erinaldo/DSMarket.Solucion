﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarTipoProducto() {
            var TipoPrducto = ObjDataListas.Value.ListaTipoProducto(
                new Nullable<decimal>(), null);
            ddlSeleccionarTipoProducto.DataSource = TipoPrducto;
            ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
            ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
        }
        private void CargarCategorias() {
            try {
                var Categorias = ObjDataListas.Value.ListadoCategorias(Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
                ddlSeleccionarCategoria.DataSource = Categorias;
                ddlSeleccionarCategoria.DisplayMember = "Descripcion";
                ddlSeleccionarCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }
        private void CargarUnidadMedida() {
            var UnidadMeddida = ObjDataListas.Value.BuscaUnidadMedida();
            ddlSeleccionarUnidadMedida.DataSource = UnidadMeddida;
            ddlSeleccionarUnidadMedida.DisplayMember = "Descripcion";
            ddlSeleccionarUnidadMedida.ValueMember = "IdUnidadMedida";
        }
        private void CargarMarcas() {
            var MArcas = ObjDataListas.Value.BucaLisaMarcas();
            ddlSeleccionarMarca.DataSource = MArcas;
            ddlSeleccionarMarca.DisplayMember = "Descripcion";
            ddlSeleccionarMarca.ValueMember = "IdMarca";
        }
        private void CargarModelos() {
            try {
                var CargarModelos = ObjDataListas.Value.BuscaListaModelos(Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue));
                ddlSeleccionarModelo.DataSource = CargarModelos;
                ddlSeleccionarModelo.DisplayMember = "Descripcion";
                ddlSeleccionarModelo.ValueMember = "IdModelo";
            }
            catch (Exception) { }
        }

        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO PRODUCTO";
                btnGuardar.Text = "Guardar";

                lbCLaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Modificar";

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtStock.Enabled = false;
            }
            else if(VariablesGlobales.Accion=="DELETE")
            {
                lbTitulo.Text = "ELIMINAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Eliminar";

                ddlSeleccionarTipoProducto.Enabled = false;
                ddlSeleccionarCategoria.Enabled = false;
                ddlSeleccionarUnidadMedida.Enabled = false;
                ddlSeleccionarMarca.Enabled = false;
                ddlSeleccionarModelo.Enabled = false;
                ddlSeleccionarTipoSuplidor.Enabled = false;
                ddlSeleccionarSuplidor.Enabled = false;
                txtdescripcion.Enabled = false;
                txtComentario.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtReferencia.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtStock.Enabled = false;
                txtStockMinimo.Enabled = false;
                txtPorcientoDescuento.Enabled = false;
                btnAgregarTipoProducto.Enabled = false;
                btnRefrescarTipoProducto.Enabled = false;
                btnAgregarCategoria.Enabled = false;
                btnRefrescarCategoria.Enabled = false;
                btnAgregarUnidadMedida.Enabled = false;
                btnRefrescarUnidadMedida.Enabled = false;
                btnAgregarMarca.Enabled = false;
                btnRefrescarMarca.Enabled = false;
                btnAgregarModelo.Enabled = false;
                btnRefrescarModelo.Enabled = false;
                btnAgregarTipoSuplidor.Enabled = false;
                btnRefrescarTipoSuplidor.Enabled = false;
                btnAgregarSuplidor.Enabled = false;
                btnRefrescarSuplidor.Enabled = false;
                cbAceptaOferta.Enabled = false;

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                btnBuscarFoto.Enabled = false;
            }

            
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void ddlSeleccionarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarModelos();
        }
    }
}
