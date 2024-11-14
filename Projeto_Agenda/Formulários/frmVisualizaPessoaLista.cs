using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formulários
{
    public partial class frmVisualizaPessoaLista : Form
    {
        public frmVisualizaPessoaLista()
        {
            InitializeComponent();
        }

        private void frmVisualizaPessoaLista_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
