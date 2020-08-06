using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Update.Maker.Source_files;

namespace Update.Maker.Forms
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            Globals.formulario = this;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }
    }
}
