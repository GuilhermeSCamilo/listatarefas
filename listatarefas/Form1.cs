using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listatarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //Popular DGV com tabela produtos:
            Tarefas tarefa = new Tarefas();
            dgvListaTarefas.DataSource = tarefa.ListarTudo();



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Editor janela = new Editor();
            janela.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
