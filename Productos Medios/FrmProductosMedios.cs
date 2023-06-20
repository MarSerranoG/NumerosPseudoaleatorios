using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPseudoaleatorios.Productos_Medios
{
    public partial class FrmProductosMedios : Form
    {
        public FrmProductosMedios()
        {
            InitializeComponent();
            // Icono del itsur 
            Icon icono = new Icon(@"Media\iconoItsur.ico");
            this.Icon = icono;
        }

        private void btnPMBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
