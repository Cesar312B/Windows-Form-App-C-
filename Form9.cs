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
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Printing;

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
            /* SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_COD,FECHA,INSTRUCCIONES FROM RECETA WHERE PACI_COD= '" + av + "' AND FECHA =(SELECT MAX(FECHA) FROM RECETA)", connect);*/
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_COD,FECHA,INSTRUCCIONES FROM RECETA WHERE PACI_COD= '" + av + "'ORDER BY FECHA DESC  ", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            receta.DataSource = ds.Tables[0];
            DataTable dt = (DataTable)receta.DataSource;
            DataGridViewColumn column = receta.Columns[3];
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.DefaultView.RowFilter = "FECHA like '%" + filtrar.Text + "%'";
            

            


        }

        public void limpiar()
        {


            ID.Text = null;
            FECHA.Text = null;
            INSTRUCCIONES.Text = null;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receta objeto = new Receta()
            {
                PACI_COD = Codigo.Text,
                FECHA= FECHA.Text,
                INSTRUCCIONES = INSTRUCCIONES.Text


            };


           
            if (string.IsNullOrEmpty(ID.Text))
            {

                bool respuesta = RecetaLogica.Instancia.Guardar(objeto);
                limpiar();
                mostrar_receta();


            }
            else
            {
                MessageBox.Show("Limpie el formulario para crear un nuevo registro");
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
               FECHA = FECHA.Text,
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


            Receta objeto = new Receta()
            {
                id = MyGlobals.i,


            };


            bool respuesta = RecetaLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_receta();


            }
        }

        private void receta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = receta.CurrentRow.Cells[0].Value.ToString();
            FECHA.Text = receta.CurrentRow.Cells[2].Value.ToString();
            INSTRUCCIONES.Text = receta.CurrentRow.Cells[3].Value.ToString();

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

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
       

            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

        

            string s = INSTRUCCIONES.Text;
            s = s.Replace(".", ".\n");
            Bitmap bm = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0,0, pictureBox1.Width, pictureBox1.Height));
          
            e.Graphics.DrawImage(bm,
                     (e.PageBounds.Width - bm.Width) / 2,
                     bm.Width
                  );
            bm.Dispose();
            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

            e.Graphics.DrawString("Codigo:" + Codigo.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));
            e.Graphics.DrawString("Nombre:" + Nombre.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:" + FECHA.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));
            e.Graphics.DrawString("--Receta--", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString(s, tipotexto, Brushes.Black, new RectangleF(30, y += 20, 800, 500));
            e.Graphics.DrawString("Calle Bolívar y Ayacucho Centro Comercial Muñoz OF:207", tipotexto, Brushes.Black, new Rectangle(0, y += 700, ancho, 20), stringFormat);
            e.Graphics.DrawString("Tel:985097 Celular-WhatsApp:0994144713", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

        }

       

        private  void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Establecer margen de página
    

            // Dibujar un salto de línea
            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;



            string s = INSTRUCCIONES.Text;
            s = s.Replace(".", ".\n");
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            e.Graphics.DrawImage(bm,
                     (800 - bm.Width),
                     30
                  );
            bm.Dispose();
      
            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(30, y += 20, ancho, 20), stringFormat);
            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Codigo:" + Codigo.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));

            e.Graphics.DrawString("Nombre:" + Nombre.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:" + FECHA.Text, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));

            e.Graphics.DrawString("--Receta--", tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString(s, tipotexto, Brushes.Black, new RectangleF(30, y += 20, ancho, 600));
            e.Graphics.DrawString("Calle Bolívar y Ayacucho Centro Comercial Muñoz OF:207", tipotexto, Brushes.Black, new Rectangle(0, y += 700, ancho, 20), stringFormat);
            e.Graphics.DrawString("Tel:985097 Celular-WhatsApp:0994144713", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                MessageBox.Show("Elija un receta");

                return;
            }
            else
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
                printPreviewDialog2.Document =printDocument;
                printPreviewDialog2.ShowDialog(); 
            }
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

        private void INSTRUCCIONES_TextChanged(object sender, EventArgs e)
        {
            INSTRUCCIONES.ScrollBars = ScrollBars.Both;
            INSTRUCCIONES.WordWrap = false;
        }

        private void receta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            mostrar_receta();
        }
    }
}
