using Nativo.Logica;
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
    public partial class Form7 : Form
    {
        public string _Mensaje;
        public string _nombre;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        public static class MyGlobals
        {

            public static int i;

        }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Codigo.Text = _Mensaje;
            PACI_COD.Text = _Mensaje;
            Nombre.Text = _nombre;
            mostrar_bitacora();

        }


        public void mostrar_bitacora()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id, PACI_COD, ABO_FECHA, ABO_PTAS,PRECIO_TRABAJO-ABO_PTAS AS Debe, PRECIO_TRABAJO, DESC_TRABAJO FROM Abonos WHERE PACI_COD= '" + av + "'", connect);
            DataSet ds = new DataSet();


            adap.Fill(ds);
            abonos.DataSource = ds.Tables[0];

            DataTable dt = (DataTable)abonos.DataSource;
            dt.DefaultView.RowFilter = "ABO_FECHA like '%" + filtrar.Text + "%'";
        }



        private void bitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {




            id.Text = abonos.CurrentRow.Cells[0].Value.ToString();
            PACI_COD.Text = abonos.CurrentRow.Cells[1].Value.ToString();
           
            ABO_FECHA.Text = abonos.CurrentRow.Cells[2].Value.ToString();
            ABO_PTAS.Text = abonos.CurrentRow.Cells[3].Value.ToString();
            debe.Text = abonos.CurrentRow.Cells[4].Value.ToString();
            PRECIO_TRABAJO.Text = abonos.CurrentRow.Cells[5].Value.ToString();
            DESC_TRABAJO.Text = abonos.CurrentRow.Cells[6].Value.ToString();



            /* DataSet ds1 = new DataSet();
           dp.Fill(ds1, "Persona");
           DataRow dr = ds1.Tables["Persona"].Rows[0];


                   byte[] result = (byte[])dr["Image"];

                   int ArraySize = result.GetUpperBound(0);
                   MemoryStream ms = new MemoryStream(result,0,ArraySize);
                   pictureBox1.Image = System.Drawing.Image.FromStream(ms);*/










        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int av;

            int av2;

            if (string.IsNullOrEmpty(ABO_PTAS.Text))
            {
                av = 0;
            }
            else
            {
                 av = int.Parse(ABO_PTAS.Text);
            }

            if (string.IsNullOrEmpty(PRECIO_TRABAJO.Text))
            {
                av2 = 0;
            }
            else
            {
                av2 = int.Parse(PRECIO_TRABAJO.Text);
            }

            Abonos objeto = new Abonos()
            {
                PACI_COD = PACI_COD.Text,
                ABO_FECHA = ABO_FECHA.Text,
                ABO_PTAS = av,
                PRECIO_TRABAJO= av2,
                DESC_TRABAJO= DESC_TRABAJO.Text

            };


            bool respuesta = AbonoLogica.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_bitacora();


            }
        }


        public void limpiar()
        {


            id.Text = null;
            ABO_FECHA.Text = null;
            ABO_PTAS.Text = null;
            PRECIO_TRABAJO.Text = null;
            DESC_TRABAJO.Text = null;
            textBox1.Text = null;
            debe.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {



            int av;
            int total = 0;
            int aporte ;
            int av2;

            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }


            if (string.IsNullOrEmpty(ABO_PTAS.Text)  )
            {
                av = 0;
               
  
            }
            else
            {
                

                if (string.IsNullOrEmpty(textBox1.Text)) 
                {
                    aporte = 0;
                }
                else
                {
                   aporte = int.Parse(textBox1.Text);
                }

                av = int.Parse(ABO_PTAS.Text);

                total = aporte + av;
            }


            if (string.IsNullOrEmpty(PRECIO_TRABAJO.Text))
            {
                av2 = 0;
            }
            else
            {
                av2 = int.Parse(PRECIO_TRABAJO.Text);
            }


         
            Abonos objeto = new Abonos()
            {
                id= MyGlobals.i, 
                ABO_FECHA = ABO_FECHA.Text,
                ABO_PTAS = total,
                PRECIO_TRABAJO = av2,
                DESC_TRABAJO = DESC_TRABAJO.Text

            };


            bool respuesta = AbonoLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_bitacora();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }
            Abonos objeto = new Abonos()
            {
                id = MyGlobals.i,
         

            };


            bool respuesta = AbonoLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_bitacora();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void ABO_PTAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
          
        }

        private void PRECIO_TRABAJO_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        
        }

        private void PRECIO_TRABAJO_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABO_PTAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20),stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

            e.Graphics.DrawString("Codigo:" + PACI_COD.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("Nombre:" + Nombre.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:" + ABO_FECHA.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--Abono--", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Aporte:" +ABO_PTAS.Text +"$", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Precio del trabajo:" + PRECIO_TRABAJO.Text +"$", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("Debe:" + debe.Text+"$", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString("--Descripcion del Trabajo--", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20),stringFormat);
            e.Graphics.DrawString( DESC_TRABAJO.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


        }


        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);

            e.Graphics.DrawString("Codigo:" + PACI_COD.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("Nombre:" + Nombre.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            string g1 = "Fecha";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 80, 140);

            string g2 = "Aportes";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 250, 140);

            string g3 = "Precio trabajo";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 400, 140);

            string g4 = "Desc Trabajo";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 600, 140);



            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < abonos.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= abonos.Rows.Count)
                    {

                        height += abonos.Rows[0].Height;
                        e.Graphics.DrawString(abonos.Rows[l].Cells[2].FormattedValue.ToString(), abonos.Font = new Font("Book Antiqua", 11), Brushes.Black, new RectangleF(80, height, abonos.Columns[0].Width, abonos.Rows[0].Height));
                        e.Graphics.DrawString(abonos.Rows[l].Cells[3].FormattedValue.ToString(), abonos.Font = new Font("Book Antiqua", 12), Brushes.Black, new RectangleF(250, height, abonos.Columns[0].Width, abonos.Rows[0].Height));
                        e.Graphics.DrawString(abonos.Rows[l].Cells[5].FormattedValue.ToString(), abonos.Font = new Font("Book Antiqua", 12), Brushes.Black, new RectangleF(400, height, abonos.Columns[0].Width, abonos.Rows[0].Height));
                        e.Graphics.DrawString(abonos.Rows[l].Cells[6].FormattedValue.ToString(), abonos.Font = new Font("Book Antiqua", 11), Brushes.Black, new RectangleF(600, height, abonos.Columns[0].Width, abonos.Rows[0].Height));
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
            if (string.IsNullOrEmpty(id.Text))
            {

                printPreviewDialog2.Document = printDocument2;
                printPreviewDialog2.Show();

            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            mostrar_bitacora();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mostrar_bitacora();
        }
    }
}
