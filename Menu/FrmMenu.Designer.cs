namespace NumerosPseudoaleatorios
{
    partial class FrmMenu
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
            this.btnCuadradosMedios = new System.Windows.Forms.Button();
            this.btnProductosMedios = new System.Windows.Forms.Button();
            this.btnMultConstante = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuadradosMedios
            // 
            this.btnCuadradosMedios.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCuadradosMedios.Location = new System.Drawing.Point(199, 194);
            this.btnCuadradosMedios.Name = "btnCuadradosMedios";
            this.btnCuadradosMedios.Size = new System.Drawing.Size(210, 39);
            this.btnCuadradosMedios.TabIndex = 0;
            this.btnCuadradosMedios.Text = "Cuadrados Medios";
            this.btnCuadradosMedios.UseVisualStyleBackColor = false;
            this.btnCuadradosMedios.Click += new System.EventHandler(this.btnCuadradosMedios_Click);
            // 
            // btnProductosMedios
            // 
            this.btnProductosMedios.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnProductosMedios.Location = new System.Drawing.Point(199, 271);
            this.btnProductosMedios.Name = "btnProductosMedios";
            this.btnProductosMedios.Size = new System.Drawing.Size(210, 39);
            this.btnProductosMedios.TabIndex = 1;
            this.btnProductosMedios.Text = "Productos Medios";
            this.btnProductosMedios.UseVisualStyleBackColor = false;
            this.btnProductosMedios.Click += new System.EventHandler(this.btnProductosMedios_Click);
            // 
            // btnMultConstante
            // 
            this.btnMultConstante.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMultConstante.Location = new System.Drawing.Point(199, 343);
            this.btnMultConstante.Name = "btnMultConstante";
            this.btnMultConstante.Size = new System.Drawing.Size(210, 39);
            this.btnMultConstante.TabIndex = 2;
            this.btnMultConstante.Text = "Mult. Constante";
            this.btnMultConstante.UseVisualStyleBackColor = false;
            this.btnMultConstante.Click += new System.EventHandler(this.btnMultConstante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.Location = new System.Drawing.Point(199, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(603, 514);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMultConstante);
            this.Controls.Add(this.btnProductosMedios);
            this.Controls.Add(this.btnCuadradosMedios);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Números Pseudoaleatorios Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuadradosMedios;
        private System.Windows.Forms.Button btnProductosMedios;
        private System.Windows.Forms.Button btnMultConstante;
        private System.Windows.Forms.Button btnSalir;
    }
}

