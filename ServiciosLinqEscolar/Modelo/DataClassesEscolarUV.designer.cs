﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosLinqEscolar.Modelo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="escolarUV")]
	public partial class DataClassesEscolarUVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAlumno(Alumno instance);
    partial void UpdateAlumno(Alumno instance);
    partial void DeleteAlumno(Alumno instance);
    partial void InsertCarrera(Carrera instance);
    partial void UpdateCarrera(Carrera instance);
    partial void DeleteCarrera(Carrera instance);
    partial void InsertFacultad(Facultad instance);
    partial void UpdateFacultad(Facultad instance);
    partial void DeleteFacultad(Facultad instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    #endregion
		
		public DataClassesEscolarUVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Alumno> Alumno
		{
			get
			{
				return this.GetTable<Alumno>();
			}
		}
		
		public System.Data.Linq.Table<Carrera> Carrera
		{
			get
			{
				return this.GetTable<Carrera>();
			}
		}
		
		public System.Data.Linq.Table<Facultad> Facultad
		{
			get
			{
				return this.GetTable<Facultad>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Alumno")]
	public partial class Alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAlumno;
		
		private string _nombre;
		
		private string _apellidoPaterno;
		
		private string _apellidoMaterno;
		
		private string _matricula;
		
		private string _correo;
		
		private System.Nullable<System.DateTime> _fechaNacimiento;
		
		private System.Data.Linq.Binary _foto;
		
		private System.Nullable<int> _idCarrera;
		
		private EntityRef<Carrera> _Carrera;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAlumnoChanging(int value);
    partial void OnidAlumnoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnapellidoMaternoChanging(string value);
    partial void OnapellidoMaternoChanged();
    partial void OnmatriculaChanging(string value);
    partial void OnmatriculaChanged();
    partial void OncorreoChanging(string value);
    partial void OncorreoChanged();
    partial void OnfechaNacimientoChanging(System.Nullable<System.DateTime> value);
    partial void OnfechaNacimientoChanged();
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    partial void OnidCarreraChanging(System.Nullable<int> value);
    partial void OnidCarreraChanged();
    #endregion
		
		public Alumno()
		{
			this._Carrera = default(EntityRef<Carrera>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAlumno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAlumno
		{
			get
			{
				return this._idAlumno;
			}
			set
			{
				if ((this._idAlumno != value))
				{
					this.OnidAlumnoChanging(value);
					this.SendPropertyChanging();
					this._idAlumno = value;
					this.SendPropertyChanged("idAlumno");
					this.OnidAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="VarChar(255)")]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaterno", DbType="VarChar(255)")]
		public string apellidoMaterno
		{
			get
			{
				return this._apellidoMaterno;
			}
			set
			{
				if ((this._apellidoMaterno != value))
				{
					this.OnapellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaterno = value;
					this.SendPropertyChanged("apellidoMaterno");
					this.OnapellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matricula", DbType="VarChar(25)")]
		public string matricula
		{
			get
			{
				return this._matricula;
			}
			set
			{
				if ((this._matricula != value))
				{
					this.OnmatriculaChanging(value);
					this.SendPropertyChanging();
					this._matricula = value;
					this.SendPropertyChanged("matricula");
					this.OnmatriculaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="VarChar(50)")]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this.OncorreoChanging(value);
					this.SendPropertyChanging();
					this._correo = value;
					this.SendPropertyChanged("correo");
					this.OncorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNacimiento", DbType="Date")]
		public System.Nullable<System.DateTime> fechaNacimiento
		{
			get
			{
				return this._fechaNacimiento;
			}
			set
			{
				if ((this._fechaNacimiento != value))
				{
					this.OnfechaNacimientoChanging(value);
					this.SendPropertyChanging();
					this._fechaNacimiento = value;
					this.SendPropertyChanged("fechaNacimiento");
					this.OnfechaNacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCarrera", DbType="Int")]
		public System.Nullable<int> idCarrera
		{
			get
			{
				return this._idCarrera;
			}
			set
			{
				if ((this._idCarrera != value))
				{
					if (this._Carrera.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCarreraChanging(value);
					this.SendPropertyChanging();
					this._idCarrera = value;
					this.SendPropertyChanged("idCarrera");
					this.OnidCarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Carrera_Alumno", Storage="_Carrera", ThisKey="idCarrera", OtherKey="idCarrera", IsForeignKey=true)]
		public Carrera Carrera
		{
			get
			{
				return this._Carrera.Entity;
			}
			set
			{
				Carrera previousValue = this._Carrera.Entity;
				if (((previousValue != value) 
							|| (this._Carrera.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Carrera.Entity = null;
						previousValue.Alumno.Remove(this);
					}
					this._Carrera.Entity = value;
					if ((value != null))
					{
						value.Alumno.Add(this);
						this._idCarrera = value.idCarrera;
					}
					else
					{
						this._idCarrera = default(Nullable<int>);
					}
					this.SendPropertyChanged("Carrera");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Carrera")]
	public partial class Carrera : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCarrera;
		
		private string _nombre;
		
		private string _codigo;
		
		private System.Nullable<int> _idFacultad;
		
		private EntitySet<Alumno> _Alumno;
		
		private EntityRef<Facultad> _Facultad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCarreraChanging(int value);
    partial void OnidCarreraChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnidFacultadChanging(System.Nullable<int> value);
    partial void OnidFacultadChanged();
    #endregion
		
		public Carrera()
		{
			this._Alumno = new EntitySet<Alumno>(new Action<Alumno>(this.attach_Alumno), new Action<Alumno>(this.detach_Alumno));
			this._Facultad = default(EntityRef<Facultad>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCarrera", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCarrera
		{
			get
			{
				return this._idCarrera;
			}
			set
			{
				if ((this._idCarrera != value))
				{
					this.OnidCarreraChanging(value);
					this.SendPropertyChanging();
					this._idCarrera = value;
					this.SendPropertyChanged("idCarrera");
					this.OnidCarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="VarChar(10)")]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFacultad", DbType="Int")]
		public System.Nullable<int> idFacultad
		{
			get
			{
				return this._idFacultad;
			}
			set
			{
				if ((this._idFacultad != value))
				{
					if (this._Facultad.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidFacultadChanging(value);
					this.SendPropertyChanging();
					this._idFacultad = value;
					this.SendPropertyChanged("idFacultad");
					this.OnidFacultadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Carrera_Alumno", Storage="_Alumno", ThisKey="idCarrera", OtherKey="idCarrera")]
		public EntitySet<Alumno> Alumno
		{
			get
			{
				return this._Alumno;
			}
			set
			{
				this._Alumno.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Facultad_Carrera", Storage="_Facultad", ThisKey="idFacultad", OtherKey="idFacultad", IsForeignKey=true)]
		public Facultad Facultad
		{
			get
			{
				return this._Facultad.Entity;
			}
			set
			{
				Facultad previousValue = this._Facultad.Entity;
				if (((previousValue != value) 
							|| (this._Facultad.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Facultad.Entity = null;
						previousValue.Carrera.Remove(this);
					}
					this._Facultad.Entity = value;
					if ((value != null))
					{
						value.Carrera.Add(this);
						this._idFacultad = value.idFacultad;
					}
					else
					{
						this._idFacultad = default(Nullable<int>);
					}
					this.SendPropertyChanged("Facultad");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Alumno(Alumno entity)
		{
			this.SendPropertyChanging();
			entity.Carrera = this;
		}
		
		private void detach_Alumno(Alumno entity)
		{
			this.SendPropertyChanging();
			entity.Carrera = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Facultad")]
	public partial class Facultad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idFacultad;
		
		private string _nombre;
		
		private EntitySet<Carrera> _Carrera;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidFacultadChanging(int value);
    partial void OnidFacultadChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public Facultad()
		{
			this._Carrera = new EntitySet<Carrera>(new Action<Carrera>(this.attach_Carrera), new Action<Carrera>(this.detach_Carrera));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFacultad", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idFacultad
		{
			get
			{
				return this._idFacultad;
			}
			set
			{
				if ((this._idFacultad != value))
				{
					this.OnidFacultadChanging(value);
					this.SendPropertyChanging();
					this._idFacultad = value;
					this.SendPropertyChanged("idFacultad");
					this.OnidFacultadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Facultad_Carrera", Storage="_Carrera", ThisKey="idFacultad", OtherKey="idFacultad")]
		public EntitySet<Carrera> Carrera
		{
			get
			{
				return this._Carrera;
			}
			set
			{
				this._Carrera.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Carrera(Carrera entity)
		{
			this.SendPropertyChanging();
			entity.Facultad = this;
		}
		
		private void detach_Carrera(Carrera entity)
		{
			this.SendPropertyChanging();
			entity.Facultad = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _nombre;
		
		private string _apellidoPaterno;
		
		private string _apellidoMaterno;
		
		private string _username;
		
		private string _password;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnapellidoMaternoChanging(string value);
    partial void OnapellidoMaternoChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public Usuario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(500)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="VarChar(255)")]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaterno", DbType="VarChar(255)")]
		public string apellidoMaterno
		{
			get
			{
				return this._apellidoMaterno;
			}
			set
			{
				if ((this._apellidoMaterno != value))
				{
					this.OnapellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaterno = value;
					this.SendPropertyChanged("apellidoMaterno");
					this.OnapellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
