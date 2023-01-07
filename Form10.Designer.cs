namespace Nativo
{
    partial class Form10
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
            this.recetas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.recetas)).BeginInit();
            this.SuspendLayout();
            // 
            // recetas
            // 
            this.recetas.AllowUserToAddRows = false;
            this.recetas.AllowUserToDeleteRows = false;
            this.recetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetas.Location = new System.Drawing.Point(12, 48);
            this.recetas.Name = "recetas";
            this.recetas.ReadOnly = true;
            this.recetas.RowHeadersWidth = 62;
            this.recetas.RowTemplate.Height = 28;
            this.recetas.Size = new System.Drawing.Size(931, 233);
            this.recetas.TabIndex = 0;
            this.recetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 313);
            this.Controls.Add(this.recetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form10";
            this.Text = "Todas las recetas medicas";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recetas;
    }
}