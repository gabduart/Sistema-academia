using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    internal class Plano
    {
        private int idplano;
        private string nome;
        private float preco;

        // ENCAPSULAMENTO (GET/SET): CTRL + R, CTRL + E
        public int Idplano { get => idplano; set => idplano = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
