using ProjetoAcademia.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario form = new frmUsuario();
            form.ShowDialog();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            frmAluno form = new frmAluno();
            form.ShowDialog();
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            frmPlano form = new frmPlano();
            form.ShowDialog();
        }
    }
}
