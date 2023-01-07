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
    public class AbonoLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static AbonoLogica _instancia = null;

        public AbonoLogica()
        {

        }

        public static AbonoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new AbonoLogica();
                }

                return _instancia;
            }


        }



        public bool Guardar(Abonos obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Abonos (PACI_COD,ABO_FECHA,ABO_PTAS,PRECIO_TRABAJO,DESC_TRABAJO) VALUES(@PACI_COD,@ABO_FECHA,@ABO_PTAS,@PRECIO_TRABAJO,@DESC_TRABAJO)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@ABO_FECHA", obj.ABO_FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@ABO_PTAS", obj.ABO_PTAS));
                cmd.Parameters.Add(new SQLiteParameter("@PRECIO_TRABAJO", obj.PRECIO_TRABAJO));
                cmd.Parameters.Add(new SQLiteParameter("@DESC_TRABAJO", obj.DESC_TRABAJO));
              

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar(Abonos obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Abonos set ABO_FECHA=@ABO_FECHA,ABO_PTAS=@ABO_PTAS,PRECIO_TRABAJO=@PRECIO_TRABAJO,DESC_TRABAJO=@DESC_TRABAJO  WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@ABO_FECHA", obj.ABO_FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@ABO_PTAS", obj.ABO_PTAS));
                cmd.Parameters.Add(new SQLiteParameter("@PRECIO_TRABAJO", obj.PRECIO_TRABAJO));
                cmd.Parameters.Add(new SQLiteParameter("@DESC_TRABAJO", obj.DESC_TRABAJO));


                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Abonos obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from Abonos where id=@id";
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
