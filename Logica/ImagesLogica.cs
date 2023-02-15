using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using Nativo.Modelo;
namespace Nativo.Logica
{
    public class ImagesLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ImagesLogica _instancia = null;

        public ImagesLogica()
        {

        }

        public static ImagesLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ImagesLogica();
                }

                return _instancia;
            }


        }


        public bool Guardar(Images obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Images (PACI_COD, PACI_FOTO,FECHA) VALUES(@PACI_COD,@PACI_FOTO, @FECHA)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO", obj.PACI_FOTO));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));


                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar( Images obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Images set PACI_FOTO=@PACI_FOTO,FECHA=@FECHA WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO", obj.PACI_FOTO));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Images obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from Images where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;

                }


            }

            return respuesta;


        }


    }
}
