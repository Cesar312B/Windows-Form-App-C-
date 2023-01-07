using Nativo.Logica;
using Nativo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nativo
{
    public partial class Form5 : Form
    {
        public string _Mensaje;
        public string _nombre;

        public static class MyGlobals
        {
            public static byte[] archivo1;


        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            mostrar_foto();
        }

        public void mostrar_foto()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO2  FROM Paciente WHERE PACI_COD= '" + av + "'", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            PACI_FOTO2.DataSource = ds.Tables[0];

            DataTable dt = (DataTable)PACI_FOTO2.DataSource;
            ((DataGridViewImageColumn)PACI_FOTO2.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;


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

                PACI_COD = av,
                PACI_FOTO2 = MyGlobals.archivo1,
            };



            bool respuesta = PacienteLogica.Instancia.Editar_foto3(objeto);
            if (respuesta)
            {

                mostrar_foto();
            }
        }
    }
}
