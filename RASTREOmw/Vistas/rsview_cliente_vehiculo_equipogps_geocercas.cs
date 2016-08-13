/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_cliente_vehiculo_equipogps_geocercas para la vista rsview_cliente_vehiculo_equipogps_geocercas.
'  Base soportada: PostgreSqlEntity.
'  Versión: # (1.3.0.9)
'==============================================================================================================
*/

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace RASTREOmw
{
    public class rsview_cliente_vehiculo_equipogps_geocercas : PostgreSqlEntity
    {
        public rsview_cliente_vehiculo_equipogps_geocercas(String laCadenaDeConexion)
        {
            this.QuerySource = "rsview_cliente_vehiculo_equipogps_geocercas";
            this.MappingName = "rsview_cliente_vehiculo_equipogps_geocercas";
            this.ConnectionString = laCadenaDeConexion;
        }

        //=================================================================
        //  	public procedure LoadAll() As Boolean
        //=================================================================
        //  Carga todos los registros en la base de datos, y coloca la propiedad currentRow en la primera fila
        //=================================================================
        public bool LoadAll()
        {
            return base.Query.Load();
        }

        public override void FlushData()
        {
            this._whereClause = null;
            this._aggregateClause = null;
            base.FlushData();
        }

        #region Parameters
        protected class Parameters
        {

            public static NpgsqlParameter Idrastreo_vehiculo
            {
                get
                {
                    return new NpgsqlParameter("Idrastreo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Idrastreo_persona
            {
                get
                {
                    return new NpgsqlParameter("Idrastreo_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Razon_social
            {
                get
                {
                    return new NpgsqlParameter("Razon_social", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
                }
            }

            public static NpgsqlParameter Identificador_rastreo
            {
                get
                {
                    return new NpgsqlParameter("Identificador_rastreo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Anho
            {
                get
                {
                    return new NpgsqlParameter("Anho", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Chasis
            {
                get
                {
                    return new NpgsqlParameter("Chasis", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
                }
            }

            public static NpgsqlParameter Color
            {
                get
                {
                    return new NpgsqlParameter("Color", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
                }
            }

            public static NpgsqlParameter Matricula
            {
                get
                {
                    return new NpgsqlParameter("Matricula", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
                }
            }

            public static NpgsqlParameter Kilometraje
            {
                get
                {
                    return new NpgsqlParameter("Kilometraje", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Activo
            {
                get
                {
                    return new NpgsqlParameter("Activo", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Consumo_aprox
            {
                get
                {
                    return new NpgsqlParameter("Consumo_aprox", NpgsqlTypes.NpgsqlDbType.Double, 0);
                }
            }

            public static NpgsqlParameter Marca
            {
                get
                {
                    return new NpgsqlParameter("Marca", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Modelo
            {
                get
                {
                    return new NpgsqlParameter("Modelo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Idrastreogps_equipogps
            {
                get
                {
                    return new NpgsqlParameter("Idrastreogps_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Idrastreogps_tipoequipo
            {
                get
                {
                    return new NpgsqlParameter("Idrastreogps_tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Tipo_equipo
            {
                get
                {
                    return new NpgsqlParameter("Tipo_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Tipo_de_reporte
            {
                get
                {
                    return new NpgsqlParameter("Tipo_de_reporte", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
                }
            }

            public static NpgsqlParameter Id_equipo_gps
            {
                get
                {
                    return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Nro_serie_gps
            {
                get
                {
                    return new NpgsqlParameter("Nro_serie_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
                }
            }

            public static NpgsqlParameter Idrastreogps_simcards
            {
                get
                {
                    return new NpgsqlParameter("Idrastreogps_simcards", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Sim_nro
            {
                get
                {
                    return new NpgsqlParameter("Sim_nro", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
                }
            }

            public static NpgsqlParameter Idrastreo_geocercas
            {
                get
                {
                    return new NpgsqlParameter("Idrastreo_geocercas", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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

            public static NpgsqlParameter Geocerca_activa
            {
                get
                {
                    return new NpgsqlParameter("Geocerca_activa", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
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

            public static NpgsqlParameter Avisos_activado
            {
                get
                {
                    return new NpgsqlParameter("Avisos_activado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
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
            public const string Idrastreo_vehiculo = "idrastreo_vehiculo";
            public const string Idrastreo_persona = "idrastreo_persona";
            public const string Razon_social = "razon_social";
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Anho = "anho";
            public const string Chasis = "chasis";
            public const string Color = "color";
            public const string Matricula = "matricula";
            public const string Kilometraje = "kilometraje";
            public const string Activo = "activo";
            public const string Consumo_aprox = "consumo_aprox";
            public const string Marca = "marca";
            public const string Modelo = "modelo";
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Idrastreogps_tipoequipo = "idrastreogps_tipoequipo";
            public const string Tipo_equipo = "tipo_equipo";
            public const string Tipo_de_reporte = "tipo_de_reporte";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Nro_serie_gps = "nro_serie_gps";
            public const string Idrastreogps_simcards = "idrastreogps_simcards";
            public const string Sim_nro = "sim_nro";
            public const string Idrastreo_geocercas = "idrastreo_geocercas";
            public const string Descripcion = "descripcion";
            public const string Puntos = "puntos";
            public const string Hora_activacion = "hora_activacion";
            public const string Horas_activa = "horas_activa";
            public const string Geocerca_activa = "geocerca_activa";
            public const string Activo_siempre = "activo_siempre";
            public const string Dia_activacion = "dia_activacion";
            public const string Avisar_entrada = "avisar_entrada";
            public const string Mails = "mails";
            public const string Tel_movil = "tel_movil";
            public const string Avisos_activado = "avisos_activado";
            public const string Aviso_entradasalida = "aviso_entradasalida";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_vehiculo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreo_vehiculo;
                    ht[Idrastreo_persona] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreo_persona;
                    ht[Razon_social] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Razon_social;
                    ht[Identificador_rastreo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Identificador_rastreo;
                    ht[Anho] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Anho;
                    ht[Chasis] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Chasis;
                    ht[Color] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Color;
                    ht[Matricula] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Matricula;
                    ht[Kilometraje] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Kilometraje;
                    ht[Activo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Activo;
                    ht[Consumo_aprox] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Consumo_aprox;
                    ht[Marca] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Marca;
                    ht[Modelo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Modelo;
                    ht[Idrastreogps_equipogps] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreogps_equipogps;
                    ht[Idrastreogps_tipoequipo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreogps_tipoequipo;
                    ht[Tipo_equipo] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Tipo_equipo;
                    ht[Tipo_de_reporte] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Tipo_de_reporte;
                    ht[Id_equipo_gps] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Id_equipo_gps;
                    ht[Nro_serie_gps] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Nro_serie_gps;
                    ht[Idrastreogps_simcards] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreogps_simcards;
                    ht[Sim_nro] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Sim_nro;
                    ht[Idrastreo_geocercas] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Idrastreo_geocercas;
                    ht[Descripcion] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Descripcion;
                    ht[Puntos] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Puntos;
                    ht[Hora_activacion] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Hora_activacion;
                    ht[Horas_activa] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Horas_activa;
                    ht[Geocerca_activa] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Geocerca_activa;
                    ht[Activo_siempre] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Activo_siempre;
                    ht[Dia_activacion] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Dia_activacion;
                    ht[Avisar_entrada] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Avisar_entrada;
                    ht[Mails] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Mails;
                    ht[Tel_movil] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Tel_movil;
                    ht[Avisos_activado] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Avisos_activado;
                    ht[Aviso_entradasalida] = rsview_cliente_vehiculo_equipogps_geocercas.PropertyNames.Aviso_entradasalida;

                }
                return (string)ht[columnName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Idrastreo_vehiculo = "Idrastreo_vehiculo";
            public const string Idrastreo_persona = "Idrastreo_persona";
            public const string Razon_social = "Razon_social";
            public const string Identificador_rastreo = "Identificador_rastreo";
            public const string Anho = "Anho";
            public const string Chasis = "Chasis";
            public const string Color = "Color";
            public const string Matricula = "Matricula";
            public const string Kilometraje = "Kilometraje";
            public const string Activo = "Activo";
            public const string Consumo_aprox = "Consumo_aprox";
            public const string Marca = "Marca";
            public const string Modelo = "Modelo";
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Idrastreogps_tipoequipo = "Idrastreogps_tipoequipo";
            public const string Tipo_equipo = "Tipo_equipo";
            public const string Tipo_de_reporte = "Tipo_de_reporte";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Nro_serie_gps = "Nro_serie_gps";
            public const string Idrastreogps_simcards = "Idrastreogps_simcards";
            public const string Sim_nro = "Sim_nro";
            public const string Idrastreo_geocercas = "Idrastreo_geocercas";
            public const string Descripcion = "Descripcion";
            public const string Puntos = "Puntos";
            public const string Hora_activacion = "Hora_activacion";
            public const string Horas_activa = "Horas_activa";
            public const string Geocerca_activa = "Geocerca_activa";
            public const string Activo_siempre = "Activo_siempre";
            public const string Dia_activacion = "Dia_activacion";
            public const string Avisar_entrada = "Avisar_entrada";
            public const string Mails = "Mails";
            public const string Tel_movil = "Tel_movil";
            public const string Avisos_activado = "Avisos_activado";
            public const string Aviso_entradasalida = "Aviso_entradasalida";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_vehiculo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreo_vehiculo;
                    ht[Idrastreo_persona] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreo_persona;
                    ht[Razon_social] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Razon_social;
                    ht[Identificador_rastreo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Identificador_rastreo;
                    ht[Anho] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Anho;
                    ht[Chasis] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Chasis;
                    ht[Color] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Color;
                    ht[Matricula] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Matricula;
                    ht[Kilometraje] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Kilometraje;
                    ht[Activo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Activo;
                    ht[Consumo_aprox] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Consumo_aprox;
                    ht[Marca] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Marca;
                    ht[Modelo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Modelo;
                    ht[Idrastreogps_equipogps] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreogps_equipogps;
                    ht[Idrastreogps_tipoequipo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreogps_tipoequipo;
                    ht[Tipo_equipo] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Tipo_equipo;
                    ht[Tipo_de_reporte] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Tipo_de_reporte;
                    ht[Id_equipo_gps] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Id_equipo_gps;
                    ht[Nro_serie_gps] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Nro_serie_gps;
                    ht[Idrastreogps_simcards] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreogps_simcards;
                    ht[Sim_nro] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Sim_nro;
                    ht[Idrastreo_geocercas] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Idrastreo_geocercas;
                    ht[Descripcion] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Descripcion;
                    ht[Puntos] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Puntos;
                    ht[Hora_activacion] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Hora_activacion;
                    ht[Horas_activa] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Horas_activa;
                    ht[Geocerca_activa] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Geocerca_activa;
                    ht[Activo_siempre] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Activo_siempre;
                    ht[Dia_activacion] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Dia_activacion;
                    ht[Avisar_entrada] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Avisar_entrada;
                    ht[Mails] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Mails;
                    ht[Tel_movil] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Tel_movil;
                    ht[Avisos_activado] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Avisos_activado;
                    ht[Aviso_entradasalida] = rsview_cliente_vehiculo_equipogps_geocercas.ColumnNames.Aviso_entradasalida;

                }
                return (string)ht[propertyName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region StringPropertyNames
        public class StringPropertyNames
        {
            public const string Idrastreo_vehiculo = "s_Idrastreo_vehiculo";
            public const string Idrastreo_persona = "s_Idrastreo_persona";
            public const string Razon_social = "s_Razon_social";
            public const string Identificador_rastreo = "s_Identificador_rastreo";
            public const string Anho = "s_Anho";
            public const string Chasis = "s_Chasis";
            public const string Color = "s_Color";
            public const string Matricula = "s_Matricula";
            public const string Kilometraje = "s_Kilometraje";
            public const string Activo = "s_Activo";
            public const string Consumo_aprox = "s_Consumo_aprox";
            public const string Marca = "s_Marca";
            public const string Modelo = "s_Modelo";
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Idrastreogps_tipoequipo = "s_Idrastreogps_tipoequipo";
            public const string Tipo_equipo = "s_Tipo_equipo";
            public const string Tipo_de_reporte = "s_Tipo_de_reporte";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Nro_serie_gps = "s_Nro_serie_gps";
            public const string Idrastreogps_simcards = "s_Idrastreogps_simcards";
            public const string Sim_nro = "s_Sim_nro";
            public const string Idrastreo_geocercas = "s_Idrastreo_geocercas";
            public const string Descripcion = "s_Descripcion";
            public const string Puntos = "s_Puntos";
            public const string Hora_activacion = "s_Hora_activacion";
            public const string Horas_activa = "s_Horas_activa";
            public const string Geocerca_activa = "s_Geocerca_activa";
            public const string Activo_siempre = "s_Activo_siempre";
            public const string Dia_activacion = "s_Dia_activacion";
            public const string Avisar_entrada = "s_Avisar_entrada";
            public const string Mails = "s_Mails";
            public const string Tel_movil = "s_Tel_movil";
            public const string Avisos_activado = "s_Avisos_activado";
            public const string Aviso_entradasalida = "s_Aviso_entradasalida";

        }
        #endregion

        #region Properties
        public virtual int Idrastreo_vehiculo
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreo_vehiculo);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreo_vehiculo, value);
            }
        }

        public virtual int Idrastreo_persona
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreo_persona);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreo_persona, value);
            }
        }

        public virtual string Razon_social
        {
            get
            {
                return base.Getstring(ColumnNames.Razon_social);
            }
            set
            {
                base.Setstring(ColumnNames.Razon_social, value);
            }
        }

        public virtual string Identificador_rastreo
        {
            get
            {
                return base.Getstring(ColumnNames.Identificador_rastreo);
            }
            set
            {
                base.Setstring(ColumnNames.Identificador_rastreo, value);
            }
        }

        public virtual int Anho
        {
            get
            {
                return base.Getint(ColumnNames.Anho);
            }
            set
            {
                base.Setint(ColumnNames.Anho, value);
            }
        }

        public virtual string Chasis
        {
            get
            {
                return base.Getstring(ColumnNames.Chasis);
            }
            set
            {
                base.Setstring(ColumnNames.Chasis, value);
            }
        }

        public virtual string Color
        {
            get
            {
                return base.Getstring(ColumnNames.Color);
            }
            set
            {
                base.Setstring(ColumnNames.Color, value);
            }
        }

        public virtual string Matricula
        {
            get
            {
                return base.Getstring(ColumnNames.Matricula);
            }
            set
            {
                base.Setstring(ColumnNames.Matricula, value);
            }
        }

        public virtual int Kilometraje
        {
            get
            {
                return base.Getint(ColumnNames.Kilometraje);
            }
            set
            {
                base.Setint(ColumnNames.Kilometraje, value);
            }
        }

        public virtual bool Activo
        {
            get
            {
                return base.Getbool(ColumnNames.Activo);
            }
            set
            {
                base.Setbool(ColumnNames.Activo, value);
            }
        }

        public virtual double Consumo_aprox
        {
            get
            {
                return base.Getdouble(ColumnNames.Consumo_aprox);
            }
            set
            {
                base.Setdouble(ColumnNames.Consumo_aprox, value);
            }
        }

        public virtual string Marca
        {
            get
            {
                return base.Getstring(ColumnNames.Marca);
            }
            set
            {
                base.Setstring(ColumnNames.Marca, value);
            }
        }

        public virtual string Modelo
        {
            get
            {
                return base.Getstring(ColumnNames.Modelo);
            }
            set
            {
                base.Setstring(ColumnNames.Modelo, value);
            }
        }

        public virtual int Idrastreogps_equipogps
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreogps_equipogps);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreogps_equipogps, value);
            }
        }

        public virtual int Idrastreogps_tipoequipo
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreogps_tipoequipo);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreogps_tipoequipo, value);
            }
        }

        public virtual string Tipo_equipo
        {
            get
            {
                return base.Getstring(ColumnNames.Tipo_equipo);
            }
            set
            {
                base.Setstring(ColumnNames.Tipo_equipo, value);
            }
        }

        public virtual string Tipo_de_reporte
        {
            get
            {
                return base.Getstring(ColumnNames.Tipo_de_reporte);
            }
            set
            {
                base.Setstring(ColumnNames.Tipo_de_reporte, value);
            }
        }

        public virtual string Id_equipo_gps
        {
            get
            {
                return base.Getstring(ColumnNames.Id_equipo_gps);
            }
            set
            {
                base.Setstring(ColumnNames.Id_equipo_gps, value);
            }
        }

        public virtual string Nro_serie_gps
        {
            get
            {
                return base.Getstring(ColumnNames.Nro_serie_gps);
            }
            set
            {
                base.Setstring(ColumnNames.Nro_serie_gps, value);
            }
        }

        public virtual int Idrastreogps_simcards
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreogps_simcards);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreogps_simcards, value);
            }
        }

        public virtual string Sim_nro
        {
            get
            {
                return base.Getstring(ColumnNames.Sim_nro);
            }
            set
            {
                base.Setstring(ColumnNames.Sim_nro, value);
            }
        }

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

        public virtual bool Geocerca_activa
        {
            get
            {
                return base.Getbool(ColumnNames.Geocerca_activa);
            }
            set
            {
                base.Setbool(ColumnNames.Geocerca_activa, value);
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

        public virtual string s_Idrastreo_vehiculo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreo_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_vehiculo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreo_vehiculo);
                else
                    this.Idrastreo_vehiculo = base.SetintAsString(ColumnNames.Idrastreo_vehiculo, value);
            }
        }

        public virtual string s_Idrastreo_persona
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreo_persona) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_persona);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreo_persona);
                else
                    this.Idrastreo_persona = base.SetintAsString(ColumnNames.Idrastreo_persona, value);
            }
        }

        public virtual string s_Razon_social
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Razon_social) ? string.Empty : base.GetstringAsString(ColumnNames.Razon_social);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Razon_social);
                else
                    this.Razon_social = base.SetstringAsString(ColumnNames.Razon_social, value);
            }
        }

        public virtual string s_Identificador_rastreo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Identificador_rastreo) ? string.Empty : base.GetstringAsString(ColumnNames.Identificador_rastreo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Identificador_rastreo);
                else
                    this.Identificador_rastreo = base.SetstringAsString(ColumnNames.Identificador_rastreo, value);
            }
        }

        public virtual string s_Anho
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Anho) ? string.Empty : base.GetintAsString(ColumnNames.Anho);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Anho);
                else
                    this.Anho = base.SetintAsString(ColumnNames.Anho, value);
            }
        }

        public virtual string s_Chasis
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Chasis) ? string.Empty : base.GetstringAsString(ColumnNames.Chasis);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Chasis);
                else
                    this.Chasis = base.SetstringAsString(ColumnNames.Chasis, value);
            }
        }

        public virtual string s_Color
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Color) ? string.Empty : base.GetstringAsString(ColumnNames.Color);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Color);
                else
                    this.Color = base.SetstringAsString(ColumnNames.Color, value);
            }
        }

        public virtual string s_Matricula
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Matricula) ? string.Empty : base.GetstringAsString(ColumnNames.Matricula);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Matricula);
                else
                    this.Matricula = base.SetstringAsString(ColumnNames.Matricula, value);
            }
        }

        public virtual string s_Kilometraje
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Kilometraje) ? string.Empty : base.GetintAsString(ColumnNames.Kilometraje);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Kilometraje);
                else
                    this.Kilometraje = base.SetintAsString(ColumnNames.Kilometraje, value);
            }
        }

        public virtual string s_Activo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Activo) ? string.Empty : base.GetboolAsString(ColumnNames.Activo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Activo);
                else
                    this.Activo = base.SetboolAsString(ColumnNames.Activo, value);
            }
        }

        public virtual string s_Consumo_aprox
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Consumo_aprox) ? string.Empty : base.GetdoubleAsString(ColumnNames.Consumo_aprox);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Consumo_aprox);
                else
                    this.Consumo_aprox = base.SetdoubleAsString(ColumnNames.Consumo_aprox, value);
            }
        }

        public virtual string s_Marca
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Marca) ? string.Empty : base.GetstringAsString(ColumnNames.Marca);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Marca);
                else
                    this.Marca = base.SetstringAsString(ColumnNames.Marca, value);
            }
        }

        public virtual string s_Modelo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Modelo) ? string.Empty : base.GetstringAsString(ColumnNames.Modelo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Modelo);
                else
                    this.Modelo = base.SetstringAsString(ColumnNames.Modelo, value);
            }
        }

        public virtual string s_Idrastreogps_equipogps
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreogps_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_equipogps);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreogps_equipogps);
                else
                    this.Idrastreogps_equipogps = base.SetintAsString(ColumnNames.Idrastreogps_equipogps, value);
            }
        }

        public virtual string s_Idrastreogps_tipoequipo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreogps_tipoequipo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_tipoequipo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreogps_tipoequipo);
                else
                    this.Idrastreogps_tipoequipo = base.SetintAsString(ColumnNames.Idrastreogps_tipoequipo, value);
            }
        }

        public virtual string s_Tipo_equipo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Tipo_equipo) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_equipo);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Tipo_equipo);
                else
                    this.Tipo_equipo = base.SetstringAsString(ColumnNames.Tipo_equipo, value);
            }
        }

        public virtual string s_Tipo_de_reporte
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Tipo_de_reporte) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_reporte);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Tipo_de_reporte);
                else
                    this.Tipo_de_reporte = base.SetstringAsString(ColumnNames.Tipo_de_reporte, value);
            }
        }

        public virtual string s_Id_equipo_gps
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Id_equipo_gps) ? string.Empty : base.GetstringAsString(ColumnNames.Id_equipo_gps);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Id_equipo_gps);
                else
                    this.Id_equipo_gps = base.SetstringAsString(ColumnNames.Id_equipo_gps, value);
            }
        }

        public virtual string s_Nro_serie_gps
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Nro_serie_gps) ? string.Empty : base.GetstringAsString(ColumnNames.Nro_serie_gps);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Nro_serie_gps);
                else
                    this.Nro_serie_gps = base.SetstringAsString(ColumnNames.Nro_serie_gps, value);
            }
        }

        public virtual string s_Idrastreogps_simcards
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreogps_simcards) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_simcards);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreogps_simcards);
                else
                    this.Idrastreogps_simcards = base.SetintAsString(ColumnNames.Idrastreogps_simcards, value);
            }
        }

        public virtual string s_Sim_nro
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Sim_nro) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_nro);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Sim_nro);
                else
                    this.Sim_nro = base.SetstringAsString(ColumnNames.Sim_nro, value);
            }
        }

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

        public virtual string s_Geocerca_activa
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Geocerca_activa) ? string.Empty : base.GetboolAsString(ColumnNames.Geocerca_activa);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Geocerca_activa);
                else
                    this.Geocerca_activa = base.SetboolAsString(ColumnNames.Geocerca_activa, value);
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


                public WhereParameter Idrastreo_vehiculo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Idrastreo_persona
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_persona, Parameters.Idrastreo_persona);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Razon_social
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Razon_social, Parameters.Razon_social);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Identificador_rastreo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Anho
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Anho, Parameters.Anho);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Chasis
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Chasis, Parameters.Chasis);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Color
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Color, Parameters.Color);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Matricula
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Matricula, Parameters.Matricula);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Kilometraje
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Kilometraje, Parameters.Kilometraje);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Activo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Activo, Parameters.Activo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Consumo_aprox
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Marca
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Marca, Parameters.Marca);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Modelo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Modelo, Parameters.Modelo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Idrastreogps_equipogps
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Idrastreogps_tipoequipo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_tipoequipo, Parameters.Idrastreogps_tipoequipo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Tipo_equipo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Tipo_de_reporte
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_reporte, Parameters.Tipo_de_reporte);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Id_equipo_gps
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Nro_serie_gps
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Nro_serie_gps, Parameters.Nro_serie_gps);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Idrastreogps_simcards
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_simcards, Parameters.Idrastreogps_simcards);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Sim_nro
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
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

                public WhereParameter Geocerca_activa
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Geocerca_activa, Parameters.Geocerca_activa);
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

                public WhereParameter Avisos_activado
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Avisos_activado, Parameters.Avisos_activado);
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

            public WhereParameter Idrastreo_vehiculo
            {
                get
                {
                    if (_Idrastreo_vehiculo_W == null)
                    {
                        _Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
                    }
                    return _Idrastreo_vehiculo_W;
                }
            }

            public WhereParameter Idrastreo_persona
            {
                get
                {
                    if (_Idrastreo_persona_W == null)
                    {
                        _Idrastreo_persona_W = TearOff.Idrastreo_persona;
                    }
                    return _Idrastreo_persona_W;
                }
            }

            public WhereParameter Razon_social
            {
                get
                {
                    if (_Razon_social_W == null)
                    {
                        _Razon_social_W = TearOff.Razon_social;
                    }
                    return _Razon_social_W;
                }
            }

            public WhereParameter Identificador_rastreo
            {
                get
                {
                    if (_Identificador_rastreo_W == null)
                    {
                        _Identificador_rastreo_W = TearOff.Identificador_rastreo;
                    }
                    return _Identificador_rastreo_W;
                }
            }

            public WhereParameter Anho
            {
                get
                {
                    if (_Anho_W == null)
                    {
                        _Anho_W = TearOff.Anho;
                    }
                    return _Anho_W;
                }
            }

            public WhereParameter Chasis
            {
                get
                {
                    if (_Chasis_W == null)
                    {
                        _Chasis_W = TearOff.Chasis;
                    }
                    return _Chasis_W;
                }
            }

            public WhereParameter Color
            {
                get
                {
                    if (_Color_W == null)
                    {
                        _Color_W = TearOff.Color;
                    }
                    return _Color_W;
                }
            }

            public WhereParameter Matricula
            {
                get
                {
                    if (_Matricula_W == null)
                    {
                        _Matricula_W = TearOff.Matricula;
                    }
                    return _Matricula_W;
                }
            }

            public WhereParameter Kilometraje
            {
                get
                {
                    if (_Kilometraje_W == null)
                    {
                        _Kilometraje_W = TearOff.Kilometraje;
                    }
                    return _Kilometraje_W;
                }
            }

            public WhereParameter Activo
            {
                get
                {
                    if (_Activo_W == null)
                    {
                        _Activo_W = TearOff.Activo;
                    }
                    return _Activo_W;
                }
            }

            public WhereParameter Consumo_aprox
            {
                get
                {
                    if (_Consumo_aprox_W == null)
                    {
                        _Consumo_aprox_W = TearOff.Consumo_aprox;
                    }
                    return _Consumo_aprox_W;
                }
            }

            public WhereParameter Marca
            {
                get
                {
                    if (_Marca_W == null)
                    {
                        _Marca_W = TearOff.Marca;
                    }
                    return _Marca_W;
                }
            }

            public WhereParameter Modelo
            {
                get
                {
                    if (_Modelo_W == null)
                    {
                        _Modelo_W = TearOff.Modelo;
                    }
                    return _Modelo_W;
                }
            }

            public WhereParameter Idrastreogps_equipogps
            {
                get
                {
                    if (_Idrastreogps_equipogps_W == null)
                    {
                        _Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
                    }
                    return _Idrastreogps_equipogps_W;
                }
            }

            public WhereParameter Idrastreogps_tipoequipo
            {
                get
                {
                    if (_Idrastreogps_tipoequipo_W == null)
                    {
                        _Idrastreogps_tipoequipo_W = TearOff.Idrastreogps_tipoequipo;
                    }
                    return _Idrastreogps_tipoequipo_W;
                }
            }

            public WhereParameter Tipo_equipo
            {
                get
                {
                    if (_Tipo_equipo_W == null)
                    {
                        _Tipo_equipo_W = TearOff.Tipo_equipo;
                    }
                    return _Tipo_equipo_W;
                }
            }

            public WhereParameter Tipo_de_reporte
            {
                get
                {
                    if (_Tipo_de_reporte_W == null)
                    {
                        _Tipo_de_reporte_W = TearOff.Tipo_de_reporte;
                    }
                    return _Tipo_de_reporte_W;
                }
            }

            public WhereParameter Id_equipo_gps
            {
                get
                {
                    if (_Id_equipo_gps_W == null)
                    {
                        _Id_equipo_gps_W = TearOff.Id_equipo_gps;
                    }
                    return _Id_equipo_gps_W;
                }
            }

            public WhereParameter Nro_serie_gps
            {
                get
                {
                    if (_Nro_serie_gps_W == null)
                    {
                        _Nro_serie_gps_W = TearOff.Nro_serie_gps;
                    }
                    return _Nro_serie_gps_W;
                }
            }

            public WhereParameter Idrastreogps_simcards
            {
                get
                {
                    if (_Idrastreogps_simcards_W == null)
                    {
                        _Idrastreogps_simcards_W = TearOff.Idrastreogps_simcards;
                    }
                    return _Idrastreogps_simcards_W;
                }
            }

            public WhereParameter Sim_nro
            {
                get
                {
                    if (_Sim_nro_W == null)
                    {
                        _Sim_nro_W = TearOff.Sim_nro;
                    }
                    return _Sim_nro_W;
                }
            }

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

            public WhereParameter Geocerca_activa
            {
                get
                {
                    if (_Geocerca_activa_W == null)
                    {
                        _Geocerca_activa_W = TearOff.Geocerca_activa;
                    }
                    return _Geocerca_activa_W;
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

            private WhereParameter _Idrastreo_vehiculo_W = null;
            private WhereParameter _Idrastreo_persona_W = null;
            private WhereParameter _Razon_social_W = null;
            private WhereParameter _Identificador_rastreo_W = null;
            private WhereParameter _Anho_W = null;
            private WhereParameter _Chasis_W = null;
            private WhereParameter _Color_W = null;
            private WhereParameter _Matricula_W = null;
            private WhereParameter _Kilometraje_W = null;
            private WhereParameter _Activo_W = null;
            private WhereParameter _Consumo_aprox_W = null;
            private WhereParameter _Marca_W = null;
            private WhereParameter _Modelo_W = null;
            private WhereParameter _Idrastreogps_equipogps_W = null;
            private WhereParameter _Idrastreogps_tipoequipo_W = null;
            private WhereParameter _Tipo_equipo_W = null;
            private WhereParameter _Tipo_de_reporte_W = null;
            private WhereParameter _Id_equipo_gps_W = null;
            private WhereParameter _Nro_serie_gps_W = null;
            private WhereParameter _Idrastreogps_simcards_W = null;
            private WhereParameter _Sim_nro_W = null;
            private WhereParameter _Idrastreo_geocercas_W = null;
            private WhereParameter _Descripcion_W = null;
            private WhereParameter _Puntos_W = null;
            private WhereParameter _Hora_activacion_W = null;
            private WhereParameter _Horas_activa_W = null;
            private WhereParameter _Geocerca_activa_W = null;
            private WhereParameter _Activo_siempre_W = null;
            private WhereParameter _Dia_activacion_W = null;
            private WhereParameter _Avisar_entrada_W = null;
            private WhereParameter _Mails_W = null;
            private WhereParameter _Tel_movil_W = null;
            private WhereParameter _Avisos_activado_W = null;
            private WhereParameter _Aviso_entradasalida_W = null;

            public void WhereClauseReset()
            {
                _Idrastreo_vehiculo_W = null;
                _Idrastreo_persona_W = null;
                _Razon_social_W = null;
                _Identificador_rastreo_W = null;
                _Anho_W = null;
                _Chasis_W = null;
                _Color_W = null;
                _Matricula_W = null;
                _Kilometraje_W = null;
                _Activo_W = null;
                _Consumo_aprox_W = null;
                _Marca_W = null;
                _Modelo_W = null;
                _Idrastreogps_equipogps_W = null;
                _Idrastreogps_tipoequipo_W = null;
                _Tipo_equipo_W = null;
                _Tipo_de_reporte_W = null;
                _Id_equipo_gps_W = null;
                _Nro_serie_gps_W = null;
                _Idrastreogps_simcards_W = null;
                _Sim_nro_W = null;
                _Idrastreo_geocercas_W = null;
                _Descripcion_W = null;
                _Puntos_W = null;
                _Hora_activacion_W = null;
                _Horas_activa_W = null;
                _Geocerca_activa_W = null;
                _Activo_siempre_W = null;
                _Dia_activacion_W = null;
                _Avisar_entrada_W = null;
                _Mails_W = null;
                _Tel_movil_W = null;
                _Avisos_activado_W = null;
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


                public AggregateParameter Idrastreo_vehiculo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Idrastreo_persona
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_persona, Parameters.Idrastreo_persona);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Razon_social
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Razon_social, Parameters.Razon_social);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Identificador_rastreo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Anho
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Anho, Parameters.Anho);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Chasis
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Chasis, Parameters.Chasis);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Color
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Color, Parameters.Color);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Matricula
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Matricula, Parameters.Matricula);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Kilometraje
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Kilometraje, Parameters.Kilometraje);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Activo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activo, Parameters.Activo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Consumo_aprox
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Marca
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Marca, Parameters.Marca);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Modelo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Modelo, Parameters.Modelo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Idrastreogps_equipogps
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Idrastreogps_tipoequipo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_tipoequipo, Parameters.Idrastreogps_tipoequipo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Tipo_equipo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Tipo_de_reporte
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_reporte, Parameters.Tipo_de_reporte);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Id_equipo_gps
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Nro_serie_gps
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nro_serie_gps, Parameters.Nro_serie_gps);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Idrastreogps_simcards
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_simcards, Parameters.Idrastreogps_simcards);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Sim_nro
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
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

                public AggregateParameter Geocerca_activa
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Geocerca_activa, Parameters.Geocerca_activa);
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

                public AggregateParameter Avisos_activado
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Avisos_activado, Parameters.Avisos_activado);
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

            public AggregateParameter Idrastreo_vehiculo
            {
                get
                {
                    if (_Idrastreo_vehiculo_W == null)
                    {
                        _Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
                    }
                    return _Idrastreo_vehiculo_W;
                }
            }

            public AggregateParameter Idrastreo_persona
            {
                get
                {
                    if (_Idrastreo_persona_W == null)
                    {
                        _Idrastreo_persona_W = TearOff.Idrastreo_persona;
                    }
                    return _Idrastreo_persona_W;
                }
            }

            public AggregateParameter Razon_social
            {
                get
                {
                    if (_Razon_social_W == null)
                    {
                        _Razon_social_W = TearOff.Razon_social;
                    }
                    return _Razon_social_W;
                }
            }

            public AggregateParameter Identificador_rastreo
            {
                get
                {
                    if (_Identificador_rastreo_W == null)
                    {
                        _Identificador_rastreo_W = TearOff.Identificador_rastreo;
                    }
                    return _Identificador_rastreo_W;
                }
            }

            public AggregateParameter Anho
            {
                get
                {
                    if (_Anho_W == null)
                    {
                        _Anho_W = TearOff.Anho;
                    }
                    return _Anho_W;
                }
            }

            public AggregateParameter Chasis
            {
                get
                {
                    if (_Chasis_W == null)
                    {
                        _Chasis_W = TearOff.Chasis;
                    }
                    return _Chasis_W;
                }
            }

            public AggregateParameter Color
            {
                get
                {
                    if (_Color_W == null)
                    {
                        _Color_W = TearOff.Color;
                    }
                    return _Color_W;
                }
            }

            public AggregateParameter Matricula
            {
                get
                {
                    if (_Matricula_W == null)
                    {
                        _Matricula_W = TearOff.Matricula;
                    }
                    return _Matricula_W;
                }
            }

            public AggregateParameter Kilometraje
            {
                get
                {
                    if (_Kilometraje_W == null)
                    {
                        _Kilometraje_W = TearOff.Kilometraje;
                    }
                    return _Kilometraje_W;
                }
            }

            public AggregateParameter Activo
            {
                get
                {
                    if (_Activo_W == null)
                    {
                        _Activo_W = TearOff.Activo;
                    }
                    return _Activo_W;
                }
            }

            public AggregateParameter Consumo_aprox
            {
                get
                {
                    if (_Consumo_aprox_W == null)
                    {
                        _Consumo_aprox_W = TearOff.Consumo_aprox;
                    }
                    return _Consumo_aprox_W;
                }
            }

            public AggregateParameter Marca
            {
                get
                {
                    if (_Marca_W == null)
                    {
                        _Marca_W = TearOff.Marca;
                    }
                    return _Marca_W;
                }
            }

            public AggregateParameter Modelo
            {
                get
                {
                    if (_Modelo_W == null)
                    {
                        _Modelo_W = TearOff.Modelo;
                    }
                    return _Modelo_W;
                }
            }

            public AggregateParameter Idrastreogps_equipogps
            {
                get
                {
                    if (_Idrastreogps_equipogps_W == null)
                    {
                        _Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
                    }
                    return _Idrastreogps_equipogps_W;
                }
            }

            public AggregateParameter Idrastreogps_tipoequipo
            {
                get
                {
                    if (_Idrastreogps_tipoequipo_W == null)
                    {
                        _Idrastreogps_tipoequipo_W = TearOff.Idrastreogps_tipoequipo;
                    }
                    return _Idrastreogps_tipoequipo_W;
                }
            }

            public AggregateParameter Tipo_equipo
            {
                get
                {
                    if (_Tipo_equipo_W == null)
                    {
                        _Tipo_equipo_W = TearOff.Tipo_equipo;
                    }
                    return _Tipo_equipo_W;
                }
            }

            public AggregateParameter Tipo_de_reporte
            {
                get
                {
                    if (_Tipo_de_reporte_W == null)
                    {
                        _Tipo_de_reporte_W = TearOff.Tipo_de_reporte;
                    }
                    return _Tipo_de_reporte_W;
                }
            }

            public AggregateParameter Id_equipo_gps
            {
                get
                {
                    if (_Id_equipo_gps_W == null)
                    {
                        _Id_equipo_gps_W = TearOff.Id_equipo_gps;
                    }
                    return _Id_equipo_gps_W;
                }
            }

            public AggregateParameter Nro_serie_gps
            {
                get
                {
                    if (_Nro_serie_gps_W == null)
                    {
                        _Nro_serie_gps_W = TearOff.Nro_serie_gps;
                    }
                    return _Nro_serie_gps_W;
                }
            }

            public AggregateParameter Idrastreogps_simcards
            {
                get
                {
                    if (_Idrastreogps_simcards_W == null)
                    {
                        _Idrastreogps_simcards_W = TearOff.Idrastreogps_simcards;
                    }
                    return _Idrastreogps_simcards_W;
                }
            }

            public AggregateParameter Sim_nro
            {
                get
                {
                    if (_Sim_nro_W == null)
                    {
                        _Sim_nro_W = TearOff.Sim_nro;
                    }
                    return _Sim_nro_W;
                }
            }

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

            public AggregateParameter Geocerca_activa
            {
                get
                {
                    if (_Geocerca_activa_W == null)
                    {
                        _Geocerca_activa_W = TearOff.Geocerca_activa;
                    }
                    return _Geocerca_activa_W;
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

            private AggregateParameter _Idrastreo_vehiculo_W = null;
            private AggregateParameter _Idrastreo_persona_W = null;
            private AggregateParameter _Razon_social_W = null;
            private AggregateParameter _Identificador_rastreo_W = null;
            private AggregateParameter _Anho_W = null;
            private AggregateParameter _Chasis_W = null;
            private AggregateParameter _Color_W = null;
            private AggregateParameter _Matricula_W = null;
            private AggregateParameter _Kilometraje_W = null;
            private AggregateParameter _Activo_W = null;
            private AggregateParameter _Consumo_aprox_W = null;
            private AggregateParameter _Marca_W = null;
            private AggregateParameter _Modelo_W = null;
            private AggregateParameter _Idrastreogps_equipogps_W = null;
            private AggregateParameter _Idrastreogps_tipoequipo_W = null;
            private AggregateParameter _Tipo_equipo_W = null;
            private AggregateParameter _Tipo_de_reporte_W = null;
            private AggregateParameter _Id_equipo_gps_W = null;
            private AggregateParameter _Nro_serie_gps_W = null;
            private AggregateParameter _Idrastreogps_simcards_W = null;
            private AggregateParameter _Sim_nro_W = null;
            private AggregateParameter _Idrastreo_geocercas_W = null;
            private AggregateParameter _Descripcion_W = null;
            private AggregateParameter _Puntos_W = null;
            private AggregateParameter _Hora_activacion_W = null;
            private AggregateParameter _Horas_activa_W = null;
            private AggregateParameter _Geocerca_activa_W = null;
            private AggregateParameter _Activo_siempre_W = null;
            private AggregateParameter _Dia_activacion_W = null;
            private AggregateParameter _Avisar_entrada_W = null;
            private AggregateParameter _Mails_W = null;
            private AggregateParameter _Tel_movil_W = null;
            private AggregateParameter _Avisos_activado_W = null;
            private AggregateParameter _Aviso_entradasalida_W = null;

            public void AggregateClauseReset()
            {
                _Idrastreo_vehiculo_W = null;
                _Idrastreo_persona_W = null;
                _Razon_social_W = null;
                _Identificador_rastreo_W = null;
                _Anho_W = null;
                _Chasis_W = null;
                _Color_W = null;
                _Matricula_W = null;
                _Kilometraje_W = null;
                _Activo_W = null;
                _Consumo_aprox_W = null;
                _Marca_W = null;
                _Modelo_W = null;
                _Idrastreogps_equipogps_W = null;
                _Idrastreogps_tipoequipo_W = null;
                _Tipo_equipo_W = null;
                _Tipo_de_reporte_W = null;
                _Id_equipo_gps_W = null;
                _Nro_serie_gps_W = null;
                _Idrastreogps_simcards_W = null;
                _Sim_nro_W = null;
                _Idrastreo_geocercas_W = null;
                _Descripcion_W = null;
                _Puntos_W = null;
                _Hora_activacion_W = null;
                _Horas_activa_W = null;
                _Geocerca_activa_W = null;
                _Activo_siempre_W = null;
                _Dia_activacion_W = null;
                _Avisar_entrada_W = null;
                _Mails_W = null;
                _Tel_movil_W = null;
                _Avisos_activado_W = null;
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
            return null;
        }

        protected override IDbCommand GetUpdateCommand()
        {
            return null;
        }

        protected override IDbCommand GetDeleteCommand()
        {
            return null;
        }
    }
}


