using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppADO
{
    // ADO = Active Data Objects - Objeto de Dados Ativos
    // Executa as ações no Banco de Dados
    public class DataBase : IDisposable
    {
        // Conexão Utilizada na Classe
        private MySqlConnection sqlConnection;

        // Alterar nessa Parte com os Dados do SGBD da Maquina
        private string server = "localhost";
        private string user = "admin";
        private string password = "admin";


        private string database = "system_users";


        // Contrutor da Classe ---> Ao inicia-la Retorna uma Conexão Aberta
        public DataBase()
        {
            sqlConnection = new MySqlConnection("server=" + server +
                ";user id=" + user +
                ";password=" + password +
                ";database=" + database);
            sqlConnection.Open();
        }


        // Executa um Comando (Select, Insert, Delete)
        public void executeCommand(string querry)
        {
            var command = new MySqlCommand
            {
                CommandText = querry,
                CommandType = System.Data.CommandType.Text,
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
        }

        // Retorna uma Matriz do Banco de Dados
        public MySqlDataReader readerTable(string querry)
        {
            var command = new MySqlCommand(querry, sqlConnection);
            return command.ExecuteReader();
        }

        // Quando termina a utilização da classe
        public void Dispose()
        {
            sqlConnection.Close();
        }
    }
}
