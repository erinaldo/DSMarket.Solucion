﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSMarket.Solucion.Pantallas.Pantallas.Reportes
{
    public partial class ReportesDGII : Form
    {
        public ReportesDGII()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ObtenerPrimerDiaMEs() {
            var Obtener = ObjDataConfiguracion.Value.ObtenerPrimerDiaMes();
            foreach (var n in Obtener) {
                txtFechaDesde.Text = n.PrimerDia.ToString();
            }
        }
        private void ReportesDGII_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "GENERAR REPORTES DGII";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            rbReporte606.Checked = true;
            rbPorPantalla.Checked = true;
            ObtenerPrimerDiaMEs();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //GENERAR REPORTE DEL 606
            if (rbReporte606.Checked == true) {
                if (rbPorPantalla.Checked == true) {
                    string RutaReporte = "";
                    string UsuarioBD = "";
                    string CLaveBD = "";

                    var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(10);
                    foreach (var n in SacarRutaReporte) {
                        RutaReporte = n.RutaReporte;
                    }

                    var SacarCredencialesBD = ObjDataSeguridad.Value.SacarCredencialBD(1);
                    foreach (var nCredencial in SacarCredencialesBD) {
                        UsuarioBD = nCredencial.Usuario;
                        CLaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nCredencial.Clave);
                    }

                    //ELIMINAMOS LOS DATOS
                    DSMarket.Logica.Comunes.ProcesarInformacionDataReporte606 Eliminar = new Logica.Comunes.ProcesarInformacionDataReporte606(
                        VariablesGlobales.IdUsuario, 0, 0, "", 0, "", "", 0, "", 0, "", "", "", "", DateTime.Now, "", DateTime.Now, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", 0, 0, 0, 0, 0, 0, "", "", 0, "", DateTime.Now, "", 0, DateTime.Now, DateTime.Now, "DELETE");
                    Eliminar.ProcesarInformacionReporte606();

                    //BUSCAMOS LOS DATOS PARA ALIMENTAR EL REPORTE
                    var BuscarData = ObjDataEmpresa.Value.BuscaCompraSuplidores(
                        new Nullable<decimal>(),
                        null,
                        null,
                        null,
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text),
                        1, 999999999);
                    foreach (var nData in BuscarData) {
                        DSMarket.Logica.Comunes.ProcesarInformacionDataReporte606 Guardar = new Logica.Comunes.ProcesarInformacionDataReporte606(
                         VariablesGlobales.IdUsuario,
                         Convert.ToDecimal(nData.IdCompraSuplidor),
                         Convert.ToDecimal(nData.IdTipoSuplidor),
                         nData.TipoSuplidor,
                         Convert.ToDecimal(nData.IdSuplidor),
                         nData.Suplidor,
                         nData.RNCCedula,
                         Convert.ToDecimal(nData.IdTipoIdentificacion),
                         nData.TipoIdentificacion,
                         Convert.ToDecimal(nData.IdTipoBienesServicios),
                         nData.TipoBienesServicios,
                         nData.CodigoTipoBienesServicio,
                         nData.NCF,
                         nData.NCFModificado,
                         Convert.ToDateTime(nData.FechaComprobante0),
                         nData.FechaComprobante,
                         Convert.ToDateTime(nData.FechaPago0),
                         nData.FechaPago,
                         Convert.ToDecimal(nData.MontoFacturadoServicios),
                         Convert.ToDecimal(nData.MontoFacturadoBienes),
                         Convert.ToDecimal(nData.TotalMontoFacturado),
                         Convert.ToDecimal(nData.ITBISFacturado),
                         Convert.ToDecimal(nData.ITBISRetenido),
                         Convert.ToDecimal(nData.ITBISSujetoProporcionalidad),
                         Convert.ToDecimal(nData.ITBISLlevadoCosto),
                         Convert.ToDecimal(nData.ITBISPorAdelantar),
                         Convert.ToDecimal(nData.ITBISPercibidoCompras),
                         Convert.ToDecimal(nData.IdTipoRetencionISR),
                         nData.TipoRetencionISR,
                         nData.CodigoTipoRetencionISR,
                         Convert.ToDecimal(nData.MontoRetencionRenta),
                         Convert.ToDecimal(nData.ISRPercibidoCompras),
                         Convert.ToDecimal(nData.ImpuestoSelectivoConsumo),
                         Convert.ToDecimal(nData.OtrosImpuestosTasa),
                         Convert.ToDecimal(nData.MontoPropinaLegal),
                         Convert.ToDecimal(nData.IdFormaPago),
                         nData.FormaPago,
                         nData.CodigoTipoPago,
                         Convert.ToDecimal(nData.UsuarioAdiciona),
                         nData.CreadoPor,
                         Convert.ToDateTime(nData.FechaCreado0),
                         nData.FechaCreado,
                         Convert.ToDecimal(nData.CantidadRegistros),
                         Convert.ToDateTime(txtFechaDesde.Text),
                         Convert.ToDateTime(txtFechaHasta.Text),
                         "INSERT");
                        Guardar.ProcesarInformacionReporte606();
                    }

                    //invocamos el reporte
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Reporte = new Reportes();
                    Reporte.GenerarReporte606(
                        VariablesGlobales.IdUsuario,
                        RutaReporte,
                        UsuarioBD,
                        CLaveBD);
                    Reporte.ShowDialog();

                }
                else if (rbArchivotxt.Checked == true) {
                    if (string.IsNullOrEmpty(txtAno.Text.Trim()))
                    {
                        MessageBox.Show("Favor ingresar el campo año para procesar este reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        if (string.IsNullOrEmpty(txtMes.Text.Trim()))
                        {
                            MessageBox.Show("favor ingresar el mes para procesar este reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            string RutaArchivo = "";

                            var SacarRutaArchivo = ObjDataConfiguracion.Value.BuscaRutaArchivotxt(1);
                            foreach (var n in SacarRutaArchivo)
                            {
                                RutaArchivo = n.Ruta;
                            }

                            //GENERAMOS LA FECHA DE PERIODO
                            int Year = Convert.ToInt32(txtAno.Text);
                            string Month = txtMes.Text;

                            if (Month.Length == 1)
                            {
                                Month = "0" + Month;
                            }


                            string RNC = "";
                            string Periofo = Year.ToString() + Month;
                            string CantidadRegistros = "";

                            //SACAMOS EL RNC DE LA EMPRESA
                            var SacarRNC = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
                            foreach (var n in SacarRNC)
                            {
                                RNC = n.RNC;
                            }

                            //SACAMOS LA CANTIDAD DE REGISTROS
                            var SacarCantidadRegistros = ObjDataEmpresa.Value.BuscaCompraSuplidores(
                                new Nullable<decimal>(),
                                null,
                                null,
                                null,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1, 999999999);
                            if (SacarCantidadRegistros.Count() < 1) {
                                CantidadRegistros = 0.ToString();
                            }
                            else {
                                foreach (var Cantidad in SacarCantidadRegistros)
                                {
                                    CantidadRegistros = Cantidad.CantidadRegistros.ToString();
                                }
                            }

                            using (StreamWriter outPutFile = new StreamWriter(@"" + RutaArchivo + @"\DGII_F_606_" + RNC + "_" + Periofo + ".txt"))
                            {

                                var Lineas = ObjDataEmpresa.Value.BuscaCompraSuplidores(
                                     new Nullable<decimal>(),
                                null,
                                null,
                                null,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1, 999999999);
                                outPutFile.WriteLine("606|" + RNC + "|" + Periofo + "|" + CantidadRegistros);
                                foreach (var n in Lineas)
                                {
                                    outPutFile.WriteLine(
                                        n.RNCCedula + "|" + 
                                        n.IdTipoIdentificacion + "|" + 
                                        n.CodigoTipoBienesServicio + "|" + 
                                        n.NCF + "|" + n.NCFModificado + "|" + 
                                        n.FechaComprobante + "|" + 
                                        n.FechaPago + "|" + 
                                        n.MontoFacturadoServicios + "|" + 
                                        n.MontoFacturadoBienes + "|" + 
                                        n.TotalMontoFacturado + "|" + 
                                        n.ITBISFacturado + "|" + 
                                        n.ITBISRetenido + "|" + 
                                        n.ITBISSujetoProporcionalidad + "|" + 
                                        n.ITBISLlevadoCosto + "|" + 
                                        n.ITBISPorAdelantar + "|" + 
                                        n.ITBISPercibidoCompras + "|" + 
                                        n.CodigoTipoRetencionISR + "|" + 
                                        n.MontoRetencionRenta + "|" + 
                                        n.ISRPercibidoCompras + "|" + 
                                        n.ImpuestoSelectivoConsumo + "|" + 
                                        n.OtrosImpuestosTasa + "|" + 
                                        n.MontoPropinaLegal + "|" + 
                                        n.CodigoTipoPago);
                                }
                            }
                            MessageBox.Show("Archivo 606 Generado con exito en la siguiente ruta " + RutaArchivo, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            //GENERAR REPORTE DEL 607
            else if (rbReporte607.Checked == true) {
                if (rbPorPantalla.Checked == true) {
                    //ELIMINAMOS LOS DATOS REGISTRADOS BAJO EL USUARIO
                    DSMarket.Logica.Comunes.ProcesarInformacion607 EliminarDatos607 = new Logica.Comunes.ProcesarInformacion607(
                        VariablesGlobales.IdUsuario, "", "", 0, "", "", 0, "", "", DateTime.Now, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,DateTime.Now,DateTime.Now, "DELETE");
                    EliminarDatos607.ProcesarInformacion();

                    //BUSCAMOS LOS DATOS PARA PROCESAR EL 607
                    var BuscarInformacion607 = ObjDataConfiguracion.Value.Reporte607(
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text));
                    foreach (var n in BuscarInformacion607) {
                        DSMarket.Logica.Comunes.ProcesarInformacion607 ProcesarInformacion = new Logica.Comunes.ProcesarInformacion607(
                            VariablesGlobales.IdUsuario,
                            n.NumeroIdentificacion,
                            n.TipoIdentificacion,
                            Convert.ToDecimal(n.IdTipoIdentificacion),
                            n.NCF,
                            n.NCFModificado,
                            Convert.ToDecimal(n.IdTipoIngreso),
                            n.TipoIngreso,
                            n.CodigoTipoIngreso,
                            Convert.ToDateTime(n.FechaFacturacion),
                            n.FechaArchivo,
                            n.FechaRetencion,
                            Convert.ToDecimal(n.MontoFacturado),
                            Convert.ToDecimal(n.ImpuestoFacturado),
                            0, //ITBISRetenidoPorTerceros
                            0, //ITBISPercibido
                            0, //RetencionRentaPorTerceros
                            0, //ISRPercibido
                            0, //ImpuestoSostenidoConsumo
                            0, //OtrosImpuestoTasa
                            0, //MontoPropinaLegal
                            Convert.ToDecimal(n.MontoEfectivo),
                            Convert.ToDecimal(n.MontoChequeTransferenciaDeposito),
                            Convert.ToDecimal(n.MontoTarjetaDebitoCredito),
                            Convert.ToDecimal(n.MontoVentaCredito),
                            Convert.ToDecimal(n.BonosCertificadosRegalos),
                            Convert.ToDecimal(n.Permuta),
                            Convert.ToDecimal(n.OtrasFormasVenta),
                            Convert.ToDecimal(n.CantidadRegistros),
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            "INSERT");
                        ProcesarInformacion.ProcesarInformacion();
                    }

                    //INVICAMOS EL REPORTE DEL 607 PARA VISUALIZARLO POR PANTALLA
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invicar = new Reportes();
                    Invicar.GenerarReporte607(VariablesGlobales.IdUsuario);
                    Invicar.ShowDialog();
                }
                else if (rbArchivotxt.Checked == true) {
                    if (string.IsNullOrEmpty(txtAno.Text.Trim()))
                    {
                        MessageBox.Show("El campo año no puede estar vacio para generar este archivo", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        if (string.IsNullOrEmpty(txtMes.Text.Trim()))
                        {
                            MessageBox.Show("El campo mes no puede estar vacio para generar este archivo", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            //GENERAMOS EL ARCHIVO DEL 607
                            string RutaArchivo = "";

                            var SacarRutaArchivo = ObjDataConfiguracion.Value.BuscaRutaArchivotxt(1);
                            foreach (var n in SacarRutaArchivo)
                            {
                                RutaArchivo = n.Ruta;
                            }

                            //GENERAMOS LA FECHA DE PERIODO
                            int Year = Convert.ToInt32(txtAno.Text);
                            string Month = txtMes.Text;

                            if (Month.Length == 1)
                            {
                                Month = "0" + Month;
                            }


                            string RNC = "";
                            string Periofo = Year.ToString() + Month;
                            string CantidadRegistros = "";

                            //SACAMOS EL RNC DE LA EMPRESA
                            var SacarRNC = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
                            foreach (var n in SacarRNC)
                            {
                                RNC = n.RNC;
                            }

                            //SACAMOS LA CANTIDAD DE REGISTROS
                            var SacarCantidadRegistros = ObjDataConfiguracion.Value.Reporte607(
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text));
                            foreach (var nCantidad in SacarCantidadRegistros) {
                                CantidadRegistros = nCantidad.CantidadRegistros.ToString();
                            }
                            using (StreamWriter outPutFile = new StreamWriter(@"" + RutaArchivo + @"\DGII_F_607_" + RNC + "_" + Periofo + ".txt"))
                            {
                                var Lineas = ObjDataConfiguracion.Value.Reporte607(
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text));
                                outPutFile.WriteLine("607|" + RNC + "|" + Periofo + "|" + CantidadRegistros);
                                foreach (var n in Lineas) {
                                    outPutFile.WriteLine(
                                        n.NumeroIdentificacion + "|" +
                                        n.IdTipoIdentificacion.ToString() + "|" +
                                        n.NCF + "|" + 
                                        n.NCFModificado + "|" +
                                        n.IdTipoIngreso.ToString() + "|" +
                                        n.FechaArchivo + "|" +
                                        n.FechaRetencion + "|" +
                                        n.MontoFacturado + "|" +
                                        n.ImpuestoFacturado + "|" +
                                        n.ITBISRetenidoPorTerceros + "|" +
                                        n.ITBISPercibido + "|" +
                                        n.RetencionRentaPorTerceros + "|" +
                                        n.ISRPercibido + "|" +
                                        n.ImpuestoSostenidoConsumo + "|" +
                                        n.OtrosImpuestoTasa + "|" +
                                        n.MontoPropinaLegal + "|" +
                                        n.MontoEfectivo + "|" +
                                        n.MontoChequeTransferenciaDeposito + "|" +
                                        n.MontoTarjetaDebitoCredito + "|" +
                                        n.MontoVentaCredito + "|" +
                                        n.BonosCertificadosRegalos + "|" +
                                        n.Permuta + "|" +
                                        n.OtrasFormasVenta);
                                }
                                //var Lineas = ObjDataEmpresa.Value.BuscaCompraSuplidores(
                            
                            }
                            MessageBox.Show("Archivo Generado 607 con exito en la siguiente ruta " + RutaArchivo, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }

            //GENERAR REPORTE DEL 608
            else if (rbReporte608.Checked == true) {
                if (rbPorPantalla.Checked == true) {
                    //ELIMINAMOS TODOS LOS REGISTROS RELACIONADOS CON EL USUARIO
                    DSMarket.Logica.Comunes.ProcesarInformacionReporte608 EliminarData = new Logica.Comunes.ProcesarInformacionReporte608(VariablesGlobales.IdUsuario, "", DateTime.Now, "", "", "", "", "", 0, DateTime.Now, DateTime.Now, "DELETE");
                    EliminarData.ProcesarInformacion();

                    //CONSULTAMOS LOS DATOS QUE SE VAN A GUARDAR
                    var BuscarData = ObjDataConfiguracion.Value.GenerarArchivo608(
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text));
                    foreach (var n in BuscarData) {
                        DSMarket.Logica.Comunes.ProcesarInformacionReporte608 Procesar = new Logica.Comunes.ProcesarInformacionReporte608(
                            VariablesGlobales.IdUsuario,
                            n.Comprobante,
                            Convert.ToDateTime(n.FechaFacturacion0),
                            n.FechaFacturacion,
                            n.FechaArchivo,
                            n.TipoAnulacion,
                            n.CodigoTipoAnulacion,
                            n.Comentario,
                            Convert.ToDecimal(n.CantidadRegistros),
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            "INSERT");   
                        Procesar.ProcesarInformacion();
                    }

                    //INVOCAMOS EL REPORTE A MOSTRAR
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar608 = new Reportes();
                    Invocar608.GenerarReporte608(VariablesGlobales.IdUsuario);
                    Invocar608.ShowDialog();
                }
                else if (rbArchivotxt.Checked == true) {
                    if (string.IsNullOrEmpty(txtAno.Text.Trim()))
                    {
                        MessageBox.Show("El campo año no puede estar vacio para generar este archivo", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        if (string.IsNullOrEmpty(txtMes.Text.Trim()))
                        {
                            MessageBox.Show("El campo Mes no puede estar vacio para generar este archivo", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            //INICIAMOS EL PROCESO PARA GENERAR EL ARCHVO

                            //1-SACAMOS LA RUTA DEL ARCHIVO
                            string RutaArchivo = "";

                            var SacarRutaArchivo = ObjDataConfiguracion.Value.BuscaRutaArchivotxt(1);
                            foreach (var n in SacarRutaArchivo)
                            {
                                RutaArchivo = n.Ruta;
                            }

                            //2-GENERAMOS LA FECHA DE PERIODO
                            int Year = Convert.ToInt32(txtAno.Text);
                            string Month = txtMes.Text;

                            if (Month.Length == 1)
                            {
                                Month = "0" + Month;
                            }

                            string RNC = "";
                            string Periofo = Year.ToString() + Month;
                            string CantidadRegistros = "";

                            //SACAMOS EL RNC DE LA EMPRESA
                            var SacarRNC = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
                            foreach (var n in SacarRNC)
                            {
                                RNC = n.RNC;
                            }

                            //3-SACAMOS LA CANTIDAD DE REGISTROS
                            var SacarCantidadRegistros = ObjDataConfiguracion.Value.GenerarArchivo608(
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text));
                            foreach (var nCantidad in SacarCantidadRegistros)
                            {
                                CantidadRegistros = nCantidad.CantidadRegistros.ToString();
                            }

                            //4-ESCRIBIMOS EL ARCHIVO
                            using (StreamWriter outPutFile = new StreamWriter(@"" + RutaArchivo + @"\DGII_F_608_" + RNC + "_" + Periofo + ".txt"))
                            {
                                var Lineas = ObjDataConfiguracion.Value.GenerarArchivo608(
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text));
                                outPutFile.WriteLine("608|" + RNC + "|" + Periofo + "|" + CantidadRegistros);
                                foreach (var n in Lineas)
                                {
                                    outPutFile.WriteLine(
                                        n.Comprobante + "|" +
                                        n.FechaArchivo + "|" +
                                        n.CodigoTipoAnulacion
                                        );
                                }
                                MessageBox.Show("Archivo 608 Generado con exito en la siguiente ruta " + RutaArchivo, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //var Lineas = ObjDataEmpresa.Value.BuscaCompraSuplidores(

                            }
                        }
                    }

                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReportesDGII_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
