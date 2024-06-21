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
    public partial class frmAluno : Form
    {
        BLL.Aluno alu = new BLL.Aluno();
        DAL.AlunoDAL aluDAL = new DAL.AlunoDAL();
        public frmAluno()
        {
            InitializeComponent();
        }

        public void Novo()
        {
            txtNomeAluno.Clear();
            txtCpfAluno.Clear();
            txtEmailAluno.Clear();
            txtTelefoneAluno.Clear();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = aluDAL.ConsultarTodos();
        }

        private void btnGravarAluno_Click(object sender, EventArgs e)
        {
            alu.Nome = txtNomeAluno.Text;
            alu.Cpf = txtCpfAluno.Text;
            alu.Email = txtEmailAluno.Text;
            alu.Telefone = txtTelefoneAluno.Text;

            if (btnGravarAluno.Text == "Atualizar")
            {
                aluDAL.Atualizar(alu);
                MessageBox.Show("Dados atualizados com sucesso!");
                btnGravarAluno.Text = "Gravar";
                btnGravarAluno.Width -= 20;
                btnNovoAluno.Left -= 20;

                Novo();
            }
            else
            {
                aluDAL.Cadastrar(alu);
                MessageBox.Show("Dados gravados com sucesso!");

                Novo();
            }

            // Após cadastrar, atualizar consulta
            dgvConsulta.DataSource = aluDAL.ConsultarTodos();
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnExcluirPlano_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas sendo listadas
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    alu.Idaluno = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                    aluDAL.Excluir(alu);// executando o método de exclus2ão
                    dgvConsulta.DataSource = aluDAL.ConsultarTodos();// atualizando a consulta
                }
            }
        }

        private void TxtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            alu.Nome = txtPesquisar.Text;
            dgvConsulta.DataSource = aluDAL.Pesquisar(alu);
        }

        private void BtnEditarPlano_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)
            {
                alu.Idaluno = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                alu = aluDAL.Retornar(alu);
                txtNomeAluno.Text = alu.Nome;
                txtEmailAluno.Text = alu.Email;
                txtCpfAluno.Text = alu.Cpf;
                txtTelefoneAluno.Text = alu.Telefone;

                tabControl1.SelectedTab = tabPage1;

                btnGravarAluno.Text = "Atualizar";
                btnGravarAluno.Width += 20;
                btnNovoAluno.Left += 20;
            }
        }
    }
}
