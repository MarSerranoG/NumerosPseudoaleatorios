namespace NumerosPseudoaleatorios.Multiplicador_Constante
{
    partial class FrmMultiplicador_Constante
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
            this.btnMCBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMCBack
            // 
            this.btnMCBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMCBack.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCBack.Location = new System.Drawing.Point(12, 403);
            this.btnMCBack.Name = "btnMCBack";
            this.btnMCBack.Size = new System.Drawing.Size(108, 35);
            this.btnMCBack.TabIndex = 1;
            this.btnMCBack.Text = "Regresar";
            this.btnMCBack.UseVisualStyleBackColor = false;
            this.btnMCBack.Click += new System.EventHandler(this.btnMCBack_Click);
            // 
            // FrmMultiplicador_Constante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMCBack);
            this.Name = "FrmMultiplicador_Constante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicador Constante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMCBack;
    }
}