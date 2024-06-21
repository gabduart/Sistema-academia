namespace ProjetoAcademia.UI
{
    partial class frmAluno
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
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnGravarAluno = new System.Windows.Forms.Button();
            this.txtTelefoneAluno = new System.Windows.Forms.TextBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirPlano = new System.Windows.Forms.Button();
            this.btnEditarPlano = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNovoAluno);
            this.tabPage1.Controls.Add(this.btnGravarAluno);
            this.tabPage1.Controls.Add(this.txtTelefoneAluno);
            this.tabPage1.Controls.Add(this.txtEmailAluno);
            this.tabPage1.Controls.Add(this.txtCpfAluno);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNomeAluno);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 421);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.FlatAppearance.BorderSize = 2;
            this.btnNovoAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAluno.Image = global::ProjetoAcademia.Properties.Resources._new;
            this.btnNovoAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAluno.Location = new System.Drawing.Point(258, 237);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(101, 46);
            this.btnNovoAluno.TabIndex = 23;
            this.btnNovoAluno.Text = "Novo";
            this.btnNovoAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnGravarAluno
            // 
            this.btnGravarAluno.FlatAppearance.BorderSize = 2;
            this.btnGravarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarAluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarAluno.Image = global::ProjetoAcademia.Properties.Resources.save;
            this.btnGravarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarAluno.Location = new System.Drawing.Point(134, 237);
            this.btnGravarAluno.Name = "btnGravarAluno";
            this.btnGravarAluno.Size = new System.Drawing.Size(118, 46);
            this.btnGravarAluno.TabIndex = 22;
            this.btnGravarAluno.Text = "Gravar";
            this.btnGravarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarAluno.UseVisualStyleBackColor = true;
            this.btnGravarAluno.Click += new System.EventHandler(this.btnGravarAluno_Click);
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneAluno.Location = new System.Drawing.Point(134, 204);
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(445, 27);
            this.txtTelefoneAluno.TabIndex = 21;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAluno.Location = new System.Drawing.Point(134, 152);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(445, 27);
            this.txtEmailAluno.TabIndex = 20;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfAluno.Location = new System.Drawing.Point(134, 100);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(445, 27);
            this.txtCpfAluno.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAluno.Location = new System.Drawing.Point(134, 49);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(445, 27);
            this.txtNomeAluno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluirPlano);
            this.tabPage2.Controls.Add(this.btnEditarPlano);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvConsulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 421);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPlano
            // 
            this.btnExcluirPlano.FlatAppearance.BorderSize = 2;
            this.btnExcluirPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPlano.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPlano.Image = global::ProjetoAcademia.Properties.Resources.delete;
            this.btnExcluirPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirPlano.Location = new System.Drawing.Point(600, 16);
            this.btnExcluirPlano.Name = "btnExcluirPlano";
            this.btnExcluirPlano.Size = new System.Drawing.Size(107, 46);
            this.btnExcluirPlano.TabIndex = 23;
            this.btnExcluirPlano.Text = "Excluir";
            this.btnExcluirPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirPlano.UseVisualStyleBackColor = true;
            this.btnExcluirPlano.Click += new System.EventHandler(this.BtnExcluirPlano_Click);
            // 
            // btnEditarPlano
            // 
            this.btnEditarPlano.FlatAppearance.BorderSize = 2;
            this.btnEditarPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPlano.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlano.Image = global::ProjetoAcademia.Properties.Resources._new;
            this.btnEditarPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPlano.Location = new System.Drawing.Point(487, 16);
            this.btnEditarPlano.Name = "btnEditarPlano";
            this.btnEditarPlano.Size = new System.Drawing.Size(107, 46);
            this.btnEditarPlano.TabIndex = 22;
            this.btnEditarPlano.Text = "Editar";
            this.btnEditarPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPlano.UseVisualStyleBackColor = true;
            this.btnEditarPlano.Click += new System.EventHandler(this.BtnEditarPlano_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(3, 35);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(445, 27);
            this.txtPesquisar.TabIndex = 21;
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPesquisar_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pesquisar por nome...";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 77);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(704, 341);
            this.dgvConsulta.TabIndex = 19;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAluno";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluirPlano;
        private System.Windows.Forms.Button btnEditarPlano;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtTelefoneAluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnGravarAluno;
    }
}