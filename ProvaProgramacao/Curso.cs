using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProgramacao
{
    public class Curso
    {
        public string nome { get; set; }
        public int duracao { get; set; }
        public List<string> disciplinas { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataLimite { get; set; }
        public string nota { get; set; }
        public bool concluido { get; set; }

        public Curso(string nome, int duracao, List<string> disciplinas)
        {
            this.nome = nome;
            this.duracao = duracao;
            this.disciplinas = disciplinas;
            this.nota = "cursando";
            this.dataInicio = DateTime.Today;
            this.dataLimite = dataInicio.AddDays(duracao);
            this.concluido = false;
        }
    }

}
