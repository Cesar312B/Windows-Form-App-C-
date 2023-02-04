namespace Nativo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.PACI_FOTO = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO)).BeginInit();
            this.SuspendLayout();
            // 
            // PACI_FOTO
            // 
            this.PACI_FOTO.AllowUserToAddRows = false;
            this.PACI_FOTO.AllowUserToDeleteRows = false;
            this.PACI_FOTO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PACI_FOTO.ColumnHeadersHeight = 4;
            this.PACI_FOTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PACI_FOTO.Location = new System.Drawing.Point(0, 0);
            this.PACI_FOTO.Name = "PACI_FOTO";
            this.PACI_FOTO.ReadOnly = true;
            this.PACI_FOTO.RowHeadersWidth = 5;
            this.PACI_FOTO.RowTemplate.Height = 600;
            this.PACI_FOTO.Size = new System.Drawing.Size(798, 680);
            this.PACI_FOTO.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 680);
            this.Controls.Add(this.PACI_FOTO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PACI_FOTO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}