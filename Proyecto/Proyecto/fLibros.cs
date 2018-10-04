using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class fLibros : Form
    {
        public fLibros()
        {
            InitializeComponent();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
