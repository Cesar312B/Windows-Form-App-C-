namespace Nativo
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.PACI_FOTO2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO2)).BeginInit();
            this.SuspendLayout();
            // 
            // PACI_FOTO2
            // 
            this.PACI_FOTO2.AllowUserToAddRows = false;
            this.PACI_FOTO2.AllowUserToDeleteRows = false;
            this.PACI_FOTO2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PACI_FOTO2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PACI_FOTO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PACI_FOTO2.Location = new System.Drawing.Point(0, 0);
            this.PACI_FOTO2.Name = "PACI_FOTO2";
            this.PACI_FOTO2.ReadOnly = true;
            this.PACI_FOTO2.RowHeadersWidth = 5;
            this.PACI_FOTO2.RowTemplate.Height = 600;
            this.PACI_FOTO2.Size = new System.Drawing.Size(800, 685);
            this.PACI_FOTO2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.PACI_FOTO2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PACI_FOTO2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PACI_FOTO2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}