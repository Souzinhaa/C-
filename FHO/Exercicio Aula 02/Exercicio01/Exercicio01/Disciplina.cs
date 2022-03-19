using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Disciplina
    {
        public int id { get; set; }
        public String nome { get; set; }

        public Disciplina(int id, String nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
