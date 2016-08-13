
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_template_hoja_de_ruta.
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
	public abstract class _rastreo_template_hoja_de_ruta : PostgreSqlEntity
	{
		public _rastreo_template_hoja_de_ruta()
		{
			this.QuerySource = "rastreo_template_hoja_de_ruta";
			this.MappingName = "rastreo_template_hoja_de_ruta";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_template_hoja_de_ruta_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_recorridotemplate)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_recorridotemplate, Id_recorridotemplate);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_template_hoja_de_ruta_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Id_recorridotemplate
			{
				get
				{
					return new NpgsqlParameter("Id_recorridotemplate", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_persona
			{
				get
				{
					return new NpgsqlParameter("Id_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_usuarios
			{
				get
				{
					return new NpgsqlParameter("Id_usuarios", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion_recorrido
			{
				get
				{
					return new NpgsqlParameter("Descripcion_recorrido", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Publico
			{
				get
				{
					return new NpgsqlParameter("Publico", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_recorridotemplate = "id_recorridotemplate";
            public const string Id_persona = "id_persona";
            public const string Id_usuarios = "id_usuarios";
            public const string Descripcion_recorrido = "descripcion_recorrido";
            public const string Publico = "publico";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_recorridotemplate] = _rastreo_template_hoja_de_ruta.PropertyNames.Id_recorridotemplate;
					ht[Id_persona] = _rastreo_template_hoja_de_ruta.PropertyNames.Id_persona;
					ht[Id_usuarios] = _rastreo_template_hoja_de_ruta.PropertyNames.Id_usuarios;
					ht[Descripcion_recorrido] = _rastreo_template_hoja_de_ruta.PropertyNames.Descripcion_recorrido;
					ht[Publico] = _rastreo_template_hoja_de_ruta.PropertyNames.Publico;
					ht[User_ins] = _rastreo_template_hoja_de_ruta.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_template_hoja_de_ruta.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_template_hoja_de_ruta.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_template_hoja_de_ruta.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_recorridotemplate = "Id_recorridotemplate";
            public const string Id_persona = "Id_persona";
            public const string Id_usuarios = "Id_usuarios";
            public const string Descripcion_recorrido = "Descripcion_recorrido";
            public const string Publico = "Publico";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_recorridotemplate] = _rastreo_template_hoja_de_ruta.ColumnNames.Id_recorridotemplate;
					ht[Id_persona] = _rastreo_template_hoja_de_ruta.ColumnNames.Id_persona;
					ht[Id_usuarios] = _rastreo_template_hoja_de_ruta.ColumnNames.Id_usuarios;
					ht[Descripcion_recorrido] = _rastreo_template_hoja_de_ruta.ColumnNames.Descripcion_recorrido;
					ht[Publico] = _rastreo_template_hoja_de_ruta.ColumnNames.Publico;
					ht[User_ins] = _rastreo_template_hoja_de_ruta.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_template_hoja_de_ruta.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_template_hoja_de_ruta.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_template_hoja_de_ruta.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_recorridotemplate = "s_Id_recorridotemplate";
            public const string Id_persona = "s_Id_persona";
            public const string Id_usuarios = "s_Id_usuarios";
            public const string Descripcion_recorrido = "s_Descripcion_recorrido";
            public const string Publico = "s_Publico";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_recorridotemplate
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_recorridotemplate);
			}
			set
	        {
				base.Setint(ColumnNames.Id_recorridotemplate, value);
			}
		}

		public virtual int Id_persona
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_persona);
			}
			set
	        {
				base.Setint(ColumnNames.Id_persona, value);
			}
		}

		public virtual int Id_usuarios
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_usuarios);
			}
			set
	        {
				base.Setint(ColumnNames.Id_usuarios, value);
			}
		}

		public virtual string Descripcion_recorrido
	    {
			get
	        {
				return base.Getstring(ColumnNames.Descripcion_recorrido);
			}
			set
	        {
				base.Setstring(ColumnNames.Descripcion_recorrido, value);
			}
		}

		public virtual bool Publico
	    {
			get
	        {
				return base.Getbool(ColumnNames.Publico);
			}
			set
	        {
				base.Setbool(ColumnNames.Publico, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_recorridotemplate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_recorridotemplate) ? string.Empty : base.GetintAsString(ColumnNames.Id_recorridotemplate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_recorridotemplate);
				else
					this.Id_recorridotemplate = base.SetintAsString(ColumnNames.Id_recorridotemplate, value);
			}
		}

		public virtual string s_Id_persona
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_persona) ? string.Empty : base.GetintAsString(ColumnNames.Id_persona);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_persona);
				else
					this.Id_persona = base.SetintAsString(ColumnNames.Id_persona, value);
			}
		}

		public virtual string s_Id_usuarios
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_usuarios) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuarios);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_usuarios);
				else
					this.Id_usuarios = base.SetintAsString(ColumnNames.Id_usuarios, value);
			}
		}

		public virtual string s_Descripcion_recorrido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Descripcion_recorrido) ? string.Empty : base.GetstringAsString(ColumnNames.Descripcion_recorrido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Descripcion_recorrido);
				else
					this.Descripcion_recorrido = base.SetstringAsString(ColumnNames.Descripcion_recorrido, value);
			}
		}

		public virtual string s_Publico
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Publico) ? string.Empty : base.GetboolAsString(ColumnNames.Publico);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Publico);
				else
					this.Publico = base.SetboolAsString(ColumnNames.Publico, value);
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
				
				
				public WhereParameter Id_recorridotemplate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_recorridotemplate, Parameters.Id_recorridotemplate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_persona
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_persona, Parameters.Id_persona);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_usuarios
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_usuarios, Parameters.Id_usuarios);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Descripcion_recorrido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Descripcion_recorrido, Parameters.Descripcion_recorrido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Publico
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Publico, Parameters.Publico);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_recorridotemplate
		    {
				get
		        {
					if(_Id_recorridotemplate_W == null)
	        	    {
						_Id_recorridotemplate_W = TearOff.Id_recorridotemplate;
					}
					return _Id_recorridotemplate_W;
				}
			}

			public WhereParameter Id_persona
		    {
				get
		        {
					if(_Id_persona_W == null)
	        	    {
						_Id_persona_W = TearOff.Id_persona;
					}
					return _Id_persona_W;
				}
			}

			public WhereParameter Id_usuarios
		    {
				get
		        {
					if(_Id_usuarios_W == null)
	        	    {
						_Id_usuarios_W = TearOff.Id_usuarios;
					}
					return _Id_usuarios_W;
				}
			}

			public WhereParameter Descripcion_recorrido
		    {
				get
		        {
					if(_Descripcion_recorrido_W == null)
	        	    {
						_Descripcion_recorrido_W = TearOff.Descripcion_recorrido;
					}
					return _Descripcion_recorrido_W;
				}
			}

			public WhereParameter Publico
		    {
				get
		        {
					if(_Publico_W == null)
	        	    {
						_Publico_W = TearOff.Publico;
					}
					return _Publico_W;
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

			private WhereParameter _Id_recorridotemplate_W = null;
			private WhereParameter _Id_persona_W = null;
			private WhereParameter _Id_usuarios_W = null;
			private WhereParameter _Descripcion_recorrido_W = null;
			private WhereParameter _Publico_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Id_recorridotemplate_W = null;
				_Id_persona_W = null;
				_Id_usuarios_W = null;
				_Descripcion_recorrido_W = null;
				_Publico_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;

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
				
				
				public AggregateParameter Id_recorridotemplate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_recorridotemplate, Parameters.Id_recorridotemplate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_persona
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_persona, Parameters.Id_persona);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_usuarios
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuarios, Parameters.Id_usuarios);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Descripcion_recorrido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion_recorrido, Parameters.Descripcion_recorrido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Publico
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Publico, Parameters.Publico);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_recorridotemplate
		    {
				get
		        {
					if(_Id_recorridotemplate_W == null)
	        	    {
						_Id_recorridotemplate_W = TearOff.Id_recorridotemplate;
					}
					return _Id_recorridotemplate_W;
				}
			}

			public AggregateParameter Id_persona
		    {
				get
		        {
					if(_Id_persona_W == null)
	        	    {
						_Id_persona_W = TearOff.Id_persona;
					}
					return _Id_persona_W;
				}
			}

			public AggregateParameter Id_usuarios
		    {
				get
		        {
					if(_Id_usuarios_W == null)
	        	    {
						_Id_usuarios_W = TearOff.Id_usuarios;
					}
					return _Id_usuarios_W;
				}
			}

			public AggregateParameter Descripcion_recorrido
		    {
				get
		        {
					if(_Descripcion_recorrido_W == null)
	        	    {
						_Descripcion_recorrido_W = TearOff.Descripcion_recorrido;
					}
					return _Descripcion_recorrido_W;
				}
			}

			public AggregateParameter Publico
		    {
				get
		        {
					if(_Publico_W == null)
	        	    {
						_Publico_W = TearOff.Publico;
					}
					return _Publico_W;
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

			private AggregateParameter _Id_recorridotemplate_W = null;
			private AggregateParameter _Id_persona_W = null;
			private AggregateParameter _Id_usuarios_W = null;
			private AggregateParameter _Descripcion_recorrido_W = null;
			private AggregateParameter _Publico_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Id_recorridotemplate_W = null;
				_Id_persona_W = null;
				_Id_usuarios_W = null;
				_Descripcion_recorrido_W = null;
				_Publico_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_hoja_de_ruta_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Id_recorridotemplate.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_hoja_de_ruta_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_hoja_de_ruta_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_recorridotemplate);
			p.SourceColumn = ColumnNames.Id_recorridotemplate;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_recorridotemplate);
			p.SourceColumn = ColumnNames.Id_recorridotemplate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_persona);
			p.SourceColumn = ColumnNames.Id_persona;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_usuarios);
			p.SourceColumn = ColumnNames.Id_usuarios;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion_recorrido);
			p.SourceColumn = ColumnNames.Descripcion_recorrido;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Publico);
			p.SourceColumn = ColumnNames.Publico;
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


			return cmd;
		}
	}
}
