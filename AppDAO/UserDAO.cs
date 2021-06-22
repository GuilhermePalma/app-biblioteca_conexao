using AppADO;
using AppDLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDAO
{
    // Manipula as ações Para envia-las ao Banco de Dados
    public class UserDAO
    {
        // Executa as ações no Banco de Dados
        private DataBase database;

        public void Insert(User usuario)
        {
            String insertDB = "";

            insertDB = "INSERT INTO users(name, cargo, date) VALUE(";
            insertDB += string.Format("'{0}',", usuario.Name);
            insertDB += string.Format("'{0}',", usuario.Cargo);
            insertDB += string.Format("STR_TO_DATE('{0}','%d/%m/%Y'));", usuario.Date);

            using (database = new DataBase())
            {
                database.executeCommand(insertDB);
            }

        }

        public void Update(User usuario)
        {
            String updateUser = "";
            updateUser = "UPDATE USERS SET ";
            updateUser += string.Format("name='{0}',", usuario.Name);
            updateUser += string.Format("cargo='{0}',", usuario.Cargo);
            updateUser += string.Format("date=STR_TO_DATE('{0}'," +
                "'%d/%m/%Y') ", usuario.Date);
            updateUser += string.Format("WHERE id='{0}';", usuario.Id);

            using (database = new DataBase())
            {
                database.executeCommand(updateUser);
            }
        }

        public void Delete(User usuario)
        {
            String deleteUser = "";
            deleteUser = "DELETE FROM users WHERE ";
            deleteUser += string.Format("id = {0};", usuario.Id);

            using (database = new DataBase())
            {
                database.executeCommand(deleteUser);
            }
        }

        public MySqlDataReader SelectAll()
        {
            DataBase db = new DataBase();

            String selectAll = "SELECT * FROM USERS ORDER BY id asc;";

            return db.readerTable(selectAll);
        }

    }
}
