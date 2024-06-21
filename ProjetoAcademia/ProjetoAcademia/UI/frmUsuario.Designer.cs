namespace ProjetoAcademia.UI
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNovoUser = new System.Windows.Forms.Button();
            this.btnGravarUser = new System.Windows.Forms.Button();
            this.ckbAdministrador = new System.Windows.Forms.CheckBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNovoUser);
            this.tabPage1.Controls.Add(this.btnGravarUser);
            this.tabPage1.Controls.Add(this.ckbAdministrador);
            this.tabPage1.Controls.Add(this.txtSenhaUser);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmailUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNomeUser);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.FlatAppearance.BorderSize = 2;
            this.btnNovoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUser.Image = global::ProjetoAcademia.Properties.Resources._new;
            this.btnNovoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoUser.Location = new System.Drawing.Point(258, 288);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(101, 46);
            this.btnNovoUser.TabIndex = 17;
            this.btnNovoUser.Text = "Novo";
            this.btnNovoUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // btnGravarUser
            // 
            this.btnGravarUser.FlatAppearance.BorderSize = 2;
            this.btnGravarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarUser.Image = global::ProjetoAcademia.Properties.Resources.save;
            this.btnGravarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarUser.Location = new System.Drawing.Point(134, 288);
            this.btnGravarUser.Name = "btnGravarUser";
            this.btnGravarUser.Size = new System.Drawing.Size(118, 46);
            this.btnGravarUser.TabIndex = 16;
            this.btnGravarUser.Text = "Gravar";
            this.btnGravarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarUser.UseVisualStyleBackColor = true;
            this.btnGravarUser.Click += new System.EventHandler(this.btnGravarUser_Click);
            // 
            // ckbAdministrador
            // 
            this.ckbAdministrador.AutoSize = true;
            this.ckbAdministrador.Checked = true;
            this.ckbAdministrador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdministrador.Location = new System.Drawing.Point(134, 246);
            this.ckbAdministrador.Name = "ckbAdministrador";
            this.ckbAdministrador.Size = new System.Drawing.Size(141, 22);
            this.ckbAdministrador.TabIndex = 15;
            this.ckbAdministrador.Text = "Administrador";
            this.ckbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaUser.Location = new System.Drawing.Point(134, 213);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(243, 27);
            this.txtSenhaUser.TabIndex = 14;
            this.txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha:";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailUser.Location = new System.Drawing.Point(134, 161);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(445, 27);
            this.txtEmailUser.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail:";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUser.Location = new System.Drawing.Point(134, 109);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(445, 27);
            this.txtNomeUser.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluirUser);
            this.tabPage2.Controls.Add(this.btnEditarUser);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvConsulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.FlatAppearance.BorderSize = 2;
            this.btnExcluirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUser.Image = global::ProjetoAcademia.Properties.Resources.delete;
            this.btnExcluirUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirUser.Location = new System.Drawing.Point(595, 20);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(107, 46);
            this.btnExcluirUser.TabIndex = 18;
            this.btnExcluirUser.Text = "Excluir";
            this.btnExcluirUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirUser.UseVisualStyleBackColor = true;
            this.btnExcluirUser.Click += new System.EventHandler(this.BtnExcluirUser_Click);
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.FlatAppearance.BorderSize = 2;
            this.btnEditarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUser.Image = global::ProjetoAcademia.Properties.Resources._new;
            this.btnEditarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUser.Location = new System.Drawing.Point(482, 20);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(107, 46);
            this.btnEditarUser.TabIndex = 17;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUser.UseVisualStyleBackColor = true;
            this.btnEditarUser.Click += new System.EventHandler(this.BtnEditarUser_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(8, 39);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(445, 27);
            this.txtPesquisar.TabIndex = 12;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPesquisar_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pesquisar por nome...";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(8, 72);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(694, 341);
            this.dgvConsulta.TabIndex = 0;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 452);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNovoUser;
        private System.Windows.Forms.Button btnGravarUser;
        private System.Windows.Forms.CheckBox ckbAdministrador;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.Button btnEditarUser;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}