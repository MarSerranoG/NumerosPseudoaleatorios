namespace NumerosPseudoaleatorios.Cuadrados_Medios
{
    partial class FrmCuadradosMedios
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
            this.btnCMBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCMBack
            // 
            this.btnCMBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCMBack.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMBack.Location = new System.Drawing.Point(12, 403);
            this.btnCMBack.Name = "btnCMBack";
            this.btnCMBack.Size = new System.Drawing.Size(108, 35);
            this.btnCMBack.TabIndex = 0;
            this.btnCMBack.Text = "Regresar";
            this.btnCMBack.UseVisualStyleBackColor = false;
            this.btnCMBack.Click += new System.EventHandler(this.btnCMBack_Click);
            // 
            // FrmCuadradosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCMBack);
            this.Name = "FrmCuadradosMedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuadradosMedios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCMBack;
    }
}