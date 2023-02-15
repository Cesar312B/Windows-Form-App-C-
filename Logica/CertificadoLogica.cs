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
    public class CertificadoLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static CertificadoLogica _instancia = null;

        public CertificadoLogica()
        {

        }

        public static CertificadoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CertificadoLogica();
                }

                return _instancia;
            }


        }

        public bool Guardar(Certificado obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO CERTIFICADO (PACI_COD, FECHA, ENFERMEDAD, DESCRIPCION, RECOMENDACION) VALUES(@PACI_COD, @FECHA, @ENFERMEDAD, @DESCRIPCION, @RECOMENDACION)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@ENFERMEDAD", obj.ENFERMEDAD));
                cmd.Parameters.Add(new SQLiteParameter("@DESCRIPCION", obj.DESCRIPCION));
                cmd.Parameters.Add(new SQLiteParameter("@RECOMENDACION", obj.RECOMENDACION));


                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public bool Editar(Certificado obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE CERTIFICADO SET  FECHA=@FECHA, ENFERMEDAD=@ENFERMEDAD, DESCRIPCION=@DESCRIPCION, RECOMENDACION=@RECOMENDACION  WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@FECHA", obj.FECHA));
                cmd.Parameters.Add(new SQLiteParameter("@ENFERMEDAD", obj.ENFERMEDAD));
                cmd.Parameters.Add(new SQLiteParameter("@DESCRIPCION", obj.DESCRIPCION));
                cmd.Parameters.Add(new SQLiteParameter("@RECOMENDACION", obj.RECOMENDACION));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Certificado obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from CERTIFICADO  where id=@id";
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
