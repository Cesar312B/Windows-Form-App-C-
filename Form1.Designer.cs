namespace Nativo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fecha_t = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.bitacora = new System.Windows.Forms.DataGridView();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.codigo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.filtrar = new System.Windows.Forms.TextBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_t
            // 
            this.fecha_t.AutoSize = true;
            this.fecha_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_t.Location = new System.Drawing.Point(174, 70);
            this.fecha_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fecha_t.Name = "fecha_t";
            this.fecha_t.Size = new System.Drawing.Size(42, 13);
            this.fecha_t.TabIndex = 0;
            this.fecha_t.Text = "Fecha";
            this.fecha_t.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(51, 122);
            this.descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion.Name = "descripcion";
            this.descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descripcion.Size = new System.Drawing.Size(235, 20);
            this.descripcion.TabIndex = 5;
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(51, 154);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(66, 29);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.Location = new System.Drawing.Point(122, 154);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(51, 29);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Location = new System.Drawing.Point(177, 154);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(67, 29);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bitacora
            // 
            this.bitacora.AllowUserToAddRows = false;
            this.bitacora.AllowUserToDeleteRows = false;
            this.bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacora.Location = new System.Drawing.Point(51, 203);
            this.bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.bitacora.Name = "bitacora";
            this.bitacora.ReadOnly = true;
            this.bitacora.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacora.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bitacora.RowTemplate.Height = 28;
            this.bitacora.Size = new System.Drawing.Size(585, 145);
            this.bitacora.TabIndex = 10;
            this.bitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacora_CellClick);
            this.bitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacora_CellContentClick);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button_limpiar.Location = new System.Drawing.Point(248, 154);
            this.button_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(62, 29);
            this.button_limpiar.TabIndex = 12;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // get
            // 
            this.get.AutoSize = true;
            this.get.Location = new System.Drawing.Point(275, 34);
            this.get.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(0, 13);
            this.get.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(102, 25);
            this.codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(0, 13);
            this.codigo.TabIndex = 23;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(105, 41);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 13);
            this.nombre.TabIndex = 24;
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dd/MM/yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(177, 84);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(110, 20);
            this.fecha.TabIndex = 25;
            // 
            // codigo2
            // 
            this.codigo2.Enabled = false;
            this.codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo2.Location = new System.Drawing.Point(114, 84);
            this.codigo2.Margin = new System.Windows.Forms.Padding(2);
            this.codigo2.Name = "codigo2";
            this.codigo2.Size = new System.Drawing.Size(60, 20);
            this.codigo2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Codigo";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(54, 84);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 20);
            this.id.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(470, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Filtrar fecha";
            // 
            // filtrar
            // 
            this.filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar.Location = new System.Drawing.Point(470, 84);
            this.filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(93, 20);
            this.filtrar.TabIndex = 33;
            this.filtrar.TextChanged += new System.EventHandler(this.filtrar_TextChanged);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 370);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codigo2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.bitacora);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_t);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fecha_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView bitacora;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Label get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox codigo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filtrar;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
    }
}

