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
    public class RecetaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static RecetaLogica _instancia = null;

        public RecetaLogica()
        {

        }

        public static RecetaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new RecetaLogica();
                }

                return _instancia;
            }


        }

        public bool Guardar(Receta obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO RECETA (PACI_COD,FECHA,INSTRUCCIONES) VALUES(@PACI_COD,@FECHA,@INSTRUCCIONES)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@INSTRUCCIONES", obj.INSTRUCCIONES));


                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar(Receta obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE RECETA set FECHA=@FECHA,INSTRUCCIONES=@INSTRUCCIONES  WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@INSTRUCCIONES", obj.INSTRUCCIONES));


                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Receta obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from RECETA where id=@id";
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
