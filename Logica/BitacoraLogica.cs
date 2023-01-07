using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using Nativo.Modelo;
using System.Threading.Tasks;

namespace Nativo.Logica
{
    public class BitacoraLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static BitacoraLogica _instancia = null;

        public BitacoraLogica()
        {

        }

        public static BitacoraLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new BitacoraLogica();
                }

                return _instancia;
            }


        }



        public bool Guardar(Bitacora obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO BITACORA (PACI_COD,BIT_FECHA,BIT_DES) VALUES(@PACI_COD, @BIT_FECHA, @BIT_DES)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@BIT_FECHA", obj.BIT_FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@BIT_DES", obj.BIT_DES));
  
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar(Bitacora obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE BITACORA set BIT_FECHA=@BIT_FECHA,BIT_DES=@BIT_DES  WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@BIT_FECHA", obj.BIT_FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@BIT_DES", obj.BIT_DES));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Bitacora obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from BITACORA where id=@id";
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
