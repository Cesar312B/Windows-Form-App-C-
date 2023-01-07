namespace Nativo.Modelo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dbpacientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buscar_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PACI_COD = new System.Windows.Forms.TextBox();
            this.PACI_NOM = new System.Windows.Forms.TextBox();
            this.PACI_DIR = new System.Windows.Forms.TextBox();
            this.PACI_NORD = new System.Windows.Forms.TextBox();
            this.PACI_LOCAL = new System.Windows.Forms.TextBox();
            this.PACI_REPRE = new System.Windows.Forms.TextBox();
            this.PACI_PROF = new System.Windows.Forms.TextBox();
            this.PACI_TELEF = new System.Windows.Forms.TextBox();
            this.PACI_FOTO2 = new System.Windows.Forms.Button();
            this.PACI_FOTO_ORTO2 = new System.Windows.Forms.Button();
            this.PACI_HIST = new System.Windows.Forms.TextBox();
            this.PACI_COMEN = new System.Windows.Forms.TextBox();
            this.Archivos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PACI_SEXO = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.PACI_FOTO_ORTO = new System.Windows.Forms.Button();
            this.PACI_FOTO = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.edad = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.set = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbpacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dbpacientes
            // 
            this.dbpacientes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dbpacientes.AllowUserToAddRows = false;
            this.dbpacientes.AllowUserToDeleteRows = false;
            this.dbpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbpacientes.Location = new System.Drawing.Point(25, 173);
            this.dbpacientes.Name = "dbpacientes";
            this.dbpacientes.ReadOnly = true;
            this.dbpacientes.RowHeadersWidth = 45;
            this.dbpacientes.RowTemplate.Height = 28;
            this.dbpacientes.Size = new System.Drawing.Size(610, 342);
            this.dbpacientes.TabIndex = 0;
            this.dbpacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dbpacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbpacientes_CellContentClick);
            this.dbpacientes.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dbpacientes_RowPostPaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscar_nombre
            // 
            this.buscar_nombre.Location = new System.Drawing.Point(30, 70);
            this.buscar_nombre.Name = "buscar_nombre";
            this.buscar_nombre.Size = new System.Drawing.Size(251, 26);
            this.buscar_nombre.TabIndex = 5;
            this.buscar_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // PACI_COD
            // 
            this.PACI_COD.Enabled = false;
            this.PACI_COD.Location = new System.Drawing.Point(645, 44);
            this.PACI_COD.Name = "PACI_COD";
            this.PACI_COD.Size = new System.Drawing.Size(126, 26);
            this.PACI_COD.TabIndex = 13;
            // 
            // PACI_NOM
            // 
            this.PACI_NOM.Location = new System.Drawing.Point(779, 44);
            this.PACI_NOM.Name = "PACI_NOM";
            this.PACI_NOM.Size = new System.Drawing.Size(235, 26);
            this.PACI_NOM.TabIndex = 14;
            // 
            // PACI_DIR
            // 
            this.PACI_DIR.Location = new System.Drawing.Point(645, 230);
            this.PACI_DIR.Name = "PACI_DIR";
            this.PACI_DIR.Size = new System.Drawing.Size(167, 26);
            this.PACI_DIR.TabIndex = 15;
            // 
            // PACI_NORD
            // 
            this.PACI_NORD.Location = new System.Drawing.Point(647, 356);
            this.PACI_NORD.Name = "PACI_NORD";
            this.PACI_NORD.Size = new System.Drawing.Size(165, 26);
            this.PACI_NORD.TabIndex = 17;
            // 
            // PACI_LOCAL
            // 
            this.PACI_LOCAL.Location = new System.Drawing.Point(834, 164);
            this.PACI_LOCAL.Name = "PACI_LOCAL";
            this.PACI_LOCAL.Size = new System.Drawing.Size(178, 26);
            this.PACI_LOCAL.TabIndex = 18;
            // 
            // PACI_REPRE
            // 
            this.PACI_REPRE.Location = new System.Drawing.Point(834, 230);
            this.PACI_REPRE.Name = "PACI_REPRE";
            this.PACI_REPRE.Size = new System.Drawing.Size(178, 26);
            this.PACI_REPRE.TabIndex = 22;
            // 
            // PACI_PROF
            // 
            this.PACI_PROF.Location = new System.Drawing.Point(645, 167);
            this.PACI_PROF.Name = "PACI_PROF";
            this.PACI_PROF.Size = new System.Drawing.Size(167, 26);
            this.PACI_PROF.TabIndex = 23;
            // 
            // PACI_TELEF
            // 
            this.PACI_TELEF.Location = new System.Drawing.Point(834, 356);
            this.PACI_TELEF.Name = "PACI_TELEF";
            this.PACI_TELEF.Size = new System.Drawing.Size(180, 26);
            this.PACI_TELEF.TabIndex = 25;
            this.PACI_TELEF.TextChanged += new System.EventHandler(this.PACI_TELEF_TextChanged);
            // 
            // PACI_FOTO2
            // 
            this.PACI_FOTO2.Location = new System.Drawing.Point(645, 668);
            this.PACI_FOTO2.Name = "PACI_FOTO2";
            this.PACI_FOTO2.Size = new System.Drawing.Size(161, 29);
            this.PACI_FOTO2.TabIndex = 27;
            this.PACI_FOTO2.Text = "PACI_FOTO2";
            this.PACI_FOTO2.UseVisualStyleBackColor = true;
            this.PACI_FOTO2.Click += new System.EventHandler(this.PACI_FOTO2_Click);
            // 
            // PACI_FOTO_ORTO2
            // 
            this.PACI_FOTO_ORTO2.Location = new System.Drawing.Point(845, 666);
            this.PACI_FOTO_ORTO2.Name = "PACI_FOTO_ORTO2";
            this.PACI_FOTO_ORTO2.Size = new System.Drawing.Size(180, 31);
            this.PACI_FOTO_ORTO2.TabIndex = 28;
            this.PACI_FOTO_ORTO2.Text = "PACI_FOTO_ORTO2";
            this.PACI_FOTO_ORTO2.UseVisualStyleBackColor = true;
            this.PACI_FOTO_ORTO2.Click += new System.EventHandler(this.PACI_FOTO_ORTO2_Click);
            // 
            // PACI_HIST
            // 
            this.PACI_HIST.Location = new System.Drawing.Point(645, 513);
            this.PACI_HIST.Multiline = true;
            this.PACI_HIST.Name = "PACI_HIST";
            this.PACI_HIST.Size = new System.Drawing.Size(367, 50);
            this.PACI_HIST.TabIndex = 21;
            // 
            // PACI_COMEN
            // 
            this.PACI_COMEN.Location = new System.Drawing.Point(645, 429);
            this.PACI_COMEN.Multiline = true;
            this.PACI_COMEN.Name = "PACI_COMEN";
            this.PACI_COMEN.Size = new System.Drawing.Size(367, 48);
            this.PACI_COMEN.TabIndex = 20;
            // 
            // Archivos
            // 
            this.Archivos.AutoSize = true;
            this.Archivos.Location = new System.Drawing.Point(797, 589);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(119, 20);
            this.Archivos.TabIndex = 30;
            this.Archivos.Text = "Añadir Archivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "PACI_COD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "PACI_NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "PACI_NACI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "PACI_SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "PACI_DIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "PACI_LOCAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(830, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "PACI_REPRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(830, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "PACI_ENT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(641, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "PACI_PROF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(643, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "PACI_NORD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(830, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "PACI_TELEF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(645, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "PACI_COMEN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(641, 490);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 47;
            this.label18.Text = "PACI_HIST";
            // 
            // PACI_SEXO
            // 
            this.PACI_SEXO.Location = new System.Drawing.Point(840, 101);
            this.PACI_SEXO.MaxLength = 1;
            this.PACI_SEXO.Name = "PACI_SEXO";
            this.PACI_SEXO.Size = new System.Drawing.Size(96, 26);
            this.PACI_SEXO.TabIndex = 48;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 49;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Nombre,Codigo o Cedula";
            // 
            // PACI_FOTO_ORTO
            // 
            this.PACI_FOTO_ORTO.Location = new System.Drawing.Point(845, 628);
            this.PACI_FOTO_ORTO.Name = "PACI_FOTO_ORTO";
            this.PACI_FOTO_ORTO.Size = new System.Drawing.Size(167, 29);
            this.PACI_FOTO_ORTO.TabIndex = 26;
            this.PACI_FOTO_ORTO.Text = "PACI_FOTO_ORTO";
            this.PACI_FOTO_ORTO.UseVisualStyleBackColor = true;
            this.PACI_FOTO_ORTO.Click += new System.EventHandler(this.PACI_FOTO_ORTO_Click);
            // 
            // PACI_FOTO
            // 
            this.PACI_FOTO.Location = new System.Drawing.Point(645, 626);
            this.PACI_FOTO.Name = "PACI_FOTO";
            this.PACI_FOTO.Size = new System.Drawing.Size(161, 31);
            this.PACI_FOTO.TabIndex = 4;
            this.PACI_FOTO.Text = "PACI_FOTO";
            this.PACI_FOTO.UseVisualStyleBackColor = true;
            this.PACI_FOTO.Click += new System.EventHandler(this.PACI_FOTO_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(645, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 26);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 3, 11, 52, 8, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(834, 296);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 26);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(1057, 418);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(0, 20);
            this.edad.TabIndex = 54;
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Location = new System.Drawing.Point(1053, 477);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(0, 20);
            this.entrada.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1053, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1053, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Edad";
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(25, 523);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(114, 31);
            this.set.TabIndex = 58;
            this.set.Text = "Bitacora";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 37);
            this.button5.TabIndex = 59;
            this.button5.Text = "PACI_FOTO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(237, 608);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 37);
            this.button6.TabIndex = 60;
            this.button6.Text = "PACI_FOTO2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(237, 665);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 37);
            this.button7.TabIndex = 61;
            this.button7.Text = "PACI_FOTO_ORTO";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(30, 665);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(191, 37);
            this.button8.TabIndex = 62;
            this.button8.Text = "PACI_FOTO_ORTO2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 577);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 63;
            this.label15.Text = "Ver Imagenes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1027, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 5;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(172, 286);
            this.dataGridView2.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 523);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 31);
            this.button9.TabIndex = 64;
            this.button9.Text = "Abonos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 20);
            this.label19.TabIndex = 65;
            this.label19.Text = "Pacientes:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(111, 150);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 20);
            this.count.TabIndex = 66;
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(645, 102);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(179, 26);
            this.DNI.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(645, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 20);
            this.label20.TabIndex = 68;
            this.label20.Text = "DNI O PASAPORTE";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1169, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 29);
            this.button10.TabIndex = 69;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1123, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 29);
            this.button11.TabIndex = 70;
            this.button11.Text = "---";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(237, 523);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 31);
            this.button12.TabIndex = 71;
            this.button12.Text = "Receta";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 723);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.set);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PACI_SEXO);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.PACI_FOTO_ORTO2);
            this.Controls.Add(this.PACI_FOTO2);
            this.Controls.Add(this.PACI_FOTO_ORTO);
            this.Controls.Add(this.PACI_TELEF);
            this.Controls.Add(this.PACI_PROF);
            this.Controls.Add(this.PACI_REPRE);
            this.Controls.Add(this.PACI_HIST);
            this.Controls.Add(this.PACI_COMEN);
            this.Controls.Add(this.PACI_LOCAL);
            this.Controls.Add(this.PACI_NORD);
            this.Controls.Add(this.PACI_DIR);
            this.Controls.Add(this.PACI_NOM);
            this.Controls.Add(this.PACI_COD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar_nombre);
            this.Controls.Add(this.PACI_FOTO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbpacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbpacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox buscar_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PACI_COD;
        private System.Windows.Forms.TextBox PACI_NOM;
        private System.Windows.Forms.TextBox PACI_DIR;
        private System.Windows.Forms.TextBox PACI_NORD;
        private System.Windows.Forms.TextBox PACI_LOCAL;
        private System.Windows.Forms.TextBox PACI_REPRE;
        private System.Windows.Forms.TextBox PACI_PROF;
        private System.Windows.Forms.TextBox PACI_TELEF;
        private System.Windows.Forms.Button PACI_FOTO2;
        private System.Windows.Forms.Button PACI_FOTO_ORTO2;
        private System.Windows.Forms.TextBox PACI_HIST;
        private System.Windows.Forms.TextBox PACI_COMEN;
        private System.Windows.Forms.Label Archivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PACI_SEXO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PACI_FOTO_ORTO;
        private System.Windows.Forms.Button PACI_FOTO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label entrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}