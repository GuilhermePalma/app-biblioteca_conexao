using AppDAO;
using AppDLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationUser
{
    class Program
    {
        // Parte Executavel do Programa ---> Controla e Usa as demais partes
        static void Main(string[] args)
        {

            Boolean numberAvalible = false;
            int option = 5;

            // Laço de Repetição ---> Só termina quando for inserida um Valor Valido
            while (!numberAvalible)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                drawMenu();

                try
                {
                    Console.WriteLine("\nOpção Escolhida: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    option = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Blue;

                    numberAvalible = true;

                    if (option >= 5 || option < 0)
                    {
                        drawError();
                        numberAvalible = false;
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    numberAvalible = false;

                    drawError();
                }

            }

            // Trata de Acordo com a Opção Selecionada pelo Usuario
            switch (option)
            {
                case 0:
                    insertUser();
                    break;

                case 1:
                    updateUser();
                    break;

                case 2:
                    deleteUser();
                    break;

                case 3:
                    listUsers();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }


        }

        // Desenha o Menu na Tela
        static private void drawMenu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("|   0 - Cadastrar Usuario   |");
            Console.WriteLine("|   1 - Editar Usuario      |");
            Console.WriteLine("|   2 - Excluir Usuario     |");
            Console.WriteLine("|   3 - Listar Usuario      |");
            Console.WriteLine("|   4 - Sair                |");
            Console.WriteLine("=============================");
        }

        // Mensagem de Erro na Tela
        static private void drawError()
        {
            Console.WriteLine("\nPressione 'Enter' e Escolha " +
                           "umas dessas Opções: 0, 1, 2, 3 ou 4");
            Console.ReadLine();

            Console.Clear();
        }


        // Insere um Usuario no Banco de Dados
        static private void insertUser()
        {
            Console.WriteLine("\n ---------------------------" +
                "\nDados do Novo Usuario: ");

            User user = new User();

            Console.WriteLine("\nDigite o Nome do Usuario");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDigite o Cargo do Usuario");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Cargo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDigite a Data de Nascimento do Usuario (DD/MM/AAAA)");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Date = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            UserDAO usuarioDAO = new UserDAO();
            usuarioDAO.Insert(user);
            listUsers();

        }

        // Ataliza um Usuario no Banco de Dados
        static private void updateUser()
        {
            Console.WriteLine("\n ---------------------------" +
                  "\nDados de Atualização do Usuario: ");

            User user = new User();

            Console.WriteLine("\nDigite o novo Nome do Usuario");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Name = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDigite o novo Cargo do Usuario");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Cargo = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDigite a nova Data de Nascimento do Usuario (DD/MM/AAAA)");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Date = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDigite o ID do Usuario que será alterado");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Id = Console.ReadLine();

            UserDAO usuarioDAO = new UserDAO();
            usuarioDAO.Update(user);
            listUsers();

        }

        // Exclui um Usuario no Banco de Dados
        static private void deleteUser()
        {
            Console.WriteLine("\n ---------------------------" +
                "\nDados para Deletar um Usuario: ");

            User user = new User();

            Console.WriteLine("\nDigite o ID (Identificação) do Usuario");
            Console.ForegroundColor = ConsoleColor.Red;
            user.Id = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            UserDAO usuarioDAO = new UserDAO();
            usuarioDAO.Delete(user);
            listUsers();

        }

        // Lista os Usuarios no Banco de Dados
        static private void listUsers()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            UserDAO usuarioDAO = new UserDAO();
            MySqlDataReader reader = usuarioDAO.SelectAll();

            Console.WriteLine("\n ---------------------------");

            if (!reader.HasRows)
            {
                Console.WriteLine("\nO Banco de Dados não possui nenhum Usuario Cadastrado.");
            }
            else
            {
                Console.WriteLine("\nListagem dos Usuarios: ");

                while (reader.Read())
                {
                    Console.WriteLine(" ID: {0}, Nome: {1}, Cargo: {2}, Data: {3}",
                        reader["id"], reader["name"], reader["cargo"],
                        reader["date"]);
                }
            }

            Console.ReadLine();
        }
    }
}
