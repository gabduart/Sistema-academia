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
    public partial class frmUsuario : Form
    {
        BLL.Usuario usu = new BLL.Usuario();
        DAL.UsuarioDAL usuDAL = new DAL.UsuarioDAL();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            txtNomeUser.Text = "";
            txtEmailUser.Text = "";
            txtSenhaUser.Text = "";
            ckbAdministrador.Checked = true;
            txtNomeUser.Focus();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // Exibir consulta assim que carregar
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnGravarUser_Click(object sender, EventArgs e)
        {
            usu.Nome = txtNomeUser.Text;
            usu.Email = txtEmailUser.Text;
            usu.Senha = txtSenhaUser.Text;
            usu.Isadm = ckbAdministrador.Checked;

            if (btnGravarUser.Text == "Atualizar")
            {
                usuDAL.Atualizar(usu);
                MessageBox.Show("Dados atualizados com sucesso!");
                btnGravarUser.Text = "Gravar";
                btnGravarUser.Width -= 20;
                btnNovoUser.Left -= 20;

                Novo();
            } else
            {
                usuDAL.Cadastrar(usu);
                MessageBox.Show("Dados gravados com sucesso!");
                Novo();
            }
            // Após cadastrar, atualizar consulta
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void BtnExcluirUser_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas sendo listadas
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    usu.Idusuario = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                    usuDAL.Excluir(usu);// executando o método de exclus2ão
                    dgvConsulta.DataSource = usuDAL.ConsultarTodos();// atualizando a consulta
                }
            }
           
        }

        private void BtnEditarUser_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)
            {
                usu.Idusuario = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value);
                usu = usuDAL.Retornar(usu);
                txtNomeUser.Text = usu.Nome;
                txtEmailUser.Text = usu.Email;
                txtSenhaUser.Text = usu.Senha;
                ckbAdministrador.Checked = usu.Isadm;

                tabControl1.SelectedTab = tabPage1;

                btnGravarUser.Text = "Atualizar";
                btnGravarUser.Width += 20;
                btnNovoUser.Left += 20;
            }
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // Mesmo função do evento KeyUp
        }

        private void TxtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            usu.Nome = txtPesquisar.Text;
            dgvConsulta.DataSource = usuDAL.Pesquisar(usu);
        }
    }
}
