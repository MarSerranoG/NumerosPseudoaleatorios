using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPseudoaleatorios.Cuadrados_Medios
{
    public partial class FrmCuadradosMedios : Form
    {
        public FrmCuadradosMedios()
        {
            InitializeComponent();
            // Icono del itsur 
            Icon icono = new Icon(@"Media\iconoItsur.ico");
            this.Icon = icono;
        }

        private void btnCMBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
