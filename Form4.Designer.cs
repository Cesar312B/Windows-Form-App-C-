namespace Nativo
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.PACI_FOTO_ORTO = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO_ORTO)).BeginInit();
            this.SuspendLayout();
            // 
            // PACI_FOTO_ORTO
            // 
            this.PACI_FOTO_ORTO.AllowUserToAddRows = false;
            this.PACI_FOTO_ORTO.AllowUserToDeleteRows = false;
            this.PACI_FOTO_ORTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PACI_FOTO_ORTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PACI_FOTO_ORTO.Location = new System.Drawing.Point(0, 0);
            this.PACI_FOTO_ORTO.Name = "PACI_FOTO_ORTO";
            this.PACI_FOTO_ORTO.ReadOnly = true;
            this.PACI_FOTO_ORTO.RowHeadersWidth = 5;
            this.PACI_FOTO_ORTO.RowTemplate.Height = 750;
            this.PACI_FOTO_ORTO.Size = new System.Drawing.Size(1138, 605);
            this.PACI_FOTO_ORTO.TabIndex = 0;
            this.PACI_FOTO_ORTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PACI_FOTO_ORTO_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Elimianr foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PACI_FOTO_ORTO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO_ORTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PACI_FOTO_ORTO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}