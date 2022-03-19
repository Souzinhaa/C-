using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Aluno
    {
        public String ra { get; set; }
        public String nome { get; set; }
        public String sexo { get; set; }
        public Disciplina[] disciplinas { get; set; } = new Disciplina[5];

        public Aluno(String ra, String nome, String sexo)
        {
            this.ra = ra;
            this.nome = nome;
            this.sexo = sexo;
        }

        public void imprimir()
        {
            Console.WriteLine("\nRA: " + this.ra);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Sexo: " + this.sexo);
            foreach (Disciplina d in this.disciplinas)
            {
                if (d != null)
                    Console.WriteLine("   Discilplina " + d.id + " - " + d.nome);
            }
        }
    }
}
