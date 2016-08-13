/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreo_hoja_de_ruta_puntos 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreo_hoja_de_ruta_puntos : _rastreo_hoja_de_ruta_puntos
	{
		public rastreo_hoja_de_ruta_puntos(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
