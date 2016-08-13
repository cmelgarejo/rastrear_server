/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreogps_equipo_eventos 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreogps_equipo_eventos : _rastreogps_equipo_eventos
	{
		public rastreogps_equipo_eventos(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
