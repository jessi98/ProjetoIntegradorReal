using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorReal
{
    class Login
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }


        public Login() { }

        public Login(int codigo, string nome, string senha)
        {
            Codigo = codigo;
            Nome = nome;
            Senha = senha;
        }

        public static List<Login> ListaUsuarios = new List<Login>();

        public void Cadastrar()
        {
            ListaUsuarios.Add(this);
        }

    }
}
