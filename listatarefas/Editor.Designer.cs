namespace listatarefas
{
    partial class Editor
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
            this.btnCadastrarTarefa = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.dgvListaTarefas = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.txbObservacaoCad = new System.Windows.Forms.TextBox();
            this.txbLocalCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblObservacaoCad = new System.Windows.Forms.Label();
            this.lblLocalCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.dtpDataLimiteCad = new System.Windows.Forms.DateTimePicker();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbObservacaoEdi = new System.Windows.Forms.TextBox();
            this.txbLocalEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblObservacaoEdi = new System.Windows.Forms.Label();
            this.lblLocalEdi = new System.Windows.Forms.Label();
            this.lblNomeTarefa = new System.Windows.Forms.Label();
            this.dtpDataLimiteEdi = new System.Windows.Forms.DateTimePicker();
            this.lblDataEdi = new System.Windows.Forms.Label();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarefas)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarTarefa
            // 
            this.btnCadastrarTarefa.Location = new System.Drawing.Point(39, 132);
            this.btnCadastrarTarefa.Name = "btnCadastrarTarefa";
            this.btnCadastrarTarefa.Size = new System.Drawing.Size(108, 27);
            this.btnCadastrarTarefa.TabIndex = 0;
            this.btnCadastrarTarefa.Text = "Cadastrar";
            this.btnCadastrarTarefa.UseVisualStyleBackColor = true;
            this.btnCadastrarTarefa.Click += new System.EventHandler(this.btnCadastrarTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(531, 427);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(108, 27);
            this.btnExcluirTarefa.TabIndex = 2;
            this.btnExcluirTarefa.Text = "Excluir";
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // dgvListaTarefas
            // 
            this.dgvListaTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTarefas.Location = new System.Drawing.Point(251, 31);
            this.dgvListaTarefas.Name = "dgvListaTarefas";
            this.dgvListaTarefas.ReadOnly = true;
            this.dgvListaTarefas.Size = new System.Drawing.Size(388, 390);
            this.dgvListaTarefas.TabIndex = 3;
            this.dgvListaTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTarefas_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.dtpDataLimiteCad);
            this.grbCadastrar.Controls.Add(this.lblDataCad);
            this.grbCadastrar.Controls.Add(this.txbObservacaoCad);
            this.grbCadastrar.Controls.Add(this.txbLocalCad);
            this.grbCadastrar.Controls.Add(this.txbNomeCad);
            this.grbCadastrar.Controls.Add(this.lblObservacaoCad);
            this.grbCadastrar.Controls.Add(this.lblLocalCad);
            this.grbCadastrar.Controls.Add(this.lblNomeCad);
            this.grbCadastrar.Controls.Add(this.btnCadastrarTarefa);
            this.grbCadastrar.Location = new System.Drawing.Point(33, 31);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(199, 164);
            this.grbCadastrar.TabIndex = 4;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // txbObservacaoCad
            // 
            this.txbObservacaoCad.Location = new System.Drawing.Point(104, 80);
            this.txbObservacaoCad.Name = "txbObservacaoCad";
            this.txbObservacaoCad.Size = new System.Drawing.Size(83, 20);
            this.txbObservacaoCad.TabIndex = 12;
            // 
            // txbLocalCad
            // 
            this.txbLocalCad.Location = new System.Drawing.Point(104, 56);
            this.txbLocalCad.Name = "txbLocalCad";
            this.txbLocalCad.Size = new System.Drawing.Size(83, 20);
            this.txbLocalCad.TabIndex = 11;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(104, 30);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(83, 20);
            this.txbNomeCad.TabIndex = 10;
            // 
            // lblObservacaoCad
            // 
            this.lblObservacaoCad.AutoSize = true;
            this.lblObservacaoCad.Location = new System.Drawing.Point(12, 80);
            this.lblObservacaoCad.Name = "lblObservacaoCad";
            this.lblObservacaoCad.Size = new System.Drawing.Size(68, 13);
            this.lblObservacaoCad.TabIndex = 9;
            this.lblObservacaoCad.Text = "Observação:";
            // 
            // lblLocalCad
            // 
            this.lblLocalCad.AutoSize = true;
            this.lblLocalCad.Location = new System.Drawing.Point(12, 54);
            this.lblLocalCad.Name = "lblLocalCad";
            this.lblLocalCad.Size = new System.Drawing.Size(36, 13);
            this.lblLocalCad.TabIndex = 8;
            this.lblLocalCad.Text = "Local:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(12, 30);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(72, 13);
            this.lblNomeCad.TabIndex = 7;
            this.lblNomeCad.Text = "Nome Tarefa:";
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Location = new System.Drawing.Point(12, 106);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(63, 13);
            this.lblDataCad.TabIndex = 13;
            this.lblDataCad.Text = "Data Limite:";
            // 
            // dtpDataLimiteCad
            // 
            this.dtpDataLimiteCad.Location = new System.Drawing.Point(104, 106);
            this.dtpDataLimiteCad.Name = "dtpDataLimiteCad";
            this.dtpDataLimiteCad.Size = new System.Drawing.Size(83, 20);
            this.dtpDataLimiteCad.TabIndex = 14;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.dtpDataLimiteEdi);
            this.grbEditar.Controls.Add(this.lblDataEdi);
            this.grbEditar.Controls.Add(this.txbObservacaoEdi);
            this.grbEditar.Controls.Add(this.txbLocalEdi);
            this.grbEditar.Controls.Add(this.btnEditarTarefa);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblObservacaoEdi);
            this.grbEditar.Controls.Add(this.lblLocalEdi);
            this.grbEditar.Controls.Add(this.lblNomeTarefa);
            this.grbEditar.Location = new System.Drawing.Point(33, 263);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(200, 158);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txbObservacaoEdi
            // 
            this.txbObservacaoEdi.Location = new System.Drawing.Point(98, 73);
            this.txbObservacaoEdi.Name = "txbObservacaoEdi";
            this.txbObservacaoEdi.Size = new System.Drawing.Size(83, 20);
            this.txbObservacaoEdi.TabIndex = 6;
            // 
            // txbLocalEdi
            // 
            this.txbLocalEdi.Location = new System.Drawing.Point(98, 49);
            this.txbLocalEdi.Name = "txbLocalEdi";
            this.txbLocalEdi.Size = new System.Drawing.Size(83, 20);
            this.txbLocalEdi.TabIndex = 5;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(98, 23);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(83, 20);
            this.txbNomeEdi.TabIndex = 4;
            // 
            // lblObservacaoEdi
            // 
            this.lblObservacaoEdi.AutoSize = true;
            this.lblObservacaoEdi.Location = new System.Drawing.Point(6, 75);
            this.lblObservacaoEdi.Name = "lblObservacaoEdi";
            this.lblObservacaoEdi.Size = new System.Drawing.Size(68, 13);
            this.lblObservacaoEdi.TabIndex = 2;
            this.lblObservacaoEdi.Text = "Observação:";
            // 
            // lblLocalEdi
            // 
            this.lblLocalEdi.AutoSize = true;
            this.lblLocalEdi.Location = new System.Drawing.Point(6, 50);
            this.lblLocalEdi.Name = "lblLocalEdi";
            this.lblLocalEdi.Size = new System.Drawing.Size(36, 13);
            this.lblLocalEdi.TabIndex = 1;
            this.lblLocalEdi.Text = "Local:";
            // 
            // lblNomeTarefa
            // 
            this.lblNomeTarefa.AutoSize = true;
            this.lblNomeTarefa.Location = new System.Drawing.Point(6, 26);
            this.lblNomeTarefa.Name = "lblNomeTarefa";
            this.lblNomeTarefa.Size = new System.Drawing.Size(72, 13);
            this.lblNomeTarefa.TabIndex = 0;
            this.lblNomeTarefa.Text = "Nome Tarefa:";
            // 
            // dtpDataLimiteEdi
            // 
            this.dtpDataLimiteEdi.Location = new System.Drawing.Point(98, 99);
            this.dtpDataLimiteEdi.Name = "dtpDataLimiteEdi";
            this.dtpDataLimiteEdi.Size = new System.Drawing.Size(83, 20);
            this.dtpDataLimiteEdi.TabIndex = 16;
            // 
            // lblDataEdi
            // 
            this.lblDataEdi.AutoSize = true;
            this.lblDataEdi.Location = new System.Drawing.Point(6, 99);
            this.lblDataEdi.Name = "lblDataEdi";
            this.lblDataEdi.Size = new System.Drawing.Size(63, 13);
            this.lblDataEdi.TabIndex = 15;
            this.lblDataEdi.Text = "Data Limite:";
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Location = new System.Drawing.Point(39, 125);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(108, 27);
            this.btnEditarTarefa.TabIndex = 1;
            this.btnEditarTarefa.Text = "Editar";
            this.btnEditarTarefa.UseVisualStyleBackColor = true;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 520);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvListaTarefas);
            this.Controls.Add(this.btnExcluirTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarefas)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarTarefa;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.DataGridView dgvListaTarefas;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataLimiteCad;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.TextBox txbObservacaoCad;
        private System.Windows.Forms.TextBox txbLocalCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblObservacaoCad;
        private System.Windows.Forms.Label lblLocalCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.DateTimePicker dtpDataLimiteEdi;
        private System.Windows.Forms.Label lblDataEdi;
        private System.Windows.Forms.TextBox txbObservacaoEdi;
        private System.Windows.Forms.TextBox txbLocalEdi;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblObservacaoEdi;
        private System.Windows.Forms.Label lblLocalEdi;
        private System.Windows.Forms.Label lblNomeTarefa;
    }
}