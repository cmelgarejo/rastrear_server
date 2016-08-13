/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreogps_equipogps 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreogps_equipogps : _rastreogps_equipogps
	{
		public rastreogps_equipogps(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
