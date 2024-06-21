using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Usuario
    {
        private int idusuario;
        private string nome;
        private string email;
        private string senha;
        private bool isadm;

        // ENCAPSULAMENTO (GET/SET): CTRL + R, CTRL + E
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Isadm { get => isadm; set => isadm = value; }
    }
}
