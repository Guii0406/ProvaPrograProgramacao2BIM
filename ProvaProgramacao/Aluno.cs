using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProgramacao
{
    public class Aluno
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public new List<Curso> cursos { get; set; }
        

        public Aluno(string nome, string cpf, List<Curso> cursos)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cursos = cursos;
        }
    }
}
