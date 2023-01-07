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

namespace Nativo
{
    public partial class Form9 : Form
    {
        public string _Mensaje;
        public string _nombre;

        public static class MyGlobals
        {

            public static int i;

        }

        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public Form9()
        {
            InitializeComponent();
        }

    

        private void Form9_Load(object sender, EventArgs e)
        {
            Codigo.Text = _Mensaje;
     
            Nombre.Text = _nombre;
            mostrar_receta();

        }



        public void mostrar_receta()
        {
            string av = _Mensaje;
     
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_COD,MEDICAMENTO,CANTIDAD,FECHA,INSTRUCCIONES FROM RECETA WHERE PACI_COD= '" + av + "' AND FECHA =(SELECT MAX(FECHA) FROM RECETA)", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            receta.DataSource = ds.Tables[0];

            DataTable dt = (DataTable)receta.DataSource;
          
        }

        public void limpiar()
        {


            ID.Text = null;
            MEDICAMENTO.Text = null;
            FECHA.Text = null;
            CNT.Text = null;
            INSTRUCCIONES.Text = null;
            ID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receta objeto = new Receta()
            {
                PACI_COD = Codigo.Text,
                MEDICAMENTO = MEDICAMENTO.Text,
                CANTIDADA = CNT.Text,
                FECHA= Convert.ToDateTime(FECHA.Value.Date.ToString("dd/MM/yyyy")),
                INSTRUCCIONES = INSTRUCCIONES.Text


            };


            bool respuesta = RecetaLogica.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_receta();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(ID.Text);
            }



           Receta objeto = new Receta()
            {
               id = MyGlobals.i,
               MEDICAMENTO = MEDICAMENTO.Text,
               CANTIDADA = CNT.Text,
               FECHA = Convert.ToDateTime(FECHA.Value.Date.ToString("dd/MM/yyyy")),
               INSTRUCCIONES = INSTRUCCIONES.Text


           };


            bool respuesta = RecetaLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_receta();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(ID.Text);
            }

            Bitacora objeto = new Bitacora()
            {
                id = MyGlobals.i,
            };


            bool respuesta = BitacoraLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_receta();
            }
        }

        private void receta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = receta.CurrentRow.Cells[0].Value.ToString();
            MEDICAMENTO.Text = receta.CurrentRow.Cells[2].Value.ToString();
            CNT.Text = receta.CurrentRow.Cells[3].Value.ToString();
            FECHA.Text = receta.CurrentRow.Cells[4].Value.ToString();
            INSTRUCCIONES.Text = receta.CurrentRow.Cells[5].Value.ToString();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

            e.Graphics.DrawString("Codigo:" + Codigo.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("Nombre:" + Nombre.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            string g1 = "Medicamento";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 80, 140);

            string g2 = "Cantidad";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 250, 140);

            string g3 = "Fecha";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 400, 140);

            string g4 = "Instrucciones";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 600, 140);



            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < receta.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= receta.Rows.Count)
                    {

                        height += receta.Rows[0].Height;
                        e.Graphics.DrawString(receta.Rows[l].Cells[2].FormattedValue.ToString(), receta.Font = new Font("Book Antiqua", 11), Brushes.Black, new RectangleF(80, height, receta.Columns[0].Width, receta.Rows[0].Height));
                        e.Graphics.DrawString(receta.Rows[l].Cells[3].FormattedValue.ToString(), receta.Font = new Font("Book Antiqua", 12), Brushes.Black, new RectangleF(250, height, receta.Columns[0].Width, receta.Rows[0].Height));
                        e.Graphics.DrawString(receta.Rows[l].Cells[4].FormattedValue.ToString(), receta.Font = new Font("Book Antiqua", 12), Brushes.Black, new RectangleF(400, height, receta.Columns[0].Width, receta.Rows[0].Height));
                        e.Graphics.DrawString(receta.Rows[l].Cells[5].FormattedValue.ToString(), receta.Font = new Font("Book Antiqua", 11), Brushes.Black, new RectangleF(600, height,receta.Columns[0].Width, receta.Rows[0].Height));
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 _ver = new Form10();



            if (string.IsNullOrEmpty(Codigo.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = Codigo.Text;
                _ver.Show();
            }
        }
    }
}
