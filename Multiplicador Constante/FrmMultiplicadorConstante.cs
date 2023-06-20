using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPseudoaleatorios.Multiplicador_Constante
{
    public partial class FrmMultiplicador_Constante : Form
    {
        public FrmMultiplicador_Constante()
        {
            InitializeComponent();
            // Icono del itsur 
            Icon icono = new Icon(@"Media\iconoItsur.ico");
            this.Icon = icono;
        }

        private void btnMCBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
