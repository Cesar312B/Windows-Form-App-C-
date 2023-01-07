using Nativo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nativo
{
    public partial class Form10 : Form
    {
        public string _Mensaje;
    
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            mostrar_receta();
        }

        public void mostrar_receta()
        {
            string av = _Mensaje;

            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_COD,MEDICAMENTO,CANTIDAD,FECHA,INSTRUCCIONES FROM RECETA WHERE PACI_COD= '" + av + "' ORDER BY FECHA DESC", connect);
            DataSet ds = new DataSet();


            adap.Fill(ds);
            recetas.DataSource = ds.Tables[0];

            DataTable dt = (DataTable)recetas.DataSource;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
