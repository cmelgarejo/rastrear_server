/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreo_historial 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreo_historial : _rastreo_historial
	{
		public rastreo_historial(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
