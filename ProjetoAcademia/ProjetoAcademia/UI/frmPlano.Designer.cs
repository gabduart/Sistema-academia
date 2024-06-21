namespace ProjetoAcademia.UI
{
    partial class frmPlano
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoPlano = new System.Windows.Forms.Button();
            this.btnGravarPlano = new System.Windows.Forms.Button();
            this.txtPrecoPlano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnNovoPlano);
            this.tabPage1.Controls.Add(this.btnGravarPlano);
            this.tabPage1.Controls.Add(this.txtPrecoPlano);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNomePlano);
            this.tabPage1.Controls.Add(this.lbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 419);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(131, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Digite no formato: XX.XX";
            // 
            // btnNovoPlano
            // 
            this.btnNovoPlano.FlatAppearance.BorderSize = 2;
            this.btnNovoPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPlano.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPlano.Image = global::ProjetoAcademia.Properties.Resources._new;
            this.btnNovoPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPlano.Location = new System.Drawing.Point(258, 156);
            this.btnNovoPlano.Name = "btnNovoPlano";
            this.btnNovoPlano.Size = new System.Drawing.Size(101, 46);
            this.btnNovoPlano.TabIndex = 23;
            this.btnNovoPlano.Text = "Novo";
            this.btnNovoPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoPlano.UseVisualStyleBackColor = true;
            this.btnNovoPlano.Click += new System.EventHandler(this.btnNovoPlano_Click);
            // 
            // btnGravarPlano
            // 
            this.btnGravarPlano.FlatAppearance.BorderSize = 2;
            this.btnGravarPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarPlano.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarPlano.Image = global::ProjetoAcademia.Properties.Resources.save;
            this.btnGravarPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarPlano.Location = new System.Drawing.Point(134, 156);
            this.btnGravarPlano.Name = "btnGravarPlano";
            this.btnGravarPlano.Size = new System.Drawing.Size(118, 46);
            this.btnGravarPlano.TabIndex = 22;
            this.btnGravarPlano.Text = "Gravar";
            this.btnGravarPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarPlano.UseVisualStyleBackColor = true;
            this.btnGravarPlano.Click += new System.EventHandler(this.btnGravarPlano_Click);
            // 
            // txtPrecoPlano
            // 
            this.txtPrecoPlano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoPlano.Location = new System.Drawing.Point(134, 100);
            this.txtPrecoPlano.Name = "txtPrecoPlano";
            this.txtPrecoPlano.Size = new System.Drawing.Size(445, 27);
            this.txtPrecoPlano.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço:";
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePlano.Location = new System.Drawing.Point(134, 49);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.Size = new System.Drawing.Size(445, 27);
            this.txtNomePlano.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(131, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(113, 18);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Nome Plano:";
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
            this.tabPage2.Size = new System.Drawing.Size(792, 419);
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
            this.btnExcluirPlano.Location = new System.Drawing.Point(677, 16);
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
            this.btnEditarPlano.Location = new System.Drawing.Point(564, 16);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pesquisar por plano...";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 75);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(786, 341);
            this.dgvConsulta.TabIndex = 19;
            // 
            // frmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPlano";
            this.Text = "frmPlano";
            this.Load += new System.EventHandler(this.frmPlano_Load);
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
        private System.Windows.Forms.Button btnNovoPlano;
        private System.Windows.Forms.Button btnGravarPlano;
        private System.Windows.Forms.TextBox txtPrecoPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluirPlano;
        private System.Windows.Forms.Button btnEditarPlano;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label1;
    }
}