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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
