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
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using Image = System.Drawing.Image;

namespace Nativo
{
    public partial class Form1 : Form
    {
        public string _Mensaje;
        public string _nombre;

        public static class MyGlobals
        {
          
            public static int i;

        }

        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            codigo.Text = _Mensaje;
            codigo2.Text = _Mensaje;
            nombre.Text = _nombre;
            mostrar_bitacora();
           
        }

        public void mostrar_bitacora()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_COD,BIT_FECHA,BIT_DES AS Material  FROM BITACORA WHERE PACI_COD= '" + av + "'", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            bitacora.DataSource = ds.Tables[0];
            DataTable dt = (DataTable)bitacora.DataSource;
            bitacora.Columns[1].Visible = false;
            dt.DefaultView.RowFilter = "BIT_FECHA like '%" + filtrar.Text + "%'";
        }


        public Form1()
        {
            InitializeComponent();
            
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      


     

        private void btnguardar_Click(object sender, EventArgs e)
        {

            
            Bitacora objeto = new Bitacora() { 
            PACI_COD =codigo2.Text ,
            BIT_FECHA = fecha.Text,
            BIT_DES= descripcion.Text,
           
            };


              
            if  (string.IsNullOrEmpty(id.Text))
            {
                bool respuesta = BitacoraLogica.Instancia.Guardar(objeto);
                limpiar();
                mostrar_bitacora();


            }
            else
            {
                MessageBox.Show("Limpie el formulario para crear un nuevo registro");
            }

        }

        public void limpiar()
        {


            id.Text = null;
            descripcion.Text = null;
            fecha.Text = null;
            fecha_t.Focus();
        }
  



      

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }



                Bitacora objeto = new Bitacora()
            {
                id = MyGlobals.i,
                BIT_FECHA = fecha.Text,
                BIT_DES = descripcion.Text,

            };


            bool respuesta = BitacoraLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_bitacora();

            }




        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }

            Bitacora objeto = new Bitacora()
            {
                id = MyGlobals.i,
            };


            bool respuesta = BitacoraLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_bitacora();
            }

        }

      

        private void bitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

          
         
            id.Text = bitacora.CurrentRow.Cells[0].Value.ToString();
            codigo2.Text = bitacora.CurrentRow.Cells[1].Value.ToString();
            fecha.Text = bitacora.CurrentRow.Cells[2].Value.ToString();
            descripcion.Text = bitacora.CurrentRow.Cells[3].Value.ToString();


            /* DataSet ds1 = new DataSet();
           dp.Fill(ds1, "Persona");
           DataRow dr = ds1.Tables["Persona"].Rows[0];


                   byte[] result = (byte[])dr["Image"];

                   int ArraySize = result.GetUpperBound(0);
                   MemoryStream ms = new MemoryStream(result,0,ArraySize);
                   pictureBox1.Image = System.Drawing.Image.FromStream(ms);*/










        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

       


        

    

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
        




        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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

            e.Graphics.DrawString("Codigo:" + codigo.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("Nombre:" + nombre.Text, tipotexto, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            string g1 = "Descripcion";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 80, 140);

            string g2 = "Fecha";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Black, 250, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < bitacora.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= bitacora.Rows.Count)
                    {

                        height += bitacora.Rows[0].Height;
                        e.Graphics.DrawString(bitacora.Rows[l].Cells[3].FormattedValue.ToString(), bitacora.Font = new Font("Book Antiqua", 11), Brushes.Black, new RectangleF(80, height, bitacora.Columns[0].Width,bitacora.Rows[0].Height));
                        e.Graphics.DrawString(bitacora.Rows[l].Cells[2].FormattedValue.ToString(), bitacora.Font = new Font("Book Antiqua", 12), Brushes.Black, new RectangleF(250, height, bitacora.Columns[0].Width, bitacora.Rows[0].Height));
                
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
            e.Graphics.DrawString("AR Dental Tulcán", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Byron Almeida Odontologo", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString("Codigo:" + codigo.Text, tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nombre:" + nombre.Text, tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("----Bitacora----", tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20), stringFormat);
            e.Graphics.DrawString( descripcion.Text +" "+ fecha.Text, tipotexto, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
      


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {

                printPreviewDialog2.Document = printDocument1;
                printPreviewDialog2.ShowDialog();

            }
            else
            {
                printPreviewDialog1.Document = printDocument2;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            mostrar_bitacora();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mostrar_bitacora();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
