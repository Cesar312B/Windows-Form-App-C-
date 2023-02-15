using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nativo.Modelo;
using Nativo.Logica;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Nativo
{
    public partial class Form11 : Form
    {

        public string _Mensaje;
        public string _nombre;

        public static class MyGlobals
        {

            public static int i;
            public static byte[] archivo1;
       

        }


        /*protected OpenFileDialog _openFileDialog = new OpenFileDialog();*/



        protected OpenFileDialog openFileDialog1 = new OpenFileDialog();
        


      

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            codigo.Text = _Mensaje;
            Nombre.Text = _nombre;
            mostrar_images();
        }


        public void mostrar_images()
        {
            string av = _Mensaje;
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,PACI_FOTO,FECHA  FROM Images WHERE PACI_COD= '" + av + "'", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            images.DataSource = ds.Tables[0];
            ((DataGridViewImageColumn)images.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            images.Columns[1].Width = 120;
            images.Columns[0].Visible = false;
            DataTable dt = (DataTable)images.DataSource;
            dt.DefaultView.RowFilter = "FECHA like '%" + filtrar.Text + "%'";
            count.Text = dt.Rows.Count.ToString();




        }

        public void limpiar()
        {


            id.Text = null;
            dateTimePicker1.Text = null;
            pictureBox1.Image = null;
            MyGlobals.archivo1 = null;

       

        }

        private void images_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = images.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = images.CurrentRow.Cells[2].Value.ToString();


            string av5;

            av5 = images.CurrentRow.Cells[0].Value.ToString();
            string cadena3 = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect3 = new SQLiteConnection(cadena3);
            SQLiteCommand command2 = new SQLiteCommand("SELECT PACI_FOTO FROM Images WHERE id ='" + av5 + "'", connect3);
            SQLiteDataAdapter dp2 = new SQLiteDataAdapter(command2);
            DataSet ds5 = new DataSet("Images");

            dp2.Fill(ds5, "Images");
            DataRow myRow2 = ds5.Tables["Images"].Rows[0];





            if (myRow2["PACI_FOTO"] != DBNull.Value)
            {
                MyGlobals.archivo1 = (byte[])myRow2["PACI_FOTO"];

                MemoryStream ms = new MemoryStream(MyGlobals.archivo1);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);



            }
            else
            {

                MyGlobals.archivo1 = null;
                pictureBox1.Image = null;
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

            Images objeto = new Images()
            {
                id = MyGlobals.i,
                FECHA = dateTimePicker1.Text,
                PACI_FOTO= MyGlobals.archivo1

            };


            bool respuesta = ImagesLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_images();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Images objeto = new Images()
            {
                PACI_COD = codigo.Text,
                FECHA = dateTimePicker1.Text,
                PACI_FOTO = MyGlobals.archivo1,
          

            };



            if (string.IsNullOrEmpty(id.Text))
            {
                bool respuesta = ImagesLogica.Instancia.Guardar(objeto);
                limpiar();
                mostrar_images();


            }
            else
            {
                MessageBox.Show("Limpie el formulario para crear un nuevo registro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen desde el archivo seleccionado en el diálogo de archivo
                System.Drawing.Image img = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                // Comprueba si la imagen tiene información de orientación
                if (img.PropertyIdList.Contains(0x0112)) // El valor 0x0112 corresponde al código de propiedad de orientación
                {
                    // Obtiene el valor de orientación de la imagen
                    var prop = img.GetPropertyItem(0x0112);
                    var orientation = (int)prop.Value[0];

                    // Corrige la orientación de la imagen si es necesario
                    switch (orientation)
                    {
                        case 2:
                            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            break;
                        case 3:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 4:
                            img.RotateFlip(RotateFlipType.Rotate180FlipX);
                            break;
                        case 5:
                            img.RotateFlip(RotateFlipType.Rotate90FlipX);
                            break;
                        case 6:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 7:
                            img.RotateFlip(RotateFlipType.Rotate270FlipX);
                            break;
                        case 8:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                        default:
                            break;
                    }

                    // Establece la propiedad de orientación de la imagen a su valor predeterminado
                    prop.Value = BitConverter.GetBytes((short)1);
                    img.SetPropertyItem(prop);
                }

                // Guarda la imagen corregida en el archivo
                

                pictureBox1.Image = new Bitmap(img);
                Stream Mystrem1 = openFileDialog1.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);
                MyGlobals.archivo1 = obj1.ToArray();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Eliga un REGISTRO");
            }
            else
            {

                MyGlobals.i = int.Parse(id.Text);
            }

            Images objeto = new Images()
            {
                id = MyGlobals.i,
            };


            bool respuesta = ImagesLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_images();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            mostrar_images();
        }

        private void FullScreenImage(System.Drawing.Image imageToShow)
        {
            Form12 fullScreenForm = new Form12()
            {
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.Sizable,
                BackgroundImage = imageToShow,
                BackgroundImageLayout = ImageLayout.Zoom
            };

         

            fullScreenForm.ShowDialog();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }
    }
}
