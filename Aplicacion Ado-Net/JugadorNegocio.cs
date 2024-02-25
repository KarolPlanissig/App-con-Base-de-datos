using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace Aplicacion_Ado_Net
{
    internal class JugadorNegocio
    {
        public List<Disco> Discoss()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; 
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo, CantidadCanciones, IdEstilo, UrlImagenTapa from DISCOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                 
                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];                   
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.IdEstilo = (int)lector["IdEstilo"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    lista.Add(aux); 
                }
                conexion.Close(); 
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
          


     
    }
}
