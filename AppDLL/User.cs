using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    // DLL = Dynamic Link Library
    // Classe com os dados do Usuario
    public class User
    {
        private string id;
        private string name;
        private string cargo;
        private string date;

        public User() { }

        public User(string id, string name, string cargo, string date)
        {
            this.id = id;
            this.name = name;
            this.cargo = cargo;
            this.date = date;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Date { get => date; set => date = value; }
    }
}
