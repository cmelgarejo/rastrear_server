
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla reportesgps62010.
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
    public abstract class _reportesgps : PostgreSqlEntity
    {
        public _reportesgps()
        {
            this.QuerySource = "reportesgps62010";
            this.MappingName = "reportesgps62010";

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

            return base.LoadFromSql(this.SchemaStoredProcedure + "reportesgps62010_load_all", parameters);
        }

        //=================================================================
        // public Overridable Function LoadByPrimaryKey()  As Boolean
        //=================================================================
        //  Loads a single row of via the primary key
        //=================================================================
        public virtual bool LoadByPrimaryKey(int Idreportesgps62010)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(Parameters.Idreportesgps62010, Idreportesgps62010);


            return base.LoadFromSql(this.SchemaStoredProcedure + "reportesgps62010_load_by_primarykey", parameters);
        }

        #region Parameters
        protected class Parameters
        {

            public static NpgsqlParameter Idreportesgps62010
            {
                get
                {
                    return new NpgsqlParameter("Idreportesgps62010", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Id_equipogps
            {
                get
                {
                    return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Gps_longitud
            {
                get
                {
                    return new NpgsqlParameter("Gps_longitud", NpgsqlTypes.NpgsqlDbType.Double, 0);
                }
            }

            public static NpgsqlParameter Gps_latitud
            {
                get
                {
                    return new NpgsqlParameter("Gps_latitud", NpgsqlTypes.NpgsqlDbType.Double, 0);
                }
            }

            public static NpgsqlParameter Gps_fechahora_reporte
            {
                get
                {
                    return new NpgsqlParameter("Gps_fechahora_reporte", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
                }
            }

            public static NpgsqlParameter Gps_velocidad
            {
                get
                {
                    return new NpgsqlParameter("Gps_velocidad", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Gps_rumbo
            {
                get
                {
                    return new NpgsqlParameter("Gps_rumbo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Gps_evento
            {
                get
                {
                    return new NpgsqlParameter("Gps_evento", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_edaddeldato
            {
                get
                {
                    return new NpgsqlParameter("Gps_edaddeldato", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_hdop
            {
                get
                {
                    return new NpgsqlParameter("Gps_hdop", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_satstatus
            {
                get
                {
                    return new NpgsqlParameter("Gps_satstatus", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_gsmstatus
            {
                get
                {
                    return new NpgsqlParameter("Gps_gsmstatus", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_estado_io
            {
                get
                {
                    return new NpgsqlParameter("Gps_estado_io", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_tipodeposicion
            {
                get
                {
                    return new NpgsqlParameter("Gps_tipodeposicion", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Gps_ip
            {
                get
                {
                    return new NpgsqlParameter("Gps_ip", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
                }
            }

            public static NpgsqlParameter Gps_obs
            {
                get
                {
                    return new NpgsqlParameter("Gps_obs", NpgsqlTypes.NpgsqlDbType.Text, 0);
                }
            }

            public static NpgsqlParameter Gps_dir
            {
                get
                {
                    return new NpgsqlParameter("Gps_dir", NpgsqlTypes.NpgsqlDbType.Text, 0);
                }
            }

        }
        #endregion

        #region ColumnNames
        public class ColumnNames
        {
            public const string Idreportesgps62010 = "idreportesgps62010";
            public const string Id_equipogps = "id_equipogps";
            public const string Gps_longitud = "gps_longitud";
            public const string Gps_latitud = "gps_latitud";
            public const string Gps_fechahora_reporte = "gps_fechahora_reporte";
            public const string Gps_velocidad = "gps_velocidad";
            public const string Gps_rumbo = "gps_rumbo";
            public const string Gps_evento = "gps_evento";
            public const string Gps_edaddeldato = "gps_edaddeldato";
            public const string Gps_hdop = "gps_hdop";
            public const string Gps_satstatus = "gps_satstatus";
            public const string Gps_gsmstatus = "gps_gsmstatus";
            public const string Gps_estado_io = "gps_estado_io";
            public const string Gps_tipodeposicion = "gps_tipodeposicion";
            public const string Gps_ip = "gps_ip";
            public const string Gps_obs = "gps_obs";
            public const string Gps_dir = "gps_dir";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idreportesgps62010] = _reportesgps.PropertyNames.Idreportesgps62010;
                    ht[Id_equipogps] = _reportesgps.PropertyNames.Id_equipogps;
                    ht[Gps_longitud] = _reportesgps.PropertyNames.Gps_longitud;
                    ht[Gps_latitud] = _reportesgps.PropertyNames.Gps_latitud;
                    ht[Gps_fechahora_reporte] = _reportesgps.PropertyNames.Gps_fechahora_reporte;
                    ht[Gps_velocidad] = _reportesgps.PropertyNames.Gps_velocidad;
                    ht[Gps_rumbo] = _reportesgps.PropertyNames.Gps_rumbo;
                    ht[Gps_evento] = _reportesgps.PropertyNames.Gps_evento;
                    ht[Gps_edaddeldato] = _reportesgps.PropertyNames.Gps_edaddeldato;
                    ht[Gps_hdop] = _reportesgps.PropertyNames.Gps_hdop;
                    ht[Gps_satstatus] = _reportesgps.PropertyNames.Gps_satstatus;
                    ht[Gps_gsmstatus] = _reportesgps.PropertyNames.Gps_gsmstatus;
                    ht[Gps_estado_io] = _reportesgps.PropertyNames.Gps_estado_io;
                    ht[Gps_tipodeposicion] = _reportesgps.PropertyNames.Gps_tipodeposicion;
                    ht[Gps_ip] = _reportesgps.PropertyNames.Gps_ip;
                    ht[Gps_obs] = _reportesgps.PropertyNames.Gps_obs;
                    ht[Gps_dir] = _reportesgps.PropertyNames.Gps_dir;

                }
                return (string)ht[columnName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Idreportesgps62010 = "Idreportesgps62010";
            public const string Id_equipogps = "Id_equipogps";
            public const string Gps_longitud = "Gps_longitud";
            public const string Gps_latitud = "Gps_latitud";
            public const string Gps_fechahora_reporte = "Gps_fechahora_reporte";
            public const string Gps_velocidad = "Gps_velocidad";
            public const string Gps_rumbo = "Gps_rumbo";
            public const string Gps_evento = "Gps_evento";
            public const string Gps_edaddeldato = "Gps_edaddeldato";
            public const string Gps_hdop = "Gps_hdop";
            public const string Gps_satstatus = "Gps_satstatus";
            public const string Gps_gsmstatus = "Gps_gsmstatus";
            public const string Gps_estado_io = "Gps_estado_io";
            public const string Gps_tipodeposicion = "Gps_tipodeposicion";
            public const string Gps_ip = "Gps_ip";
            public const string Gps_obs = "Gps_obs";
            public const string Gps_dir = "Gps_dir";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idreportesgps62010] = _reportesgps.ColumnNames.Idreportesgps62010;
                    ht[Id_equipogps] = _reportesgps.ColumnNames.Id_equipogps;
                    ht[Gps_longitud] = _reportesgps.ColumnNames.Gps_longitud;
                    ht[Gps_latitud] = _reportesgps.ColumnNames.Gps_latitud;
                    ht[Gps_fechahora_reporte] = _reportesgps.ColumnNames.Gps_fechahora_reporte;
                    ht[Gps_velocidad] = _reportesgps.ColumnNames.Gps_velocidad;
                    ht[Gps_rumbo] = _reportesgps.ColumnNames.Gps_rumbo;
                    ht[Gps_evento] = _reportesgps.ColumnNames.Gps_evento;
                    ht[Gps_edaddeldato] = _reportesgps.ColumnNames.Gps_edaddeldato;
                    ht[Gps_hdop] = _reportesgps.ColumnNames.Gps_hdop;
                    ht[Gps_satstatus] = _reportesgps.ColumnNames.Gps_satstatus;
                    ht[Gps_gsmstatus] = _reportesgps.ColumnNames.Gps_gsmstatus;
                    ht[Gps_estado_io] = _reportesgps.ColumnNames.Gps_estado_io;
                    ht[Gps_tipodeposicion] = _reportesgps.ColumnNames.Gps_tipodeposicion;
                    ht[Gps_ip] = _reportesgps.ColumnNames.Gps_ip;
                    ht[Gps_obs] = _reportesgps.ColumnNames.Gps_obs;
                    ht[Gps_dir] = _reportesgps.ColumnNames.Gps_dir;

                }
                return (string)ht[propertyName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region StringPropertyNames
        public class StringPropertyNames
        {
            public const string Idreportesgps62010 = "s_Idreportesgps62010";
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Gps_longitud = "s_Gps_longitud";
            public const string Gps_latitud = "s_Gps_latitud";
            public const string Gps_fechahora_reporte = "s_Gps_fechahora_reporte";
            public const string Gps_velocidad = "s_Gps_velocidad";
            public const string Gps_rumbo = "s_Gps_rumbo";
            public const string Gps_evento = "s_Gps_evento";
            public const string Gps_edaddeldato = "s_Gps_edaddeldato";
            public const string Gps_hdop = "s_Gps_hdop";
            public const string Gps_satstatus = "s_Gps_satstatus";
            public const string Gps_gsmstatus = "s_Gps_gsmstatus";
            public const string Gps_estado_io = "s_Gps_estado_io";
            public const string Gps_tipodeposicion = "s_Gps_tipodeposicion";
            public const string Gps_ip = "s_Gps_ip";
            public const string Gps_obs = "s_Gps_obs";
            public const string Gps_dir = "s_Gps_dir";

        }
        #endregion

        #region Properties

        public virtual int Idreportesgps62010
        {
            get
            {
                return base.Getint(ColumnNames.Idreportesgps62010);
            }
            set
            {
                base.Setint(ColumnNames.Idreportesgps62010, value);
            }
        }

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

        public virtual double Gps_longitud
        {
            get
            {
                return base.Getdouble(ColumnNames.Gps_longitud);
            }
            set
            {
                base.Setdouble(ColumnNames.Gps_longitud, value);
            }
        }

        public virtual double Gps_latitud
        {
            get
            {
                return base.Getdouble(ColumnNames.Gps_latitud);
            }
            set
            {
                base.Setdouble(ColumnNames.Gps_latitud, value);
            }
        }

        public virtual DateTime Gps_fechahora_reporte
        {
            get
            {
                return base.GetDateTime(ColumnNames.Gps_fechahora_reporte);
            }
            set
            {
                base.SetDateTime(ColumnNames.Gps_fechahora_reporte, value);
            }
        }

        public virtual int Gps_velocidad
        {
            get
            {
                return base.Getint(ColumnNames.Gps_velocidad);
            }
            set
            {
                base.Setint(ColumnNames.Gps_velocidad, value);
            }
        }

        public virtual int Gps_rumbo
        {
            get
            {
                return base.Getint(ColumnNames.Gps_rumbo);
            }
            set
            {
                base.Setint(ColumnNames.Gps_rumbo, value);
            }
        }

        public virtual string Gps_evento
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_evento);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_evento, value);
            }
        }

        public virtual string Gps_edaddeldato
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_edaddeldato);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_edaddeldato, value);
            }
        }

        public virtual string Gps_hdop
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_hdop);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_hdop, value);
            }
        }

        public virtual string Gps_satstatus
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_satstatus);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_satstatus, value);
            }
        }

        public virtual string Gps_gsmstatus
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_gsmstatus);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_gsmstatus, value);
            }
        }

        public virtual string Gps_estado_io
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_estado_io);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_estado_io, value);
            }
        }

        public virtual string Gps_tipodeposicion
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_tipodeposicion);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_tipodeposicion, value);
            }
        }

        public virtual string Gps_ip
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_ip);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_ip, value);
            }
        }

        public virtual string Gps_obs
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_obs);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_obs, value);
            }
        }

        public virtual string Gps_dir
        {
            get
            {
                return base.Getstring(ColumnNames.Gps_dir);
            }
            set
            {
                base.Setstring(ColumnNames.Gps_dir, value);
            }
        }


        #endregion

        #region String Properties

        public virtual string s_Idreportesgps62010
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idreportesgps62010) ? string.Empty : base.GetintAsString(ColumnNames.Idreportesgps62010);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idreportesgps62010);
                else
                    this.Idreportesgps62010 = base.SetintAsString(ColumnNames.Idreportesgps62010, value);
            }
        }

        public virtual string s_Id_equipogps
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Id_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Id_equipogps);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Id_equipogps);
                else
                    this.Id_equipogps = base.SetintAsString(ColumnNames.Id_equipogps, value);
            }
        }

        public virtual string s_Gps_longitud
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_longitud) ? string.Empty : base.GetdoubleAsString(ColumnNames.Gps_longitud);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_longitud);
                else
                    this.Gps_longitud = base.SetdoubleAsString(ColumnNames.Gps_longitud, value);
            }
        }

        public virtual string s_Gps_latitud
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_latitud) ? string.Empty : base.GetdoubleAsString(ColumnNames.Gps_latitud);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_latitud);
                else
                    this.Gps_latitud = base.SetdoubleAsString(ColumnNames.Gps_latitud, value);
            }
        }

        public virtual string s_Gps_fechahora_reporte
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_fechahora_reporte) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Gps_fechahora_reporte);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_fechahora_reporte);
                else
                    this.Gps_fechahora_reporte = base.SetDateTimeAsString(ColumnNames.Gps_fechahora_reporte, value);
            }
        }

        public virtual string s_Gps_velocidad
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_velocidad) ? string.Empty : base.GetintAsString(ColumnNames.Gps_velocidad);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_velocidad);
                else
                    this.Gps_velocidad = base.SetintAsString(ColumnNames.Gps_velocidad, value);
            }
        }

        public virtual string s_Gps_rumbo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_rumbo) ? string.Empty : base.GetintAsString(ColumnNames.Gps_rumbo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_rumbo);
                else
                    this.Gps_rumbo = base.SetintAsString(ColumnNames.Gps_rumbo, value);
            }
        }

        public virtual string s_Gps_evento
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_evento) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_evento);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_evento);
                else
                    this.Gps_evento = base.SetstringAsString(ColumnNames.Gps_evento, value);
            }
        }

        public virtual string s_Gps_edaddeldato
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_edaddeldato) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_edaddeldato);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_edaddeldato);
                else
                    this.Gps_edaddeldato = base.SetstringAsString(ColumnNames.Gps_edaddeldato, value);
            }
        }

        public virtual string s_Gps_hdop
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_hdop) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_hdop);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_hdop);
                else
                    this.Gps_hdop = base.SetstringAsString(ColumnNames.Gps_hdop, value);
            }
        }

        public virtual string s_Gps_satstatus
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_satstatus) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_satstatus);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_satstatus);
                else
                    this.Gps_satstatus = base.SetstringAsString(ColumnNames.Gps_satstatus, value);
            }
        }

        public virtual string s_Gps_gsmstatus
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_gsmstatus) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_gsmstatus);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_gsmstatus);
                else
                    this.Gps_gsmstatus = base.SetstringAsString(ColumnNames.Gps_gsmstatus, value);
            }
        }

        public virtual string s_Gps_estado_io
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_estado_io) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_estado_io);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_estado_io);
                else
                    this.Gps_estado_io = base.SetstringAsString(ColumnNames.Gps_estado_io, value);
            }
        }

        public virtual string s_Gps_tipodeposicion
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_tipodeposicion) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_tipodeposicion);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_tipodeposicion);
                else
                    this.Gps_tipodeposicion = base.SetstringAsString(ColumnNames.Gps_tipodeposicion, value);
            }
        }

        public virtual string s_Gps_ip
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_ip) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_ip);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_ip);
                else
                    this.Gps_ip = base.SetstringAsString(ColumnNames.Gps_ip, value);
            }
        }

        public virtual string s_Gps_obs
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_obs) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_obs);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_obs);
                else
                    this.Gps_obs = base.SetstringAsString(ColumnNames.Gps_obs, value);
            }
        }

        public virtual string s_Gps_dir
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Gps_dir) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_dir);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Gps_dir);
                else
                    this.Gps_dir = base.SetstringAsString(ColumnNames.Gps_dir, value);
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
                    if (_tearOff == null)
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


                public WhereParameter Idreportesgps62010
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idreportesgps62010, Parameters.Idreportesgps62010);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
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

                public WhereParameter Gps_longitud
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_longitud, Parameters.Gps_longitud);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_latitud
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_latitud, Parameters.Gps_latitud);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_fechahora_reporte
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_fechahora_reporte, Parameters.Gps_fechahora_reporte);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_velocidad
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_velocidad, Parameters.Gps_velocidad);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_rumbo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_rumbo, Parameters.Gps_rumbo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_evento
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_evento, Parameters.Gps_evento);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_edaddeldato
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_edaddeldato, Parameters.Gps_edaddeldato);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_hdop
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_hdop, Parameters.Gps_hdop);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_satstatus
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_satstatus, Parameters.Gps_satstatus);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_gsmstatus
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_gsmstatus, Parameters.Gps_gsmstatus);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_estado_io
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_estado_io, Parameters.Gps_estado_io);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_tipodeposicion
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_tipodeposicion, Parameters.Gps_tipodeposicion);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_ip
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_ip, Parameters.Gps_ip);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_obs
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_obs, Parameters.Gps_obs);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Gps_dir
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Gps_dir, Parameters.Gps_dir);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }


                private WhereClause _clause;
            }
            #endregion

            public WhereParameter Idreportesgps62010
            {
                get
                {
                    if (_Idreportesgps62010_W == null)
                    {
                        _Idreportesgps62010_W = TearOff.Idreportesgps62010;
                    }
                    return _Idreportesgps62010_W;
                }
            }

            public WhereParameter Id_equipogps
            {
                get
                {
                    if (_Id_equipogps_W == null)
                    {
                        _Id_equipogps_W = TearOff.Id_equipogps;
                    }
                    return _Id_equipogps_W;
                }
            }

            public WhereParameter Gps_longitud
            {
                get
                {
                    if (_Gps_longitud_W == null)
                    {
                        _Gps_longitud_W = TearOff.Gps_longitud;
                    }
                    return _Gps_longitud_W;
                }
            }

            public WhereParameter Gps_latitud
            {
                get
                {
                    if (_Gps_latitud_W == null)
                    {
                        _Gps_latitud_W = TearOff.Gps_latitud;
                    }
                    return _Gps_latitud_W;
                }
            }

            public WhereParameter Gps_fechahora_reporte
            {
                get
                {
                    if (_Gps_fechahora_reporte_W == null)
                    {
                        _Gps_fechahora_reporte_W = TearOff.Gps_fechahora_reporte;
                    }
                    return _Gps_fechahora_reporte_W;
                }
            }

            public WhereParameter Gps_velocidad
            {
                get
                {
                    if (_Gps_velocidad_W == null)
                    {
                        _Gps_velocidad_W = TearOff.Gps_velocidad;
                    }
                    return _Gps_velocidad_W;
                }
            }

            public WhereParameter Gps_rumbo
            {
                get
                {
                    if (_Gps_rumbo_W == null)
                    {
                        _Gps_rumbo_W = TearOff.Gps_rumbo;
                    }
                    return _Gps_rumbo_W;
                }
            }

            public WhereParameter Gps_evento
            {
                get
                {
                    if (_Gps_evento_W == null)
                    {
                        _Gps_evento_W = TearOff.Gps_evento;
                    }
                    return _Gps_evento_W;
                }
            }

            public WhereParameter Gps_edaddeldato
            {
                get
                {
                    if (_Gps_edaddeldato_W == null)
                    {
                        _Gps_edaddeldato_W = TearOff.Gps_edaddeldato;
                    }
                    return _Gps_edaddeldato_W;
                }
            }

            public WhereParameter Gps_hdop
            {
                get
                {
                    if (_Gps_hdop_W == null)
                    {
                        _Gps_hdop_W = TearOff.Gps_hdop;
                    }
                    return _Gps_hdop_W;
                }
            }

            public WhereParameter Gps_satstatus
            {
                get
                {
                    if (_Gps_satstatus_W == null)
                    {
                        _Gps_satstatus_W = TearOff.Gps_satstatus;
                    }
                    return _Gps_satstatus_W;
                }
            }

            public WhereParameter Gps_gsmstatus
            {
                get
                {
                    if (_Gps_gsmstatus_W == null)
                    {
                        _Gps_gsmstatus_W = TearOff.Gps_gsmstatus;
                    }
                    return _Gps_gsmstatus_W;
                }
            }

            public WhereParameter Gps_estado_io
            {
                get
                {
                    if (_Gps_estado_io_W == null)
                    {
                        _Gps_estado_io_W = TearOff.Gps_estado_io;
                    }
                    return _Gps_estado_io_W;
                }
            }

            public WhereParameter Gps_tipodeposicion
            {
                get
                {
                    if (_Gps_tipodeposicion_W == null)
                    {
                        _Gps_tipodeposicion_W = TearOff.Gps_tipodeposicion;
                    }
                    return _Gps_tipodeposicion_W;
                }
            }

            public WhereParameter Gps_ip
            {
                get
                {
                    if (_Gps_ip_W == null)
                    {
                        _Gps_ip_W = TearOff.Gps_ip;
                    }
                    return _Gps_ip_W;
                }
            }

            public WhereParameter Gps_obs
            {
                get
                {
                    if (_Gps_obs_W == null)
                    {
                        _Gps_obs_W = TearOff.Gps_obs;
                    }
                    return _Gps_obs_W;
                }
            }

            public WhereParameter Gps_dir
            {
                get
                {
                    if (_Gps_dir_W == null)
                    {
                        _Gps_dir_W = TearOff.Gps_dir;
                    }
                    return _Gps_dir_W;
                }
            }

            private WhereParameter _Idreportesgps62010_W = null;
            private WhereParameter _Id_equipogps_W = null;
            private WhereParameter _Gps_longitud_W = null;
            private WhereParameter _Gps_latitud_W = null;
            private WhereParameter _Gps_fechahora_reporte_W = null;
            private WhereParameter _Gps_velocidad_W = null;
            private WhereParameter _Gps_rumbo_W = null;
            private WhereParameter _Gps_evento_W = null;
            private WhereParameter _Gps_edaddeldato_W = null;
            private WhereParameter _Gps_hdop_W = null;
            private WhereParameter _Gps_satstatus_W = null;
            private WhereParameter _Gps_gsmstatus_W = null;
            private WhereParameter _Gps_estado_io_W = null;
            private WhereParameter _Gps_tipodeposicion_W = null;
            private WhereParameter _Gps_ip_W = null;
            private WhereParameter _Gps_obs_W = null;
            private WhereParameter _Gps_dir_W = null;

            public void WhereClauseReset()
            {
                _Idreportesgps62010_W = null;
                _Id_equipogps_W = null;
                _Gps_longitud_W = null;
                _Gps_latitud_W = null;
                _Gps_fechahora_reporte_W = null;
                _Gps_velocidad_W = null;
                _Gps_rumbo_W = null;
                _Gps_evento_W = null;
                _Gps_edaddeldato_W = null;
                _Gps_hdop_W = null;
                _Gps_satstatus_W = null;
                _Gps_gsmstatus_W = null;
                _Gps_estado_io_W = null;
                _Gps_tipodeposicion_W = null;
                _Gps_ip_W = null;
                _Gps_obs_W = null;
                _Gps_dir_W = null;

                this._entity.Query.FlushWhereParameters();

            }

            private BusinessEntity _entity;
            private TearOffWhereParameter _tearOff;

        }

        public WhereClause Where
        {
            get
            {
                if (_whereClause == null)
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
                    if (_tearOff == null)
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


                public AggregateParameter Idreportesgps62010
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idreportesgps62010, Parameters.Idreportesgps62010);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
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

                public AggregateParameter Gps_longitud
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_longitud, Parameters.Gps_longitud);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_latitud
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_latitud, Parameters.Gps_latitud);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_fechahora_reporte
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_fechahora_reporte, Parameters.Gps_fechahora_reporte);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_velocidad
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_velocidad, Parameters.Gps_velocidad);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_rumbo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_rumbo, Parameters.Gps_rumbo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_evento
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_evento, Parameters.Gps_evento);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_edaddeldato
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_edaddeldato, Parameters.Gps_edaddeldato);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_hdop
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_hdop, Parameters.Gps_hdop);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_satstatus
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_satstatus, Parameters.Gps_satstatus);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_gsmstatus
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_gsmstatus, Parameters.Gps_gsmstatus);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_estado_io
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_estado_io, Parameters.Gps_estado_io);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_tipodeposicion
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_tipodeposicion, Parameters.Gps_tipodeposicion);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_ip
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_ip, Parameters.Gps_ip);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_obs
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_obs, Parameters.Gps_obs);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Gps_dir
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_dir, Parameters.Gps_dir);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }


                private AggregateClause _clause;
            }
            #endregion

            public AggregateParameter Idreportesgps62010
            {
                get
                {
                    if (_Idreportesgps62010_W == null)
                    {
                        _Idreportesgps62010_W = TearOff.Idreportesgps62010;
                    }
                    return _Idreportesgps62010_W;
                }
            }

            public AggregateParameter Id_equipogps
            {
                get
                {
                    if (_Id_equipogps_W == null)
                    {
                        _Id_equipogps_W = TearOff.Id_equipogps;
                    }
                    return _Id_equipogps_W;
                }
            }

            public AggregateParameter Gps_longitud
            {
                get
                {
                    if (_Gps_longitud_W == null)
                    {
                        _Gps_longitud_W = TearOff.Gps_longitud;
                    }
                    return _Gps_longitud_W;
                }
            }

            public AggregateParameter Gps_latitud
            {
                get
                {
                    if (_Gps_latitud_W == null)
                    {
                        _Gps_latitud_W = TearOff.Gps_latitud;
                    }
                    return _Gps_latitud_W;
                }
            }

            public AggregateParameter Gps_fechahora_reporte
            {
                get
                {
                    if (_Gps_fechahora_reporte_W == null)
                    {
                        _Gps_fechahora_reporte_W = TearOff.Gps_fechahora_reporte;
                    }
                    return _Gps_fechahora_reporte_W;
                }
            }

            public AggregateParameter Gps_velocidad
            {
                get
                {
                    if (_Gps_velocidad_W == null)
                    {
                        _Gps_velocidad_W = TearOff.Gps_velocidad;
                    }
                    return _Gps_velocidad_W;
                }
            }

            public AggregateParameter Gps_rumbo
            {
                get
                {
                    if (_Gps_rumbo_W == null)
                    {
                        _Gps_rumbo_W = TearOff.Gps_rumbo;
                    }
                    return _Gps_rumbo_W;
                }
            }

            public AggregateParameter Gps_evento
            {
                get
                {
                    if (_Gps_evento_W == null)
                    {
                        _Gps_evento_W = TearOff.Gps_evento;
                    }
                    return _Gps_evento_W;
                }
            }

            public AggregateParameter Gps_edaddeldato
            {
                get
                {
                    if (_Gps_edaddeldato_W == null)
                    {
                        _Gps_edaddeldato_W = TearOff.Gps_edaddeldato;
                    }
                    return _Gps_edaddeldato_W;
                }
            }

            public AggregateParameter Gps_hdop
            {
                get
                {
                    if (_Gps_hdop_W == null)
                    {
                        _Gps_hdop_W = TearOff.Gps_hdop;
                    }
                    return _Gps_hdop_W;
                }
            }

            public AggregateParameter Gps_satstatus
            {
                get
                {
                    if (_Gps_satstatus_W == null)
                    {
                        _Gps_satstatus_W = TearOff.Gps_satstatus;
                    }
                    return _Gps_satstatus_W;
                }
            }

            public AggregateParameter Gps_gsmstatus
            {
                get
                {
                    if (_Gps_gsmstatus_W == null)
                    {
                        _Gps_gsmstatus_W = TearOff.Gps_gsmstatus;
                    }
                    return _Gps_gsmstatus_W;
                }
            }

            public AggregateParameter Gps_estado_io
            {
                get
                {
                    if (_Gps_estado_io_W == null)
                    {
                        _Gps_estado_io_W = TearOff.Gps_estado_io;
                    }
                    return _Gps_estado_io_W;
                }
            }

            public AggregateParameter Gps_tipodeposicion
            {
                get
                {
                    if (_Gps_tipodeposicion_W == null)
                    {
                        _Gps_tipodeposicion_W = TearOff.Gps_tipodeposicion;
                    }
                    return _Gps_tipodeposicion_W;
                }
            }

            public AggregateParameter Gps_ip
            {
                get
                {
                    if (_Gps_ip_W == null)
                    {
                        _Gps_ip_W = TearOff.Gps_ip;
                    }
                    return _Gps_ip_W;
                }
            }

            public AggregateParameter Gps_obs
            {
                get
                {
                    if (_Gps_obs_W == null)
                    {
                        _Gps_obs_W = TearOff.Gps_obs;
                    }
                    return _Gps_obs_W;
                }
            }

            public AggregateParameter Gps_dir
            {
                get
                {
                    if (_Gps_dir_W == null)
                    {
                        _Gps_dir_W = TearOff.Gps_dir;
                    }
                    return _Gps_dir_W;
                }
            }

            private AggregateParameter _Idreportesgps62010_W = null;
            private AggregateParameter _Id_equipogps_W = null;
            private AggregateParameter _Gps_longitud_W = null;
            private AggregateParameter _Gps_latitud_W = null;
            private AggregateParameter _Gps_fechahora_reporte_W = null;
            private AggregateParameter _Gps_velocidad_W = null;
            private AggregateParameter _Gps_rumbo_W = null;
            private AggregateParameter _Gps_evento_W = null;
            private AggregateParameter _Gps_edaddeldato_W = null;
            private AggregateParameter _Gps_hdop_W = null;
            private AggregateParameter _Gps_satstatus_W = null;
            private AggregateParameter _Gps_gsmstatus_W = null;
            private AggregateParameter _Gps_estado_io_W = null;
            private AggregateParameter _Gps_tipodeposicion_W = null;
            private AggregateParameter _Gps_ip_W = null;
            private AggregateParameter _Gps_obs_W = null;
            private AggregateParameter _Gps_dir_W = null;

            public void AggregateClauseReset()
            {
                _Idreportesgps62010_W = null;
                _Id_equipogps_W = null;
                _Gps_longitud_W = null;
                _Gps_latitud_W = null;
                _Gps_fechahora_reporte_W = null;
                _Gps_velocidad_W = null;
                _Gps_rumbo_W = null;
                _Gps_evento_W = null;
                _Gps_edaddeldato_W = null;
                _Gps_hdop_W = null;
                _Gps_satstatus_W = null;
                _Gps_gsmstatus_W = null;
                _Gps_estado_io_W = null;
                _Gps_tipodeposicion_W = null;
                _Gps_ip_W = null;
                _Gps_obs_W = null;
                _Gps_dir_W = null;

                this._entity.Query.FlushAggregateParameters();

            }

            private BusinessEntity _entity;
            private TearOffAggregateParameter _tearOff;

        }

        public AggregateClause Aggregate
        {
            get
            {
                if (_aggregateClause == null)
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
            cmd.CommandText = this.SchemaStoredProcedure + "reportesgps62010_insert";

            CreateParameters(cmd);

            NpgsqlParameter p;
            p = cmd.Parameters[Parameters.Idreportesgps62010.ParameterName];
            p.Direction = ParameterDirection.Output;

            return cmd;
        }

        protected override IDbCommand GetUpdateCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "reportesgps62010_update";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "reportesgps62010_delete";

            NpgsqlParameter p;
            p = cmd.Parameters.Add(Parameters.Idreportesgps62010);
            p.SourceColumn = ColumnNames.Idreportesgps62010;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }

        private IDbCommand CreateParameters(NpgsqlCommand cmd)
        {
            NpgsqlParameter p;

            p = cmd.Parameters.Add(Parameters.Idreportesgps62010);
            p.SourceColumn = ColumnNames.Idreportesgps62010;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Id_equipogps);
            p.SourceColumn = ColumnNames.Id_equipogps;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_longitud);
            p.SourceColumn = ColumnNames.Gps_longitud;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_latitud);
            p.SourceColumn = ColumnNames.Gps_latitud;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_fechahora_reporte);
            p.SourceColumn = ColumnNames.Gps_fechahora_reporte;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_velocidad);
            p.SourceColumn = ColumnNames.Gps_velocidad;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_rumbo);
            p.SourceColumn = ColumnNames.Gps_rumbo;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_evento);
            p.SourceColumn = ColumnNames.Gps_evento;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_edaddeldato);
            p.SourceColumn = ColumnNames.Gps_edaddeldato;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_hdop);
            p.SourceColumn = ColumnNames.Gps_hdop;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_satstatus);
            p.SourceColumn = ColumnNames.Gps_satstatus;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_gsmstatus);
            p.SourceColumn = ColumnNames.Gps_gsmstatus;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_estado_io);
            p.SourceColumn = ColumnNames.Gps_estado_io;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_tipodeposicion);
            p.SourceColumn = ColumnNames.Gps_tipodeposicion;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_ip);
            p.SourceColumn = ColumnNames.Gps_ip;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_obs);
            p.SourceColumn = ColumnNames.Gps_obs;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Gps_dir);
            p.SourceColumn = ColumnNames.Gps_dir;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}


