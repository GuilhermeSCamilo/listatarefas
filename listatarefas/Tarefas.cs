using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace listatarefas
{
    internal class Tarefas
    {
        public int Id { get; set; }
        public string NomeTarefa { get; set; }
        public string Local { get; set; }
        public string Observacao { get; set; }
        public DateTime DataLimite { get; set; }

        public bool Cadastrar()
        {

            string comando = "INSERT INTO tarefas (nome_tarefa, local, observacao, data_limite) " +
                    "VALUES (@nome_tarefa, @local, @observacao, @data_limite)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
           
            cmd.Parameters.AddWithValue("@nome_tarefa", NomeTarefa);
            cmd.Parameters.AddWithValue("@local", Local);
            cmd.Parameters.AddWithValue("@observacao", Observacao);
            cmd.Parameters.AddWithValue("@data_limite", DataLimite);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }



        }


        public bool Editar()
        {
            string comando = "UPDATE tarefas SET nome_tarefa = @nome_tarefa, " +
                "local = @local, observacao = @observacao, data_limite = @data_limite WHERE id = @id";           
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome_tarefa", NomeTarefa);
            cmd.Parameters.AddWithValue("@local", Local);
            cmd.Parameters.AddWithValue("@observacao", Observacao);
            cmd.Parameters.AddWithValue("@data_limite", DataLimite);
           
            cmd.Prepare();


            //try
            //{
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
        //}
        //    catch
        //    {
        //        conexaoBD.Desconectar(con);
        //        return false;
        //    }
}

        public bool Apagar()
        {
            string comando = "DELETE FROM tarefas WHERE id = @id";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;

            }
        }




        public DataTable ListarTudo()
        {
            string comando = "SELECT * FROM tarefas";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            DataTable tabela = new DataTable();
            MySqlCommand cmd = new MySqlCommand(comando, con);



            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;


        }
    }
}
