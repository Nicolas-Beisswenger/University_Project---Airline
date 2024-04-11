using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient; 

namespace Aerolinea.BaseDeDatos
{
    class Conexion
    {
        SqlConnection conexion; 

        public Conexion()
        {
            conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nicolas Beisswenger\\OneDrive\\Documentos\\ULACIT\\Cuatrimestre 05\\Diseño de Aplicaciones\\Semana 14\\Expo\\Versión Final\\Aerolínea\\Aerolinea\\BaseDeDatos\\Aerolinea.mdf;Integrated Security=True");
        }

        public SqlConnection RecibirConexion()
        {
            return conexion; 
        }
    }
}
