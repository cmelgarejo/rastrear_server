
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_usuarios.
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
    public abstract class _rastreo_usuarios : PostgreSqlEntity
    {
        public _rastreo_usuarios()
        {
            this.QuerySource = "rastreo_usuarios";
            this.MappingName = "rastreo_usuarios";

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

            return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_usuarios_load_all", parameters);
        }

        //=================================================================
        // public Overridable Function LoadByPrimaryKey()  As Boolean
        //=================================================================
        //  Loads a single row of via the primary key
        //=================================================================
        public virtual bool LoadByPrimaryKey(int Idrastreo_usuarios)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(Parameters.Idrastreo_usuarios, Idrastreo_usuarios);


            return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_usuarios_load_by_primarykey", parameters);
        }

        #region Parameters
        protected class Parameters
        {

            public static NpgsqlParameter Idrastreo_usuarios
            {
                get
                {
                    return new NpgsqlParameter("Idrastreo_usuarios", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Id_persona
            {
                get
                {
                    return new NpgsqlParameter("Id_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
                }
            }

            public static NpgsqlParameter Usuario
            {
                get
                {
                    return new NpgsqlParameter("Usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
                }
            }

            public static NpgsqlParameter Pass
            {
                get
                {
                    return new NpgsqlParameter("Pass", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
                }
            }

            public static NpgsqlParameter Su
            {
                get
                {
                    return new NpgsqlParameter("Su", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
                }
            }

            public static NpgsqlParameter Fech_login
            {
                get
                {
                    return new NpgsqlParameter("Fech_login", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
                }
            }

            public static NpgsqlParameter Intentos_login
            {
                get
                {
                    return new NpgsqlParameter("Intentos_login", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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

            public static NpgsqlParameter Nombre_completo
            {
                get
                {
                    return new NpgsqlParameter("Nombre_completo", NpgsqlTypes.NpgsqlDbType.Varchar, 256);
                }
            }

            public static NpgsqlParameter Emails
            {
                get
                {
                    return new NpgsqlParameter("Emails", NpgsqlTypes.NpgsqlDbType.Text, 0);
                }
            }

        }
        #endregion

        #region ColumnNames
        public class ColumnNames
        {
            public const string Idrastreo_usuarios = "idrastreo_usuarios";
            public const string Id_persona = "id_persona";
            public const string Usuario = "usuario";
            public const string Pass = "pass";
            public const string Su = "su";
            public const string Fech_login = "fech_login";
            public const string Intentos_login = "intentos_login";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Nombre_completo = "nombre_completo";
            public const string Emails = "emails";

            static public string ToPropertyName(string columnName)
            {
                if(ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_usuarios] = _rastreo_usuarios.PropertyNames.Idrastreo_usuarios;
                    ht[Id_persona] = _rastreo_usuarios.PropertyNames.Id_persona;
                    ht[Usuario] = _rastreo_usuarios.PropertyNames.Usuario;
                    ht[Pass] = _rastreo_usuarios.PropertyNames.Pass;
                    ht[Su] = _rastreo_usuarios.PropertyNames.Su;
                    ht[Fech_login] = _rastreo_usuarios.PropertyNames.Fech_login;
                    ht[Intentos_login] = _rastreo_usuarios.PropertyNames.Intentos_login;
                    ht[User_ins] = _rastreo_usuarios.PropertyNames.User_ins;
                    ht[Fech_ins] = _rastreo_usuarios.PropertyNames.Fech_ins;
                    ht[User_upd] = _rastreo_usuarios.PropertyNames.User_upd;
                    ht[Fech_upd] = _rastreo_usuarios.PropertyNames.Fech_upd;
                    ht[Nombre_completo] = _rastreo_usuarios.PropertyNames.Nombre_completo;
                    ht[Emails] = _rastreo_usuarios.PropertyNames.Emails;

                }
                return (string)ht[columnName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Idrastreo_usuarios = "Idrastreo_usuarios";
            public const string Id_persona = "Id_persona";
            public const string Usuario = "Usuario";
            public const string Pass = "Pass";
            public const string Su = "Su";
            public const string Fech_login = "Fech_login";
            public const string Intentos_login = "Intentos_login";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Nombre_completo = "Nombre_completo";
            public const string Emails = "Emails";

            static public string ToColumnName(string propertyName)
            {
                if(ht == null)
                {
                    ht = new Hashtable();

                    ht[Idrastreo_usuarios] = _rastreo_usuarios.ColumnNames.Idrastreo_usuarios;
                    ht[Id_persona] = _rastreo_usuarios.ColumnNames.Id_persona;
                    ht[Usuario] = _rastreo_usuarios.ColumnNames.Usuario;
                    ht[Pass] = _rastreo_usuarios.ColumnNames.Pass;
                    ht[Su] = _rastreo_usuarios.ColumnNames.Su;
                    ht[Fech_login] = _rastreo_usuarios.ColumnNames.Fech_login;
                    ht[Intentos_login] = _rastreo_usuarios.ColumnNames.Intentos_login;
                    ht[User_ins] = _rastreo_usuarios.ColumnNames.User_ins;
                    ht[Fech_ins] = _rastreo_usuarios.ColumnNames.Fech_ins;
                    ht[User_upd] = _rastreo_usuarios.ColumnNames.User_upd;
                    ht[Fech_upd] = _rastreo_usuarios.ColumnNames.Fech_upd;
                    ht[Nombre_completo] = _rastreo_usuarios.ColumnNames.Nombre_completo;
                    ht[Emails] = _rastreo_usuarios.ColumnNames.Emails;

                }
                return (string)ht[propertyName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region StringPropertyNames
        public class StringPropertyNames
        {
            public const string Idrastreo_usuarios = "s_Idrastreo_usuarios";
            public const string Id_persona = "s_Id_persona";
            public const string Usuario = "s_Usuario";
            public const string Pass = "s_Pass";
            public const string Su = "s_Su";
            public const string Fech_login = "s_Fech_login";
            public const string Intentos_login = "s_Intentos_login";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Nombre_completo = "s_Nombre_completo";
            public const string Emails = "s_Emails";

        }
        #endregion

        #region Properties

        public virtual int Idrastreo_usuarios
        {
            get
            {
                return base.Getint(ColumnNames.Idrastreo_usuarios);
            }
            set
            {
                base.Setint(ColumnNames.Idrastreo_usuarios, value);
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

        public virtual string Usuario
        {
            get
            {
                return base.Getstring(ColumnNames.Usuario);
            }
            set
            {
                base.Setstring(ColumnNames.Usuario, value);
            }
        }

        public virtual string Pass
        {
            get
            {
                return base.Getstring(ColumnNames.Pass);
            }
            set
            {
                base.Setstring(ColumnNames.Pass, value);
            }
        }

        public virtual bool Su
        {
            get
            {
                return base.Getbool(ColumnNames.Su);
            }
            set
            {
                base.Setbool(ColumnNames.Su, value);
            }
        }

        public virtual DateTime Fech_login
        {
            get
            {
                return base.GetDateTime(ColumnNames.Fech_login);
            }
            set
            {
                base.SetDateTime(ColumnNames.Fech_login, value);
            }
        }

        public virtual int Intentos_login
        {
            get
            {
                return base.Getint(ColumnNames.Intentos_login);
            }
            set
            {
                base.Setint(ColumnNames.Intentos_login, value);
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

        public virtual string Nombre_completo
        {
            get
            {
                return base.Getstring(ColumnNames.Nombre_completo);
            }
            set
            {
                base.Setstring(ColumnNames.Nombre_completo, value);
            }
        }

        public virtual string Emails
        {
            get
            {
                return base.Getstring(ColumnNames.Emails);
            }
            set
            {
                base.Setstring(ColumnNames.Emails, value);
            }
        }


        #endregion

        #region String Properties

        public virtual string s_Idrastreo_usuarios
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Idrastreo_usuarios) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_usuarios);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Idrastreo_usuarios);
                else
                    this.Idrastreo_usuarios = base.SetintAsString(ColumnNames.Idrastreo_usuarios, value);
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

        public virtual string s_Usuario
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Usuario) ? string.Empty : base.GetstringAsString(ColumnNames.Usuario);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Usuario);
                else
                    this.Usuario = base.SetstringAsString(ColumnNames.Usuario, value);
            }
        }

        public virtual string s_Pass
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Pass) ? string.Empty : base.GetstringAsString(ColumnNames.Pass);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Pass);
                else
                    this.Pass = base.SetstringAsString(ColumnNames.Pass, value);
            }
        }

        public virtual string s_Su
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Su) ? string.Empty : base.GetboolAsString(ColumnNames.Su);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Su);
                else
                    this.Su = base.SetboolAsString(ColumnNames.Su, value);
            }
        }

        public virtual string s_Fech_login
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Fech_login) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fech_login);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Fech_login);
                else
                    this.Fech_login = base.SetDateTimeAsString(ColumnNames.Fech_login, value);
            }
        }

        public virtual string s_Intentos_login
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Intentos_login) ? string.Empty : base.GetintAsString(ColumnNames.Intentos_login);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Intentos_login);
                else
                    this.Intentos_login = base.SetintAsString(ColumnNames.Intentos_login, value);
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

        public virtual string s_Nombre_completo
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Nombre_completo) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_completo);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Nombre_completo);
                else
                    this.Nombre_completo = base.SetstringAsString(ColumnNames.Nombre_completo, value);
            }
        }

        public virtual string s_Emails
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Emails) ? string.Empty : base.GetstringAsString(ColumnNames.Emails);
            }
            set
            {
                if(string.Empty == value)
                    this.SetColumnNull(ColumnNames.Emails);
                else
                    this.Emails = base.SetstringAsString(ColumnNames.Emails, value);
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


                public WhereParameter Idrastreo_usuarios
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_usuarios, Parameters.Idrastreo_usuarios);
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

                public WhereParameter Usuario
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Usuario, Parameters.Usuario);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Pass
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Pass, Parameters.Pass);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Su
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Su, Parameters.Su);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Fech_login
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Fech_login, Parameters.Fech_login);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Intentos_login
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Intentos_login, Parameters.Intentos_login);
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

                public WhereParameter Nombre_completo
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Nombre_completo, Parameters.Nombre_completo);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Emails
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Emails, Parameters.Emails);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }


                private WhereClause _clause;
            }
            #endregion

            public WhereParameter Idrastreo_usuarios
            {
                get
                {
                    if(_Idrastreo_usuarios_W == null)
                    {
                        _Idrastreo_usuarios_W = TearOff.Idrastreo_usuarios;
                    }
                    return _Idrastreo_usuarios_W;
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

            public WhereParameter Usuario
            {
                get
                {
                    if(_Usuario_W == null)
                    {
                        _Usuario_W = TearOff.Usuario;
                    }
                    return _Usuario_W;
                }
            }

            public WhereParameter Pass
            {
                get
                {
                    if(_Pass_W == null)
                    {
                        _Pass_W = TearOff.Pass;
                    }
                    return _Pass_W;
                }
            }

            public WhereParameter Su
            {
                get
                {
                    if(_Su_W == null)
                    {
                        _Su_W = TearOff.Su;
                    }
                    return _Su_W;
                }
            }

            public WhereParameter Fech_login
            {
                get
                {
                    if(_Fech_login_W == null)
                    {
                        _Fech_login_W = TearOff.Fech_login;
                    }
                    return _Fech_login_W;
                }
            }

            public WhereParameter Intentos_login
            {
                get
                {
                    if(_Intentos_login_W == null)
                    {
                        _Intentos_login_W = TearOff.Intentos_login;
                    }
                    return _Intentos_login_W;
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

            public WhereParameter Nombre_completo
            {
                get
                {
                    if(_Nombre_completo_W == null)
                    {
                        _Nombre_completo_W = TearOff.Nombre_completo;
                    }
                    return _Nombre_completo_W;
                }
            }

            public WhereParameter Emails
            {
                get
                {
                    if(_Emails_W == null)
                    {
                        _Emails_W = TearOff.Emails;
                    }
                    return _Emails_W;
                }
            }

            private WhereParameter _Idrastreo_usuarios_W = null;
            private WhereParameter _Id_persona_W = null;
            private WhereParameter _Usuario_W = null;
            private WhereParameter _Pass_W = null;
            private WhereParameter _Su_W = null;
            private WhereParameter _Fech_login_W = null;
            private WhereParameter _Intentos_login_W = null;
            private WhereParameter _User_ins_W = null;
            private WhereParameter _Fech_ins_W = null;
            private WhereParameter _User_upd_W = null;
            private WhereParameter _Fech_upd_W = null;
            private WhereParameter _Nombre_completo_W = null;
            private WhereParameter _Emails_W = null;

            public void WhereClauseReset()
            {
                _Idrastreo_usuarios_W = null;
                _Id_persona_W = null;
                _Usuario_W = null;
                _Pass_W = null;
                _Su_W = null;
                _Fech_login_W = null;
                _Intentos_login_W = null;
                _User_ins_W = null;
                _Fech_ins_W = null;
                _User_upd_W = null;
                _Fech_upd_W = null;
                _Nombre_completo_W = null;
                _Emails_W = null;

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


                public AggregateParameter Idrastreo_usuarios
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_usuarios, Parameters.Idrastreo_usuarios);
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

                public AggregateParameter Usuario
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Usuario, Parameters.Usuario);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Pass
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pass, Parameters.Pass);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Su
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Su, Parameters.Su);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Fech_login
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fech_login, Parameters.Fech_login);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Intentos_login
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Intentos_login, Parameters.Intentos_login);
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

                public AggregateParameter Nombre_completo
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_completo, Parameters.Nombre_completo);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Emails
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emails, Parameters.Emails);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }


                private AggregateClause _clause;
            }
            #endregion

            public AggregateParameter Idrastreo_usuarios
            {
                get
                {
                    if(_Idrastreo_usuarios_W == null)
                    {
                        _Idrastreo_usuarios_W = TearOff.Idrastreo_usuarios;
                    }
                    return _Idrastreo_usuarios_W;
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

            public AggregateParameter Usuario
            {
                get
                {
                    if(_Usuario_W == null)
                    {
                        _Usuario_W = TearOff.Usuario;
                    }
                    return _Usuario_W;
                }
            }

            public AggregateParameter Pass
            {
                get
                {
                    if(_Pass_W == null)
                    {
                        _Pass_W = TearOff.Pass;
                    }
                    return _Pass_W;
                }
            }

            public AggregateParameter Su
            {
                get
                {
                    if(_Su_W == null)
                    {
                        _Su_W = TearOff.Su;
                    }
                    return _Su_W;
                }
            }

            public AggregateParameter Fech_login
            {
                get
                {
                    if(_Fech_login_W == null)
                    {
                        _Fech_login_W = TearOff.Fech_login;
                    }
                    return _Fech_login_W;
                }
            }

            public AggregateParameter Intentos_login
            {
                get
                {
                    if(_Intentos_login_W == null)
                    {
                        _Intentos_login_W = TearOff.Intentos_login;
                    }
                    return _Intentos_login_W;
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

            public AggregateParameter Nombre_completo
            {
                get
                {
                    if(_Nombre_completo_W == null)
                    {
                        _Nombre_completo_W = TearOff.Nombre_completo;
                    }
                    return _Nombre_completo_W;
                }
            }

            public AggregateParameter Emails
            {
                get
                {
                    if(_Emails_W == null)
                    {
                        _Emails_W = TearOff.Emails;
                    }
                    return _Emails_W;
                }
            }

            private AggregateParameter _Idrastreo_usuarios_W = null;
            private AggregateParameter _Id_persona_W = null;
            private AggregateParameter _Usuario_W = null;
            private AggregateParameter _Pass_W = null;
            private AggregateParameter _Su_W = null;
            private AggregateParameter _Fech_login_W = null;
            private AggregateParameter _Intentos_login_W = null;
            private AggregateParameter _User_ins_W = null;
            private AggregateParameter _Fech_ins_W = null;
            private AggregateParameter _User_upd_W = null;
            private AggregateParameter _Fech_upd_W = null;
            private AggregateParameter _Nombre_completo_W = null;
            private AggregateParameter _Emails_W = null;

            public void AggregateClauseReset()
            {
                _Idrastreo_usuarios_W = null;
                _Id_persona_W = null;
                _Usuario_W = null;
                _Pass_W = null;
                _Su_W = null;
                _Fech_login_W = null;
                _Intentos_login_W = null;
                _User_ins_W = null;
                _Fech_ins_W = null;
                _User_upd_W = null;
                _Fech_upd_W = null;
                _Nombre_completo_W = null;
                _Emails_W = null;

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
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_usuarios_insert";

            CreateParameters(cmd);

            NpgsqlParameter p;
            p = cmd.Parameters[Parameters.Idrastreo_usuarios.ParameterName];
            p.Direction = ParameterDirection.Output;

            return cmd;
        }

        protected override IDbCommand GetUpdateCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_usuarios_update";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = this.SchemaStoredProcedure + "rastreo_usuarios_delete";

            NpgsqlParameter p;
            p = cmd.Parameters.Add(Parameters.Idrastreo_usuarios);
            p.SourceColumn = ColumnNames.Idrastreo_usuarios;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }

        private IDbCommand CreateParameters(NpgsqlCommand cmd)
        {
            NpgsqlParameter p;

            p = cmd.Parameters.Add(Parameters.Idrastreo_usuarios);
            p.SourceColumn = ColumnNames.Idrastreo_usuarios;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Id_persona);
            p.SourceColumn = ColumnNames.Id_persona;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Usuario);
            p.SourceColumn = ColumnNames.Usuario;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Pass);
            p.SourceColumn = ColumnNames.Pass;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Su);
            p.SourceColumn = ColumnNames.Su;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Fech_login);
            p.SourceColumn = ColumnNames.Fech_login;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Intentos_login);
            p.SourceColumn = ColumnNames.Intentos_login;
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

            p = cmd.Parameters.Add(Parameters.Nombre_completo);
            p.SourceColumn = ColumnNames.Nombre_completo;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Emails);
            p.SourceColumn = ColumnNames.Emails;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}