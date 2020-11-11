using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProgramacao
{
    public class Disciplina
    {
        public string nome { get; set; }
        public string nota { get; set; }

        public Disciplina(string nome)
        {
            this.nome = nome;
            nota = "cursando";
        }
    }
}
