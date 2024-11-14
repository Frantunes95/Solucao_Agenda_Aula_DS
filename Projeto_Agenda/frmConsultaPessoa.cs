using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmConsultaPessoa : Form
    {
        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vFiltro="";

            vFiltro = cmbColuna.Text;

            switch (cmbProcurar.Text)
            {
                case "Que contém":
                    vFiltro += $" like '%{txtValor1.Text}%'";
                    break;
                case "Todos":
                    vFiltro = "";
                    break;
            }

            pessoaBindingSource.Filter = vFiltro;
        }
    }
}
