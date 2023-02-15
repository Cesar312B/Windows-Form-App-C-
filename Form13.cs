using Nativo.Logica;
using Nativo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Nativo
{
    public partial class Form13 : Form
    {

        public string _Mensaje;
        public string _cedula;
        public string _nombre;
        public string _edad;
        public string _direccion;
        public string _telefono;
        public string _profesion;

        public static class MyGlobals
        {

            public static int i;

        }
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            codigo.Text = _Mensaje;
            Nombre.Text = _nombre;
            cedula.Text = _cedula;
            mostrar_certificado();
        }



        public void mostrar_certificado()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,FECHA,ENFERMEDAD, DESCRIPCION,RECOMENDACION  FROM CERTIFICADO WHERE PACI_COD= '" + av + "'", connect);
            DataSet ds = new DataSet();


            adap.Fill(ds);
            certificados.DataSource = ds.Tables[0];
            DataTable dt = (DataTable)certificados.DataSource;
            certificados.Columns[0].Visible = false;
            dt.DefaultView.RowFilter = "FECHA like '%" + filtrar.Text + "%'";
            DataGridViewColumn column = certificados.Columns[3];
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewColumn column2 = certificados.Columns[4];
            column2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            certificados.Columns[0].Visible = false;
        }


        public void limpiar()
        {


            id.Text = null;
            descripcion.Text = null;
            fecha.Text = null;
            descripcion.Text = null;
            enfermedad.Text = null;
            recomendacion.Text = null;
            filtrar.Text = null;
            id.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Certificado objeto = new Certificado()
            {
                PACI_COD = codigo.Text,
                FECHA = fecha.Text,
                ENFERMEDAD = enfermedad.Text,
                DESCRIPCION= descripcion.Text,
                RECOMENDACION= recomendacion.Text,

            };



            if (string.IsNullOrEmpty(id.Text))
            {
                bool respuesta = CertificadoLogica.Instancia.Guardar(objeto);
                limpiar();
                mostrar_certificado();


            }
            else
            {
                MessageBox.Show("Limpie el formulario para crear un nuevo registro");
            }
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            mostrar_certificado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }



            Certificado objeto = new Certificado()
            {
                id = MyGlobals.i,
                FECHA = fecha.Text,
                ENFERMEDAD= enfermedad.Text,
                DESCRIPCION= descripcion.Text,
                RECOMENDACION=recomendacion.Text,

            };


            bool respuesta = CertificadoLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_certificado();

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

            Certificado objeto = new Certificado()
            {
                id = MyGlobals.i,
            };


            bool respuesta = CertificadoLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_certificado();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void certificados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = certificados.CurrentRow.Cells[0].Value.ToString();
            fecha.Text = certificados.CurrentRow.Cells[1].Value.ToString();
            enfermedad.Text = certificados.CurrentRow.Cells[2].Value.ToString();
            descripcion.Text = certificados.CurrentRow.Cells[3].Value.ToString();
            recomendacion.Text = certificados.CurrentRow.Cells[4].Value.ToString();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {
            descripcion.ScrollBars = ScrollBars.Both;
            descripcion.WordWrap = false;
        }

        private void recomendacion_TextChanged(object sender, EventArgs e)
        {
            recomendacion.ScrollBars = ScrollBars.Both;
            recomendacion.WordWrap = false;
        }

        private void certificados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Establecer margen de página


            // Dibujar un salto de línea
            Font tipotexto = new Font("Arial", 14, FontStyle.Italic);
            Font tipotexto2 = new Font("Arial", 11, FontStyle.Italic);
            Font tipotexto3 = new Font("Arial", 10, FontStyle.Italic);
            int ancho = 900;
            int y = 20;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            StringFormat stringFormat2 = new StringFormat();
            stringFormat2.Alignment = StringAlignment.Near;
            stringFormat2.LineAlignment = StringAlignment.Near;

            string s = "Certifico que,"+Nombre.Text+" de "+_edad+" de edad,con CI:"+_cedula+",Actividad Laboral:"+_profesion+",Dirección:"+_direccion+" y Telf:"+_telefono+".Asiste a la consulta odotológica el dia"+fecha.Text+".Con el diagnóstico de "+enfermedad.Text+" y los siguientes síntomas:"+descripcion.Text+"."+"Se recomienda "+recomendacion.Text+".Para lo cual reitero hacer el uso de la presente documento para fines que creyere conveniente.Atentamente;";
            s = s.Replace(".", ".\n");

            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            e.Graphics.DrawImage(bm,
                     (800 - bm.Width),
                     30
                  );
            bm.Dispose();

            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString(fecha.Text, tipotexto3, Brushes.Black, new Rectangle(20, y += 20, ancho, 20), stringFormat2);
            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CERTIFICADO ODONTOLÓGICO", tipotexto, Brushes.Black, new Rectangle(0, y += 35, ancho, 20), stringFormat);
            e.Graphics.DrawString(s, tipotexto2, Brushes.Black, new RectangleF(20, y += 30, 800, 500));
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 500, ancho, 20), stringFormat);
            e.Graphics.DrawString("Implantólo-Orotodenciasta", tipotexto, Brushes.Black, new Rectangle(0, y += 40, ancho, 20), stringFormat);
            e.Graphics.DrawString("MSP-LIBRO:10 FOLIO:81 N-249", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Dr Byron Aníbal Almeida Revelo", tipotexto, Brushes.Black, new Rectangle(0, y += 50, ancho, 20), stringFormat);
            e.Graphics.DrawString("040061073-9", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("byronalr@yahoo.com", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Calle Bolívar y Ayacucho Centro Comercial Muñoz OF:207", tipotexto, Brushes.Black, new Rectangle(0, y += 200, ancho, 20), stringFormat);
            e.Graphics.DrawString("Tel:985097 Celular-WhatsApp:0994144713", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);







        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Elija un registro");

                return;
            }
            else
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
                printPreviewDialog1.Document = printDocument;
                printPreviewDialog1.ShowDialog();
            }
        }
    }
}
