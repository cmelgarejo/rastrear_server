/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreo_hojaderuta_has_vehiculo 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreo_hojaderuta_has_vehiculo : _rastreo_hojaderuta_has_vehiculo
	{
		public rastreo_hojaderuta_has_vehiculo(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
