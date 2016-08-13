/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreo_pais 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreo_pais : _rastreo_pais
	{
		public rastreo_pais(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
