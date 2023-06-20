using NumerosPseudoaleatorios.Cuadrados_Medios;
using NumerosPseudoaleatorios.Multiplicador_Constante;
using NumerosPseudoaleatorios.Productos_Medios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPseudoaleatorios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            // Icono del itsur 
          Icon icono = new Icon(@"Media\iconoItsur.ico");
          this.Icon = icono;

        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            FrmCuadradosMedios frmCuadradosMedios = new FrmCuadradosMedios();
            this.Hide();
            frmCuadradosMedios.Show();

        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {

            FrmProductosMedios frmProductosMedios = new FrmProductosMedios();
            this.Hide();
            frmProductosMedios.Show();
        }

        private void btnMultConstante_Click(object sender, EventArgs e)
        {
            FrmMultiplicador_Constante frmMultiplicadorConstante = new FrmMultiplicador_Constante();
            this.Hide();
            frmMultiplicadorConstante.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
