/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreogps_simcards 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreogps_simcards : _rastreogps_simcards
	{
		public rastreogps_simcards(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
