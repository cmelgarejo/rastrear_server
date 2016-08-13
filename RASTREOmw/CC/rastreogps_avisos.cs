/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreogps_avisos 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreogps_avisos : _rastreogps_avisos
	{
		public rastreogps_avisos(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
