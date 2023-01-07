using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nativo.Modelo;
using Nativo.Logica;
using System.Configuration;
using System.Data.SQLite;
using static Nativo.Modelo.Form2;
using System.IO;

namespace Nativo
{
    public partial class Form3 : Form
    {
        public string _Mensaje;
        public string _nombre;


        public static class MyGlobals
        {
            public static byte[] archivo1;
        

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mostrar_foto();
        }

        public void mostrar_foto()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO  FROM Paciente WHERE PACI_COD= '" + av + "'", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            PACI_FOTO.DataSource = ds.Tables[0];

            DataTable dt = (DataTable)PACI_FOTO.DataSource;

            ((DataGridViewImageColumn)PACI_FOTO.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog1.FilterIndex = 1;


            openFileDialog1.ShowDialog();



            if (File.Exists(openFileDialog1.FileName))
            {


                Stream Mystrem1 = openFileDialog1.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);

                MyGlobals.archivo1 = obj1.ToArray();




            }
            string av = _Mensaje;

            Paciente objeto = new Paciente()
            {
              
               PACI_COD=av,
               PACI_FOTO = MyGlobals.archivo1,
              

            };



            bool respuesta = PacienteLogica.Instancia.Editar_foto1(objeto);
            if (respuesta)
            {
               
                mostrar_foto();
            }
        }
    }
}
