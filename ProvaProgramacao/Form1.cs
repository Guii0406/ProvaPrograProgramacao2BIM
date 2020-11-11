using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaProgramacao
{
    public partial class Form1 : Form
    {
        List<Curso> listaDeCursos = new List<Curso>();
        List<Aluno> listaDeAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
            CriarCursos();
        }
        void CriarCursos()
        {
            //CURSO C#
            List<string> disciplinasCsharp = new List<string>();
            disciplinasCsharp.AddRange(new string[2] { "algoritimos", "Fundamentos de programação" });
            listaDeCursos.Add(new Curso("c#", 60, disciplinasCsharp));

            //CURSO DEV WEB
            List<string> disciplinasDevWeb = new List<string>();
            disciplinasDevWeb.AddRange(new string[3] {"HTML", "CSS", "JavaScript" });
            listaDeCursos.Add(new Curso("Desenvolvimento Web", 90, disciplinasDevWeb));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginAluno formAluno = new FormLoginAluno(listaDeCursos, listaDeAlunos, this);
            formAluno.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor(listaDeCursos, listaDeAlunos, this);
            formProfessor.Show();
            this.Hide();
        }
    }
}
