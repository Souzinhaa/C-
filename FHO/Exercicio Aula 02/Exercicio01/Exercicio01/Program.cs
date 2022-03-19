using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            Disciplina[] disciplinas = new Disciplina[5];

            Disciplina d1 = new Disciplina(1, "Programacao Web I");
            disciplinas[0] = d1;
            Disciplina d2 = new Disciplina(1, "Programacao Web II");
            disciplinas[1] = d2;
            Disciplina d3 = new Disciplina(1, "Programacao Web III");
            disciplinas[2] = d3;
            Disciplina d4 = new Disciplina(1, "Programacao Web IV");
            disciplinas[3] = d4;
            Disciplina d5 = new Disciplina(1, "Programacao Web V");
            disciplinas[4] = d5;

            Aluno a1 = new Aluno("110402", "Bruno", "Masculino");
            alunos[0] = a1;
            Aluno a2 = new Aluno("109264", "Adrian", "Masculino");
            alunos[1] = a2;
            Aluno a3 = new Aluno("110247", "Hyan", "Masculino");
            alunos[2] = a3;
            Aluno a4 = new Aluno("100240", "Mathias", "Masculino");
            alunos[3] = a4;
            Aluno a5 = new Aluno("110194", "Corba", "Feminino");
            alunos[4] = a5;

            for (int i = 0; i < 2; i++)
            {
                a1.disciplinas[i] = disciplinas[i];
            }

            for (int i = 0; i < 5; i++)
            {
                a2.disciplinas[i] = disciplinas[i];
            }

            for (int i = 2; i < 5; i++)
            {
                a3.disciplinas[i] = disciplinas[i];
            }

            Aluno a2copy = a2;

            Disciplina d1copy1 = d1;
            Disciplina d1copy2 = d1;

            d1copy2.nome = "Orientacao a Objetos";
            d1copy2.id = 10;

            a2.disciplinas[2].id = 30;
            a2.disciplinas[2].nome = "Sistemas Operacionais";

            foreach(Aluno a in alunos)
            {
                a.imprimir();
            }

        }
    }
}
