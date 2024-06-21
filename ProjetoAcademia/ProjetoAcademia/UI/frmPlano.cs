using ProjetoAcademia.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI
{
    public partial class frmPlano : Form
    {
        BLL.Plano plan = new BLL.Plano();
        DAL.PlanoDAL planoDAL = new DAL.PlanoDAL();
        public frmPlano()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            txtNomePlano.Clear();
            txtPrecoPlano.Clear();
        }

        private void frmPlano_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = planoDAL.ConsultarTodos();
            //FORMATAR PREÇO "c" VEM COM CIFRÃO E "m" VEM SEM - BY ANDERSON SPERA
            dgvConsulta.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btnGravarPlano_Click(object sender, EventArgs e)
        {
            plan.Nome = txtNomePlano.Text;
            plan.Preco = float.Parse(txtPrecoPlano.Text);

            if (btnGravarPlano.Text == "Atualizar")
            {
                planoDAL.Atualizar(plan);
                MessageBox.Show("Dados atualizados com sucesso!");
                btnGravarPlano.Text = "Gravar";
                btnGravarPlano.Width -= 20;
                btnNovoPlano.Left -= 20;

                Novo();
            }
            else
            {
                planoDAL.Cadastrar(plan);
                MessageBox.Show("Dados gravados com sucesso!");
                Novo();
            }
            // Ap
            // Após cadastrar, atualizar consulta
            dgvConsulta.DataSource = planoDAL.ConsultarTodos();
        }

        private void btnNovoPlano_Click(object sender, EventArgs e)
        {
            txtNomePlano.Text = "";
            txtPrecoPlano.Text = "";
            txtNomePlano.Focus();
        }

        private void BtnEditarPlano_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)
            {
                plan.Idplano = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                planoDAL.Retornar(plan);
                txtNomePlano.Text = plan.Nome;
                txtPrecoPlano.Text = plan.Preco.ToString();

                tabControl1.SelectedTab = tabPage1;

                btnGravarPlano.Text = "Atualizar";
                btnGravarPlano.Width += 20;
                btnNovoPlano.Left += 20;
            }
        }

        private void BtnExcluirPlano_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas sendo listadas
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    plan.Idplano = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                    planoDAL.Excluir(plan);// executando o método de exclus2ão
                    dgvConsulta.DataSource = planoDAL.ConsultarTodos();// atualizando a consulta
                }
            }
        }
    }
}
