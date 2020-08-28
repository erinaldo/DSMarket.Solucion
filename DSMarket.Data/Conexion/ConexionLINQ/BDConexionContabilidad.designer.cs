﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSMarket.Data.Conexion.ConexionLINQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DSMarket")]
	public partial class BDConexionContabilidadDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BDConexionContabilidadDataContext() : 
				base(global::DSMarket.Data.Properties.Settings.Default.DSMarketConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionContabilidadDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionContabilidadDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionContabilidadDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionContabilidadDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Contabilidad.SP_BUSCA_REGISTROS_CATALOGO_CUENTAS")]
		public ISingleResult<SP_BUSCA_REGISTROS_CATALOGO_CUENTASResult> SP_BUSCA_REGISTROS_CATALOGO_CUENTAS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdRegistro", DbType="Decimal(20,0)")] System.Nullable<decimal> idRegistro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuentaContable", DbType="VarChar(50)")] string cuentaContable, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Auxiliar", DbType="VarChar(50)")] string auxiliar, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescripcionCuenta", DbType="VarChar(1000)")] string descripcionCuenta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuentaDecarge", DbType="VarChar(50)")] string cuentaDecarge, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroPagina", DbType="Int")] System.Nullable<int> numeroPagina, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroRegistros", DbType="Int")] System.Nullable<int> numeroRegistros)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idRegistro, cuentaContable, auxiliar, descripcionCuenta, cuentaDecarge, numeroPagina, numeroRegistros);
			return ((ISingleResult<SP_BUSCA_REGISTROS_CATALOGO_CUENTASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Contabilidad.SP_MANTENIMIENTO_CATALOGO_CUENTA")]
		public ISingleResult<SP_MANTENIMIENTO_CATALOGO_CUENTAResult> SP_MANTENIMIENTO_CATALOGO_CUENTA(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdRegistro", DbType="Decimal(20,0)")] System.Nullable<decimal> idRegistro, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cuenta", DbType="VarChar(30)")] string cuenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Auxiliar", DbType="VarChar(30)")] string auxiliar, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(1000)")] string descripcion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdOrigenCuenta", DbType="Int")] System.Nullable<int> idOrigenCuenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoCuenta", DbType="Int")] System.Nullable<int> idTipoCuenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdClaseCuenta", DbType="Int")] System.Nullable<int> idClaseCuenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdAceptaMovimientoCuenta", DbType="Int")] System.Nullable<int> idAceptaMovimientoCuenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodAnexo", DbType="Int")] System.Nullable<int> codAnexo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuentaDescargo", DbType="VarChar(30)")] string cuentaDescargo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuentaPresupuesto", DbType="VarChar(30)")] string cuentaPresupuesto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AuxiliarPresupuesto", DbType="VarChar(30)")] string auxiliarPresupuesto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Estatus", DbType="Bit")] System.Nullable<bool> estatus, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuentaAnterior", DbType="VarChar(30)")] string cuentaAnterior, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdUsuario", DbType="Int")] System.Nullable<int> idUsuario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Accion", DbType="VarChar(150)")] string accion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idRegistro, cuenta, auxiliar, descripcion, idOrigenCuenta, idTipoCuenta, idClaseCuenta, idAceptaMovimientoCuenta, codAnexo, cuentaDescargo, cuentaPresupuesto, auxiliarPresupuesto, estatus, cuentaAnterior, idUsuario, accion);
			return ((ISingleResult<SP_MANTENIMIENTO_CATALOGO_CUENTAResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_BUSCA_REGISTROS_CATALOGO_CUENTASResult
	{
		
		private System.Nullable<decimal> _IdRegistro;
		
		private string _Cuenta;
		
		private string _Auxiliar;
		
		private string _NombreCuenta;
		
		private System.Nullable<int> _IdOrigenCuenta;
		
		private string _Origen;
		
		private System.Nullable<int> _IdTipoCuenta;
		
		private string _Tipo;
		
		private System.Nullable<int> _IdClaseCuenta;
		
		private string _Clase;
		
		private System.Nullable<int> _IdAceptaMovimientoCuenta;
		
		private string _AceptaMovimiento;
		
		private System.Nullable<int> _CodAnexo;
		
		private string _CuentaDescargo;
		
		private string _CuentaPresupuesto;
		
		private string _AuxiliarPresupuesto;
		
		private System.Nullable<bool> _Estatus0;
		
		private string _Estatus;
		
		private string _CuentaAnterior;
		
		private System.Nullable<int> _UsuarioAdiciona;
		
		private string _CreadoPor;
		
		private System.Nullable<System.DateTime> _FechaAdiciona;
		
		private string _FechaCreado;
		
		private System.Nullable<int> _UsuarioModifica;
		
		private string _ModificadoPor;
		
		private System.Nullable<System.DateTime> _FechaModifica;
		
		private string _FechaModificado;
		
		public SP_BUSCA_REGISTROS_CATALOGO_CUENTASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRegistro", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> IdRegistro
		{
			get
			{
				return this._IdRegistro;
			}
			set
			{
				if ((this._IdRegistro != value))
				{
					this._IdRegistro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuenta", DbType="VarChar(30)")]
		public string Cuenta
		{
			get
			{
				return this._Cuenta;
			}
			set
			{
				if ((this._Cuenta != value))
				{
					this._Cuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Auxiliar", DbType="VarChar(30)")]
		public string Auxiliar
		{
			get
			{
				return this._Auxiliar;
			}
			set
			{
				if ((this._Auxiliar != value))
				{
					this._Auxiliar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCuenta", DbType="VarChar(1000)")]
		public string NombreCuenta
		{
			get
			{
				return this._NombreCuenta;
			}
			set
			{
				if ((this._NombreCuenta != value))
				{
					this._NombreCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOrigenCuenta", DbType="Int")]
		public System.Nullable<int> IdOrigenCuenta
		{
			get
			{
				return this._IdOrigenCuenta;
			}
			set
			{
				if ((this._IdOrigenCuenta != value))
				{
					this._IdOrigenCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origen", DbType="VarChar(20)")]
		public string Origen
		{
			get
			{
				return this._Origen;
			}
			set
			{
				if ((this._Origen != value))
				{
					this._Origen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoCuenta", DbType="Int")]
		public System.Nullable<int> IdTipoCuenta
		{
			get
			{
				return this._IdTipoCuenta;
			}
			set
			{
				if ((this._IdTipoCuenta != value))
				{
					this._IdTipoCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo", DbType="VarChar(1000)")]
		public string Tipo
		{
			get
			{
				return this._Tipo;
			}
			set
			{
				if ((this._Tipo != value))
				{
					this._Tipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdClaseCuenta", DbType="Int")]
		public System.Nullable<int> IdClaseCuenta
		{
			get
			{
				return this._IdClaseCuenta;
			}
			set
			{
				if ((this._IdClaseCuenta != value))
				{
					this._IdClaseCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clase", DbType="VarChar(100)")]
		public string Clase
		{
			get
			{
				return this._Clase;
			}
			set
			{
				if ((this._Clase != value))
				{
					this._Clase = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAceptaMovimientoCuenta", DbType="Int")]
		public System.Nullable<int> IdAceptaMovimientoCuenta
		{
			get
			{
				return this._IdAceptaMovimientoCuenta;
			}
			set
			{
				if ((this._IdAceptaMovimientoCuenta != value))
				{
					this._IdAceptaMovimientoCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AceptaMovimiento", DbType="VarChar(2)")]
		public string AceptaMovimiento
		{
			get
			{
				return this._AceptaMovimiento;
			}
			set
			{
				if ((this._AceptaMovimiento != value))
				{
					this._AceptaMovimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodAnexo", DbType="Int")]
		public System.Nullable<int> CodAnexo
		{
			get
			{
				return this._CodAnexo;
			}
			set
			{
				if ((this._CodAnexo != value))
				{
					this._CodAnexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaDescargo", DbType="VarChar(30)")]
		public string CuentaDescargo
		{
			get
			{
				return this._CuentaDescargo;
			}
			set
			{
				if ((this._CuentaDescargo != value))
				{
					this._CuentaDescargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaPresupuesto", DbType="VarChar(30)")]
		public string CuentaPresupuesto
		{
			get
			{
				return this._CuentaPresupuesto;
			}
			set
			{
				if ((this._CuentaPresupuesto != value))
				{
					this._CuentaPresupuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuxiliarPresupuesto", DbType="VarChar(30)")]
		public string AuxiliarPresupuesto
		{
			get
			{
				return this._AuxiliarPresupuesto;
			}
			set
			{
				if ((this._AuxiliarPresupuesto != value))
				{
					this._AuxiliarPresupuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus0", DbType="Bit")]
		public System.Nullable<bool> Estatus0
		{
			get
			{
				return this._Estatus0;
			}
			set
			{
				if ((this._Estatus0 != value))
				{
					this._Estatus0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaAnterior", DbType="VarChar(30)")]
		public string CuentaAnterior
		{
			get
			{
				return this._CuentaAnterior;
			}
			set
			{
				if ((this._CuentaAnterior != value))
				{
					this._CuentaAnterior = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioAdiciona", DbType="Int")]
		public System.Nullable<int> UsuarioAdiciona
		{
			get
			{
				return this._UsuarioAdiciona;
			}
			set
			{
				if ((this._UsuarioAdiciona != value))
				{
					this._UsuarioAdiciona = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreadoPor", DbType="VarChar(100)")]
		public string CreadoPor
		{
			get
			{
				return this._CreadoPor;
			}
			set
			{
				if ((this._CreadoPor != value))
				{
					this._CreadoPor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaAdiciona", DbType="Date")]
		public System.Nullable<System.DateTime> FechaAdiciona
		{
			get
			{
				return this._FechaAdiciona;
			}
			set
			{
				if ((this._FechaAdiciona != value))
				{
					this._FechaAdiciona = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreado", DbType="NVarChar(4000)")]
		public string FechaCreado
		{
			get
			{
				return this._FechaCreado;
			}
			set
			{
				if ((this._FechaCreado != value))
				{
					this._FechaCreado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioModifica", DbType="Int")]
		public System.Nullable<int> UsuarioModifica
		{
			get
			{
				return this._UsuarioModifica;
			}
			set
			{
				if ((this._UsuarioModifica != value))
				{
					this._UsuarioModifica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModificadoPor", DbType="VarChar(100)")]
		public string ModificadoPor
		{
			get
			{
				return this._ModificadoPor;
			}
			set
			{
				if ((this._ModificadoPor != value))
				{
					this._ModificadoPor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaModifica", DbType="Date")]
		public System.Nullable<System.DateTime> FechaModifica
		{
			get
			{
				return this._FechaModifica;
			}
			set
			{
				if ((this._FechaModifica != value))
				{
					this._FechaModifica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaModificado", DbType="NVarChar(4000)")]
		public string FechaModificado
		{
			get
			{
				return this._FechaModificado;
			}
			set
			{
				if ((this._FechaModificado != value))
				{
					this._FechaModificado = value;
				}
			}
		}
	}
	
	public partial class SP_MANTENIMIENTO_CATALOGO_CUENTAResult
	{
		
		private System.Nullable<decimal> _IdRegistro;
		
		private string _Cuenta;
		
		private string _Auxiliar;
		
		private string _Descripcion;
		
		private System.Nullable<int> _IdOrigenCuenta;
		
		private System.Nullable<int> _IdTipoCuenta;
		
		private System.Nullable<int> _IdClaseCuenta;
		
		private System.Nullable<int> _IdAceptaMovimientoCuenta;
		
		private System.Nullable<int> _CodAnexo;
		
		private string _CuentaDescargo;
		
		private string _CuentaPresupuesto;
		
		private string _AuxiliarPresupuesto;
		
		private System.Nullable<bool> _Estatus;
		
		private string _CuentaAnterior;
		
		private System.Nullable<int> _UsuarioAdiciona;
		
		private System.Nullable<System.DateTime> _FechaAdiciona;
		
		private System.Nullable<int> _UsuarioModifica;
		
		private System.Nullable<System.DateTime> _FechaModifica;
		
		public SP_MANTENIMIENTO_CATALOGO_CUENTAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRegistro", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> IdRegistro
		{
			get
			{
				return this._IdRegistro;
			}
			set
			{
				if ((this._IdRegistro != value))
				{
					this._IdRegistro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuenta", DbType="VarChar(30)")]
		public string Cuenta
		{
			get
			{
				return this._Cuenta;
			}
			set
			{
				if ((this._Cuenta != value))
				{
					this._Cuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Auxiliar", DbType="VarChar(30)")]
		public string Auxiliar
		{
			get
			{
				return this._Auxiliar;
			}
			set
			{
				if ((this._Auxiliar != value))
				{
					this._Auxiliar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(1000)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOrigenCuenta", DbType="Int")]
		public System.Nullable<int> IdOrigenCuenta
		{
			get
			{
				return this._IdOrigenCuenta;
			}
			set
			{
				if ((this._IdOrigenCuenta != value))
				{
					this._IdOrigenCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoCuenta", DbType="Int")]
		public System.Nullable<int> IdTipoCuenta
		{
			get
			{
				return this._IdTipoCuenta;
			}
			set
			{
				if ((this._IdTipoCuenta != value))
				{
					this._IdTipoCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdClaseCuenta", DbType="Int")]
		public System.Nullable<int> IdClaseCuenta
		{
			get
			{
				return this._IdClaseCuenta;
			}
			set
			{
				if ((this._IdClaseCuenta != value))
				{
					this._IdClaseCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAceptaMovimientoCuenta", DbType="Int")]
		public System.Nullable<int> IdAceptaMovimientoCuenta
		{
			get
			{
				return this._IdAceptaMovimientoCuenta;
			}
			set
			{
				if ((this._IdAceptaMovimientoCuenta != value))
				{
					this._IdAceptaMovimientoCuenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodAnexo", DbType="Int")]
		public System.Nullable<int> CodAnexo
		{
			get
			{
				return this._CodAnexo;
			}
			set
			{
				if ((this._CodAnexo != value))
				{
					this._CodAnexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaDescargo", DbType="VarChar(30)")]
		public string CuentaDescargo
		{
			get
			{
				return this._CuentaDescargo;
			}
			set
			{
				if ((this._CuentaDescargo != value))
				{
					this._CuentaDescargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaPresupuesto", DbType="VarChar(30)")]
		public string CuentaPresupuesto
		{
			get
			{
				return this._CuentaPresupuesto;
			}
			set
			{
				if ((this._CuentaPresupuesto != value))
				{
					this._CuentaPresupuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuxiliarPresupuesto", DbType="VarChar(30)")]
		public string AuxiliarPresupuesto
		{
			get
			{
				return this._AuxiliarPresupuesto;
			}
			set
			{
				if ((this._AuxiliarPresupuesto != value))
				{
					this._AuxiliarPresupuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit")]
		public System.Nullable<bool> Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CuentaAnterior", DbType="VarChar(30)")]
		public string CuentaAnterior
		{
			get
			{
				return this._CuentaAnterior;
			}
			set
			{
				if ((this._CuentaAnterior != value))
				{
					this._CuentaAnterior = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioAdiciona", DbType="Int")]
		public System.Nullable<int> UsuarioAdiciona
		{
			get
			{
				return this._UsuarioAdiciona;
			}
			set
			{
				if ((this._UsuarioAdiciona != value))
				{
					this._UsuarioAdiciona = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaAdiciona", DbType="Date")]
		public System.Nullable<System.DateTime> FechaAdiciona
		{
			get
			{
				return this._FechaAdiciona;
			}
			set
			{
				if ((this._FechaAdiciona != value))
				{
					this._FechaAdiciona = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioModifica", DbType="Int")]
		public System.Nullable<int> UsuarioModifica
		{
			get
			{
				return this._UsuarioModifica;
			}
			set
			{
				if ((this._UsuarioModifica != value))
				{
					this._UsuarioModifica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaModifica", DbType="Date")]
		public System.Nullable<System.DateTime> FechaModifica
		{
			get
			{
				return this._FechaModifica;
			}
			set
			{
				if ((this._FechaModifica != value))
				{
					this._FechaModifica = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
