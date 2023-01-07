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
            this.fecha_t.Location = new System.Drawing.Point(261, 107);
            this.fecha_t.Name = "fecha_t";
            this.fecha_t.Size = new System.Drawing.Size(54, 20);
            this.fecha_t.TabIndex = 0;
            this.fecha_t.Text = "Fecha";
            this.fecha_t.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(77, 188);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descripcion.Size = new System.Drawing.Size(351, 48);
            this.descripcion.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(77, 254);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(88, 37);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(171, 254);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(76, 37);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(253, 254);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(92, 37);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bitacora
            // 
            this.bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacora.Location = new System.Drawing.Point(77, 306);
            this.bitacora.Name = "bitacora";
            this.bitacora.RowHeadersWidth = 62;
            this.bitacora.RowTemplate.Height = 28;
            this.bitacora.Size = new System.Drawing.Size(878, 170);
            this.bitacora.TabIndex = 10;
            this.bitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacora_CellClick);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(351, 254);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(77, 37);
            this.button_limpiar.TabIndex = 12;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // get
            // 
            this.get.AutoSize = true;
            this.get.Location = new System.Drawing.Point(412, 53);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(0, 20);
            this.get.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(153, 39);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(0, 20);
            this.codigo.TabIndex = 23;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(157, 63);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 20);
            this.nombre.TabIndex = 24;
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dd/MM/yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(265, 130);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(163, 26);
            this.fecha.TabIndex = 25;
            // 
            // codigo2
            // 
            this.codigo2.Enabled = false;
            this.codigo2.Location = new System.Drawing.Point(171, 130);
            this.codigo2.Name = "codigo2";
            this.codigo2.Size = new System.Drawing.Size(88, 26);
            this.codigo2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Codigo";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(81, 130);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(84, 26);
            this.id.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
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
            this.label6.Location = new System.Drawing.Point(701, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Filtrar datos";
            // 
            // filtrar
            // 
            this.filtrar.Location = new System.Drawing.Point(705, 130);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(138, 26);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 514);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

