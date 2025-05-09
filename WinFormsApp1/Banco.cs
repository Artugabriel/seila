using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public static class Banco
    {
        //string de conexão com o banco de dados

        //BANCO DE DADOS LOCAL (XAMPP)

        //public static string db = "SERVER=localhost;USER=root;DATABASE=mestremotores";

        //BANCO DE DADOS ONLINE (SERVIDOR WEB)

        public static string db = "SERVER=w_system.vpshost3061.mysql.dbaas.com.br;USER=w_system;PASSWORD=senacJBQ@1;DATABASE=w_system;SSL MODE=None";
        //"SERVER=smpsistema.com.br;USER=u283879542_mestremotores;PASSWORD=Senac@Ti26;DATABASE=u283879542_mestremotores;SSL MODE=None";

        //ESTRUTURA DE CONEXÃO

        public static MySqlConnection conexao;

        //Método para Abrir a conexão com o banco

        public static void Conectar()

        {

            try

            {

                conexao = new MySqlConnection(db);

                conexao.Open();

            }

            catch

            {

                MessageBox.Show("Erro ao acessar o BANCO DE DADOS");

            }

        }

        //Método para fechar a conexão com o banco

        public static void Desconectar()

        {

            try

            {

                conexao = new MySqlConnection(db);

                conexao.Close();

            }

            catch

            {

                MessageBox.Show("Erro ao desconectar o BANCO DE DADOS");

            }

        }

    }

}
 
    

