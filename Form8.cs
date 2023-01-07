using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using Nativo.Modelo;

namespace Nativo
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

   

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        public void login()
        {

          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usuario.Text.Trim() == "" && contraseña.Text.Trim() =="")
            {
                MessageBox.Show("Relllene los Campos", "Error");
            }
            else
            {
                string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

                SQLiteConnection connect = new SQLiteConnection(cadena);
                connect.Open();

                string query= "SELECT * FROM usuario WHERE nom_user=@nom_user AND clave_user=@clave_user";
                SQLiteCommand cmd = new SQLiteCommand(query, connect);
                cmd.Parameters.AddWithValue("@nom_user", usuario.Text);
                cmd.Parameters.AddWithValue("@clave_user", contraseña.Text);
                SQLiteDataAdapter adap = new SQLiteDataAdapter(cmd);
                DataTable ds = new DataTable();
                adap.Fill(ds);

                if (ds.Rows.Count > 0)
                {


                    Form2 _ver = new Form2();
                    _ver.Show();
                    this.Hide();
                   
                    MessageBox.Show("Estas logeado", "Login Seccessful");
                }
                else
                {
                    MessageBox.Show("Error login", "Error");
                }

            }
           
        }
    }
}
