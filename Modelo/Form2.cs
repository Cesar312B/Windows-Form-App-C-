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
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Globalization;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Nativo.Modelo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

  

   



        public static class MyGlobals
        {
            public static byte[] archivo1;
            public static byte[] archivo2;
            public static byte[] archivo3;
            public static byte[] archivo4;

        }

        public void mostrar_pacientes()
        {

            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            SQLiteConnection connect = new SQLiteConnection(cadena);
            connect.Open();
            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_COD,DNI,PACI_NOM FROM Paciente ORDER BY id DESC", connect);

            DataSet ds = new DataSet();


            adap.Fill(ds);
            dbpacientes.DataSource = ds.Tables[0];
           

            DataTable dt = (DataTable)dbpacientes.DataSource;



            count.Text = dt.Rows.Count.ToString();

            dt.DefaultView.RowFilter = "PACI_COD like '%" + buscar_nombre.Text + "%'"+ "OR PACI_NOM like '%" + buscar_nombre.Text + "%'"+ "OR DNI like '%" + buscar_nombre.Text + "%'";












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
            SQLiteCommand command = new SQLiteCommand("SELECT PACI_NACI, PACI_SEXO, PACI_DIR, PACI_LOCAL, PACI_TELEF, PACI_ENT, PACI_PROF, PACI_NORD, PACI_COMEN, PACI_HIST, PACI_REPRE, DNI FROM Paciente WHERE PACI_COD ='" + av + "'", connect);
            SQLiteDataAdapter dp = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet("Paciente");

            SQLiteDataAdapter adap = new SQLiteDataAdapter("SELECT PACI_FOTO FROM Paciente WHERE PACI_COD ='" + av + "' ", connect);

            DataSet ds2 = new DataSet();
            adap.Fill(ds2);
            dataGridView2.RowTemplate.Height = 200;
            dataGridView2.ColumnHeadersVisible = false;

            dataGridView2.DataSource = ds2.Tables[0];

            DataTable dt = (DataTable)dataGridView2.DataSource;

            DataGridViewColumn column = dataGridView2.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewImageColumn)dataGridView2.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            

           
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


            if ( myRow["PACI_NORD"] != DBNull.Value)
            {


               

                PACI_NORD.Text = (string)myRow["PACI_NORD"];



            }
            else
            {
              

                PACI_NORD.Text = null;

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
















            /*string av;
           
            av = dbpacientes.CurrentRow.Cells[0].Value.ToString();
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection connect = new SQLiteConnection(cadena);
            SQLiteCommand command = new SQLiteCommand("SELECT PACI_FOTO,PACI_FOTO_ORTO,PACI_FOTO2,PACI_FOTO_ORTO2 FROM Paciente WHERE PACI_COD ='"+av+"'", connect);
            SQLiteDataAdapter dp = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet("Paciente");

            dp.Fill(ds, "Paciente");
            DataRow myRow = ds.Tables["Paciente"].Rows[0];
      




            if (myRow["PACI_FOTO"] != DBNull.Value)
            {
                byte[] result = (byte[])myRow["PACI_FOTO"];
                int ArraySize = result.GetUpperBound(0);
               
                MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                Image imageBlob = Image.FromStream(ms,false);
                pictureBox1.Image = imageBlob;


            }
            else
            {
                pictureBox1.Image = null;
            }


            if (myRow["PACI_FOTO_ORTO"] != DBNull.Value)
            {
                byte[] result = (byte[])myRow["PACI_FOTO_ORTO"];
                int ArraySize = result.GetUpperBound(0);

                MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                Image imageBlob = Image.FromStream(ms, false);
                pictureBox2.Image = imageBlob;


            }
            else
            {
                pictureBox2.Image = null;
            }

            if (myRow["PACI_FOTO2"] != DBNull.Value)
            {
                byte[] result = (byte[])myRow["PACI_FOTO2"];
                int ArraySize = result.GetUpperBound(0);

                MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                Image imageBlob = Image.FromStream(ms, false);
                pictureBox3.Image = imageBlob;


            }
            else
            {
                pictureBox3.Image = null;
            }


            if (myRow["PACI_FOTO_ORTO2"] != DBNull.Value)
            {
                byte[] result = (byte[])myRow["PACI_FOTO_ORTO2"];
                int ArraySize = result.GetUpperBound(0);

                MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                Image imageBlob = Image.FromStream(ms, false);
                pictureBox4.Image = imageBlob;


            }
            else
            {
                pictureBox4.Image = null;
            }
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
             
           
            
           

            if (File.Exists(openFileDialog1.FileName))
            {
             
            Stream Mystrem1 = openFileDialog1.OpenFile();
            MemoryStream obj1 = new MemoryStream();
            Mystrem1.CopyTo(obj1);
           
              MyGlobals.archivo1 = obj1.ToArray();  
                
                
            

            }

            



          

           

            if (File.Exists(openFileDialog2.FileName))
            {

                Stream Mystrem2 = openFileDialog2.OpenFile();
              
                
                    MemoryStream obj2 = new MemoryStream();
                    Mystrem2.CopyTo(obj2);

                    MyGlobals.archivo2 = obj2.ToArray();

                }
               
            
                
            

            

            if (File.Exists(openFileDialog3.FileName))
            {

                Stream Mystrem3 = openFileDialog3.OpenFile();


                MemoryStream obj3 = new MemoryStream();
                Mystrem3.CopyTo(obj3);
                MyGlobals.archivo3 = obj3.ToArray();
            }
                

            
           

            

            

            if (File.Exists(openFileDialog4.FileName))
            {
                Stream Mystrem4 = openFileDialog4.OpenFile();

                MemoryStream obj4 = new MemoryStream();
                Mystrem4.CopyTo(obj4);

                MyGlobals.archivo4 = obj4.ToArray();
            }






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
                PACI_NORD= PACI_NORD.Text,
                PACI_REPRE= PACI_REPRE.Text,
                PACI_COMEN= PACI_COMEN.Text,
                PACI_HIST= PACI_HIST.Text,
                DNI = DNI.Text,
                PACI_FOTO = MyGlobals.archivo1,
                PACI_FOTO2= MyGlobals.archivo2,
                PACI_FOTO_ORTO= MyGlobals.archivo3,
                PACI_FOTO_ORTO2= MyGlobals.archivo4,
                
            };



            bool respuesta = PacienteLogica.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_pacientes();
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
            PACI_NORD.Text = null;
            PACI_REPRE.Text = null;
            PACI_COMEN.Text = null;
            PACI_HIST.Text = null;
            dateTimePicker2.Text = null;
            DNI.Text = null;
            PACI_COD.Focus();
            
            RegistryKey registrykeyHKLM = Registry.LocalMachine;
            string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Run\MyApp";
            registrykeyHKLM.DeleteValue(keyPath);
            registrykeyHKLM.Close();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PACI_FOTO_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog1.FilterIndex = 1;


            openFileDialog1.ShowDialog();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            



     

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
             
                PACI_NORD = PACI_NORD.Text,
                PACI_REPRE = PACI_REPRE.Text,
                PACI_COMEN = PACI_COMEN.Text,
                PACI_HIST = PACI_HIST.Text,
                DNI= DNI.Text,

            };
        
           



            bool respuesta = PacienteLogica.Instancia.Editar(objeto);
         

            if (respuesta )
            {
                limpiar();
                mostrar_pacientes();

                RegistryKey registrykeyHKLM = Registry.LocalMachine;
                string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Run\MyApp";
                registrykeyHKLM.DeleteValue(keyPath);
                registrykeyHKLM.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                PACI_COD = PACI_COD.Text,
            };
            bool respuesta = PacienteLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_pacientes();
            }
        }

        private void PACI_FOTO2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog2.FilterIndex = 1;

            openFileDialog2.ShowDialog();
            

        }

        private void PACI_FOTO_ORTO_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog3.FilterIndex = 1;

             openFileDialog3.ShowDialog();
            
        }

        private void PACI_FOTO_ORTO2_Click(object sender, EventArgs e)
        {
            openFileDialog4.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog4.FilterIndex = 1;

            openFileDialog4.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            mostrar_pacientes();
         

     
            
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

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.Show();
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

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 _ver = new Form5();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 _ver = new Form4();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 _ver = new Form6();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver.Show();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 _ver = new Form7();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 _ver = new Form9();



            if (string.IsNullOrEmpty(PACI_COD.Text))
            {

                MessageBox.Show("Eliga un paciente");

                return;

            }
            else
            {
                _ver._Mensaje = PACI_COD.Text;
                _ver._nombre = PACI_NOM.Text;
                _ver.Show();
            }
        }
    }
}
