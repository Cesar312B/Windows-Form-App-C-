namespace Nativo
{
    partial class Form7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.abonos = new System.Windows.Forms.DataGridView();
            this.PACI_COD = new System.Windows.Forms.TextBox();
            this.PRECIO_TRABAJO = new System.Windows.Forms.TextBox();
            this.ABO_PTAS = new System.Windows.Forms.TextBox();
            this.DESC_TRABAJO = new System.Windows.Forms.TextBox();
            this.ABO_FECHA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.filtrar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.total_abonado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dv = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.filtrar2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonos)).BeginInit();
            this.SuspendLayout();
            // 
            // abonos
            // 
            this.abonos.AllowUserToAddRows = false;
            this.abonos.AllowUserToDeleteRows = false;
            this.abonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonos.Location = new System.Drawing.Point(47, 258);
            this.abonos.Margin = new System.Windows.Forms.Padding(2);
            this.abonos.Name = "abonos";
            this.abonos.ReadOnly = true;
            this.abonos.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.abonos.RowTemplate.Height = 28;
            this.abonos.Size = new System.Drawing.Size(688, 165);
            this.abonos.TabIndex = 0;
            this.abonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacora_CellClick);
            // 
            // PACI_COD
            // 
            this.PACI_COD.Enabled = false;
            this.PACI_COD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PACI_COD.Location = new System.Drawing.Point(111, 77);
            this.PACI_COD.Margin = new System.Windows.Forms.Padding(2);
            this.PACI_COD.Name = "PACI_COD";
            this.PACI_COD.Size = new System.Drawing.Size(68, 20);
            this.PACI_COD.TabIndex = 1;
            // 
            // PRECIO_TRABAJO
            // 
            this.PRECIO_TRABAJO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRECIO_TRABAJO.Location = new System.Drawing.Point(47, 123);
            this.PRECIO_TRABAJO.Margin = new System.Windows.Forms.Padding(2);
            this.PRECIO_TRABAJO.Name = "PRECIO_TRABAJO";
            this.PRECIO_TRABAJO.Size = new System.Drawing.Size(117, 20);
            this.PRECIO_TRABAJO.TabIndex = 3;
            this.PRECIO_TRABAJO.TextChanged += new System.EventHandler(this.PRECIO_TRABAJO_TextChanged);
            this.PRECIO_TRABAJO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PRECIO_TRABAJO_keyPress);
            // 
            // ABO_PTAS
            // 
            this.ABO_PTAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABO_PTAS.Location = new System.Drawing.Point(184, 123);
            this.ABO_PTAS.Margin = new System.Windows.Forms.Padding(2);
            this.ABO_PTAS.Name = "ABO_PTAS";
            this.ABO_PTAS.Size = new System.Drawing.Size(89, 20);
            this.ABO_PTAS.TabIndex = 4;
            this.ABO_PTAS.TextChanged += new System.EventHandler(this.ABO_PTAS_TextChanged);
            this.ABO_PTAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABO_PTAS_KeyPress);
            // 
            // DESC_TRABAJO
            // 
            this.DESC_TRABAJO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESC_TRABAJO.Location = new System.Drawing.Point(47, 164);
            this.DESC_TRABAJO.Margin = new System.Windows.Forms.Padding(2);
            this.DESC_TRABAJO.Name = "DESC_TRABAJO";
            this.DESC_TRABAJO.Size = new System.Drawing.Size(256, 20);
            this.DESC_TRABAJO.TabIndex = 5;
            this.DESC_TRABAJO.TextChanged += new System.EventHandler(this.DESC_TRABAJO_TextChanged);
            // 
            // ABO_FECHA
            // 
            this.ABO_FECHA.CustomFormat = "yyyy-MM-dd";
            this.ABO_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ABO_FECHA.Location = new System.Drawing.Point(186, 77);
            this.ABO_FECHA.Margin = new System.Windows.Forms.Padding(2);
            this.ABO_FECHA.Name = "ABO_FECHA";
            this.ABO_FECHA.Size = new System.Drawing.Size(117, 20);
            this.ABO_FECHA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PACI_COD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Abono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ABONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRECIO_TRABAJO $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(45, 8);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(50, 13);
            this.label113.TabIndex = 13;
            this.label113.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(91, 8);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(0, 13);
            this.Codigo.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(91, 28);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(0, 13);
            this.Nombre.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(117, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(184, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(257, 209);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 31);
            this.button4.TabIndex = 20;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(50, 77);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(50, 20);
            this.id.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "id";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(625, 145);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 36);
            this.button5.TabIndex = 27;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // filtrar
            // 
            this.filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar.Location = new System.Drawing.Point(565, 66);
            this.filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(97, 20);
            this.filtrar.TabIndex = 28;
            this.filtrar.TextChanged += new System.EventHandler(this.filtrar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Filtrar fecha";
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total Abonado:";
            // 
            // total_abonado
            // 
            this.total_abonado.AutoSize = true;
            this.total_abonado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_abonado.Location = new System.Drawing.Point(155, 444);
            this.total_abonado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_abonado.Name = "total_abonado";
            this.total_abonado.Size = new System.Drawing.Size(0, 18);
            this.total_abonado.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 444);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Precio del trabajo:";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(366, 444);
            this.precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(0, 18);
            this.precio.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 444);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 18);
            this.label11.TabIndex = 34;
            this.label11.Text = "Debe:";
            // 
            // dv
            // 
            this.dv.AutoSize = true;
            this.dv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv.Location = new System.Drawing.Point(498, 444);
            this.dv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dv.Name = "dv";
            this.dv.Size = new System.Drawing.Size(0, 18);
            this.dv.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(642, 439);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 35);
            this.button6.TabIndex = 36;
            this.button6.Text = "Calculadora";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // filtrar2
            // 
            this.filtrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar2.Location = new System.Drawing.Point(665, 66);
            this.filtrar2.Margin = new System.Windows.Forms.Padding(2);
            this.filtrar2.Name = "filtrar2";
            this.filtrar2.Size = new System.Drawing.Size(97, 20);
            this.filtrar2.TabIndex = 37;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(605, 103);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 38);
            this.button7.TabIndex = 38;
            this.button7.Text = "Filtrar entre Fechas";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(565, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Fecha Inicial";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(664, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Fecha Final ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 485);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.filtrar2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.total_abonado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ABO_FECHA);
            this.Controls.Add(this.DESC_TRABAJO);
            this.Controls.Add(this.ABO_PTAS);
            this.Controls.Add(this.PRECIO_TRABAJO);
            this.Controls.Add(this.PACI_COD);
            this.Controls.Add(this.abonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.Text = "Abonos";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView abonos;
        private System.Windows.Forms.TextBox PACI_COD;
        private System.Windows.Forms.TextBox PRECIO_TRABAJO;
        private System.Windows.Forms.TextBox ABO_PTAS;
        private System.Windows.Forms.TextBox DESC_TRABAJO;
        private System.Windows.Forms.DateTimePicker ABO_FECHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.TextBox filtrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_abonado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox filtrar2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}