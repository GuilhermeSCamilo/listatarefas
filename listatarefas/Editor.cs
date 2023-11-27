using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace listatarefas
{
    public partial class Editor : Form
    {

        //Variável Global
        int IdSelecionado = 0;
        public Editor()
        {
            InitializeComponent();

            //Popular DGV com tabela produtos:
            Tarefas tarefa = new Tarefas();
            dgvListaTarefas.DataSource = tarefa.ListarTudo();


        }

        private void Editor_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvListaTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //Obter a linha:
            int linhaselecionada = dgvListaTarefas.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvListaTarefas.Rows[linhaselecionada];

            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
            txbLocalEdi.Text = linha.Cells[2].Value.ToString();
            txbObservacaoEdi.Text = linha.Cells[3].Value.ToString();
            dtpDataLimiteEdi.Text = linha.Cells[4].Value.ToString();

          

            //Armazenar ID selecionado na variavel global:
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnCadastrarTarefa_Click(object sender, EventArgs e)
        {
            //Instanciar a tarefa:
            Tarefas tarefa = new Tarefas();

            tarefa.NomeTarefa = txbNomeCad.Text;
            tarefa.Local = txbLocalCad.Text;
            tarefa.Observacao = txbObservacaoCad.Text;
            tarefa.DataLimite = DateTime.Parse(dtpDataLimiteCad.Text);

            if (tarefa.Cadastrar() == true)
            {
                MessageBox.Show("Tarefa cadastrado com sucesso!!");
                //Limpar os campos:
                txbNomeCad.Clear();
                txbLocalCad.Clear();
                txbObservacaoCad.Clear();

                //Atualizar Tabela:
                dgvListaTarefas.DataSource = tarefa.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao cadastrar tarefa");

            }
        }

        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            Tarefas tarefa = new Tarefas();

            tarefa.Id = IdSelecionado;
            tarefa.NomeTarefa = txbNomeEdi.Text;
            tarefa.Local = txbLocalEdi.Text;
            tarefa.Observacao = txbObservacaoEdi.Text;
            tarefa.DataLimite = DateTime.Parse(dtpDataLimiteEdi.Text);

            if (tarefa.Editar() == true)
            {
                MessageBox.Show("Tarefa editada", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar os campos:
                txbNomeEdi.Clear();
                txbLocalEdi.Clear();
                txbObservacaoEdi.Clear();

                //Atualizar Tabela:
                dgvListaTarefas.DataSource = tarefa.ListarTudo();

            

               
            }
            else
            {

                MessageBox.Show("Falha ao editar tarefa", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            Tarefas tarefa = new Tarefas();
            tarefa.Id = IdSelecionado;
            

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (tarefa.Apagar() == true)
                {
                    MessageBox.Show("Tarefa removida", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campos:
                    txbNomeEdi.Clear();
                    txbLocalEdi.Clear();
                    txbObservacaoEdi.Clear();

                    //Atualizar Tabela:
                    dgvListaTarefas.DataSource = tarefa.ListarTudo();

                   

                }
                else
                {

                    MessageBox.Show("Falha ao remover tarefa", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        }
    }
}

