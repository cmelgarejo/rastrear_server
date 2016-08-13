
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_equipo_eventos.
'  Base soportada:PostgreSqlEntity.
'  Versión: # (1.3.0.9).
'
'  Este objeto es abstracto, por ello, necesita ser heredado para poder instanciarlo.
'  Las propiedades y métodos pueden ser sobreescritas en la clase derivada.
'  (Clase Concreta)
'
'  NUNCA EDITE ESTE ARCHIVO.
'===============================================================================
*/

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace RASTREOmw
{
	public abstract class _rastreogps_equipo_eventos : PostgreSqlEntity
	{
		public _rastreogps_equipo_eventos()
		{
			this.QuerySource = "rastreogps_equipo_eventos";
			this.MappingName = "rastreogps_equipo_eventos";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_equipo_eventos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_equipogps, int Id_tipoevento)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_equipogps, Id_equipogps);

parameters.Add(Parameters.Id_tipoevento, Id_tipoevento);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_equipo_eventos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Id_equipogps
			{
				get
				{
					return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_tipoevento
			{
				get
				{
					return new NpgsqlParameter("Id_tipoevento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Habilitado
			{
				get
				{
					return new NpgsqlParameter("Habilitado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter User_ins
			{
				get
				{
					return new NpgsqlParameter("User_ins", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Fech_ins
			{
				get
				{
					return new NpgsqlParameter("Fech_ins", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter User_upd
			{
				get
				{
					return new NpgsqlParameter("User_upd", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Fech_upd
			{
				get
				{
					return new NpgsqlParameter("Fech_upd", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Evento
			{
				get
				{
					return new NpgsqlParameter("Evento", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Sonoro
			{
				get
				{
					return new NpgsqlParameter("Sonoro", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Arch_sonido
			{
				get
				{
					return new NpgsqlParameter("Arch_sonido", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Email
			{
				get
				{
					return new NpgsqlParameter("Email", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_equipogps = "id_equipogps";
            public const string Id_tipoevento = "id_tipoevento";
            public const string Habilitado = "habilitado";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Evento = "evento";
            public const string Sonoro = "sonoro";
            public const string Arch_sonido = "arch_sonido";
            public const string Email = "email";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_equipogps] = _rastreogps_equipo_eventos.PropertyNames.Id_equipogps;
					ht[Id_tipoevento] = _rastreogps_equipo_eventos.PropertyNames.Id_tipoevento;
					ht[Habilitado] = _rastreogps_equipo_eventos.PropertyNames.Habilitado;
					ht[User_ins] = _rastreogps_equipo_eventos.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_equipo_eventos.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreogps_equipo_eventos.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreogps_equipo_eventos.PropertyNames.Fech_upd;
					ht[Evento] = _rastreogps_equipo_eventos.PropertyNames.Evento;
					ht[Sonoro] = _rastreogps_equipo_eventos.PropertyNames.Sonoro;
					ht[Arch_sonido] = _rastreogps_equipo_eventos.PropertyNames.Arch_sonido;
					ht[Email] = _rastreogps_equipo_eventos.PropertyNames.Email;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_equipogps = "Id_equipogps";
            public const string Id_tipoevento = "Id_tipoevento";
            public const string Habilitado = "Habilitado";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Evento = "Evento";
            public const string Sonoro = "Sonoro";
            public const string Arch_sonido = "Arch_sonido";
            public const string Email = "Email";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_equipogps] = _rastreogps_equipo_eventos.ColumnNames.Id_equipogps;
					ht[Id_tipoevento] = _rastreogps_equipo_eventos.ColumnNames.Id_tipoevento;
					ht[Habilitado] = _rastreogps_equipo_eventos.ColumnNames.Habilitado;
					ht[User_ins] = _rastreogps_equipo_eventos.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_equipo_eventos.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreogps_equipo_eventos.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreogps_equipo_eventos.ColumnNames.Fech_upd;
					ht[Evento] = _rastreogps_equipo_eventos.ColumnNames.Evento;
					ht[Sonoro] = _rastreogps_equipo_eventos.ColumnNames.Sonoro;
					ht[Arch_sonido] = _rastreogps_equipo_eventos.ColumnNames.Arch_sonido;
					ht[Email] = _rastreogps_equipo_eventos.ColumnNames.Email;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Id_tipoevento = "s_Id_tipoevento";
            public const string Habilitado = "s_Habilitado";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Evento = "s_Evento";
            public const string Sonoro = "s_Sonoro";
            public const string Arch_sonido = "s_Arch_sonido";
            public const string Email = "s_Email";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_equipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_equipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Id_equipogps, value);
			}
		}

		public virtual int Id_tipoevento
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_tipoevento);
			}
			set
	        {
				base.Setint(ColumnNames.Id_tipoevento, value);
			}
		}

		public virtual bool Habilitado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Habilitado);
			}
			set
	        {
				base.Setbool(ColumnNames.Habilitado, value);
			}
		}

		public virtual int User_ins
	    {
			get
	        {
				return base.Getint(ColumnNames.User_ins);
			}
			set
	        {
				base.Setint(ColumnNames.User_ins, value);
			}
		}

		public virtual DateTime Fech_ins
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fech_ins);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fech_ins, value);
			}
		}

		public virtual int User_upd
	    {
			get
	        {
				return base.Getint(ColumnNames.User_upd);
			}
			set
	        {
				base.Setint(ColumnNames.User_upd, value);
			}
		}

		public virtual DateTime Fech_upd
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fech_upd);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fech_upd, value);
			}
		}

		public virtual string Evento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Evento);
			}
			set
	        {
				base.Setstring(ColumnNames.Evento, value);
			}
		}

		public virtual bool Sonoro
	    {
			get
	        {
				return base.Getbool(ColumnNames.Sonoro);
			}
			set
	        {
				base.Setbool(ColumnNames.Sonoro, value);
			}
		}

		public virtual string Arch_sonido
	    {
			get
	        {
				return base.Getstring(ColumnNames.Arch_sonido);
			}
			set
	        {
				base.Setstring(ColumnNames.Arch_sonido, value);
			}
		}

		public virtual string Email
	    {
			get
	        {
				return base.Getstring(ColumnNames.Email);
			}
			set
	        {
				base.Setstring(ColumnNames.Email, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_equipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Id_equipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_equipogps);
				else
					this.Id_equipogps = base.SetintAsString(ColumnNames.Id_equipogps, value);
			}
		}

		public virtual string s_Id_tipoevento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_tipoevento) ? string.Empty : base.GetintAsString(ColumnNames.Id_tipoevento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_tipoevento);
				else
					this.Id_tipoevento = base.SetintAsString(ColumnNames.Id_tipoevento, value);
			}
		}

		public virtual string s_Habilitado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Habilitado) ? string.Empty : base.GetboolAsString(ColumnNames.Habilitado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Habilitado);
				else
					this.Habilitado = base.SetboolAsString(ColumnNames.Habilitado, value);
			}
		}

		public virtual string s_User_ins
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_ins) ? string.Empty : base.GetintAsString(ColumnNames.User_ins);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_ins);
				else
					this.User_ins = base.SetintAsString(ColumnNames.User_ins, value);
			}
		}

		public virtual string s_Fech_ins
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fech_ins) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fech_ins);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fech_ins);
				else
					this.Fech_ins = base.SetDateTimeAsString(ColumnNames.Fech_ins, value);
			}
		}

		public virtual string s_User_upd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_upd) ? string.Empty : base.GetintAsString(ColumnNames.User_upd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_upd);
				else
					this.User_upd = base.SetintAsString(ColumnNames.User_upd, value);
			}
		}

		public virtual string s_Fech_upd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fech_upd) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fech_upd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fech_upd);
				else
					this.Fech_upd = base.SetDateTimeAsString(ColumnNames.Fech_upd, value);
			}
		}

		public virtual string s_Evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Evento) ? string.Empty : base.GetstringAsString(ColumnNames.Evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Evento);
				else
					this.Evento = base.SetstringAsString(ColumnNames.Evento, value);
			}
		}

		public virtual string s_Sonoro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sonoro) ? string.Empty : base.GetboolAsString(ColumnNames.Sonoro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sonoro);
				else
					this.Sonoro = base.SetboolAsString(ColumnNames.Sonoro, value);
			}
		}

		public virtual string s_Arch_sonido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Arch_sonido) ? string.Empty : base.GetstringAsString(ColumnNames.Arch_sonido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Arch_sonido);
				else
					this.Arch_sonido = base.SetstringAsString(ColumnNames.Arch_sonido, value);
			}
		}

		public virtual string s_Email
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Email) ? string.Empty : base.GetstringAsString(ColumnNames.Email);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Email);
				else
					this.Email = base.SetstringAsString(ColumnNames.Email, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter Id_equipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_tipoevento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoevento, Parameters.Id_tipoevento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Habilitado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Habilitado, Parameters.Habilitado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_ins
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_ins, Parameters.User_ins);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fech_ins
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fech_ins, Parameters.Fech_ins);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_upd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_upd, Parameters.User_upd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fech_upd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fech_upd, Parameters.Fech_upd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Evento, Parameters.Evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sonoro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sonoro, Parameters.Sonoro);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Arch_sonido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Arch_sonido, Parameters.Arch_sonido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_equipogps
		    {
				get
		        {
					if(_Id_equipogps_W == null)
	        	    {
						_Id_equipogps_W = TearOff.Id_equipogps;
					}
					return _Id_equipogps_W;
				}
			}

			public WhereParameter Id_tipoevento
		    {
				get
		        {
					if(_Id_tipoevento_W == null)
	        	    {
						_Id_tipoevento_W = TearOff.Id_tipoevento;
					}
					return _Id_tipoevento_W;
				}
			}

			public WhereParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
				}
			}

			public WhereParameter User_ins
		    {
				get
		        {
					if(_User_ins_W == null)
	        	    {
						_User_ins_W = TearOff.User_ins;
					}
					return _User_ins_W;
				}
			}

			public WhereParameter Fech_ins
		    {
				get
		        {
					if(_Fech_ins_W == null)
	        	    {
						_Fech_ins_W = TearOff.Fech_ins;
					}
					return _Fech_ins_W;
				}
			}

			public WhereParameter User_upd
		    {
				get
		        {
					if(_User_upd_W == null)
	        	    {
						_User_upd_W = TearOff.User_upd;
					}
					return _User_upd_W;
				}
			}

			public WhereParameter Fech_upd
		    {
				get
		        {
					if(_Fech_upd_W == null)
	        	    {
						_Fech_upd_W = TearOff.Fech_upd;
					}
					return _Fech_upd_W;
				}
			}

			public WhereParameter Evento
		    {
				get
		        {
					if(_Evento_W == null)
	        	    {
						_Evento_W = TearOff.Evento;
					}
					return _Evento_W;
				}
			}

			public WhereParameter Sonoro
		    {
				get
		        {
					if(_Sonoro_W == null)
	        	    {
						_Sonoro_W = TearOff.Sonoro;
					}
					return _Sonoro_W;
				}
			}

			public WhereParameter Arch_sonido
		    {
				get
		        {
					if(_Arch_sonido_W == null)
	        	    {
						_Arch_sonido_W = TearOff.Arch_sonido;
					}
					return _Arch_sonido_W;
				}
			}

			public WhereParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Id_tipoevento_W = null;
			private WhereParameter _Habilitado_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Evento_W = null;
			private WhereParameter _Sonoro_W = null;
			private WhereParameter _Arch_sonido_W = null;
			private WhereParameter _Email_W = null;

			public void WhereClauseReset()
			{
				_Id_equipogps_W = null;
				_Id_tipoevento_W = null;
				_Habilitado_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Evento_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;
				_Email_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter Id_equipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_tipoevento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoevento, Parameters.Id_tipoevento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Habilitado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Habilitado, Parameters.Habilitado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_ins
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_ins, Parameters.User_ins);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fech_ins
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fech_ins, Parameters.Fech_ins);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_upd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_upd, Parameters.User_upd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fech_upd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fech_upd, Parameters.Fech_upd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Evento, Parameters.Evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sonoro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sonoro, Parameters.Sonoro);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Arch_sonido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Arch_sonido, Parameters.Arch_sonido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_equipogps
		    {
				get
		        {
					if(_Id_equipogps_W == null)
	        	    {
						_Id_equipogps_W = TearOff.Id_equipogps;
					}
					return _Id_equipogps_W;
				}
			}

			public AggregateParameter Id_tipoevento
		    {
				get
		        {
					if(_Id_tipoevento_W == null)
	        	    {
						_Id_tipoevento_W = TearOff.Id_tipoevento;
					}
					return _Id_tipoevento_W;
				}
			}

			public AggregateParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
				}
			}

			public AggregateParameter User_ins
		    {
				get
		        {
					if(_User_ins_W == null)
	        	    {
						_User_ins_W = TearOff.User_ins;
					}
					return _User_ins_W;
				}
			}

			public AggregateParameter Fech_ins
		    {
				get
		        {
					if(_Fech_ins_W == null)
	        	    {
						_Fech_ins_W = TearOff.Fech_ins;
					}
					return _Fech_ins_W;
				}
			}

			public AggregateParameter User_upd
		    {
				get
		        {
					if(_User_upd_W == null)
	        	    {
						_User_upd_W = TearOff.User_upd;
					}
					return _User_upd_W;
				}
			}

			public AggregateParameter Fech_upd
		    {
				get
		        {
					if(_Fech_upd_W == null)
	        	    {
						_Fech_upd_W = TearOff.Fech_upd;
					}
					return _Fech_upd_W;
				}
			}

			public AggregateParameter Evento
		    {
				get
		        {
					if(_Evento_W == null)
	        	    {
						_Evento_W = TearOff.Evento;
					}
					return _Evento_W;
				}
			}

			public AggregateParameter Sonoro
		    {
				get
		        {
					if(_Sonoro_W == null)
	        	    {
						_Sonoro_W = TearOff.Sonoro;
					}
					return _Sonoro_W;
				}
			}

			public AggregateParameter Arch_sonido
		    {
				get
		        {
					if(_Arch_sonido_W == null)
	        	    {
						_Arch_sonido_W = TearOff.Arch_sonido;
					}
					return _Arch_sonido_W;
				}
			}

			public AggregateParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Id_tipoevento_W = null;
			private AggregateParameter _Habilitado_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Evento_W = null;
			private AggregateParameter _Sonoro_W = null;
			private AggregateParameter _Arch_sonido_W = null;
			private AggregateParameter _Email_W = null;

			public void AggregateClauseReset()
			{
				_Id_equipogps_W = null;
				_Id_tipoevento_W = null;
				_Habilitado_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Evento_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;
				_Email_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipo_eventos_insert";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipo_eventos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipo_eventos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_tipoevento);
			p.SourceColumn = ColumnNames.Id_tipoevento;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_tipoevento);
			p.SourceColumn = ColumnNames.Id_tipoevento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Habilitado);
			p.SourceColumn = ColumnNames.Habilitado;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_ins);
			p.SourceColumn = ColumnNames.User_ins;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_ins);
			p.SourceColumn = ColumnNames.Fech_ins;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_upd);
			p.SourceColumn = ColumnNames.User_upd;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_upd);
			p.SourceColumn = ColumnNames.Fech_upd;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Evento);
			p.SourceColumn = ColumnNames.Evento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sonoro);
			p.SourceColumn = ColumnNames.Sonoro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Arch_sonido);
			p.SourceColumn = ColumnNames.Arch_sonido;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Email);
			p.SourceColumn = ColumnNames.Email;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
