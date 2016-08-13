/*
'==============================================================================================================
'  Autor: CLrSoft
'  Clase concreta de la tabla: rastreo_cliente_documentos 
'  Base soportada: .
'  Version MyGen: # (1.3.0.9)
'==============================================================================================================
*/


using System;

namespace RASTREOmw
{
	public class rastreo_cliente_documentos : _rastreo_cliente_documentos
	{
		public rastreo_cliente_documentos(String laCadenaDeConexion)
		{
			this.ConnectionString = laCadenaDeConexion;
		}
		
		public bool DataBindSqlQuery(string Proc)
        {
            return base.LoadFromRawSql(Proc);
        }
	}
}
