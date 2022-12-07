using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormRelatorioAluno : Form
    {
        public FormRelatorioAluno()
        {
            InitializeComponent();
        }

        private void FormRelatorioAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_ACGDataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
            this.aLUNOTableAdapter.Fill(this.bD_ACGDataSet.ALUNO);

            this.reportViewer1.RefreshReport();
        }
    }
}
