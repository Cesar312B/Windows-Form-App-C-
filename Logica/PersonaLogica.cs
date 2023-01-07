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
    public class PersonaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PersonaLogica _instancia = null;

        public PersonaLogica()
        {

        }

        public static PersonaLogica Instancia
        {
            get {
                if (_instancia == null)
                {
                    _instancia = new PersonaLogica();
                }

                return _instancia;
            }


        }


        public bool Guardar(Persona obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {
                conexion.Open();

                string query = "insert into Persona (Nombre,Apellido,Telefono,Image) values (@nombre,@apellido,@telefono,@image)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@image", obj.Image));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
        
            }
            return respuesta;
        }

        
        public List<Persona> Listar()
        {
            List<Persona> oLista = new List<Persona>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))

            {
                conexion.Open();
                string query = "select id,Nombre,Apellido,Telefono from Persona";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Persona()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            


                    });


                    }


                }
            }

            return oLista;
        }


    


        public bool Editar(Persona obj) {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena)){
                conexion.Open();
                string query = "Update Persona set Nombre = @nombre,Apellido = @apellido,Telefono = @telefono ,Image= @image where Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@image", obj.Image));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                   respuesta = false;

                }
                    

            }
            return respuesta;


        }


        public bool Eliminar(Persona obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from Persona where Id = @id";
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
