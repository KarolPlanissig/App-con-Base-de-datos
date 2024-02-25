namespace Aplicacion_Ado_Net
{
    partial class FistApp
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
            this.dgbDiscos = new System.Windows.Forms.DataGridView();
            this.pBoxAutor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbDiscos
            // 
            this.dgbDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDiscos.Location = new System.Drawing.Point(12, 82);
            this.dgbDiscos.Name = "dgbDiscos";
            this.dgbDiscos.RowHeadersWidth = 51;
            this.dgbDiscos.RowTemplate.Height = 24;
            this.dgbDiscos.Size = new System.Drawing.Size(524, 190);
            this.dgbDiscos.TabIndex = 0;
            this.dgbDiscos.SelectionChanged += new System.EventHandler(this.dgbDiscos_SelectionChanged);
            // 
            // pBoxAutor
            // 
            this.pBoxAutor.Location = new System.Drawing.Point(620, 82);
            this.pBoxAutor.Name = "pBoxAutor";
            this.pBoxAutor.Size = new System.Drawing.Size(206, 190);
            this.pBoxAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAutor.TabIndex = 1;
            this.pBoxAutor.TabStop = false;
            // 
            // FistApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.pBoxAutor);
            this.Controls.Add(this.dgbDiscos);
            this.Name = "FistApp";
            this.Text = "FirstApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbDiscos;
        private System.Windows.Forms.PictureBox pBoxAutor;
    }
}

