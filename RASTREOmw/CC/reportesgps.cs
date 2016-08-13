/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: reportesgps NO CAMBIAR 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class reportesgps : _reportesgps
	{
        public reportesgps(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
