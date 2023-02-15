using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Nativo.Modelo;
using Nativo.Logica;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;


namespace Nativo.Modelo
{
    public partial class Form2 : Form
    {
        protected OpenFileDialog _openFileDialog = new OpenFileDialog();

        protected OpenFileDialog _openFileDialog1 = new OpenFileDialog();

        protected OpenFileDialog _openFileDialog2 = new OpenFileDialog();

        protected OpenFileDialog _openFileDialog3 = new OpenFileDialog();

        public static class MyGlobals
        {
            public static byte[] archivo1;
            public static byte[] archivo2;
            public static byte[] archivo3;
            public static byte[] archivo4;

        }
    

        private void PACI_FOTO_Click(object sender, EventArgs e)
        {
            _openFileDialog.Filter ="Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            _openFileDialog.FilterIndex = 1;
            _openFileDialog.RestoreDirectory = true;
    
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //some code
                Image img = Image.FromFile(_openFileDialog.FileName);

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
                Stream Mystrem1 = _openFileDialog.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);
                MyGlobals.archivo1 = obj1.ToArray();

            }


        }

        private void PACI_FOTO2_Click(object sender, EventArgs e)
        {
            _openFileDialog1.Filter ="Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            _openFileDialog1.FilterIndex = 1;
            _openFileDialog1.RestoreDirectory = true;
            if (_openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //some code
                //some code
                Image img = Image.FromFile(_openFileDialog1.FileName);

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

                pictureBox2.Image = new Bitmap(img);
                Stream Mystrem1 = _openFileDialog1.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);

                MyGlobals.archivo2 = obj1.ToArray();
            }



        }

        private void PACI_FOTO_ORTO_Click(object sender, EventArgs e)
        {
            _openFileDialog2.Filter ="Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            _openFileDialog2.FilterIndex = 1;
            _openFileDialog2.RestoreDirectory = true;
   
            if (_openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //some code

                //some code
                Image img = Image.FromFile(_openFileDialog2.FileName);

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

                pictureBox3.Image = new Bitmap(img);
                Stream Mystrem1 = _openFileDialog2.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);

                MyGlobals.archivo3 = obj1.ToArray();
            }

        }

        private void PACI_FOTO_ORTO2_Click(object sender, EventArgs e)
        {

            _openFileDialog3.Filter ="Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            _openFileDialog3.FilterIndex = 1;
            _openFileDialog3.RestoreDirectory = true;
            if (_openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                //some code


                //some code
                Image img = Image.FromFile(_openFileDialog3.FileName);

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

                pictureBox4.Image = new Bitmap(img);
                Stream Mystrem1 = _openFileDialog3.OpenFile();
                MemoryStream obj1 = new MemoryStream();
                Mystrem1.CopyTo(obj1);

                MyGlobals.archivo4 = obj1.ToArray();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            mostrar_pacientes();




        }

        public Form2()
        {
            InitializeComponent();
            
        }

  

   



      

        public void mostrar_pacientes()
        {

            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT  PACI_COD,DNI,PACI_NOM FROM Paciente ORDER BY id DESC", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            dbpacientes.DataSource = ds.Tables[0];
           

            DataTable dt = (DataTable)dbpacientes.DataSource;

            dt.DefaultView.RowFilter = "PACI_COD like '%" + buscar_nombre.Text + "%'"+ "OR PACI_NOM like '%" + buscar_nombre.Text + "%'"+ "OR DNI like '%" + buscar_nombre.Text + "%'";

            count.Text = dt.Rows.Count.ToString();

         
        }

       



        private void dbpacientes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dbpacientes.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 3);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)

        {
            var bounds = Screen.FromControl(this).Bounds;
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            mostrar_pacientes();
       


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int EdadPersona(DateTime FechaNacimiento)
        {
            if (FechaNacimiento.Year == DateTime.Today.Year )
                return 0;

            return 1 + EdadPersona(FechaNacimiento.AddYears(1));
        }



        
  
    


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PACI_COD.Text = dbpacientes.CurrentRow.Cells[0].Value.ToString();
            PACI_NOM.Text = dbpacientes.CurrentRow.Cells[2].Value.ToString();
         
           



            string av;

            av = dbpacientes.CurrentRow.Cells[0].Value.ToString();
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect = new SQLiteConnection(cadena);
            SQLiteCommand command = new SQLiteCommand("SELECT PACI_NACI, PACI_SEXO, PACI_DIR, PACI_LOCAL, PACI_TELEF, PACI_ENT, PACI_PROF, PACI_COMEN, PACI_HIST, PACI_REPRE, DNI FROM Paciente WHERE PACI_COD ='" + av + "'", connect);
            SQLiteDataAdapter dp = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet("Paciente");


            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
            SQLiteDataAdapter adap1 = new SQLiteDataAdapter("SELECT PACI_FOTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
            SQLiteDataAdapter adap2 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
            SQLiteDataAdapter adap3 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);


            DataSet ds1 = new DataSet();
            adap.Fill(ds1);

            DataSet ds2 = new DataSet();
            adap1.Fill(ds2);

            DataSet ds3 = new DataSet();
            adap2.Fill(ds3);

            DataSet ds4 = new DataSet();
            adap3.Fill(ds4);



            dataGridView2.RowTemplate.Height = 220;
            dataGridView2.ColumnHeadersVisible = false;

            dataGridView2.DataSource = ds1.Tables[0];

            DataTable dt = (DataTable)dataGridView2.DataSource;

            DataGridViewColumn column = dataGridView2.Columns[0];
            dataGridView2.Columns[1].Visible = false;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewImageColumn)dataGridView2.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView4.RowTemplate.Height = 220;
            dataGridView4.ColumnHeadersVisible = false;
            dataGridView4.DataSource = ds2.Tables[0];
            DataTable dt2 = (DataTable)dataGridView4.DataSource;
            DataGridViewColumn column2 = dataGridView4.Columns[0];
            dataGridView4.Columns[1].Visible = false;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewImageColumn)dataGridView4.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DataSource = ds3.Tables[0];
            DataTable dt3 = (DataTable)dataGridView1.DataSource;

            DataGridViewColumn column3 = dataGridView1.Columns[0];
            dataGridView1.Columns[1].Visible = false;
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewImageColumn)dataGridView1.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView3.RowTemplate.Height = 150;
            dataGridView3.ColumnHeadersVisible = false;
            
            dataGridView3.DataSource = ds4.Tables[0];

            DataTable d4 = (DataTable)dataGridView3.DataSource;

            DataGridViewColumn column4 = dataGridView3.Columns[0];
            dataGridView3.Columns[1].Visible = false;
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewImageColumn)dataGridView3.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;


            dp.Fill(ds, "Paciente");
            DataRow myRow = ds.Tables["Paciente"].Rows[0];
            if (myRow["PACI_NACI"] != DBNull.Value )
            {


                dateTimePicker1.Text = (string)myRow["PACI_NACI"];
             
                edad.Text = string.Format("{0} años", EdadPersona(dateTimePicker1.Value));

            }
            else 
            {
              
                dateTimePicker1.Text = null;
            

                edad.Text = "Sin datos";


            }

            if ( myRow["PACI_SEXO"] != DBNull.Value)
            {
     
                PACI_SEXO.Text = (string)myRow["PACI_SEXO"];
          

            }
            else
            {

                PACI_SEXO.Text = null;

            }

            if ( myRow["PACI_DIR"] != DBNull.Value)
            {

                PACI_DIR.Text = (string)myRow["PACI_DIR"];
    
            }
            else
            {

                PACI_DIR.Text = null;

            }




            if (myRow["PACI_LOCAL"] != DBNull.Value )
            {

                PACI_LOCAL.Text = (string)myRow["PACI_LOCAL"];
             

             

                
            }
            else 
            {

         
                PACI_LOCAL.Text = null;
        
            }


            if ( myRow["PACI_TELEF"] != DBNull.Value )
            {

                
                PACI_TELEF.Text = (string)myRow["PACI_TELEF"];
            
                




            }
            else
            {

             
                
                PACI_TELEF.Text = null;
            
            }


            if (myRow["PACI_ENT"] != DBNull.Value)
            {

   
                dateTimePicker2.Text = (string)myRow["PACI_ENT"];
                entrada.Text = string.Format("{0} años", EdadPersona(dateTimePicker2.Value));




            }
            else
            {

                entrada.Text = "Sin datos";
              
                dateTimePicker2.Text = null;
            }


            if (myRow["PACI_PROF"] != DBNull.Value )
            {

                
                PACI_PROF.Text = (string)myRow["PACI_PROF"];

           



            }
            else
            {
                PACI_PROF.Text = null;

      

            }


         

            if (myRow["PACI_REPRE"] != DBNull.Value )
            {
               

                PACI_REPRE.Text = (string)myRow["PACI_REPRE"];
             


            }
            else
            {
                PACI_REPRE.Text = null;
                

            }

            if ( myRow["PACI_COMEN"] != DBNull.Value )
            {


             
                PACI_COMEN.Text = (string)myRow["PACI_COMEN"];
        


            }
            else
            {
               
                PACI_COMEN.Text = null;
              

            }

            if ( myRow["PACI_HIST"] != DBNull.Value)
            {


                PACI_HIST.Text = (string)myRow["PACI_HIST"];


            }
            else
            {
                PACI_HIST.Text = null;

            }


            if (myRow["DNI"] != DBNull.Value)
            {


                DNI.Text = (string)myRow["DNI"];


            }
            else
            {
                DNI.Text = null;

            }

       
         
            string av5;
           
            av5 = dbpacientes.CurrentRow.Cells[0].Value.ToString();
            string cadena3 = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect3 = new SQLiteConnection(cadena3);
            SQLiteCommand command2 = new SQLiteCommand("SELECT PACI_FOTO,PACI_FOTO_ORTO,PACI_FOTO2,PACI_FOTO_ORTO2 FROM Paciente WHERE PACI_COD ='" + av5 + "'", connect3);
            SQLiteDataAdapter dp2 = new SQLiteDataAdapter(command2);
            DataSet ds5 = new DataSet("Paciente");

            dp2.Fill(ds5, "Paciente");
            DataRow myRow2 = ds5.Tables["Paciente"].Rows[0];
      




            if (myRow2["PACI_FOTO"] != DBNull.Value)
            {
                MyGlobals.archivo1 = (byte[])myRow2["PACI_FOTO"];





            }
            else
            {

                MyGlobals.archivo1 =null;
            }

            if (myRow2["PACI_FOTO2"] != DBNull.Value)
            {
                MyGlobals.archivo2 = (byte[])myRow2["PACI_FOTO2"];



            }
            else
            {
                MyGlobals.archivo2 = null;
            }



            if (myRow2["PACI_FOTO_ORTO"] != DBNull.Value)
            {
                MyGlobals.archivo3 = (byte[])myRow2["PACI_FOTO_ORTO"];



            }
            else
            {

                MyGlobals.archivo3 = null;
            }
            

         
           


            if (myRow2["PACI_FOTO_ORTO2"] != DBNull.Value)
            {
                MyGlobals.archivo4 = (byte[])myRow2["PACI_FOTO_ORTO2"];



            }
            else
            {
                MyGlobals.archivo4 = null;
            }
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect = new SQLiteConnection(cadena);




         






            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[4];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            Console.WriteLine(resultString);





            Paciente objeto = new Paciente()
            {
                PACI_COD = "ORTO"+resultString,
                PACI_NOM = PACI_NOM.Text,
                PACI_NACI= dateTimePicker1.Text,
                PACI_SEXO= PACI_SEXO.Text,
                PACI_DIR= PACI_DIR.Text,
                PACI_LOCAL= PACI_LOCAL.Text,
                PACI_TELEF= PACI_TELEF.Text,
                PACI_ENT= dateTimePicker2.Text,
                PACI_PROF= PACI_PROF.Text,
                PACI_REPRE= PACI_REPRE.Text,
                PACI_COMEN= PACI_COMEN.Text,
                PACI_HIST= PACI_HIST.Text,
                DNI = DNI.Text,
                PACI_FOTO = MyGlobals.archivo1,
                PACI_FOTO2= MyGlobals.archivo2,
                PACI_FOTO_ORTO= MyGlobals.archivo3,
                PACI_FOTO_ORTO2= MyGlobals.archivo4,
                
            };

           

            if (string.IsNullOrEmpty(PACI_COD.Text))
            {
                bool respuesta = PacienteLogica.Instancia.Guardar(objeto);
                
                mostrar_pacientes();
                string av;

                av = objeto.PACI_COD;

                SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap1 = new SQLiteDataAdapter("SELECT PACI_FOTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap2 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap3 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);


                DataSet ds1 = new DataSet();
                adap.Fill(ds1);

                DataSet ds2 = new DataSet();
                adap1.Fill(ds2);

                DataSet ds3 = new DataSet();
                adap2.Fill(ds3);

                DataSet ds4 = new DataSet();
                adap3.Fill(ds4);



                dataGridView2.RowTemplate.Height = 220;
                dataGridView2.ColumnHeadersVisible = false;

                dataGridView2.DataSource = ds1.Tables[0];

                DataTable dt = (DataTable)dataGridView2.DataSource;

                DataGridViewColumn column = dataGridView2.Columns[0];
                dataGridView2.Columns[1].Visible = false;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView2.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView4.RowTemplate.Height = 220;
                dataGridView4.ColumnHeadersVisible = false;
                dataGridView4.DataSource = ds2.Tables[0];
                DataTable dt2 = (DataTable)dataGridView4.DataSource;
                DataGridViewColumn column2 = dataGridView4.Columns[0];
                dataGridView4.Columns[1].Visible = false;
                column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView4.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.RowTemplate.Height = 150;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.DataSource = ds3.Tables[0];
                DataTable dt3 = (DataTable)dataGridView1.DataSource;

                DataGridViewColumn column3 = dataGridView1.Columns[0];
                dataGridView1.Columns[1].Visible = false;
                column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView1.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView3.RowTemplate.Height = 150;
                dataGridView3.ColumnHeadersVisible = false;

                dataGridView3.DataSource = ds4.Tables[0];

                DataTable d4 = (DataTable)dataGridView3.DataSource;

                DataGridViewColumn column4 = dataGridView3.Columns[0];
                dataGridView3.Columns[1].Visible = false;
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView3.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                limpiar2();

            }
            else
            {
                MessageBox.Show("Limpie el formulario para crear un nuevo registro");
            }



          
        }

        public void limpiar()
        {
            PACI_COD.Text = null;
            PACI_NOM.Text = null;
            PACI_SEXO.Text = null;
            PACI_DIR.Text = null;
            PACI_LOCAL.Text = null;
            PACI_TELEF.Text = null;
            PACI_PROF.Text = null;
            dateTimePicker1.Text = null;
            PACI_REPRE.Text = null;
            PACI_COMEN.Text = null;
            PACI_HIST.Text = null;
            dateTimePicker2.Text = null;
            edad.Text = null;
            entrada.Text = null;
            DNI.Text = null;
            PACI_COD.Focus();
            PACI_FOTO.Text = "Foto de Perfil";
            PACI_FOTO2.Text = "Foto de Perfil 2";
            PACI_FOTO_ORTO.Text = "Foto Ortodental 1";
            PACI_FOTO_ORTO2.Text = "Foto Ortodental 2";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            MyGlobals.archivo1 = null;
            MyGlobals.archivo2 = null;
            MyGlobals.archivo3 = null;
            MyGlobals.archivo4 = null;

        }


        public void limpiar2()
        {
            PACI_COD.Text = null;
            PACI_NOM.Text = null;
            PACI_SEXO.Text = null;
            PACI_DIR.Text = null;
            PACI_LOCAL.Text = null;
            PACI_TELEF.Text = null;
            PACI_PROF.Text = null;
            dateTimePicker1.Text = null;
            PACI_REPRE.Text = null;
            PACI_COMEN.Text = null;
            PACI_HIST.Text = null;
            dateTimePicker2.Text = null;
            DNI.Text = null;
            MyGlobals.archivo1 = null;
            MyGlobals.archivo2 = null;
            MyGlobals.archivo3 = null;
            MyGlobals.archivo4 = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            PACI_FOTO.Text = "Foto de Perfil";
            PACI_FOTO2.Text = "Foto de Perfil 2";
            PACI_FOTO_ORTO.Text = "Foto Ortodental 1";
            PACI_FOTO_ORTO2.Text = "Foto Ortodental 2";
            edad.Text = null;
            entrada.Text = null;
            buscar_nombre.Text = null;


            DataTable dt = (DataTable)dataGridView2.DataSource;
            dt.Clear();

            DataTable dt1 = (DataTable)dataGridView4.DataSource;
            dt1.Clear();



            DataTable dt2 = (DataTable)dataGridView1.DataSource;
            dt2.Clear();


            DataTable dt3 = (DataTable)dataGridView3.DataSource;
            dt3.Clear();
            PACI_COD.Focus();





        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect = new SQLiteConnection(cadena);

            Paciente objeto = new Paciente()
            {
                PACI_COD = PACI_COD.Text,
                PACI_NOM = PACI_NOM.Text,
                PACI_NACI = dateTimePicker1.Text,
                PACI_SEXO = PACI_SEXO.Text,
                PACI_DIR = PACI_DIR.Text,
                PACI_LOCAL = PACI_LOCAL.Text,
                PACI_TELEF = PACI_TELEF.Text,
                PACI_ENT = dateTimePicker2.Text,
                PACI_PROF = PACI_PROF.Text,
                PACI_REPRE = PACI_REPRE.Text,
                PACI_COMEN = PACI_COMEN.Text,
                PACI_HIST = PACI_HIST.Text,
                DNI= DNI.Text,
                PACI_FOTO = MyGlobals.archivo1,
                PACI_FOTO2 = MyGlobals.archivo2,
                PACI_FOTO_ORTO = MyGlobals.archivo3,
                PACI_FOTO_ORTO2 = MyGlobals.archivo4,

            };
        
           



         
         

            if (!string.IsNullOrEmpty(PACI_COD.Text))
            {
                bool respuesta = PacienteLogica.Instancia.Editar(objeto);
                limpiar();
                mostrar_pacientes();
                string av;

                av = objeto.PACI_COD;

                SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap1 = new SQLiteDataAdapter("SELECT PACI_FOTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap2 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO,PACI_COD FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);
                SQLiteDataAdapter adap3 = new SQLiteDataAdapter("SELECT PACI_FOTO_ORTO2,PACI_COD  FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);


                DataSet ds1 = new DataSet();
                adap.Fill(ds1);

                DataSet ds2 = new DataSet();
                adap1.Fill(ds2);

                DataSet ds3 = new DataSet();
                adap2.Fill(ds3);

                DataSet ds4 = new DataSet();
                adap3.Fill(ds4);



                dataGridView2.RowTemplate.Height = 220;
                dataGridView2.ColumnHeadersVisible = false;

                dataGridView2.DataSource = ds1.Tables[0];

                DataTable dt = (DataTable)dataGridView2.DataSource;

                DataGridViewColumn column = dataGridView2.Columns[0];
                dataGridView2.Columns[1].Visible = false;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView2.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView4.RowTemplate.Height = 220;
                dataGridView4.ColumnHeadersVisible = false;
                dataGridView4.DataSource = ds2.Tables[0];
                DataTable dt2 = (DataTable)dataGridView4.DataSource;
                DataGridViewColumn column2 = dataGridView4.Columns[0];
                dataGridView4.Columns[1].Visible = false;
                column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView4.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.RowTemplate.Height = 150;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.DataSource = ds3.Tables[0];
                DataTable dt3 = (DataTable)dataGridView1.DataSource;

                DataGridViewColumn column3 = dataGridView1.Columns[0];
                dataGridView1.Columns[1].Visible = false;
                column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView1.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView3.RowTemplate.Height = 150;
                dataGridView3.ColumnHeadersVisible = false;

                dataGridView3.DataSource = ds4.Tables[0];

                DataTable d4 = (DataTable)dataGridView3.DataSource;

                DataGridViewColumn column4 = dataGridView3.Columns[0];
                dataGridView3.Columns[1].Visible = false;
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ((DataGridViewImageColumn)dataGridView3.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            else
            {
                MessageBox.Show("Eliga un paciente para editar");
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                PACI_COD = PACI_COD.Text,
            };
           
            if (!string.IsNullOrEmpty(PACI_COD.Text))
            {
                bool respuesta = PacienteLogica.Instancia.Eliminar(objeto);
                limpiar2();
                mostrar_pacientes();
            }
            else
            {
                MessageBox.Show("Eliga un paciente para elimianrlo");
            }
        }


        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
             string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT id,DNI,PACI_COD,PACI_NOM FROM Paciente ORDER BY id DESC", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            dbpacientes.DataSource = ds.Tables[0];
           

            DataTable dt = (DataTable)dbpacientes.DataSource;



            count.Text = dt.Rows.Count.ToString();

            dt.DefaultView.RowFilter = "PACI_COD like '%" + buscar_nombre.Text + "%'";
            dt.DefaultView.RowFilter = "PACI_NOM like '%"+buscar_nombre.Text+"%'";
            dt.DefaultView.RowFilter = "DNI like '%" + buscar_nombre.Text + "%'";

        }

        private void set_Click(object sender, EventArgs e)
        {
            Form1 _ver = new Form1();

        

            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.ShowDialog();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 _ver = new Form3();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 _ver = new Form5();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 _ver = new Form4();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 _ver = new Form6();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.ShowDialog();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 _ver = new Form7();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.ShowDialog();
            }
        }

        private void PACI_TELEF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dbpacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

       

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 _ver = new Form9();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PACI_COMEN_TextChanged(object sender, EventArgs e)
        {
            PACI_COMEN.ScrollBars = ScrollBars.Both;
            PACI_COMEN.WordWrap = true;
        }

        private void PACI_HIST_TextChanged(object sender, EventArgs e)
        {
            PACI_HIST.ScrollBars = ScrollBars.Both;
            PACI_HIST.WordWrap = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 _ver = new Form3();



          
            
                _ver._Mensaje = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                _ver.ShowDialog();
            

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form5 _ver = new Form5();



                _ver._Mensaje = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                _ver.ShowDialog();
            

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 _ver = new Form4();



           
                _ver._Mensaje = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                _ver.ShowDialog();
            

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form6 _ver = new Form6();



        
                _ver._Mensaje = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                _ver.ShowDialog();
            

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form11 _ver = new Form11();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.ShowDialog();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form13 _ver = new Form13();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Elija un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver._cedula = DNI.Text;
                _ver._edad = edad.Text;
                _ver._direccion = PACI_DIR.Text;
                _ver._telefono = PACI_TELEF.Text;
                _ver._profesion = PACI_PROF.Text;
                _ver.ShowDialog();
            }
        }
    }
}
