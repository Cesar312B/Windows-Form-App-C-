using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using Nativo.Modelo;
using System.Runtime.ConstrainedExecution;

namespace Nativo.Logica
{
    public class PacienteLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PacienteLogica _instancia = null;

        public PacienteLogica()
        {

        }

        public static PacienteLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PacienteLogica();
                }

                return _instancia;
            }


        }



        public bool Guardar(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Paciente (PACI_COD, PACI_NOM, PACI_NACI, PACI_FOTO, PACI_FOTO_ORTO, PACI_FOTO2, PACI_SEXO, PACI_DIR, PACI_LOCAL, PACI_TELEF, PACI_ENT, PACI_PROF, PACI_COMEN, PACI_HIST, PACI_REPRE, PACI_FOTO_ORTO2,DNI) VALUES(@PACI_COD, @PACI_NOM, @PACI_NACI, @PACI_FOTO, @PACI_FOTO_ORTO, @PACI_FOTO2, @PACI_SEXO, @PACI_DIR, @PACI_LOCAL, @PACI_TELEF, @PACI_ENT, @PACI_PROF, @PACI_COMEN, @PACI_HIST, @PACI_REPRE, @PACI_FOTO_ORTO2,@DNI)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_NOM", obj.PACI_NOM));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_NACI", obj.PACI_NACI));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO", obj.PACI_FOTO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO", obj.PACI_FOTO_ORTO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO2", obj.PACI_FOTO2));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_SEXO", obj.PACI_SEXO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_DIR", obj.PACI_DIR));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_LOCAL", obj.PACI_LOCAL));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_TELEF", obj.PACI_TELEF));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_ENT", obj.PACI_ENT));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_PROF", obj.PACI_PROF));
                cmd.Parameters.Add(new SQLiteParameter("@DNI", obj.DNI));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO2", obj.PACI_FOTO_ORTO2));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COMEN", obj.PACI_COMEN));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_HIST", obj.PACI_HIST));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_REPRE", obj.PACI_REPRE));
               
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Paciente set PACI_COD=@PACI_COD, PACI_NOM=@PACI_NOM, PACI_NACI=@PACI_NACI, PACI_SEXO=@PACI_SEXO, PACI_DIR=@PACI_DIR, PACI_LOCAL=@PACI_LOCAL, PACI_TELEF=@PACI_TELEF, PACI_ENT=@PACI_ENT, PACI_PROF=@PACI_PROF, PACI_COMEN=@PACI_COMEN, PACI_HIST=@PACI_HIST, PACI_REPRE=@PACI_REPRE,DNI=@DNI,PACI_FOTO=@PACI_FOTO,PACI_FOTO_ORTO=@PACI_FOTO_ORTO,PACI_FOTO2=@PACI_FOTO2,PACI_FOTO_ORTO2=@PACI_FOTO_ORTO2 WHERE PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_NOM", obj.PACI_NOM));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_NACI", obj.PACI_NACI));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_SEXO", obj.PACI_SEXO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_DIR", obj.PACI_DIR));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_LOCAL", obj.PACI_LOCAL));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_TELEF", obj.PACI_TELEF));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_ENT", obj.PACI_ENT));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_PROF", obj.PACI_PROF));
                cmd.Parameters.Add(new SQLiteParameter("@DNI", obj.DNI));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COMEN", obj.PACI_COMEN));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_HIST", obj.PACI_HIST));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_REPRE", obj.PACI_REPRE));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO", obj.PACI_FOTO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO", obj.PACI_FOTO_ORTO));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO2", obj.PACI_FOTO2));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO2", obj.PACI_FOTO_ORTO2));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar_foto1(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Paciente set  PACI_FOTO=@PACI_FOTO WHERE PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
               
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO", obj.PACI_FOTO));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Editar_foto2(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Paciente set  PACI_FOTO_ORTO=@PACI_FOTO_ORTO WHERE PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO", obj.PACI_FOTO_ORTO));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public bool Editar_foto3(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Paciente set  PACI_FOTO2=@PACI_FOTO2 WHERE PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO2", obj.PACI_FOTO2));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public bool Editar_foto4(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Paciente set  PACI_FOTO_ORTO2=@PACI_FOTO_ORTO2 WHERE PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
                cmd.Parameters.Add(new SQLiteParameter("@PACI_FOTO_ORTO2", obj.PACI_FOTO_ORTO2));

                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        
        public List<Paciente> Listar()
        {
            List<Paciente> oLista = new List<Paciente>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))

            {
                conexion.Open();
             
                string query = "SELECT PACI_COD, PACI_NOM, PACI_NACI, PACI_SEXO, PACI_DIR, PACI_LOCAL, PACI_TELEF, PACI_ENT, PACI_PROF, PACI_NORD, PACI_COMEN, PACI_HIST, PACI_REPRE FROM Paciente";
                
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {



                        oLista.Add(new Paciente()
                        {

                            PACI_COD = dr["PACI_COD"].ToString(),
                            PACI_NOM = dr["PACI_NOM"].ToString(),
                            PACI_NACI = dr["PACI_NACI"].ToString(),
                            PACI_SEXO = dr["PACI_SEXO"].ToString(),
                            PACI_DIR = dr["PACI_DIR"].ToString(),
                            PACI_LOCAL = dr["PACI_LOCAL"].ToString(),
                            PACI_TELEF = dr["PACI_TELEF"].ToString(),
                            PACI_ENT = dr["PACI_ENT"].ToString(),
                    
                            PACI_PROF = dr["PACI_PROF"].ToString(),
                         
                            PACI_COMEN = dr["PACI_COMEN"].ToString(),
                            PACI_HIST = dr["PACI_HIST"].ToString(),
                            PACI_REPRE = dr["PACI_REPRE"].ToString(),

                        }); 


                    }


                }
            }

            return oLista;
        }
        


        public bool Eliminar(Paciente obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from Paciente where PACI_COD=@PACI_COD";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@PACI_COD", obj.PACI_COD));
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
