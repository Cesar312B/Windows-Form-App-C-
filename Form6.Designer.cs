namespace Nativo
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.PACI_FOTO_ORTO2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO_ORTO2)).BeginInit();
            this.SuspendLayout();
            // 
            // PACI_FOTO_ORTO2
            // 
            this.PACI_FOTO_ORTO2.AllowUserToAddRows = false;
            this.PACI_FOTO_ORTO2.AllowUserToDeleteRows = false;
            this.PACI_FOTO_ORTO2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PACI_FOTO_ORTO2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PACI_FOTO_ORTO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PACI_FOTO_ORTO2.Location = new System.Drawing.Point(0, 0);
            this.PACI_FOTO_ORTO2.Name = "PACI_FOTO_ORTO2";
            this.PACI_FOTO_ORTO2.ReadOnly = true;
            this.PACI_FOTO_ORTO2.RowHeadersWidth = 5;
            this.PACI_FOTO_ORTO2.RowTemplate.Height = 600;
            this.PACI_FOTO_ORTO2.Size = new System.Drawing.Size(800, 771);
            this.PACI_FOTO_ORTO2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.PACI_FOTO_ORTO2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO_ORTO2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PACI_FOTO_ORTO2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}