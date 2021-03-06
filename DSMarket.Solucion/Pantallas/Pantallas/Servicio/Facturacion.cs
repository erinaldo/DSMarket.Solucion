﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region BLOQUEAR Y DESBLOQUEAR CONTROLES DEL LADO DEL CLIENTE
        private void BloarControlesClientes() {
            txtCodigoCliente.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            btnRegresar.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtComentario.Enabled = false;
            txtNombrePaciente.Enabled = false;

            //CARGAR LOS TIPOS DE FACTURACION
            //CARGAR LOS TIPOS DE IDENTIFICACION

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;

            txtNombrePaciente.Text = "CLIENTE CONSUMIDOR FINAL";
            txtIdentificacion.Text = "00000000000";
        }
        private void DesbloquearControlesClientes() {
            txtCodigoCliente.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            btnRegresar.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtComentario.Enabled = true;
            txtNombrePaciente.Enabled = true;

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
        }
        #endregion
        #region APLICAR TEMA
        private void TemaGenerico() {
            //COLOR DE FONDO
            this.BackColor = SystemColors.Control;


            //COLOR DE TEMBOX
            txtCodigoCliente.BackColor = Color.WhiteSmoke;
            ddlTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombrePaciente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtNoCotizacion.BackColor = Color.WhiteSmoke;
            ddlTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            ddlTipoVenta.BackColor = Color.WhiteSmoke;
            ddlCantidadDias.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            //txtPorcientoImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            ddltIPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtCambio.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;

            //COLOR DE FUENTE
            txtCodigoCliente.ForeColor = Color.Black;
            ddlTipoFacturacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtNoCotizacion.ForeColor = Color.Black;
            ddlTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            ddlTipoVenta.ForeColor = Color.Black;
            ddlCantidadDias.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            //txtPorcientoImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            ddltIPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtCambio.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;

            dtProductosAgregados.BackgroundColor = SystemColors.Control;
            dtFacturasMinimizadas.BackgroundColor = SystemColors.Control;

        }
        #endregion
        #region METODOS PARA MOVER LA PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        #region MOSTRAMOS LOS COMPROBANTES FISCALES

        private void MostrarComprobantesFiscales() {
            //VERIFICAMOS SI EL SISTEMA ESTA CONFIGURADO PARA USAR COMPROBANTES FISCALES
            bool UsoComprobante = false;
            var VerificarUsoComprobantes = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in VerificarUsoComprobantes)
            {
                UsoComprobante = Convert.ToBoolean(n.Estatus0);
            }
            if (UsoComprobante == true)
            {
                //Mostrar los comprobantes fiscales
                var Comprobantes = ObjDataListas.Value.BuscaCOmprobantesFiscales();
                ddlTipoFacturacion.DataSource = Comprobantes;
                ddlTipoFacturacion.DisplayMember = "Comprbante";
                ddlTipoFacturacion.ValueMember = "IdComprobante";
            }
            else {
                //No Mostrar los comprobantes fiscales
                var NoMostrarComprobantes = ObjDataListas.Value.BuscaComprobantesnulos();
                ddlTipoFacturacion.DataSource = NoMostrarComprobantes;
                ddlTipoFacturacion.DisplayMember = "Descripcion";
                ddlTipoFacturacion.ValueMember = "IdComprobanteNulo";
            }
        }
        #endregion
        #region MOSTRAR LISTADO DE LOS TIPOS DE VENTAS
        private void MostrarListadoTipoVenta() {
            var TipoVenta = ObjDataListas.Value.BuscaTipoVenta();
            ddlTipoVenta.DataSource = TipoVenta;
            ddlTipoVenta.DisplayMember = "TipoVenta";
            ddlTipoVenta.ValueMember = "IdTipoVenta";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS TIPOS DE IDENTIFICACION
        private void MostrarTipoIdentificacion() {
            var TipoIdentificacion = ObjDataListas.Value.BuscaTipoIdentificacion();
            ddlTipoIdentificacion.DataSource = TipoIdentificacion;
            ddlTipoIdentificacion.DisplayMember = "TipoIdentificacion";
            ddlTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region BLOQUEAR CONTROLES
        private void BloquearControles() {
            cbAgregarCliente.Enabled = false;
            cbBuscarPorCodigo.Enabled = false;
            txtCodigoConsulta.Enabled = false;
            btnBuscarCodigoCliente.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            txtCodigoCliente.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtNombrePaciente.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtNoCotizacion.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtComentario.Enabled = false;
            btnBuscarCotizacion.Enabled = false;

            btnRegresar.Enabled = true;
            btnRefresarCotizacion.Enabled = true;
            VariablesGlobales.BloqueaControles = true;
        }

        private void DesbloquearControles() {
            cbAgregarCliente.Enabled = true;
            cbBuscarPorCodigo.Enabled = true;
            txtCodigoConsulta.Enabled = true;
            btnBuscarCodigoCliente.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            txtCodigoCliente.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtNombrePaciente.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtNoCotizacion.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtComentario.Enabled = true;
            btnBuscarCotizacion.Enabled = true;

            btnRegresar.Enabled = false;
            btnRefresarCotizacion.Enabled = false;

            VariablesGlobales.BloqueaControles = false;

        }

        private void LimpiarControles() {
           
            txtCodigoConsulta.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;
            MostrarComprobantesFiscales();
            txtNombrePaciente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNoCotizacion.Text = string.Empty;
            MostrarTipoIdentificacion();
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            cbAgregarCliente.Checked = false;
            cbBuscarPorCodigo.Checked = false;
            MostrarListadoTipoVenta();
            cbAgregarCliente.Enabled = true;
            MostrarLosTipoSIngresos();
            txtCantidadDiasGarantia.Value = 0;
        }
        #endregion
        #region MOSTRAR LA CANTIDAD DE DIAS
        private void ListadoCantidadDias() {
            var Listado = ObjDataListas.Value.ListadoCantidadDias();
            ddlCantidadDias.DataSource = Listado;
            ddlCantidadDias.DisplayMember = "CantidadDias";
            ddlCantidadDias.ValueMember = "IdCantidadDias";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LAS FACTURAS MINIMIZADAS
        private void ListadoFacturaMinimizadas()
        {
            try
            {
                var BuscarFacturasMinimizadas = ObjDataServicio.Value.BuscaFacturasMinimizadas(
                    VariablesGlobales.IdUsuario);
                dtFacturasMinimizadas.DataSource = BuscarFacturasMinimizadas;
                OcultarColumnasMinimizadas();
                if (BuscarFacturasMinimizadas.Count() < 1)
                {
                    lbcantidadFActuras.Text = "0";

                }
                else
                {
                    foreach (var n in BuscarFacturasMinimizadas)
                    {
                        int CantidadRegistros = Convert.ToInt32(n.Cantidadregistros);
                        lbcantidadFActuras.Text = CantidadRegistros.ToString("N0");
                    }
                }
            }
            catch (Exception) { }

        }
        private void OcultarColumnasMinimizadas()
        {
            this.dtFacturasMinimizadas.Columns["IdUsuario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Usuario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NumeroConector"].Visible = false;
            this.dtFacturasMinimizadas.Columns["AgregarCliente"].Visible = false;
            this.dtFacturasMinimizadas.Columns["BuscarCliente"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["TipoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdCantidadDias"].Visible = false;
            this.dtFacturasMinimizadas.Columns["CantidadDias"].Visible = false;
            this.dtFacturasMinimizadas.Columns["RncConsulta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdComprobante"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Comprobante"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Telefono"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Email"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NoCotizacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["TipoIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NumeroIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Comentario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["MontoCredito"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FacturarCotizar"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FacturaPuntoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FormatoFactura"].Visible = false;
            this.dtFacturasMinimizadas.Columns["BloqueaControles"].Visible = false;
            this.dtFacturasMinimizadas.Columns["CantidadDiasGarantia"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoIngreso"].Visible = false;
            this.dtFacturasMinimizadas.Columns["TipoIngreso"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Cantidadregistros" +
                ""].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoTiempoGarantia"].Visible = false;
        }
        #endregion
        #region MANTENIMIENTO DE FACTURAS MINIMIZADAS
        private void MANFacturasMinimizadas(string Accion)
        {
            try
            {
                bool FacturrCotizar = false;

                if (rbFacturar.Checked == true)
                {
                    FacturrCotizar = true;
                }
                else if (rbCotizar.Checked == true)
                {
                    FacturrCotizar = false;
                }


                bool FormatoFActura = false;
                if (rbfacturaspanish.Checked == true)
                {
                    FormatoFActura = true;
                }
                else if (rbfacturaenglish.Checked == true)
                {
                    FormatoFActura = false;
                }

                if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
                {
                    txtNoCotizacion.Text = "0";
                }

                DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturaMinimizada();

                Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
                Mantenimiento.NumeroConector = VariablesGlobales.NumeroConector;
                Mantenimiento.Secuencia = VariablesGlobales.SecuencialFActuraMinimizada;
                Mantenimiento.AgregarCliente = cbAgregarCliente.Checked;
                Mantenimiento.BuscarCliente = cbBuscarPorCodigo.Checked;
                Mantenimiento.IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                Mantenimiento.IdCantidadDias = Convert.ToInt32(ddlCantidadDias.SelectedValue);
                Mantenimiento.RncConsulta = txtCodigoCliente.Text;
                Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
                Mantenimiento.Nombre = txtNombrePaciente.Text;
                Mantenimiento.Telefono = txtTelefono.Text;
                Mantenimiento.Email = txtEmail.Text;
                Mantenimiento.NoCotizacion = Convert.ToDecimal(txtNoCotizacion.Text);
                Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
                Mantenimiento.NumeroIdentificacion = txtIdentificacion.Text;
                Mantenimiento.Comentario = txtComentario.Text;
                Mantenimiento.MontoCredito = Convert.ToDecimal(lbMontoCredito.Text);
                Mantenimiento.FacturarCotizar = FacturrCotizar;
                Mantenimiento.FacturaPuntoVenta = cbFacturaPuntoVenta.Checked;
                Mantenimiento.FormatoFactura = FormatoFActura;
                Mantenimiento.BloqueaControles = VariablesGlobales.BloqueaControles;
                Mantenimiento.CantidadDiasGarantia = Convert.ToInt32(txtCantidadDiasGarantia.Value);
                Mantenimiento.IdTipoIngreso = Convert.ToInt32(ddlSeleccionarTipoIngres.SelectedValue);
                Mantenimiento.IdTipoTiempoGarantia = Convert.ToInt32(ddlSeleccionarTiempoGarantia.SelectedValue);

                var MANFacturaMinimizada = ObjDataServicio.Value.MantenimientoFacturaMinimizado(Mantenimiento, Accion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al minimizar, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        #endregion
        #region GENERAR NUMERO DE CONECTOR
        /// <summary>
        /// Este metodo es para generar un numero aleatorio desde el numero 0 hasta el 999,999,999
        /// </summary>
        private void GenerarNumeroConector() {
            Random Generar = new Random();
            int Numero = Generar.Next(0, 999999999);
            VariablesGlobales.NumeroConector = Numero;
            VariablesGlobales.GenerarConector = false;
            lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
        }
        #endregion
        #region MANTENIMIENTOS
        //GUARDAR LOS DATOS DEL CLIENTE
        private void GuardarDatosClientes(decimal IdFactura,string Accion) {
            int IdEstatusFacturacion = 0;

            if (rbFacturar.Checked == true) {
                IdEstatusFacturacion = 1;
            }
            else if (rbCotizar.Checked == true) { IdEstatusFacturacion = 2; }


            int TipoTiempoGarantia = 0;
            if (ddlSeleccionarTiempoGarantia.Text == "DIAS") { TipoTiempoGarantia = 1; }
            else {
                TipoTiempoGarantia = 2;
            }


            if (string.IsNullOrEmpty(txtNombrePaciente.Text.Trim())) {
                txtNombrePaciente.Text = "CLIENTE CONSUMIDOR FINAL";
            }

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes ManClientes = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            ManClientes.IdFactura = IdFactura;
            ManClientes.NumeroConector = VariablesGlobales.NumeroConector;
            ManClientes.IdEstatusFacturacion = IdEstatusFacturacion;
            ManClientes.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            ManClientes.Nombre = txtNombrePaciente.Text;
            ManClientes.Telefono = txtTelefono.Text;
            ManClientes.Email = txtEmail.Text;
            ManClientes.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            ManClientes.NumeroIdentificacion = txtIdentificacion.Text;
            ManClientes.Direccion = txtDireccion.Text;
            ManClientes.Comentario = txtComentario.Text;
            ManClientes.IdTipoVenta = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
            ManClientes.IdCantidadDias = Convert.ToDecimal(ddlCantidadDias.SelectedValue);
            ManClientes.IdUsuario = VariablesGlobales.IdUsuario;
            ManClientes.AplicaGarantia = VariablesGlobales.AplicaGanancia;
            ManClientes.DiasGarantia = Convert.ToInt32(txtCantidadDiasGarantia.Value);
            ManClientes.IdTipoIngreso = Convert.ToInt32(ddlSeleccionarTipoIngres.SelectedValue);
            ManClientes.IdTipoAnulaicon = 0;
            ManClientes.TipoTiempoGarantia =TipoTiempoGarantia;

            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(ManClientes, Accion);
        }
        //GUARDAR LOS DATOS DE LOS CALCULOS
        private void GuardarDatosCalculos(string Accion) {
            CalcularImpuestos();
            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Calculos = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            Calculos.NumeroColector = VariablesGlobales.NumeroConector;
            Calculos.CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            Calculos.CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            Calculos.CantidadArticulos = Convert.ToInt32(txtTotalServicios.Text);
            Calculos.TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            Calculos.SubTotal = Convert.ToDecimal(txtSubtotal.Text);
            Calculos.Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            Calculos.PorcientoImpuesto = 0;
            Calculos.MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);
            Calculos.Cambio = Convert.ToDecimal(txtCambio.Text);
            Calculos.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
            Calculos.TotalGeneral = Convert.ToDecimal(txtTotal.Text);
            Calculos.PorcientoTipoPago = Convert.ToInt32(txtImpuestoAdicional.Text);
            Calculos.MontoImpuestoTipoPago = Convert.ToDecimal(lbMontoPorcientoTipoPagoVariable.Text);
            Calculos.PorcientoImpuestoComprobante = Convert.ToInt32(txtImpuestoComprobante.Text);
            Calculos.MontoImpuestoComprobante = Convert.ToDecimal(lbMontoPorcientoImpuestoComprobanteVariable.Text);


            var MAn = ObjDataServicio.Value.GuardarFacturacionCalculos(Calculos, Accion);
        }
        #endregion
        #region SACAR LA DATA DE LAS FACTURAS MINIMIZADAS
        private void SacarDataFacturaMinimizadas() {
            var Buscar = ObjDataServicio.Value.BuscaFacturasMinimizadas(
                        VariablesGlobales.IdUsuario,
                        VariablesGlobales.NumeroConector,
                        VariablesGlobales.SecuencialFActuraMinimizada);
            foreach (var n in Buscar)
            {
                VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
                cbAgregarCliente.Checked = (n.AgregarCliente.HasValue ? n.AgregarCliente.Value : false);
                cbBuscarPorCodigo.Checked = (n.BuscarCliente.HasValue ? n.BuscarCliente.Value : false);
                ddlTipoVenta.Text = n.TipoVenta;
                ddlCantidadDias.Text = n.CantidadDias;
                txtCodigoCliente.Text = n.RncConsulta;
                ddlTipoFacturacion.Text = n.Comprobante;
                txtNombrePaciente.Text = n.Nombre;
                txtTelefono.Text = n.Telefono;
                txtEmail.Text = n.Email;
                txtNoCotizacion.Text = n.NoCotizacion.ToString();
                txtCantidadDiasGarantia.Value = Convert.ToInt32(n.CantidadDiasGarantia);
                ddlSeleccionarTipoIngres.Text = n.TipoIngreso;
                ddlSeleccionarTiempoGarantia.Text = n.TipoTiempoGarantia;
                if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
                {
                    txtNoCotizacion.Text = string.Empty;
                }
                ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.TipoIdentificacion;
                txtComentario.Text = n.Comentario;
                decimal MontoCredito = Convert.ToDecimal(n.MontoCredito);
                lbMontoCredito.Text = MontoCredito.ToString("N2");
                bool TipoProceso = Convert.ToBoolean(n.FacturarCotizar.HasValue ? n.FacturarCotizar.Value : false);
                if (TipoProceso == true)
                {
                    rbCotizar.Checked = false;
                    rbFacturar.Checked = true;
                }
                else
                {
                    rbFacturar.Checked = false;
                    rbCotizar.Checked = true;

                }
                cbFacturaPuntoVenta.Checked = (n.FacturaPuntoVenta.HasValue ? n.FacturaPuntoVenta.Value : false);
                bool BloqueaControles = Convert.ToBoolean(n.BloqueaControles.HasValue ? n.BloqueaControles.Value : false);
                if (BloqueaControles == true)
                {
                    BloquearControles();
                }
                else
                {
                    DesbloquearControles();
                }
            }
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTO ESPEJO
        private void MANProductoEspejo(string Accion) {

            if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim())) {
                txtNoCotizacion.Text = "0";
            }
            bool FActurarCotizar = false;
            if (rbFacturar.Checked == true) {
                FActurarCotizar = true;
            }
            else if (rbCotizar.Checked == true) {
                FActurarCotizar = false;
            }

            bool FormatoFActura = false;

            if (rbfacturaspanish.Checked == true) {
                FormatoFActura = true;
            }
            else if (rbfacturaenglish.Checked == true) {
                FormatoFActura = true;
            }

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturacionEspejo();

            Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.NumeroConector = VariablesGlobales.NumeroConector;
            Mantenimiento.AgregarCliente = cbAgregarCliente.Checked;
            Mantenimiento.BuscarCliente = cbBuscarPorCodigo.Checked;
            Mantenimiento.IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
            Mantenimiento.IdCantidadDias = Convert.ToInt32(ddlCantidadDias.SelectedValue);
            Mantenimiento.RncConsulta = txtCodigoCliente.Text;
            Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            Mantenimiento.Nombre = txtNombrePaciente.Text;
            Mantenimiento.Telefono = txtTelefono.Text;
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.NoCotizacion = Convert.ToDecimal(txtNoCotizacion.Text);
            Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            Mantenimiento.NumeroIdentificacion = txtIdentificacion.Text;
            Mantenimiento.Comentario = txtComentario.Text;
            Mantenimiento.MontoCredito = Convert.ToDecimal(lbMontoCredito.Text);
            Mantenimiento.FacturarCotizar = FActurarCotizar;
            Mantenimiento.FacturaPuntoVenta = cbFacturaPuntoVenta.Checked;
            Mantenimiento.FormatoFactura = FormatoFActura;
            Mantenimiento.BloqueaControles = VariablesGlobales.BloqueaControles;
            Mantenimiento.CantidadDiasGarantia = Convert.ToInt32(txtCantidadDiasGarantia.Value);
            Mantenimiento.IdTipoIngreso = Convert.ToInt32(ddlSeleccionarTipoIngres.SelectedValue);
            Mantenimiento.IdTiempoGarantia = Convert.ToInt32(ddlSeleccionarTiempoGarantia.SelectedValue);

            var MAn = ObjDataServicio.Value.ManteniientoFacturacionEspejo(Mantenimiento, Accion);

        }
        #endregion
        #region SACAR LOS DATOS DE LA FACTURACION ESPEJO
        /// <summary>
        /// Este metodo es para sacar los datos de la facturacion espejo, utilizada al momento de cambiar de pantalla
        /// </summary>
        /// <param name="IdUsuario"></param>
        private void SacarInformacionFacturacionEspejo() {
            var SacarListadoFacturacionEspejo = ObjDataServicio.Value.BuscaFacturacionEspeo(VariablesGlobales.IdUsuario);
            foreach (var n in SacarListadoFacturacionEspejo) {
                cbAgregarCliente.Checked = (n.AgregarCliente.HasValue ? n.AgregarCliente.Value : false);
                cbBuscarPorCodigo.Checked = (n.BuscarCliente.HasValue ? n.BuscarCliente.Value : false);
                VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
                txtNombrePaciente.Text = n.Nombre;
                txtCantidadDiasGarantia.Value = Convert.ToInt32(n.CantidadDiasGarantia);
                ddlSeleccionarTipoIngres.Text = n.TipoIngreso;
                ddlSeleccionarTiempoGarantia.Text = n.TipoTiempoGarantia;
               
                ddlTipoVenta.Text = n.TipoVenta;
                ddlCantidadDias.Text = n.CantidadDias;
                txtCodigoCliente.Text = n.RncConsulta;
                ddlTipoFacturacion.Text = n.Comprobante;
                txtTelefono.Text = n.Telefono;
                txtEmail.Text = n.Email;
                if (n.NoCotizacion == 0)
                {
                    txtNoCotizacion.Text = string.Empty;
                }
                else {
                    txtNoCotizacion.Text = n.NoCotizacion.ToString();
                }
                ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.NumeroIdentificacion;
                txtComentario.Text = n.Comentario;
                decimal MontoCredito = Convert.ToDecimal(n.MontoCredito);
                lbMontoCredito.Text = MontoCredito.ToString("N2");
                bool FacturarCotizar = Convert.ToBoolean(n.FacturarCotizar);
                if (FacturarCotizar == true) {
                    rbCotizar.Checked = false;
                    rbFacturar.Checked = true;
                }
                else if (FacturarCotizar == false) {
                    rbFacturar.Checked = false;
                    rbCotizar.Checked = true;
                }
                cbFacturaPuntoVenta.Checked = (n.FacturaPuntoVenta.HasValue ? n.FacturaPuntoVenta.Value : false);
                bool FormatoFactura = Convert.ToBoolean(n.FormatoFactura);
                if (FormatoFactura == true) {
                    rbfacturaenglish.Checked = false;
                    rbfacturaspanish.Checked = true;
                }
                else if (FormatoFactura == false) {
                    rbfacturaspanish.Checked = false;
                    rbfacturaenglish.Checked = true;    
                }
                bool BloqueaControles = Convert.ToBoolean(n.BloqueaControles);
                if (BloqueaControles == true)
                {
                    BloquearControles();
                    btnAgregarAlmacen.Visible = false;
                    btnRegresar.Visible = true;
                }
                else if (BloqueaControles == false)
                {
                    DesbloquearControles();
                }
            }
        }
        #endregion
        #region BUSCAR CONTROLES
        private void BuscarPorRNC() {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo rnc vacio para buscar un registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCliente.Focus();
            }
            else
            {
                //BUSCAMOS EL REGISTRO
                var Buscarregistro = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    null, null, txtCodigoCliente.Text, null,null, 1, 1);
                if (Buscarregistro.Count() < 1)
                {
                    MessageBox.Show("El rnc de cliente ingresado no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoCliente.Text = string.Empty;
                    txtCodigoCliente.Focus();
                }
                else
                {
                    foreach (var n in Buscarregistro)
                    {
                        bool usoComprobante = false;

                        var ValidarUsoCOmprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
                        foreach (var n2 in ValidarUsoCOmprobante)
                        {
                            usoComprobante = Convert.ToBoolean(n2.Estatus0);
                        }

                        if (usoComprobante == true)
                        {
                            ddlTipoFacturacion.Text = n.Comprobante;
                        }
                        decimal Credito = Convert.ToDecimal(n.MontoCredito);
                        lbMontoCredito.Text = Credito.ToString("N2");
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        txtEmail.Text = n.Email;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.RNC;
                        txtDireccion.Text = n.Direccion;
                        txtComentario.Text = n.Comentario;
                    }
                    btnAgregarAlmacen.Visible = false;
                    btnRegresar.Visible = true;
                    BloquearControles();
                }
            }
        }
        #endregion
        #region BUSCAR LOS PRODUCTOS AGRGADOS
        private void BuscarProductosAgregados(decimal NumeroConector)
        {
            var BuscarRegistros = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<Decimal>(),
                NumeroConector);
            dtProductosAgregados.DataSource = BuscarRegistros;

            foreach (var n in BuscarRegistros)
            {
                decimal TotalDescuento = Convert.ToDecimal(n.TotalDescuento);
                decimal SubTotal = Convert.ToDecimal(n.SubTotal);
                decimal Impuesto = Convert.ToDecimal(n.TotalImpuesto);
              //  decimal PorcientoImpuesto = Convert.ToDecimal(n.PorcientoImpuesto);
                decimal Total = Convert.ToDecimal(n.TotalGeneral);
                decimal CantidadArticulos = Convert.ToDecimal(n.CantidadProductos);
                decimal CantidadServicios = Convert.ToDecimal(n.CantidadServicios);
                decimal TotalRegistros = Convert.ToDecimal(n.CantidadRegistros);
              

                txtTotalDescuento.Text = TotalDescuento.ToString("N2");
                txtSubtotal.Text = SubTotal.ToString("N2");
                txtImpuesto.Text = Impuesto.ToString("N2");
               // txtPorcientoImpuesto.Text = PorcientoImpuesto.ToString("N0");
                txtTotal.Text = Total.ToString("N2");
                VariablesGlobales.TotalPagarFacturacion = Convert.ToDecimal(txtTotal.Text);
                txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N0");
                txtCantidadServicios.Text = CantidadServicios.ToString("N0");
                txtTotalServicios.Text = TotalRegistros.ToString("N0");
            }

            this.dtProductosAgregados.Columns["NumeroConector"].Visible = false;
            this.dtProductosAgregados.Columns["IdTipoProducto"].Visible = false;
            this.dtProductosAgregados.Columns["IdCategoria"].Visible = false;
            this.dtProductosAgregados.Columns["DescripcionTipoProducto1"].Visible = false;
            this.dtProductosAgregados.Columns["Acumulativo"].Visible = false;
            this.dtProductosAgregados.Columns["IdProducto"].Visible = false;
            this.dtProductosAgregados.Columns["ConectorProducto"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadProductos"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadServicios"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadRegistros"].Visible = false;
            this.dtProductosAgregados.Columns["TotalDescuento"].Visible = false;
            this.dtProductosAgregados.Columns["PorcientoImpuesto"].Visible = false;
            this.dtProductosAgregados.Columns["SubTotal"].Visible = false;
            this.dtProductosAgregados.Columns["TotalImpuesto"].Visible = false;
            this.dtProductosAgregados.Columns["TotalGeneral"].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;

            bool Operacion = false;

            var ValidarOperacionImpuesto = ObjDataConfiguracion.Value.BuscaImpuestos(1);
            foreach (var ni in ValidarOperacionImpuesto)
            {
                Operacion = Convert.ToBoolean(ni.Operacion0);
            }

            if (Operacion == true) {
                decimal SubtotalMaco = Convert.ToDecimal(txtSubtotal.Text);
                decimal ImpuestoMaco = Convert.ToDecimal(txtImpuesto.Text);
                decimal TotalPagarMaco = Convert.ToDecimal(txtTotal.Text);
                decimal TotalDescuentoMaco = Convert.ToDecimal(txtTotalDescuento.Text);
                decimal OperacionMaco = 0;

                txtSubtotal.Text = string.Empty;
                txtTotal.Text = string.Empty;

                OperacionMaco = (TotalPagarMaco + ImpuestoMaco) - TotalDescuentoMaco;
                txtSubtotal.Text = TotalPagarMaco.ToString("N2");
                txtTotal.Text = OperacionMaco.ToString("N2");
            }
            if (lbTitulo.Text != "FACTURACION" && lbTitulo.Text != "COTIZACION")
            {
                cbAgregarCliente.Enabled = false;
                btnAgregarProductos.Enabled = false;
                dtFacturasMinimizadas.Enabled = false;
            }
            else { cbAgregarCliente.Enabled = true;
                btnAgregarProductos.Enabled = true;
                dtFacturasMinimizadas.Enabled = true;
            }
        }
        #endregion
        #region MOSTRAR LOS TIPOS DE PAGOS
        private void MostrarListadoTipoPagos() {
            var TipoPago = ObjDataListas.Value.BuscaTipoPago(
                new Nullable<decimal>());
            ddltIPago.DataSource = TipoPago;
            ddltIPago.DisplayMember = "TipoPago";
            ddltIPago.ValueMember = "IdTipoPago";
        }
        #endregion
        #region DEVOLVER PRODUCTO A INVENTARIO
        private void DevolverProductosInventario(decimal NumeroConectorProcesar) {
            if (lbTitulo.Text == "FACTURACION" || lbTitulo.Text == "COTIZACION") {
                var BuscaProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
               new Nullable<decimal>(),
               NumeroConectorProcesar);
                decimal IdProducto = 0;
                decimal IdTipoProducto = 0;
                bool Acumulativo = false;
                bool EstatusProducto = false;
                decimal NumeroConector = 0;
                int CantidadAgregada = 0;
                foreach (var n in BuscaProductosAgregados)
                {
                    IdProducto = Convert.ToDecimal(n.IdProducto);

                    //BUSCAMOS EL PRODUCTO PARA DETERMINAR QUE TIPO DE PRODUCTO ES
                    var SacarDatosProducto = ObjDataInventario.Value.BuscaProductos(
                        IdProducto,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null, null, null, null,
                        null,
                        null,
                        null, 1, 1);
                    foreach (var n2 in SacarDatosProducto)
                    {
                        IdTipoProducto = Convert.ToDecimal(n2.IdTipoProducto);
                        Acumulativo = Convert.ToBoolean(n2.ProductoAcumulativo0);
                        EstatusProducto = Convert.ToBoolean(n2.EstatusProducto0);
                        NumeroConector = Convert.ToDecimal(n2.NumeroConector);
                        CantidadAgregada = Convert.ToInt32(n.Cantidad);
                    }

                    //VALIDAMOS LOS DATOS
                    if (IdTipoProducto == 1)
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS
                        if (Acumulativo == true)
                        {
                            //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE SON ACUMULATIVO
                            //DEVOLVEMOS EL ESTATUS DEL PRODUCTO


                            ModificarStockproducto(IdProducto, NumeroConector, CantidadAgregada, "ADDPRODUCT");

                            //  EliminarListadoProductosAgregados();
                        }
                        else
                        {
                            //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE NO SON ACUMULATIVO
                            //ACTUAMIZAMOS EL ESTATUS DEL PRODUCTO

                            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Devolver = new Logica.Entidades.EntidadesInventario.EProducto();

                            Devolver.IdProducto = IdProducto;
                            Devolver.IdTipoProducto = IdTipoProducto;
                            Devolver.ProductoAcumulativo0 = Acumulativo;
                            Devolver.EstatusProducto0 = EstatusProducto;

                            var Add = ObjDataInventario.Value.MantenimientoProducto(Devolver, "CHANGESTATUS");
                            EliminarListadoProductosAgregados();
                        }
                    }
                    else
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS SERVICIOS
                        //   EliminarListadoProductosAgregados();
                    }
                }
            }
        }
        #endregion
        #region ELIMINAR LISTADO DE PRODUCTOS AGREGADOS
        private void EliminarListadoProductosAgregados() {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto Eliminar = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

            Eliminar.NumeroConector = VariablesGlobales.NumeroConector;

            var MAN = ObjDataServicio.Value.GuardarFacturacionProductos(Eliminar, "DELETEALL");
            //DSMarket.Logica.Entidades.EntidadesServicio.EProductosAgregados Eliminar = new Logica.Entidades.EntidadesServicio.EProductosAgregados();

            //Eliminar.NumeroConector = VariablesGlobales.NumeroConector;

            //var Borrar = ObjDataServicio.Value.GuardarFacturacionProductos(Eliminar, "DELETE");
        }
        #endregion
        #region MODIFICAR EL STOCK DE LA FACTURA
        private void ModificarStockproducto(decimal IdProducto, decimal NumeroConector, int Stock, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Alterar = new Logica.Entidades.EntidadesInventario.EProducto();

            Alterar.IdProducto = IdProducto;
            Alterar.NumeroConector = NumeroConector;
            Alterar.Stock = Stock;

            var MAn = ObjDataInventario.Value.MantenimientoProducto(Alterar, Accion);
        }
        #endregion
        #region PROCESO PARA COTIZAR
        private void ProcesoCotizar(decimal NumeroConectorProcesar) {
            var BuscaProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
               new Nullable<decimal>(),
               NumeroConectorProcesar);
            decimal IdProducto = 0;
            decimal IdTipoProducto = 0;
            bool Acumulativo = false;
            bool EstatusProducto = false;
            decimal NumeroConector = 0;
            int CantidadAgregada = 0;
            foreach (var n in BuscaProductosAgregados)
            {
                IdProducto = Convert.ToDecimal(n.IdProducto);

                //BUSCAMOS EL PRODUCTO PARA DETERMINAR QUE TIPO DE PRODUCTO ES
                var SacarDatosProducto = ObjDataInventario.Value.BuscaProductos(
                    IdProducto,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null, null, null, null,
                    null,
                    null,
                    null, 1, 1);
                foreach (var n2 in SacarDatosProducto)
                {
                    IdTipoProducto = Convert.ToDecimal(n2.IdTipoProducto);
                    Acumulativo = Convert.ToBoolean(n2.ProductoAcumulativo0);
                    EstatusProducto = Convert.ToBoolean(n2.EstatusProducto0);
                    NumeroConector = Convert.ToDecimal(n2.NumeroConector);
                    CantidadAgregada = Convert.ToInt32(n.Cantidad);
                }

                //VALIDAMOS LOS DATOS
                if (IdTipoProducto == 1)
                {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS
                    if (Acumulativo == true)
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE SON ACUMULATIVO
                        //DEVOLVEMOS EL ESTATUS DEL PRODUCTO


                        ModificarStockproducto(IdProducto, NumeroConector, CantidadAgregada, "ADDPRODUCT");

                        //  EliminarListadoProductosAgregados();
                    }
                    else
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE NO SON ACUMULATIVO
                        //ACTUAMIZAMOS EL ESTATUS DEL PRODUCTO

                        DSMarket.Logica.Entidades.EntidadesInventario.EProducto Devolver = new Logica.Entidades.EntidadesInventario.EProducto();

                        Devolver.IdProducto = IdProducto;
                        Devolver.IdTipoProducto = IdTipoProducto;
                        Devolver.ProductoAcumulativo0 = Acumulativo;
                        Devolver.EstatusProducto0 = EstatusProducto;

                        var Add = ObjDataInventario.Value.MantenimientoProducto(Devolver, "CHANGESTATUS");
                        
                    }
                }
                else
                {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS SERVICIOS
                    //   EliminarListadoProductosAgregados();
                }
            }
        }
        #endregion
        #region CALCULAR CAMBIO
        /// <summary>
        /// Este metodo es para calcular el cambio de la factura.
        /// </summary>
        private void CalcularCambio() {
            try
            {
                decimal MontoPagar, Total, Cambio;
                MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                Total = Convert.ToDecimal(txtTotal.Text);
                Cambio = MontoPagar - Total;
                txtCambio.Text = Cambio.ToString("N2");
            }
            catch (Exception) { }
        }
        #endregion
        #region AGREGAR REGISTROS A FACTURA
        /// <summary>
        /// Este metodo es para cambiar de pantalla para agregar registros a factura.
        /// </summary>
        private void AgregarRegistros() {
            MANProductoEspejo("DELETE");
            MANProductoEspejo("INSERT");
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AgregarProductos AddProducts = new AgregarProductos();
            AddProducts.VariablesGlbales.IdUsuario = VariablesGlobales.IdUsuario;
            AddProducts.VariablesGlbales.GenerarConector = VariablesGlobales.GenerarConector;
            AddProducts.VariablesGlbales.NumeroConector = VariablesGlobales.NumeroConector;
            AddProducts.VariablesGlbales.EstatusFacturacion = VariablesGlobales.EstatusFacturacion;
            AddProducts.VariablesGlbales.ConvertirCotizacionFactura = VariablesGlobales.ConvertirCotizacionFactura;
            AddProducts.ShowDialog();
        }
        #endregion
        #region AFECTAR COMPROBANTE FISCAL
        
        private void AfectarComprobanteFiscal() {
            //VALIDAMOS SI LOS COMPROBANTES ESTAN ACTIVOS
            bool EstatusComprobante = false;

            var ValidarComprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in ValidarComprobante) {
                EstatusComprobante = Convert.ToBoolean(n.Estatus0);
            }
            if (EstatusComprobante == true)
            {
                //AFECTAMOS LOS COMPROBANTES
                decimal IdFacturaSacada = 0;
                string DescripcionComprobanteSacada = "";
                string NumeroComprobante = "";
                //1- SACAMOS EL NUMERO DE LA FACTURA
                var SacarnumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var ns in SacarnumeroFactura)
                {
                    IdFacturaSacada = Convert.ToDecimal(ns.IdFactura);
                }

                //2- SACAMOS LA DESCRIPCION DEL COMPROBANTE Y EL NUMERO DE COMPROBANTE
                var GenerarComprobanteFiscal = ObjDataConfiguracion.Value.GenerarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                foreach (var n3 in GenerarComprobanteFiscal)
                {
                    DescripcionComprobanteSacada = n3.TipoComprobante;
                    NumeroComprobante = n3.Comprobante;
                }

                DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes Afectar = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes();

                Afectar.IdFacturacion = IdFacturaSacada;
                Afectar.NumeroConector = VariablesGlobales.NumeroConector;
                Afectar.DescripcionComprobante = DescripcionComprobanteSacada;
                Afectar.Comprobante = NumeroComprobante;

                var MAN = ObjDataServicio.Value.GuardarFacturacionComprobante(Afectar, "INSERT");

            }
            else if (EstatusComprobante == false) { }

        }
        #endregion
        #region AFECTAR LA CAJA
        private void AfectarCaja() {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoCaja = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

            MantenimientoCaja.IdHistorialCaja = 0;
            MantenimientoCaja.IdCaja = 1;
            MantenimientoCaja.Monto = Convert.ToDecimal(txtTotal.Text);
            MantenimientoCaja.Concepto = "FACTURACION";
            MantenimientoCaja.Fecha0 = DateTime.Now;
            MantenimientoCaja.IdUsuario = VariablesGlobales.IdUsuario;
            MantenimientoCaja.NumeroReferencia = VariablesGlobales.NumeroConector;
            MantenimientoCaja.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);

            var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(MantenimientoCaja, "INSERT");
        }

        private void IngresarSacarDinero(string Accion)
        {
            try
            {
                DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral AbrirCerrar = new Logica.Entidades.EntidadesCaja.ECajaGeneral();

                AbrirCerrar.IdCaja = 1;
                AbrirCerrar.Caja = "Caja General";
                AbrirCerrar.MontoActual = Convert.ToDecimal(txtTotal.Text);
                AbrirCerrar.Estatus0 = true;

                var MAN = ObjDataCaja.Value.AfectarCaja(AbrirCerrar, Accion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir o cerrar caja, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region GENERAR LA FACTURA
        private void GenerarFacturaVenta() {
            try {
                decimal IdFactura = 0;
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS EL NUMERO DE LA FACTURA
                var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var n in SacarNumeroFactura) {
                    IdFactura = Convert.ToDecimal(n.IdFactura);
                }

                if (cbFacturaPuntoVenta.Checked) {
                    //IMPRIMIMOS A FACTURA PUNTO DE VENTA
                    //SACAMOS LA RUTA DEL REPORTE DEPENDIENDO LA SELECCIONADO
                    if (rbfacturaspanish.Checked == true)
                    {
                        var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(7);
                        foreach (var n in SacarRutaReporte)
                        {
                            RutaReporte = n.RutaReporte;
                        }
                    }
                    else if (rbfacturaenglish.Checked == true)
                    {
                        var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(8);
                        foreach (var n in SacarRutaReporte)
                        {
                            RutaReporte = n.RutaReporte;
                        }
                    }
                }
                else {
                    //SACAMOS LA RUTA DEL REPORTE DEPENDIENDO LA SELECCIONADO
                    if (rbfacturaspanish.Checked == true)
                    {
                        var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(1);
                        foreach (var n in SacarRutaReporte)
                        {
                            RutaReporte = n.RutaReporte;
                        }
                    }
                    else if (rbfacturaenglish.Checked == true)
                    {
                        var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(2);
                        foreach (var n in SacarRutaReporte)
                        {
                            RutaReporte = n.RutaReporte;
                        }
                    }
                }

                //SACAMOS LAS CREDENCIALES DE LAS BASES DE DATOS
                var SacarCredencialesBD = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCredencialesBD) {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                //INVOCAMOS LA FACTURA
                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes FacturaVenta = new Reportes.Reportes();
                FacturaVenta.GenerarFacturaVenta(IdFactura, RutaReporte, UsuarioBD, ClaveBD);
                FacturaVenta.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar la factura, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region BUSCAR LA COTIZACION
        public void BuscarCotizacion() {
            if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar el numero de una cotización", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //BUSCAMOS LA COTIZACION
                var BuscarCotizacion = ObjDataServicio.Value.HistorialFacturacion(
                    Convert.ToDecimal(txtNoCotizacion.Text),
                    null,
                    2,
                    null,
                    null,
                    null,
                    null,
                    null,
                    1, 1);
                if (BuscarCotizacion.Count() < 1)
                {
                    MessageBox.Show("El numero ingresado no corresponde a ninguna cotización creada en el sistema, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //BUSCAMOS EL REGISTRO
                    foreach (var n in BuscarCotizacion)
                    {
                        //txtCodigoCliente.Text = n.NumeroIdentificacion;
                        ddlTipoFacturacion.Text = n.DescripcionComprobante;
                        txtNombrePaciente.Text = n.Cliente;
                        txtTelefono.Text = n.Telefono;
                        txtEmail.Text = n.Email;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.NumeroIdentificacion;
                        txtDireccion.Text = n.Direccion;
                        txtComentario.Text = n.Comentario;
                        VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);

                    }
                    rbCotizar.Checked = false;
                    rbFacturar.Checked = true;
                    ProcesarInformacionCuentasContables();
                    AfectarCuentasContablesCreditos();
                    AfectarCuentasContableOtrosImpuestos();
                    rbFacturar.Checked = false;
                    BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                    VariablesGlobales.ConvertirCotizacionFactura = true;
                    rbCotizar.Checked = true;
                    cbAgregarCliente.Enabled = false;
                    txtNoCotizacion.Enabled = false;
                }
            }
            MostrarComprobantesFiscales();
            ddlTipoFacturacion.Enabled = true;
            //btnBuscarCotizacion.Visible = false;
            // btnRefresarCotizacion.Visible = true;
        }
        #endregion
        #region CONVERTIR COTIZACION A FACTURA
        private void ConvertirCotizacionFactura() {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes CambiarEstatus = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            CambiarEstatus.IdFactura = Convert.ToDecimal(txtNoCotizacion.Text);
            CambiarEstatus.NumeroConector = VariablesGlobales.NumeroConector;
            CambiarEstatus.IdEstatusFacturacion = 1;

            var MANCambiarEstatus = ObjDataServicio.Value.GuardarFacturacionClientes(CambiarEstatus, "CHANGESTATUS");

            //MODIFICAMOS DATOS EN LA TABLA DE CALCULOS
            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos ModificarCalculos = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            ModificarCalculos.NumeroColector = VariablesGlobales.NumeroConector;
            ModificarCalculos.MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);
            ModificarCalculos.Cambio = Convert.ToDecimal(txtCambio.Text);
            ModificarCalculos.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
            ModificarCalculos.TotalGeneral = Convert.ToDecimal(txtTotal.Text);

            var MANModificarCalculos = ObjDataServicio.Value.GuardarFacturacionCalculos(ModificarCalculos, "CHANGESTATUS");

         

            //AFECTAMOS EL INVENTARIO
            var BuscarProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            foreach (var n in BuscarProductosAgregados)
            {
                decimal IdTipoProducto = 0;
                decimal CantidadArticulos = 0;
                decimal IdProducto = 0;
                decimal Conectorproducto = 0;


                IdTipoProducto = Convert.ToDecimal(n.IdTipoProducto);
                IdProducto = Convert.ToDecimal(n.IdProducto);
                CantidadArticulos = Convert.ToInt32(n.Cantidad);




                if (IdTipoProducto == 1)
                {
                    bool ProductoAcumulativo = false;
                    bool EstatusProducto = false;
                    //SACAMOS LA INFORMACION DE QUE SI EL PRODUCTO ES ACUMULATIVO O NO

                    var ProductoAcumulativoInformacion = ObjDataInventario.Value.BuscaProductos(
                        IdProducto, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                    foreach (var n2 in ProductoAcumulativoInformacion)
                    {
                        ProductoAcumulativo = Convert.ToBoolean(n2.ProductoAcumulativo0);
                        Conectorproducto = Convert.ToDecimal(n2.NumeroConector);
                    }

                    if (ProductoAcumulativo == true)
                    {
                        //Descontar
                        DSMarket.Logica.Entidades.EntidadesInventario.EProducto Descontar = new Logica.Entidades.EntidadesInventario.EProducto();

                        Descontar.IdProducto = IdProducto;
                        Descontar.NumeroConector = Conectorproducto;
                        Descontar.Stock = CantidadArticulos;

                        var MAN = ObjDataInventario.Value.MantenimientoProducto(Descontar, "LESSPRODUCT");
                    }
                    else if (ProductoAcumulativo == false)
                    {
                        //Cambiar Estatus
                        DSMarket.Logica.Entidades.EntidadesInventario.EProducto ModificarEstatus = new Logica.Entidades.EntidadesInventario.EProducto();

                        ModificarEstatus.IdProducto = IdProducto;
                        ModificarEstatus.IdTipoProducto = IdTipoProducto;
                        ModificarEstatus.ProductoAcumulativo0 = ProductoAcumulativo;
                        ModificarEstatus.EstatusProducto0 = EstatusProducto;

                        var MAN = ObjDataInventario.Value.MantenimientoProducto(ModificarEstatus, "CHANGESTATUS");
                    }

                }

             

            }
            AfectarComprobanteFiscal();
            AfectarCaja();
            IngresarSacarDinero("ADDMONEY");
            //ProcesarInformacionCuentasContables();
            //AfectarCuentasContablesCreditos();
            //AfectarCuentasContableOtrosImpuestos();
            MessageBox.Show("Operación realizada exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            GenerarFacturaVenta();
            this.Dispose();
            //INVOCAMOS LA FACTURA
        }
        #endregion
        #region SACAR LAS CONFIGURACIONES GENERALES


        private void ValidarConfiguracionGeneral() {
            bool FacturaIngles = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(2);
            if (FacturaIngles == true)
            {
                rbfacturaenglish.Checked = true;
                rbfacturaspanish.Checked = false;
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.LimeGreen;
            }
            else {
                rbfacturaenglish.Checked = false;
                rbfacturaspanish.Checked = true;
                rbfacturaenglish.ForeColor = Color.DarkRed;
                rbfacturaspanish.ForeColor = Color.LimeGreen;
            }


            bool FActuraPuntoVenta = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(3);
            if (FActuraPuntoVenta == true)
            {
                cbFacturaPuntoVenta.Checked = true;
                cbFacturaPuntoVenta.ForeColor = Color.LimeGreen;
            }
            else {
                cbFacturaPuntoVenta.Checked = false;
                cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            }

            bool LlevaGarantia = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(5);
            if (LlevaGarantia == true) {
                lbCantidadGarantia.Visible = true;
                txtCantidadDiasGarantia.Visible = true;
                VariablesGlobales.AplicaGanancia = true;
            
            }
            else {
                lbCantidadGarantia.Visible = false;
                txtCantidadDiasGarantia.Visible = false;
                VariablesGlobales.AplicaGanancia = false;
            
            }

        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS TIPOS DE INGRESOS
        private void MostrarLosTipoSIngresos() {
            var TiposIngresos = ObjDataListas.Value.ListadoTipoIngresos();
            ddlSeleccionarTipoIngres.DataSource = TiposIngresos;
            ddlSeleccionarTipoIngres.DisplayMember = "Descripcion";
            ddlSeleccionarTipoIngres.ValueMember = "IdTipoIngreso";
        }
        #endregion
        #region AFECTAR CUENTAS CONTABLES
        private void AfectarCuentas(string Ano, string Mes,decimal IdBanco,string Cuenta, string Auxiliar,decimal Valor, string Concepto,decimal NumeroRelacionado,int IdClaseCuenta,int IdTipoCuenta,int IdOrigenCuenta,int IdCuentaContable) {
            if (rbFacturar.Checked) {
                int TipoVenta = 0;


                TipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);

                DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos(
                       0,
                       Ano,
                       Mes,
                       IdTipoCuenta,
                       1,
                       VariablesGlobales.NumeroConector,
                       0,
                       IdBanco,
                       Cuenta,
                       Auxiliar,
                       Valor,
                       IdOrigenCuenta,
                       Concepto,
                       NumeroRelacionado,
                       IdClaseCuenta,
                       IdCuentaContable,
                       "INSERT");
                Procesar.ProcesarInformacion();

                if (TipoVenta == 2) {
                    //AFECTAMOS LAS CUENTAS CONTABLES REALIZANDO UNA VENTA  A CREDITO
                   
                }
                
            
            }
        }
        #endregion
        #region PROCESAR INFORMACION CUENTAS CONTABLES
        private void ProcesarInformacionCuentasContables() {
            //AFECTAMOS LAS CUENTAS EN DEBITO
            //SACAMOS EL AÑO ACTUAL
            string AnoActual = DateTime.Now.Year.ToString();

            //SACAMOS EL MES ACTUAL
            string Mes = DateTime.Now.Month.ToString();
            string MesActual = "";
            int CantidadCaracteresMes = Mes.Length;
            if (CantidadCaracteresMes == 1)
            {
                MesActual = "0" + Mes;
            }
            else
            {
                MesActual = Mes;
            }

            //SACAMOS EL BANCO POR DEFECTO
            decimal IdBanco = 0;
            var SacarBancoPorDefecto = ObjdataContabilidad.Value.BuscaBancos(
                new Nullable<decimal>(),
                null,
                true,
                1, 1);
            foreach (var n in SacarBancoPorDefecto)
            {
                IdBanco = Convert.ToDecimal(n.IdBanco);
            }

            //SACAMOS LA CUENTA Y EL AUXILIAR
            string CuentaContable = "";
            string Auxiliar = "";
            int IdClaseCuenta = 0;
            int IdTipoCuenta = 0;
            int IdOrigenCuenta = 0;

            var SacarDatosCuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(
                8, null, null, null, null, 1, 1);
            foreach (var nCunetas in SacarDatosCuenta)
            {
                IdClaseCuenta = Convert.ToInt32(nCunetas.IdClaseCuenta);
                CuentaContable = nCunetas.Cuenta;
                Auxiliar = nCunetas.Auxiliar;
                IdTipoCuenta = Convert.ToInt32(nCunetas.IdTipoCuenta);
                IdOrigenCuenta = Convert.ToInt32(nCunetas.IdOrigenCuenta);
            }

            //SACAMOS EL VALOR DE LA VENTA
            decimal ValorVenta = Convert.ToDecimal(txtTotal.Text);

            //SACAMOS EL CONCEPTO DE LA CUENTA
            string ConceptoCuenta = "";
            var SacarConceptoCuenta = ObjdataContabilidad.Value.BuscaProcesosCuentas(1);
            foreach (var nConcepto in SacarConceptoCuenta)
            {
                ConceptoCuenta = nConcepto.Concepto;
            }
            //SACAMOS EL NUMERO DE FACTURA
            decimal NumeroRelacionado = 0;

            var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
            foreach (var nFactura in SacarNumeroFactura)
            {
                NumeroRelacionado = Convert.ToDecimal(nFactura.IdFactura);
            }
            AfectarCuentas(AnoActual, MesActual, IdBanco, CuentaContable, Auxiliar, ValorVenta, ConceptoCuenta, NumeroRelacionado, IdClaseCuenta, IdTipoCuenta, IdOrigenCuenta,8);
        }

        //AFECTAMOS LAS CUENTAS CONTABLES CUANDO AFECTANDO LAS CUENTAS A CREDITO
        private void AfectarCuentasContablesCreditos() {
            /*
             PROCESOS A REALIZAR

                 1- VALIDAR TODOS LOS PRODUCTOS A FACTURAR Y SACAR EL ID DE CADA PRODUCTO
                 2- CON EL ID VALIDAR SI EL PRODUCTO APLICA PARA ITBIS
                 3- SI EL PRODUCTO APLICA PARA ITBIS GUARDAR LOS DATOS EN LA CUENTA 4.2 EL VALOR SIN ITBIS Y EN LA CUENTA 2.1 EL MONTO DEL ITBIS, DE LO CONTRARIO SOLO GUARDAR EN LA CUENTA 4.1


             */

            //SACAMOS EL AÑO ACTUAL
            string Ano = DateTime.Now.Year.ToString();
            //SACAMOS EL MES ACTUAL
            string Mes = DateTime.Now.Month.ToString();
            int CantidadCaracteresMes = Mes.Length;
            string MesActual = "";
            if (CantidadCaracteresMes == 1) {
                MesActual = "0" + Mes;
            }
            else {
                MesActual = Mes;
            }
            //SACAMOS EL BANCO POR DEFECTO
            decimal IdBanco = 0;
            var SacarCodigoBanco = ObjdataContabilidad.Value.BuscaBancos(
                new Nullable<decimal>(), null, true, 1, 1);
            foreach (var nBanco in SacarCodigoBanco) {
                IdBanco = Convert.ToDecimal(nBanco.IdBanco);
            }
            var SacarProductosAgragados = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            foreach (var nProductosAgregados in SacarProductosAgragados) {
                decimal IdProducto = Convert.ToDecimal(nProductosAgregados.IdProducto);
                decimal ValorProducto = Convert.ToDecimal(nProductosAgregados.Precio);
                decimal ImpuestoProducto = Convert.ToDecimal(nProductosAgregados.Impuesto);
                decimal PrecioSinImpuesto = ValorProducto - ImpuestoProducto;
                //BUSCAMOS EL PRODUCTO Y VERIFICAMOS SI EL PRODUCTO APLICA PARA ITBIS
                var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                    IdProducto,null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,1,1);
                foreach (var nInventario in BuscarProducto) {
                    bool AplicaImpuesto = Convert.ToBoolean(nInventario.AplicaParaImpuesto0);

                    if (AplicaImpuesto == true) {
                        //GUARDAMOS LA INFORMACION CUANDO EL PRODUCTO APLICA PARA IMPUESTO

                        string CuentaContableCredito = "";
                        string AuxiliarCredito = "";
                        int IdClaseCuentaCredito = 0;
                        int IdTipoCuentaCredito = 0;
                        int IdOrigenCuentaCredito = 0;
                        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        var SacarDatosCuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(14, null, null, null, null, 1, 1);
                        foreach (var nCatalogo in SacarDatosCuenta)
                        {
                            CuentaContableCredito = nCatalogo.Cuenta;
                            AuxiliarCredito = nCatalogo.Auxiliar;
                            IdClaseCuentaCredito = Convert.ToInt32(nCatalogo.IdClaseCuenta);
                            IdTipoCuentaCredito = Convert.ToInt32(nCatalogo.IdTipoCuenta);
                            IdOrigenCuentaCredito = Convert.ToInt32(nCatalogo.IdOrigenCuenta);
                        }
                        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        string ConceptoCuentaCredito = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(4);
                        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        decimal NumeroRelacionado = 0;
                        var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                        foreach (var nFactura in SacarNumeroFactura)
                        {
                            NumeroRelacionado = Convert.ToDecimal(nFactura.IdFactura);
                        }
                        AfectarCuentas(Ano, MesActual, IdBanco, CuentaContableCredito, AuxiliarCredito, PrecioSinImpuesto, ConceptoCuentaCredito, NumeroRelacionado, IdClaseCuentaCredito, IdTipoCuentaCredito, IdOrigenCuentaCredito, 14);
                        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //GUARDAMOS LOS DATOS PARA EL ITBIS
                        string CuentaContableITBIS = "";
                        string AuxiliarITBIS = "";
                        int IdClaseCuentaITBIS = 0;
                        int IdTipoCuentaITBIS = 0;
                        int IdOrigenCuentaITBIS = 0;
                        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        var SacarDatosCuentaITBIS = ObjdataContabilidad.Value.BuscaCatalogoCuentas(10, null, null, null, null, 1, 1);
                        foreach (var nITBIS in SacarDatosCuentaITBIS) {
                            CuentaContableITBIS = nITBIS.Cuenta;
                            AuxiliarITBIS = nITBIS.Auxiliar;
                            IdClaseCuentaITBIS = Convert.ToInt32(nITBIS.IdClaseCuenta);
                            IdTipoCuentaITBIS = Convert.ToInt32(nITBIS.IdTipoCuenta);
                            IdOrigenCuentaITBIS = Convert.ToInt32(nITBIS.IdOrigenCuenta);
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        string ConceptoCuentaITBIS = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(5);
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        AfectarCuentas(Ano, MesActual, IdBanco, CuentaContableITBIS, AuxiliarITBIS, ImpuestoProducto, ConceptoCuentaITBIS, NumeroRelacionado, IdClaseCuentaITBIS, IdTipoCuentaITBIS, IdOrigenCuentaITBIS, 10);


                      
                    }
                    else {
                        //GUARDAMLS LA INFORMACION CUANDO EL PRODUCTO NO APLICA PARA IMPUSTO

                        string CuentaContable = "";
                        string Auxiliar = "";
                        int IdClaseCuenta = 0;
                        int IdTipoCuenta = 0;
                        int IdOrigenCuenta = 0;


                        var SacarDatosCuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(9, null, null, null, null, 1, 1);
                        foreach (var nCatalogo in SacarDatosCuenta) {
                            CuentaContable = nCatalogo.Cuenta;
                            Auxiliar = nCatalogo.Auxiliar;
                            IdClaseCuenta = Convert.ToInt32(nCatalogo.IdClaseCuenta);
                            IdTipoCuenta = Convert.ToInt32(nCatalogo.IdTipoCuenta);
                            IdOrigenCuenta = Convert.ToInt32(nCatalogo.IdOrigenCuenta);
                        }

                        string ConceptoCuentaCredito = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(3);
                      

                        decimal NumeroRelacionado = 0;
                        var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                        foreach (var nFactura in SacarNumeroFactura) {
                            NumeroRelacionado = Convert.ToDecimal(nFactura.IdFactura);
                        }
                        AfectarCuentas(Ano, MesActual, IdBanco, CuentaContable, Auxiliar, ValorProducto, ConceptoCuentaCredito, NumeroRelacionado, IdClaseCuenta, IdTipoCuenta, IdOrigenCuenta,9);


                 

                    
                    }
                    
                }
            }

           


        }

        private void AfectarCuentasContableOtrosImpuestos() {
            //SACAMOS EL AÑO ACTUAL
            string Ano = DateTime.Now.Year.ToString();
            //SACAMOS EL MES ACTUAL
            string Mes = DateTime.Now.Month.ToString();
            int CantidadCaracteresMes = Mes.Length;
            string MesActual = "";
            if (CantidadCaracteresMes == 1)
            {
                MesActual = "0" + Mes;
            }
            else
            {
                MesActual = Mes;
            }
            //SACAMOS EL BANCO POR DEFECTO
            decimal IdBanco = 0;
            var SacarCodigoBanco = ObjdataContabilidad.Value.BuscaBancos(
                new Nullable<decimal>(), null, true, 1, 1);
            foreach (var nBanco in SacarCodigoBanco)
            {
                IdBanco = Convert.ToDecimal(nBanco.IdBanco);
            }

            //GUARDAR OTROS IMPUESTOS
            decimal MontoImpuestosComprobante = 0, MontoImpuestoTipoPago = 0, TotalMontoOtrosIpuestos = 0;

            MontoImpuestosComprobante = Convert.ToDecimal(lbMontoPorcientoImpuestoComprobanteVariable.Text);
            MontoImpuestoTipoPago = Convert.ToDecimal(lbMontoPorcientoTipoPagoVariable.Text);
            TotalMontoOtrosIpuestos = MontoImpuestosComprobante + MontoImpuestoTipoPago;

            if (TotalMontoOtrosIpuestos > 0)
            {
                string CuentaContableOtrosImpuestos = "";
                string AuxiliarOtrosImpuestos = "";
                int IdClaseCuentaOtrosImpuestos = 0;
                int IdTipoCuentaOtrosImpuestos = 0;
                int IdOrigenCuentaOtrosImpuestos = 0;

                var SacarDatosCuentaOtrosImpuesto = ObjdataContabilidad.Value.BuscaCatalogoCuentas(15, null, null, null, null, 1, 1);
                foreach (var nOtroImpuestos in SacarDatosCuentaOtrosImpuesto)
                {
                    CuentaContableOtrosImpuestos = nOtroImpuestos.Cuenta;
                    AuxiliarOtrosImpuestos = nOtroImpuestos.Auxiliar;
                    IdClaseCuentaOtrosImpuestos = Convert.ToInt32(nOtroImpuestos.IdClaseCuenta);
                    IdTipoCuentaOtrosImpuestos = Convert.ToInt32(nOtroImpuestos.IdTipoCuenta);
                    IdOrigenCuentaOtrosImpuestos = Convert.ToInt32(nOtroImpuestos.IdOrigenCuenta);
                }

                string ConceptoCuentaCreditoOtroImpuestos = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(11);

                decimal NumeroRelacionadoOtroImpuestos = 0;
                var SacarNumeroFacturaOtrosImpuestos = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var nFActuraOtrosImpuestos in SacarNumeroFacturaOtrosImpuestos)
                {
                    NumeroRelacionadoOtroImpuestos = Convert.ToDecimal(nFActuraOtrosImpuestos.IdFactura);
                }
                AfectarCuentas(Ano, MesActual, IdBanco, CuentaContableOtrosImpuestos, AuxiliarOtrosImpuestos, TotalMontoOtrosIpuestos, ConceptoCuentaCreditoOtroImpuestos, NumeroRelacionadoOtroImpuestos, IdClaseCuentaOtrosImpuestos, IdTipoCuentaOtrosImpuestos, IdOrigenCuentaOtrosImpuestos, 15);
            }
        }
        #endregion
        #region VALIDAR USO DE COMPROBANTES
        private void ManupularUsoComprobante()
        {
            if (cbUsarComprobantes.Checked == true)
            {
                cbUsarComprobantes.ForeColor = Color.LimeGreen;

                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = true;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, "UPDATE");
                MostrarComprobantesFiscales();
                CalcularImpuestos();
            }
            else
            {
                cbUsarComprobantes.ForeColor = Color.DarkRed;

                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = false;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, "UPDATE");
                MostrarComprobantesFiscales();
                CalcularImpuestos();

            }
        }
        private void ValidarUsoComprobantes() {
            var SacarData = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in SacarData)
            {
                cbUsarComprobantes.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
            ManupularUsoComprobante();

        }
        #endregion
        #region MOSTRAR EL LISTADO DEL TIPO DE TIEMPO DE GARANTIA
        private void ListadoTipoTiempoGarantia() {
            var Listado = ObjDataListas.Value.ListadoTipoTiempoGarantia();
            ddlSeleccionarTiempoGarantia.DataSource = Listado;
            ddlSeleccionarTiempoGarantia.DisplayMember = "TipoTiempoGarantia";
            ddlSeleccionarTiempoGarantia.ValueMember = "IdTipoTiempoGarantia";
        }
        #endregion
        #region SACAR EL IMPUSTO DEL COMPROBANTE SELECCIONADO
        private int SacarImpuestoComprobante(decimal IdCOmprobante) {
            int ImpuestoCOmprobante = 0;

            var SacarImpuestoCOmprobante = ObjDataConfiguracion.Value.BuscaComprobantesFiscales(IdCOmprobante);
            foreach (var n in SacarImpuestoCOmprobante) {
                ImpuestoCOmprobante = Convert.ToInt32(n.CobroPorcientoAdicional);
            }
            return ImpuestoCOmprobante;
        }
        #endregion
        #region CALCULAR DESCUENTOS CORRESPONDIENTES
        private void CalcularImpuestos() {
            try {
                decimal ImpuestoTipoPago = 0, ImpuestoComprobante = 0, ValorAcumuladoFacturar = 0;
                lbMontoPorcientoTipoPagoVariable.Text = "0";
                lbMontoPorcientoImpuestoComprobanteVariable.Text = "0";
                txtImpuestoAdicional.Text = "0";
                txtImpuestoComprobante.Text = "0";

                //SACAMOS EL IMPUESTO DEL TIPO DE PAGO
                var SacarImpuestoTipoPago = ObjDataServicio.Value.BuscaTipoPago(Convert.ToDecimal(ddltIPago.SelectedValue), null, 1, 1);
                foreach (var n in SacarImpuestoTipoPago) {
                    ImpuestoTipoPago = Convert.ToDecimal(n.Valor);
                }

                //SACAMOS EL IMPUESTO DEL COMPROBANTE 
                // ImpuestoComprobante = SacarImpuestoComprobante(Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue));
                var SacarImpuestoComprobante = ObjDataConfiguracion.Value.BuscaComprobantesFiscales(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                foreach (var n in SacarImpuestoComprobante) {
                    ImpuestoComprobante = Convert.ToDecimal(n.CobroPorcientoAdicional);
                }

                //SACAR EL VALOR ACUMULADO
                var sacarValorAcumulado = ObjDataServicio.Value.BuscapRoductosAgregados(
                    new Nullable<decimal>(),
                    VariablesGlobales.NumeroConector);
                foreach (var n in sacarValorAcumulado) {
                    ValorAcumuladoFacturar = Convert.ToDecimal(n.TotalGeneral);
                }

                txtImpuestoAdicional.Text = ImpuestoTipoPago.ToString("N0");
                txtImpuestoComprobante.Text = ImpuestoComprobante.ToString("N0");

                decimal PorcientoImpuestoTipoPago = ImpuestoTipoPago / 100;
                decimal PorcientoImpuestoComprobante = ImpuestoComprobante / 100;
                decimal MontoImpuestoTipoPago = ValorAcumuladoFacturar * PorcientoImpuestoTipoPago;
                decimal MontoImpuestoComprobante = ValorAcumuladoFacturar * PorcientoImpuestoComprobante;
                decimal ValorTotal = ValorAcumuladoFacturar + MontoImpuestoTipoPago + MontoImpuestoComprobante;

                lbMontoPorcientoTipoPagoVariable.Text = MontoImpuestoTipoPago.ToString("N2");
                lbMontoPorcientoImpuestoComprobanteVariable.Text = MontoImpuestoComprobante.ToString("N2");
                lbValorSinImpuestoVariable.Text = ValorAcumuladoFacturar.ToString("N2");
                txtTotal.Text = ValorTotal.ToString("N2");
                txtMontoPagar.Text = txtTotal.Text;

            }
            catch (Exception) { }
        }
        #endregion






        #region ELIMINAR FACTURACION CLIENTE
        private void FacturacionClienteCotizacion(decimal NumeroConector, string Accion)
        {

         
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            Mantenimiento.IdFactura = 0;
            Mantenimiento.NumeroConector = NumeroConector;
            Mantenimiento.IdEstatusFacturacion = 3;
          //  Mantenimiento.IdComprobante = IdComprobanteFactura;
           // Mantenimiento.Nombre = txtNombreCliente.Text;
            Mantenimiento.Telefono = txtTelefono.Text;
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.IdTipoIdentificacion = VariablesGlobales.IdTipoIdentificacionAnularFactura;
            Mantenimiento.NumeroIdentificacion = VariablesGlobales.NumeroIdentificacionAnularFactura;
            Mantenimiento.Direccion = txtDireccion.Text;
            Mantenimiento.Comentario = txtComentario.Text + "Anulación de la factura " + VariablesGlobales.IdMantenimeinto.ToString();
            Mantenimiento.IdTipoVenta = VariablesGlobales.IdTipoVentaAnularFactura;
            Mantenimiento.IdCantidadDias = VariablesGlobales.IdCantidadDiasAnularFactura;
            Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaFacturacion = DateTime.Now;
          //  Mantenimiento.IdTipoAnulaicon = Convert.ToDecimal(ddlSeleccionarTipoAnulacion.SelectedValue);
         //   Mantenimiento.TipoTiempoGarantia = TiempoGarantia;



            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(Mantenimiento, Accion);
        }
        #endregion
        #region ELIMINAR FACTURACION CALCULOS
        private void FacturacionCalculosCotizacion(decimal NumeroConector, string Accion)
        {

            int CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            int CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            int CantidadTotal = CantidadProductos + CantidadServicios;
            decimal TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            decimal SubTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
           // decimal Cambio = Convert.ToDecimal(txtcambio.Text);
            decimal Total = Convert.ToDecimal(txtTotal.Text);

            TotalDescuento = TotalDescuento * -1;
            SubTotal = SubTotal * -1;
            Impuesto = Impuesto * -1;
            MontoPagar = MontoPagar * -1;
           // Cambio = Cambio * -1;
            Total = Total * -1;


            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Mantenimiento = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            Mantenimiento.NumeroColector = NumeroConector;
            Mantenimiento.CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            Mantenimiento.CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            Mantenimiento.CantidadArticulos = CantidadTotal;
            Mantenimiento.TotalDescuento = TotalDescuento;
            Mantenimiento.SubTotal = SubTotal;
            Mantenimiento.Impuesto = Impuesto;
            Mantenimiento.PorcientoImpuesto = VariablesGlobales.PorcientoDescuentoAnularFactura;
            Mantenimiento.MontoPagado = MontoPagar;
            //Mantenimiento.Cambio = Cambio;
            Mantenimiento.IdTipoPago = VariablesGlobales.IdTipOpagoAnularFactura;
            Mantenimiento.TotalGeneral = Total;

            var MAn = ObjDataServicio.Value.GuardarFacturacionCalculos(Mantenimiento, Accion);
        }


        #endregion
        #region MANTENIMIENTO DE FACTURACION DE PRODUCTOS
        private void ProductosCotizacion(decimal NumeroConector, string Accion)
        {
            var BuscarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                NumeroConector);
            foreach (var n in BuscarProductos)
            {
                DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto MantenimientoProducto = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

                MantenimientoProducto.NumeroConector = NumeroConector;
                MantenimientoProducto.IdTipoProducto = Convert.ToDecimal(n.IdTipoProducto);
                MantenimientoProducto.IdCategoria = Convert.ToDecimal(n.IdCategoria);
                MantenimientoProducto.DescripcionProducto = n.DescripcionProducto;
                MantenimientoProducto.CantidadVendida = Convert.ToInt32(n.Cantidad);
                MantenimientoProducto.Precio = Convert.ToDecimal(n.Precio);
                MantenimientoProducto.DescuentoAplicado = Convert.ToDecimal(n.DescuentoAplicado);
                MantenimientoProducto.DescripcionTipoProducto = n.DescripcionTipoProducto;
                MantenimientoProducto.PorcientoDescuento = Convert.ToInt32(n.PorcientoDescuento);
                MantenimientoProducto.IdProducto = Convert.ToDecimal(n.IdProducto);
                MantenimientoProducto.Acumulativo = n.Acumulativo;
                MantenimientoProducto.ConectorProducto = Convert.ToDecimal(n.ConectorProducto);
                MantenimientoProducto.Impuesto = Convert.ToDecimal(n.Impuesto);


                var MAN = ObjDataServicio.Value.GuardarFacturacionProductos(MantenimientoProducto, Accion);
            }



        }
        #endregion

        private void Facturacion_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            
            MostrarComprobantesFiscales();
            
            ListadoTipoTiempoGarantia();
            ValidarUsoComprobantes();
            MostrarTipoIdentificacion();
            MostrarListadoTipoVenta();
            ListadoCantidadDias();
            ListadoFacturaMinimizadas();
            TemaGenerico();
            MostrarLosTipoSIngresos();
            if (VariablesGlobales.GenerarConector == true) {
                GenerarNumeroConector();
            }
            // lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();

            lbTitulo.Text = "FACTURACION";
            lbTitulo.ForeColor = Color.White;
            lbCredito.Text = "Credito:";
            lbCredito.ForeColor = Color.White;
            lbMontoCredito.Text = "0.00";
            lbMontoCredito.ForeColor = Color.White;
            lbMontoPorcientoImpuestoTipoPagoTitulo.ForeColor = Color.White;
            lbMontoPorcientoTipoPagoVariable.ForeColor = Color.White;
            lbMontoImpuestoPorcientoComprobanteVariable.ForeColor = Color.White;
            lbMontoPorcientoImpuestoComprobanteVariable.ForeColor = Color.White;
            rbFacturar.Checked = true;
            BloarControlesClientes();
            rbFacturar.ForeColor = Color.LimeGreen;
            rbCotizar.ForeColor = Color.DarkRed;
            cbAgregarCliente.ForeColor = Color.DarkRed;
            rbfacturaspanish.ForeColor = Color.LimeGreen;
            rbfacturaenglish.ForeColor = Color.DarkRed;
            cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
           // cbFacturaPuntoVenta.Checked = false;

            if (VariablesGlobales.SacarDataEspejo == true) {
                SacarInformacionFacturacionEspejo();
            }
           
            txtCantidadArtiuclos.Text = "0";
            txtCantidadServicios.Text = "0";
            txtTotalServicios.Text = "0";
            txtTotalDescuento.Text = "0";
            txtSubtotal.Text = "0";
            txtImpuesto.Text = "0";
           // txtPorcientoImpuesto.Text = "0";
            txtTotal.Text = "0";
            BuscarProductosAgregados(VariablesGlobales.NumeroConector);
            MostrarListadoTipoPagos();
            CalcularImpuestos();
            txtMontoPagar.Text = "0";
            CalcularCambio();
            ValidarConfiguracionGeneral();



            cbAgregarCliente.Visible = false;
            cbAgregarCliente.Checked = true;
            cbBuscarPorCodigo.Visible = false;
            txtCodigoConsulta.Visible = false;
            btnBuscarCodigoCliente.Visible = false;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbFacturar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
            }
            else
            {
                if (rbFacturar.Checked == true)
                {
                    lbTitulo.Text = "FACTURACION";
                    rbFacturar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "COTIZACION";
                    rbFacturar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
                rbCotizar.Checked = true;
                rbFacturar.Enabled = false;
                cbAgregarCliente.Enabled = false;
                btnMinimizarFactura.Enabled = false;
                rbCotizar.Checked = true;
            }
            else
            {
                if (rbCotizar.Checked == true)
                {
                    lbTitulo.Text = "COTIZACION";
                    rbCotizar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "FACTURACION";
                    rbCotizar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void cbAgregarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarCliente.Checked == true)
            {
                lbCredito.Visible = true;
                lbMontoCredito.Visible = true;
                DesbloquearControlesClientes();
                cbAgregarCliente.ForeColor = Color.LimeGreen;
                cbBuscarPorCodigo.Enabled = true;
            }
            else
            {
                lbCredito.Visible = false;
                lbMontoCredito.Visible = false;
                BloarControlesClientes();
                cbAgregarCliente.ForeColor = Color.DarkRed;
                cbBuscarPorCodigo.Enabled = false;
                cbBuscarPorCodigo.Checked = false;
                cbBuscarPorCodigo.ForeColor = Color.DarkRed;
                btnAgregarAlmacen.Visible = true;
                btnRegresar.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarRegistros();
        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //switch (e.CloseReason)
            //{
            //    case CloseReason.UserClosing:
            //        e.Cancel = true;
            //        break;
            //}
        }

        private void rbfacturaspanish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaspanish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.LimeGreen;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void rbfacturaenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaenglish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void cbFacturaPuntoVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFacturaPuntoVenta.Checked == true)
            {
                cbFacturaPuntoVenta.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void PCerrar_Click_1(object sender, EventArgs e)
        {
            DevolverProductosInventario(VariablesGlobales.NumeroConector);
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnAgregarAlmacen.Visible = true;
            btnRegresar.Visible = false;
            DesbloquearControles();
            LimpiarControles();
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            BuscarPorRNC();



           
        }

        private void btnBuscarCotizacion_Click(object sender, EventArgs e)
        {
            BuscarCotizacion();
         
        }

        private void btnRefresarCotizacion_Click(object sender, EventArgs e)
        {
            btnBuscarCotizacion.Visible = true;
            btnRefresarCotizacion.Visible = false;
        }

        private void cbBuscarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuscarPorCodigo.Checked == true)
            {
                btnBuscarCodigoCliente.Visible = true;
                txtCodigoConsulta.Visible = true;
                txtCodigoConsulta.Text = string.Empty;
                txtCodigoConsulta.Focus();
                cbBuscarPorCodigo.ForeColor = Color.LimeGreen;
            }
            else
            {
                btnBuscarCodigoCliente.Visible = false;
                txtCodigoConsulta.Visible = false;
                cbBuscarPorCodigo.ForeColor = Color.DarkRed;
            }
        }

        private void btnBuscarCodigoCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoConsulta.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo codigo vacio para buscar un registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoConsulta.Focus();
            }
            else {
                //BUSCAMOS EL REGISTRO
                var Buscarregistro = ObjDataEmpresa.Value.BuscaClientes(
                    Convert.ToDecimal(txtCodigoConsulta.Text),
                    null, null, null, null, null, 1, 1);
                if (Buscarregistro.Count() < 1)
                {
                    MessageBox.Show("El Codigo de cliente ingresado no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoConsulta.Text = string.Empty;
                    txtCodigoConsulta.Focus();
                }
                else {
                    foreach (var n in Buscarregistro) {
                        bool usoComprobante = false;

                        var ValidarUsoCOmprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
                        foreach (var n2 in ValidarUsoCOmprobante) {
                            usoComprobante = Convert.ToBoolean(n2.Estatus0);
                        }

                        if (usoComprobante == true) {
                            ddlTipoFacturacion.Text = n.Comprobante;
                        }

                        decimal Credito = Convert.ToDecimal(n.MontoCredito);
                        lbMontoCredito.Text = Credito.ToString("N2");
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        txtEmail.Text = n.Email;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.RNC;
                        txtDireccion.Text = n.Direccion;
                        txtComentario.Text = n.Comentario;
                        BloquearControles();
                    }
                }
            }
        }

        private void ddlTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                if (IdTipoVenta != 1)
                {
                    lbCantidadDias.Visible = true;
                    ddlCantidadDias.Visible = true;
                    lbCredito.Visible = true;
                    lbMontoCredito.Visible = true;
                    ListadoCantidadDias();
                }
                else {
                    lbCantidadDias.Visible = false;
                    ddlCantidadDias.Visible = false;
                    lbCredito.Visible = false;
                    lbMontoCredito.Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres Minimizar este proceso?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VariablesGlobales.SecuencialFActuraMinimizada = 0;
                MANFacturasMinimizadas("INSERT");
                LimpiarControles();
                ListadoFacturaMinimizadas();
                ListadoTipoTiempoGarantia();
                //GENERAMOS NUEVAMENTE UN NUEMERO DE CONECTOR
                GenerarNumeroConector();
                dtProductosAgregados.DataSource = null;
                txtCantidadArtiuclos.Text = "0";
                txtCantidadServicios.Text = "0";
                txtTotalServicios.Text = "0";
                txtTotalDescuento.Text = "0";
                txtSubtotal.Text = "0";
                txtImpuesto.Text = "0";
             //   txtPorcientoImpuesto.Text = "0";
                txtTotal.Text = "0";
            }

        }

        private void dtFacturasMinimizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal NumeroConector = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["NumeroConector"].Value.ToString());
            VariablesGlobales.NumeroConector = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["NumeroConector"].Value.ToString());
            VariablesGlobales.SecuencialFActuraMinimizada = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["Secuencia"].Value.ToString());

            if (cbEliminarfacturaMinimizada.Checked == true)
            {
                if (MessageBox.Show("¿Quieres elimianr esta factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SACAMOS LOS DATOS A VALIDAR
                    DevolverProductosInventario(NumeroConector);
                    MANFacturasMinimizadas("DELETE");
                    ListadoFacturaMinimizadas();
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(lbNumeroConector.Text);
                }
            }
            else {
                if (MessageBox.Show("¿Quieres restaurar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SacarDataFacturaMinimizadas();
                    MANFacturasMinimizadas("DELETE");
                    ListadoFacturaMinimizadas();
                    BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                }
            }
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                BuscarPorRNC();
            }
        }

        private void ddltIPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                txtTotal.Text = VariablesGlobales.TotalPagarFacturacion.ToString("N2");
                bool BloqueaMonto = false;
                bool ImpuestoAdicional = false;
                bool PorcentajeEntero = false;
                decimal Valor = 0;
                var TipoPago = ObjDataListas.Value.BuscaTipoPago(
                Convert.ToDecimal(ddltIPago.SelectedValue));
                foreach (var n in TipoPago) {
                    BloqueaMonto = Convert.ToBoolean(n.BloqueaMonto);
                    ImpuestoAdicional = Convert.ToBoolean(n.ImpuestoAdicional);
                    PorcentajeEntero = Convert.ToBoolean(n.PorcentajeEntero);
                    Valor = Convert.ToDecimal(n.Valor);

                    txtImpuestoAdicional.Text = Valor.ToString("N2");
                }
                if (BloqueaMonto == true)
                {
                    CalcularImpuestos();
                    txtMontoPagar.Enabled = false;
                    txtMontoPagar.Text = txtTotal.Text;
                }
                else {
                    CalcularImpuestos();
                    txtMontoPagar.Enabled = true;
                    txtMontoPagar.Text = string.Empty;
                    txtMontoPagar.Text = "0";
                }
               

            }
            catch (Exception) { }
        }

        private void cbEliminarfacturaMinimizada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            if (lbTitulo.Text == "FACTURACION" || lbTitulo.Text == "COTIZACION") {
                //VERIFICAMOS SI HAY PRODUCTOS AGREGADOS A FACTURA
                var ValidarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                    new Nullable<decimal>(),
                    VariablesGlobales.NumeroConector);
                if (ValidarProductos.Count() < 1)
                {
                    MessageBox.Show("No es posible completar esta operación por que no nay nada agregado para facturar, decea agregar registros?", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (MessageBox.Show("¿Quieres agregar registros?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AgregarRegistros();
                    }
                }
                else
                {
                    if (rbFacturar.Checked == true)
                    {
                        //FACTURAMOS
                        //VALIDAMOS EL TIPO DE VENTA
                        int TipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                        if (TipoVenta == 1)
                        {
                            //venta a contado
                            //validamos el tipo de pago
                            bool BloqueaControles = false;
                            var ValidarTipoPago = ObjDataListas.Value.BuscaTipoPago(
                                Convert.ToDecimal(ddltIPago.SelectedValue));
                            foreach (var n in ValidarTipoPago)
                            {
                                BloqueaControles = Convert.ToBoolean(n.BloqueaMonto);
                            }

                            if (BloqueaControles == true)
                            {
                                GuardarDatosClientes(0,"INSERT");
                                GuardarDatosCalculos("INSERT");
                                AfectarComprobanteFiscal();
                                AfectarCaja();
                                IngresarSacarDinero("ADDMONEY");
                                ProcesarInformacionCuentasContables();
                                AfectarCuentasContablesCreditos();
                                AfectarCuentasContableOtrosImpuestos();





                                MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GenerarFacturaVenta();
                                this.Dispose();

                            }
                            else if (BloqueaControles == false)
                            {
                                //VALIDAMOS SI EL CAMPO ESTA VACIO
                                if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                                {
                                    MessageBox.Show("El campo monto no puede estar vacio para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                                    decimal MontoTotal = Convert.ToDecimal(txtTotal.Text);
                                    if (MontoTotal > MontoPagar)
                                    {
                                        MessageBox.Show("El monto ingresado es menor al monto a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        GuardarDatosClientes(0,"INSERT");
                                        GuardarDatosCalculos("INSERT");
                                        AfectarComprobanteFiscal();
                                        AfectarCaja();
                                        IngresarSacarDinero("ADDMONEY");
                                        ProcesarInformacionCuentasContables();
                                        AfectarCuentasContablesCreditos();
                                        AfectarCuentasContableOtrosImpuestos();
                                        MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        GenerarFacturaVenta();
                                        this.Dispose();

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (TipoVenta == 2)
                        {
                            //venta a credito
                        }
                        else { MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else if (rbCotizar.Checked == true)
                    {
                        if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim())) {
                            txtMontoPagar.Text = "0";
                        }
                        //COTIZAMOS
                        ProcesoCotizar(VariablesGlobales.NumeroConector);
                        GuardarDatosClientes(0,"INSERT");
                        GuardarDatosCalculos("INSERT");

                        MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GenerarFacturaVenta();
                        FacturacionClienteCotizacion(VariablesGlobales.NumeroConector, "DELETE");
                        ProductosCotizacion(VariablesGlobales.NumeroConector, "DELETE");
                        FacturacionCalculosCotizacion(VariablesGlobales.NumeroConector, "DELETEALL");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else {
                //CONVERTIMOS LA COTIZACION A FACTURA
                //CAMBIAMOS EL ESTATUS DE LA COTIZACION
             
                decimal TipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
                bool BloqueaMonto = false;

                var ValidarTipoPago = ObjDataListas.Value.BuscaTipoPago(TipoPago);
                foreach (var n in ValidarTipoPago) {
                    BloqueaMonto = Convert.ToBoolean(n.BloqueaMonto);
                }


                if (BloqueaMonto == true) {

                    ConvertirCotizacionFactura();
                }
                else {
                    if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                    {
                        MessageBox.Show("El campo monto a pagar no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        decimal MontoPagar, TotalPagar;
                        MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                        TotalPagar = Convert.ToDecimal(txtTotal.Text);

                        if (MontoPagar < TotalPagar)
                        {
                            MessageBox.Show("El total a pagar es mayor al monto ingresado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            ConvertirCotizacionFactura();
                        }
                    }
                }
           

             
              
           
            }
          
           
        }

        private void txtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtCantidadDiasGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void gbGeneral_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidadDiasGarantia.Value < 0)
            {
                txtCantidadDiasGarantia.Value = 0;
            }
            else { }
        }

        private void cbUsarComprobantes_CheckedChanged(object sender, EventArgs e)
        {
            ManupularUsoComprobante();
          
        }

        private void ddlTipoFacturacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CalcularImpuestos();
            }
            catch (Exception) { }
        }
    }
}
