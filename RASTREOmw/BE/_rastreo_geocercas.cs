
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_geocercas.
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
    public abstract class _rastreo_geocercas : PostgreSqlEntity
    {
        public _rastreo_geocercas()
        {
            this.QuerySource = "rastreo_geocercas";
            this.MappingName = "rastreo_geocercas";

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

            return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_geocercas_load_all", parameters);
        }

        //=================================================================
        // public Overridable Function LoadByPrimaryKey()  As Boolean
        //=================================================================
        //  Loads a single row of via the primary key
        //=================================================================
        public virtual bool LoadByPrimaryKey(int Idrastreo_geocercas)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(Parameters.Idrastreo_geocercas, Idrastreo_geocercas);


            return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_geocercas_load_by_primarykey", parameters);
        }

        #region Parameters
        protected class Parameters
        {

            public static NpgsqlParameter Idrastreo_geocercas
            {
                get
                {
                    return new NpgsqlParameter("Idrastreo_geocercas", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Id_cliente
            {
                get
                {
                    return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Id_vehiculo
            {
                get
                {
                    return new NpgsqlParameter("Id_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Descripcion
            {
                get
                {
                    return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
                }
            }

            public static NpgsqlParameter Puntos
            {
                get
                {
                    return new NpgsqlParameter("Puntos", NpgsqlTypes.NpgsqlDbType.Text, 0);
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

            public static NpgsqlParameter Activa
            {
                get
                {
                    return new NpgsqlParameter("Activa", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Hora_activacion
            {
                get
                {
                    return new NpgsqlParameter("Hora_activacion", NpgsqlTypes.NpgsqlDbType.Time, 0);
                }
            }

            public static NpgsqlParameter Horas_activa
            {
                get
                {
                    return new NpgsqlParameter("Horas_activa", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Ultimo_aviso
            {
                get
                {
                    return new NpgsqlParameter("Ultimo_aviso", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
                }
            }

            public static NpgsqlParameter Avisar_entrada
            {
                get
                {
                    return new NpgsqlParameter("Avisar_entrada", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Mails
            {
                get
                {
                    return new NpgsqlParameter("Mails", NpgsqlTypes.NpgsqlDbType.Text, 0);
                }
            }

            public static NpgsqlParameter Tel_movil
            {
                get
                {
                    return new NpgsqlParameter("Tel_movil", NpgsqlTypes.NpgsqlDbType.Text, 0);
                }
            }

            public static NpgsqlParameter Activo_siempre
            {
                get
                {
                    return new NpgsqlParameter("Activo_siempre", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Dia_activacion
            {
                get
                {
                    return new NpgsqlParameter("Dia_activacion", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
                }
            }

            public static NpgsqlParameter Avisos_activado
            {
                get
                {
                    return new NpgsqlParameter("Avisos_activado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Id_usuario
            {
                get
                {
                    return new NpgsqlParameter("Id_usuario", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Aviso_entradasalida
            {
                get
                {
                    return new NpgsqlParameter("Aviso_entradasalida", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

        }
        #endregion

        #region ColumnNames
        public class ColumnNames
        {
            public const string Idrastreo_geocercas = "idrastreo_geocercas";
            public const string Id_cliente = "id_cliente";
            public const string Id_vehiculo = "id_vehiculo";
            public const string Descripcion = "descripcion";
            public const string Puntos = "puntos";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Activa = "activa";
            public const string Hora_activacion = "hora_activacion";
            public const string Horas_activa = "horas_activa";
            public const string Ultimo_aviso = "ultimo_aviso";
            public const string Avisar_entrada = "avisar_entrada";
            public const string Mails = "mails";
            public const string Tel_movil = "tel_movil";
            public const string Activo_siempre = "activo_siempre";
            public const string Dia_activacion = "dia_activacion";
            public const string Avisos_activado = "avisos_activado";
            public const string Id_usuario = "id_usuario";
            public const string Aviso_entradasalida = "aviso_entradasalida";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_geocercas] = _rastreo_geocercas.PropertyNames.Idrastreo_geocercas;
                    ht[Id_cliente] = _rastreo_geocercas.PropertyNames.Id_cliente;
                    ht[Id_vehiculo] = _rastreo_geocercas.PropertyNames.Id_vehiculo;
                    ht[Descripcion] = _rastreo_geocercas.PropertyNames.Descripcion;
                    ht[Puntos] = _rastreo_geocercas.PropertyNames.Puntos;
                    ht[User_ins] = _rastreo_geocercas.PropertyNames.User_ins;
                    ht[Fech_ins] = _rastreo_geocercas.PropertyNames.Fech_ins;
                    ht[User_upd] = _rastreo_geocercas.PropertyNames.User_upd;
                    ht[Fech_upd] = _rastreo_geocercas.PropertyNames.Fech_upd;
                    ht[Activa] = _rastreo_geocercas.PropertyNames.Activa;
                    ht[Hora_activacion] = _rastreo_geocercas.PropertyNames.Hora_activacion;
                    ht[Horas_activa] = _rastreo_geocercas.PropertyNames.Horas_activa;
                    ht[Ultimo_aviso] = _rastreo_geocercas.PropertyNames.Ultimo_aviso;
                    ht[Avisar_entrada] = _rastreo_geocercas.PropertyNames.Avisar_entrada;
                    ht[Mails] = _rastreo_geocercas.PropertyNames.Mails;
                    ht[Tel_movil] = _rastreo_geocercas.PropertyNames.Tel_movil;
                    ht[Activo_siempre] = _rastreo_geocercas.PropertyNames.Activo_siempre;
                    ht[Dia_activacion] = _rastreo_geocercas.PropertyNames.Dia_activacion;
                    ht[Avisos_activado] = _rastreo_geocercas.PropertyNames.Avisos_activado;
                    ht[Id_usuario] = _rastreo_geocercas.PropertyNames.Id_usuario;
                    ht[Aviso_entradasalida] = _rastreo_geocercas.PropertyNames.Aviso_entradasalida;

                }
                return (string)ht[columnName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Idrastreo_geocercas = "Idrastreo_geocercas";
            public const string Id_cliente = "Id_cliente";
            public const string Id_vehiculo = "Id_vehiculo";
            public const string Descripcion = "Descripcion";
            public const string Puntos = "Puntos";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Activa = "Activa";
            public const string Hora_activacion = "Hora_activacion";
            public const string Horas_activa = "Horas_activa";
            public const string Ultimo_aviso = "Ultimo_aviso";
            public const string Avisar_entrada = "Avisar_entrada";
            public const string Mails = "Mails";
            public const string Tel_movil = "Tel_movil";
            public const string Activo_siempre = "Activo_siempre";
            public const string Dia_activacion = "Dia_activacion";
            public const string Avisos_activado = "Avisos_activado";
            public const string Id_usuario = "Id_usuario";
            public const string Aviso_entradasalida = "Aviso_entradasalida";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_geocercas] = _rastreo_geocercas.ColumnNames.Idrastreo_geocercas;
                    ht[Id_cliente] = _rastreo_geocercas.ColumnNames.Id_cliente;
                    ht[Id_vehiculo] = _rastreo_geocercas.ColumnNames.Id_vehiculo;
                    ht[Descripcion] = _rastreo_geocercas.ColumnNames.Descripcion;
                    ht[Puntos] = _rastreo_geocercas.ColumnNames.Puntos;
                    ht[User_ins] = _rastreo_geocercas.ColumnNames.User_ins;
                    ht[Fech_ins] = _rastreo_geocercas.ColumnNames.Fech_ins;
                    ht[User_upd] = _rastreo_geocercas.ColumnNames.User_upd;
                    ht[Fech_upd] = _rastreo_geocercas.ColumnNames.Fech_upd;
                    ht[Activa] = _rastreo_geocercas.ColumnNames.Activa;
                    ht[Hora_activacion] = _rastreo_geocercas.ColumnNames.Hora_activacion;
                    ht[Horas_activa] = _rastreo_geocercas.ColumnNames.Horas_activa;
                    ht[Ultimo_aviso] = _rastreo_geocercas.ColumnNames.Ultimo_aviso;
                    ht[Avisar_entrada] = _rastreo_geocercas.ColumnNames.Avisar_entrada;
                    ht[Mails] = _rastreo_geocercas.ColumnNames.Mails;
                    ht[Tel_movil] = _rastreo_geocercas.ColumnNames.Tel_movil;
                    ht[Activo_siempre] = _rastreo_geocercas.ColumnNames.Activo_siempre;
                    ht[Dia_activacion] = _rastreo_geocercas.ColumnNames.Dia_activacion;
                    ht[Avisos_activado] = _rastreo_geocercas.ColumnNames.Avisos_activado;
                    ht[Id_usuario] = _rastreo_geocercas.ColumnNames.Id_usuario;
                    ht[Aviso_entradasalida] = _rastreo_geocercas.ColumnNames.Aviso_entradasalida;

                }
                return (string)ht[propertyName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region StringPropertyNames
        public class StringPropertyNames
        {
            public const string Idrastreo_geocercas = "s_Idrastreo_geocercas";
            public const string Id_cliente = "s_Id_cliente";
            public const string Id_vehiculo = "s_Id_vehiculo";
            public const string Descripcion = "s_Descripcion";
            public const string Puntos = "s_Puntos";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Activa = "s_Activa";
            public const string Hora_activacion = "s_Hora_activacion";
            public const string Horas_activa = "s_Horas_activa";
            public const string Ultimo_aviso = "s_Ultimo_aviso";
            public const string Avisar_entrada = "s_Avisar_entrada";
            public const string Mails = "s_Mails";
            public const string Tel_movil = "s_Tel_movil";
            public const string Activo_siempre = "s_Activo_siempre";
            public const string Dia_activacion = "s_Dia_activacion";
            public const string Avisos_activado = "s_Avisos_activado";
            public const string Id_usuario = "s_Id_usuario";
            public const string Aviso_entradasalida = "s_Aviso_entradasalida";

        }
        #endregion

        #region Properties

        public virtual int Idrastreo_geocercas
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreo_geocercas);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreo_geocercas, value);
            }
        }

        public virtual int Id_cliente
        {
            get
            {
                return base.Getint(ColumnNames.Id_cliente);
            }
            set
            {
                base.Setint(ColumnNames.Id_cliente, value);
            }
        }

        public virtual int Id_vehiculo
        {
            get
            {
                return base.Getint(ColumnNames.Id_vehiculo);
            }
            set
            {
                base.Setint(ColumnNames.Id_vehiculo, value);
            }
        }

        public virtual string Descripcion
        {
            get
            {
                return base.Getstring(ColumnNames.Descripcion);
            }
            set
            {
                base.Setstring(ColumnNames.Descripcion, value);
            }
        }

        public virtual string Puntos
        {
            get
            {
                return base.Getstring(ColumnNames.Puntos);
            }
            set
            {
                base.Setstring(ColumnNames.Puntos, value);
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

        public virtual bool Activa
        {
            get
            {
                return base.Getbool(ColumnNames.Activa);
            }
            set
            {
                base.Setbool(ColumnNames.Activa, value);
            }
        }

        public virtual DateTime Hora_activacion
        {
            get
            {
                return base.GetDateTime(ColumnNames.Hora_activacion);
            }
            set
            {
                base.SetDateTime(ColumnNames.Hora_activacion, value);
            }
        }

        public virtual int Horas_activa
        {
            get
            {
                return base.Getint(ColumnNames.Horas_activa);
            }
            set
            {
                base.Setint(ColumnNames.Horas_activa, value);
            }
        }

        public virtual DateTime Ultimo_aviso
        {
            get
            {
                return base.GetDateTime(ColumnNames.Ultimo_aviso);
            }
            set
            {
                base.SetDateTime(ColumnNames.Ultimo_aviso, value);
            }
        }

        public virtual bool Avisar_entrada
        {
            get
            {
                return base.Getbool(ColumnNames.Avisar_entrada);
            }
            set
            {
                base.Setbool(ColumnNames.Avisar_entrada, value);
            }
        }

        public virtual string Mails
        {
            get
            {
                return base.Getstring(ColumnNames.Mails);
            }
            set
            {
                base.Setstring(ColumnNames.Mails, value);
            }
        }

        public virtual string Tel_movil
        {
            get
            {
                return base.Getstring(ColumnNames.Tel_movil);
            }
            set
            {
                base.Setstring(ColumnNames.Tel_movil, value);
            }
        }

        public virtual bool Activo_siempre
        {
            get
            {
                return base.Getbool(ColumnNames.Activo_siempre);
            }
            set
            {
                base.Setbool(ColumnNames.Activo_siempre, value);
            }
        }

        public virtual DateTime Dia_activacion
        {
            get
            {
                return base.GetDateTime(ColumnNames.Dia_activacion);
            }
            set
            {
                base.SetDateTime(ColumnNames.Dia_activacion, value);
            }
        }

        public virtual bool Avisos_activado
        {
            get
            {
                return base.Getbool(ColumnNames.Avisos_activado);
            }
            set
            {
                base.Setbool(ColumnNames.Avisos_activado, value);
            }
        }

        public virtual int Id_usuario
        {
            get
            {
                return base.Getint(ColumnNames.Id_usuario);
            }
            set
            {
                base.Setint(ColumnNames.Id_usuario, value);
            }
        }

        public virtual bool Aviso_entradasalida
        {
            get
            {
                return base.Getbool(ColumnNames.Aviso_entradasalida);
            }
            set
            {
                base.Setbool(ColumnNames.Aviso_entradasalida, value);
            }
        }


        #endregion

        #region String Properties

        public virtual string s_Idrastreo_geocercas
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreo_geocercas) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_geocercas);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreo_geocercas);
                else
                    this.Idrastreo_geocercas = base.SetintAsString(ColumnNames.Idrastreo_geocercas, value);
            }
        }

        public virtual string s_Id_cliente
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Id_cliente) ? string.Empty : base.GetintAsString(ColumnNames.Id_cliente);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Id_cliente);
                else
                    this.Id_cliente = base.SetintAsString(ColumnNames.Id_cliente, value);
            }
        }

        public virtual string s_Id_vehiculo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Id_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Id_vehiculo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Id_vehiculo);
                else
                    this.Id_vehiculo = base.SetintAsString(ColumnNames.Id_vehiculo, value);
            }
        }

        public virtual string s_Descripcion
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Descripcion) ? string.Empty : base.GetstringAsString(ColumnNames.Descripcion);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Descripcion);
                else
                    this.Descripcion = base.SetstringAsString(ColumnNames.Descripcion, value);
            }
        }

        public virtual string s_Puntos
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Puntos) ? string.Empty : base.GetstringAsString(ColumnNames.Puntos);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Puntos);
                else
                    this.Puntos = base.SetstringAsString(ColumnNames.Puntos, value);
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
                if (string.Empty == value)
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
                if (string.Empty == value)
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
                if (string.Empty == value)
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Fech_upd);
                else
                    this.Fech_upd = base.SetDateTimeAsString(ColumnNames.Fech_upd, value);
            }
        }

        public virtual string s_Activa
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Activa) ? string.Empty : base.GetboolAsString(ColumnNames.Activa);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Activa);
                else
                    this.Activa = base.SetboolAsString(ColumnNames.Activa, value);
            }
        }

        public virtual string s_Hora_activacion
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Hora_activacion) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Hora_activacion);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Hora_activacion);
                else
                    this.Hora_activacion = base.SetDateTimeAsString(ColumnNames.Hora_activacion, value);
            }
        }

        public virtual string s_Horas_activa
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Horas_activa) ? string.Empty : base.GetintAsString(ColumnNames.Horas_activa);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Horas_activa);
                else
                    this.Horas_activa = base.SetintAsString(ColumnNames.Horas_activa, value);
            }
        }

        public virtual string s_Ultimo_aviso
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Ultimo_aviso) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Ultimo_aviso);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Ultimo_aviso);
                else
                    this.Ultimo_aviso = base.SetDateTimeAsString(ColumnNames.Ultimo_aviso, value);
            }
        }

        public virtual string s_Avisar_entrada
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Avisar_entrada) ? string.Empty : base.GetboolAsString(ColumnNames.Avisar_entrada);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Avisar_entrada);
                else
                    this.Avisar_entrada = base.SetboolAsString(ColumnNames.Avisar_entrada, value);
            }
        }

        public virtual string s_Mails
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Mails) ? string.Empty : base.GetstringAsString(ColumnNames.Mails);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Mails);
                else
                    this.Mails = base.SetstringAsString(ColumnNames.Mails, value);
            }
        }

        public virtual string s_Tel_movil
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Tel_movil) ? string.Empty : base.GetstringAsString(ColumnNames.Tel_movil);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Tel_movil);
                else
                    this.Tel_movil = base.SetstringAsString(ColumnNames.Tel_movil, value);
            }
        }

        public virtual string s_Activo_siempre
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Activo_siempre) ? string.Empty : base.GetboolAsString(ColumnNames.Activo_siempre);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Activo_siempre);
                else
                    this.Activo_siempre = base.SetboolAsString(ColumnNames.Activo_siempre, value);
            }
        }

        public virtual string s_Dia_activacion
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Dia_activacion) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Dia_activacion);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Dia_activacion);
                else
                    this.Dia_activacion = base.SetDateTimeAsString(ColumnNames.Dia_activacion, value);
            }
        }

        public virtual string s_Avisos_activado
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Avisos_activado) ? string.Empty : base.GetboolAsString(ColumnNames.Avisos_activado);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Avisos_activado);
                else
                    this.Avisos_activado = base.SetboolAsString(ColumnNames.Avisos_activado, value);
            }
        }

        public virtual string s_Id_usuario
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Id_usuario) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuario);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Id_usuario);
                else
                    this.Id_usuario = base.SetintAsString(ColumnNames.Id_usuario, value);
            }
        }

        public virtual string s_Aviso_entradasalida
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Aviso_entradasalida) ? string.Empty : base.GetboolAsString(ColumnNames.Aviso_entradasalida);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Aviso_entradasalida);
                else
                    this.Aviso_entradasalida = base.SetboolAsString(ColumnNames.Aviso_entradasalida, value);
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


                public WhereParameter Idrastreo_geocercas
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_geocercas, Parameters.Idrastreo_geocercas);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Id_cliente
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Id_vehiculo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Descripcion
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Puntos
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Puntos, Parameters.Puntos);
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

                public WhereParameter Activa
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Activa, Parameters.Activa);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Hora_activacion
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Hora_activacion, Parameters.Hora_activacion);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Horas_activa
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Horas_activa, Parameters.Horas_activa);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Ultimo_aviso
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Ultimo_aviso, Parameters.Ultimo_aviso);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Avisar_entrada
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Avisar_entrada, Parameters.Avisar_entrada);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Mails
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Mails, Parameters.Mails);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Tel_movil
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Tel_movil, Parameters.Tel_movil);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Activo_siempre
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Activo_siempre, Parameters.Activo_siempre);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Dia_activacion
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Dia_activacion, Parameters.Dia_activacion);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Avisos_activado
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Avisos_activado, Parameters.Avisos_activado);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Id_usuario
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Aviso_entradasalida
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Aviso_entradasalida, Parameters.Aviso_entradasalida);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }


                private WhereClause _clause;
            }
            #endregion

            public WhereParameter Idrastreo_geocercas
            {
                get
                {
                    if (_Idrastreo_geocercas_W == null)
                    {
                        _Idrastreo_geocercas_W = TearOff.Idrastreo_geocercas;
                    }
                    return _Idrastreo_geocercas_W;
                }
            }

            public WhereParameter Id_cliente
            {
                get
                {
                    if (_Id_cliente_W == null)
                    {
                        _Id_cliente_W = TearOff.Id_cliente;
                    }
                    return _Id_cliente_W;
                }
            }

            public WhereParameter Id_vehiculo
            {
                get
                {
                    if (_Id_vehiculo_W == null)
                    {
                        _Id_vehiculo_W = TearOff.Id_vehiculo;
                    }
                    return _Id_vehiculo_W;
                }
            }

            public WhereParameter Descripcion
            {
                get
                {
                    if (_Descripcion_W == null)
                    {
                        _Descripcion_W = TearOff.Descripcion;
                    }
                    return _Descripcion_W;
                }
            }

            public WhereParameter Puntos
            {
                get
                {
                    if (_Puntos_W == null)
                    {
                        _Puntos_W = TearOff.Puntos;
                    }
                    return _Puntos_W;
                }
            }

            public WhereParameter User_ins
            {
                get
                {
                    if (_User_ins_W == null)
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
                    if (_Fech_ins_W == null)
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
                    if (_User_upd_W == null)
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
                    if (_Fech_upd_W == null)
                    {
                        _Fech_upd_W = TearOff.Fech_upd;
                    }
                    return _Fech_upd_W;
                }
            }

            public WhereParameter Activa
            {
                get
                {
                    if (_Activa_W == null)
                    {
                        _Activa_W = TearOff.Activa;
                    }
                    return _Activa_W;
                }
            }

            public WhereParameter Hora_activacion
            {
                get
                {
                    if (_Hora_activacion_W == null)
                    {
                        _Hora_activacion_W = TearOff.Hora_activacion;
                    }
                    return _Hora_activacion_W;
                }
            }

            public WhereParameter Horas_activa
            {
                get
                {
                    if (_Horas_activa_W == null)
                    {
                        _Horas_activa_W = TearOff.Horas_activa;
                    }
                    return _Horas_activa_W;
                }
            }

            public WhereParameter Ultimo_aviso
            {
                get
                {
                    if (_Ultimo_aviso_W == null)
                    {
                        _Ultimo_aviso_W = TearOff.Ultimo_aviso;
                    }
                    return _Ultimo_aviso_W;
                }
            }

            public WhereParameter Avisar_entrada
            {
                get
                {
                    if (_Avisar_entrada_W == null)
                    {
                        _Avisar_entrada_W = TearOff.Avisar_entrada;
                    }
                    return _Avisar_entrada_W;
                }
            }

            public WhereParameter Mails
            {
                get
                {
                    if (_Mails_W == null)
                    {
                        _Mails_W = TearOff.Mails;
                    }
                    return _Mails_W;
                }
            }

            public WhereParameter Tel_movil
            {
                get
                {
                    if (_Tel_movil_W == null)
                    {
                        _Tel_movil_W = TearOff.Tel_movil;
                    }
                    return _Tel_movil_W;
                }
            }

            public WhereParameter Activo_siempre
            {
                get
                {
                    if (_Activo_siempre_W == null)
                    {
                        _Activo_siempre_W = TearOff.Activo_siempre;
                    }
                    return _Activo_siempre_W;
                }
            }

            public WhereParameter Dia_activacion
            {
                get
                {
                    if (_Dia_activacion_W == null)
                    {
                        _Dia_activacion_W = TearOff.Dia_activacion;
                    }
                    return _Dia_activacion_W;
                }
            }

            public WhereParameter Avisos_activado
            {
                get
                {
                    if (_Avisos_activado_W == null)
                    {
                        _Avisos_activado_W = TearOff.Avisos_activado;
                    }
                    return _Avisos_activado_W;
                }
            }

            public WhereParameter Id_usuario
            {
                get
                {
                    if (_Id_usuario_W == null)
                    {
                        _Id_usuario_W = TearOff.Id_usuario;
                    }
                    return _Id_usuario_W;
                }
            }

            public WhereParameter Aviso_entradasalida
            {
                get
                {
                    if (_Aviso_entradasalida_W == null)
                    {
                        _Aviso_entradasalida_W = TearOff.Aviso_entradasalida;
                    }
                    return _Aviso_entradasalida_W;
                }
            }

            private WhereParameter _Idrastreo_geocercas_W = null;
            private WhereParameter _Id_cliente_W = null;
            private WhereParameter _Id_vehiculo_W = null;
            private WhereParameter _Descripcion_W = null;
            private WhereParameter _Puntos_W = null;
            private WhereParameter _User_ins_W = null;
            private WhereParameter _Fech_ins_W = null;
            private WhereParameter _User_upd_W = null;
            private WhereParameter _Fech_upd_W = null;
            private WhereParameter _Activa_W = null;
            private WhereParameter _Hora_activacion_W = null;
            private WhereParameter _Horas_activa_W = null;
            private WhereParameter _Ultimo_aviso_W = null;
            private WhereParameter _Avisar_entrada_W = null;
            private WhereParameter _Mails_W = null;
            private WhereParameter _Tel_movil_W = null;
            private WhereParameter _Activo_siempre_W = null;
            private WhereParameter _Dia_activacion_W = null;
            private WhereParameter _Avisos_activado_W = null;
            private WhereParameter _Id_usuario_W = null;
            private WhereParameter _Aviso_entradasalida_W = null;

            public void WhereClauseReset()
            {
                _Idrastreo_geocercas_W = null;
                _Id_cliente_W = null;
                _Id_vehiculo_W = null;
                _Descripcion_W = null;
                _Puntos_W = null;
                _User_ins_W = null;
                _Fech_ins_W = null;
                _User_upd_W = null;
                _Fech_upd_W = null;
                _Activa_W = null;
                _Hora_activacion_W = null;
                _Horas_activa_W = null;
                _Ultimo_aviso_W = null;
                _Avisar_entrada_W = null;
                _Mails_W = null;
                _Tel_movil_W = null;
                _Activo_siempre_W = null;
                _Dia_activacion_W = null;
                _Avisos_activado_W = null;
                _Id_usuario_W = null;
                _Aviso_entradasalida_W = null;

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


                public AggregateParameter Idrastreo_geocercas
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_geocercas, Parameters.Idrastreo_geocercas);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Id_cliente
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Id_vehiculo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Descripcion
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Puntos
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Puntos, Parameters.Puntos);
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

                public AggregateParameter Activa
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activa, Parameters.Activa);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Hora_activacion
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Hora_activacion, Parameters.Hora_activacion);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Horas_activa
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Horas_activa, Parameters.Horas_activa);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Ultimo_aviso
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ultimo_aviso, Parameters.Ultimo_aviso);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Avisar_entrada
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Avisar_entrada, Parameters.Avisar_entrada);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Mails
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Mails, Parameters.Mails);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Tel_movil
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tel_movil, Parameters.Tel_movil);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Activo_siempre
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activo_siempre, Parameters.Activo_siempre);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Dia_activacion
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Dia_activacion, Parameters.Dia_activacion);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Avisos_activado
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Avisos_activado, Parameters.Avisos_activado);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Id_usuario
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Aviso_entradasalida
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Aviso_entradasalida, Parameters.Aviso_entradasalida);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }


                private AggregateClause _clause;
            }
            #endregion

            public AggregateParameter Idrastreo_geocercas
            {
                get
                {
                    if (_Idrastreo_geocercas_W == null)
                    {
                        _Idrastreo_geocercas_W = TearOff.Idrastreo_geocercas;
                    }
                    return _Idrastreo_geocercas_W;
                }
            }

            public AggregateParameter Id_cliente
            {
                get
                {
                    if (_Id_cliente_W == null)
                    {
                        _Id_cliente_W = TearOff.Id_cliente;
                    }
                    return _Id_cliente_W;
                }
            }

            public AggregateParameter Id_vehiculo
            {
                get
                {
                    if (_Id_vehiculo_W == null)
                    {
                        _Id_vehiculo_W = TearOff.Id_vehiculo;
                    }
                    return _Id_vehiculo_W;
                }
            }

            public AggregateParameter Descripcion
            {
                get
                {
                    if (_Descripcion_W == null)
                    {
                        _Descripcion_W = TearOff.Descripcion;
                    }
                    return _Descripcion_W;
                }
            }

            public AggregateParameter Puntos
            {
                get
                {
                    if (_Puntos_W == null)
                    {
                        _Puntos_W = TearOff.Puntos;
                    }
                    return _Puntos_W;
                }
            }

            public AggregateParameter User_ins
            {
                get
                {
                    if (_User_ins_W == null)
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
                    if (_Fech_ins_W == null)
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
                    if (_User_upd_W == null)
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
                    if (_Fech_upd_W == null)
                    {
                        _Fech_upd_W = TearOff.Fech_upd;
                    }
                    return _Fech_upd_W;
                }
            }

            public AggregateParameter Activa
            {
                get
                {
                    if (_Activa_W == null)
                    {
                        _Activa_W = TearOff.Activa;
                    }
                    return _Activa_W;
                }
            }

            public AggregateParameter Hora_activacion
            {
                get
                {
                    if (_Hora_activacion_W == null)
                    {
                        _Hora_activacion_W = TearOff.Hora_activacion;
                    }
                    return _Hora_activacion_W;
                }
            }

            public AggregateParameter Horas_activa
            {
                get
                {
                    if (_Horas_activa_W == null)
                    {
                        _Horas_activa_W = TearOff.Horas_activa;
                    }
                    return _Horas_activa_W;
                }
            }

            public AggregateParameter Ultimo_aviso
            {
                get
                {
                    if (_Ultimo_aviso_W == null)
                    {
                        _Ultimo_aviso_W = TearOff.Ultimo_aviso;
                    }
                    return _Ultimo_aviso_W;
                }
            }

            public AggregateParameter Avisar_entrada
            {
                get
                {
                    if (_Avisar_entrada_W == null)
                    {
                        _Avisar_entrada_W = TearOff.Avisar_entrada;
                    }
                    return _Avisar_entrada_W;
                }
            }

            public AggregateParameter Mails
            {
                get
                {
                    if (_Mails_W == null)
                    {
                        _Mails_W = TearOff.Mails;
                    }
                    return _Mails_W;
                }
            }

            public AggregateParameter Tel_movil
            {
                get
                {
                    if (_Tel_movil_W == null)
                    {
                        _Tel_movil_W = TearOff.Tel_movil;
                    }
                    return _Tel_movil_W;
                }
            }

            public AggregateParameter Activo_siempre
            {
                get
                {
                    if (_Activo_siempre_W == null)
                    {
                        _Activo_siempre_W = TearOff.Activo_siempre;
                    }
                    return _Activo_siempre_W;
                }
            }

            public AggregateParameter Dia_activacion
            {
                get
                {
                    if (_Dia_activacion_W == null)
                    {
                        _Dia_activacion_W = TearOff.Dia_activacion;
                    }
                    return _Dia_activacion_W;
                }
            }

            public AggregateParameter Avisos_activado
            {
                get
                {
                    if (_Avisos_activado_W == null)
                    {
                        _Avisos_activado_W = TearOff.Avisos_activado;
                    }
                    return _Avisos_activado_W;
                }
            }

            public AggregateParameter Id_usuario
            {
                get
                {
                    if (_Id_usuario_W == null)
                    {
                        _Id_usuario_W = TearOff.Id_usuario;
                    }
                    return _Id_usuario_W;
                }
            }

            public AggregateParameter Aviso_entradasalida
            {
                get
                {
                    if (_Aviso_entradasalida_W == null)
                    {
                        _Aviso_entradasalida_W = TearOff.Aviso_entradasalida;
                    }
                    return _Aviso_entradasalida_W;
                }
            }

            private AggregateParameter _Idrastreo_geocercas_W = null;
            private AggregateParameter _Id_cliente_W = null;
            private AggregateParameter _Id_vehiculo_W = null;
            private AggregateParameter _Descripcion_W = null;
            private AggregateParameter _Puntos_W = null;
            private AggregateParameter _User_ins_W = null;
            private AggregateParameter _Fech_ins_W = null;
            private AggregateParameter _User_upd_W = null;
            private AggregateParameter _Fech_upd_W = null;
            private AggregateParameter _Activa_W = null;
            private AggregateParameter _Hora_activacion_W = null;
            private AggregateParameter _Horas_activa_W = null;
            private AggregateParameter _Ultimo_aviso_W = null;
            private AggregateParameter _Avisar_entrada_W = null;
            private AggregateParameter _Mails_W = null;
            private AggregateParameter _Tel_movil_W = null;
            private AggregateParameter _Activo_siempre_W = null;
            private AggregateParameter _Dia_activacion_W = null;
            private AggregateParameter _Avisos_activado_W = null;
            private AggregateParameter _Id_usuario_W = null;
            private AggregateParameter _Aviso_entradasalida_W = null;

            public void AggregateClauseReset()
            {
                _Idrastreo_geocercas_W = null;
                _Id_cliente_W = null;
                _Id_vehiculo_W = null;
                _Descripcion_W = null;
                _Puntos_W = null;
                _User_ins_W = null;
                _Fech_ins_W = null;
                _User_upd_W = null;
                _Fech_upd_W = null;
                _Activa_W = null;
                _Hora_activacion_W = null;
                _Horas_activa_W = null;
                _Ultimo_aviso_W = null;
                _Avisar_entrada_W = null;
                _Mails_W = null;
                _Tel_movil_W = null;
                _Activo_siempre_W = null;
                _Dia_activacion_W = null;
                _Avisos_activado_W = null;
                _Id_usuario_W = null;
                _Aviso_entradasalida_W = null;

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
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_geocercas_insert";

            CreateParameters(cmd);

            NpgsqlParameter p;
            p = cmd.Parameters[Parameters.Idrastreo_geocercas.ParameterName];
            p.Direction = ParameterDirection.Output;

            return cmd;
        }

        protected override IDbCommand GetUpdateCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_geocercas_update";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_geocercas_delete";

            NpgsqlParameter p;
            p = cmd.Parameters.Add(Parameters.Idrastreo_geocercas);
            p.SourceColumn = ColumnNames.Idrastreo_geocercas;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }

        private IDbCommand CreateParameters(NpgsqlCommand cmd)
        {
            NpgsqlParameter p;

            p = cmd.Parameters.Add(Parameters.Idrastreo_geocercas);
            p.SourceColumn = ColumnNames.Idrastreo_geocercas;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Id_cliente);
            p.SourceColumn = ColumnNames.Id_cliente;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Id_vehiculo);
            p.SourceColumn = ColumnNames.Id_vehiculo;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Descripcion);
            p.SourceColumn = ColumnNames.Descripcion;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Puntos);
            p.SourceColumn = ColumnNames.Puntos;
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

            p = cmd.Parameters.Add(Parameters.Activa);
            p.SourceColumn = ColumnNames.Activa;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Hora_activacion);
            p.SourceColumn = ColumnNames.Hora_activacion;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Horas_activa);
            p.SourceColumn = ColumnNames.Horas_activa;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Ultimo_aviso);
            p.SourceColumn = ColumnNames.Ultimo_aviso;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Avisar_entrada);
            p.SourceColumn = ColumnNames.Avisar_entrada;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Mails);
            p.SourceColumn = ColumnNames.Mails;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Tel_movil);
            p.SourceColumn = ColumnNames.Tel_movil;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Activo_siempre);
            p.SourceColumn = ColumnNames.Activo_siempre;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Dia_activacion);
            p.SourceColumn = ColumnNames.Dia_activacion;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Avisos_activado);
            p.SourceColumn = ColumnNames.Avisos_activado;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Id_usuario);
            p.SourceColumn = ColumnNames.Id_usuario;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Aviso_entradasalida);
            p.SourceColumn = ColumnNames.Aviso_entradasalida;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}


