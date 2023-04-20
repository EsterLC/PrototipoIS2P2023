using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria--------
using System.Data.Odbc;

namespace NavegadorModelo
{
    public class Conexion
    {
        //Clase de conexion --------------
        /*public Tuple<OdbcConnection, OdbcTransaction> conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conectar = new OdbcConnection("Dsn=PrototipoEF");
            OdbcTransaction transaction = conectar.BeginTransaction();
            try
            {
                conectar.Open();
    
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return Tuple.Create(conectar, transaction);
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conectar)
        {
            try
            {
                conectar.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }*/
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }
        /*
        public Tuple<OdbcConnection, OdbcTransaction> conexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=PrototipoEF");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
        }
        */
    }
}
