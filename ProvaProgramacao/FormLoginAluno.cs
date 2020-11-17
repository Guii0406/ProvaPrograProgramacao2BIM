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
    public partial class FormLoginAluno : Form
    {
        List<Curso> listaDeCursos;
        List<Aluno> listaDeAlunos;
        Form1 form1;
        public FormLoginAluno(List<Curso> listaDeCursos, List<Aluno> listaDeAlunos, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.listaDeAlunos = listaDeAlunos;
            this.listaDeCursos = listaDeCursos;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Curso> cursos = new List<Curso>();

            if (checkBox1.Checked)
            {
                List<string> disciplinasCsharp = new List<string>();
                disciplinasCsharp.AddRange(new string[2] { "algoritimos", "Fundamentos de programação" });
                cursos.Add(new Curso("c#", 60, disciplinasCsharp));
            }
            if (checkBox2.Checked)
            {
                List<string> disciplinasDevWeb = new List<string>();
                disciplinasDevWeb.AddRange(new string[3] { "HTML", "CSS", "JavaScript" });
                cursos.Add(new Curso("Desenvolvimento Web", 90, disciplinasDevWeb));
            }

            listaDeAlunos.Add(new Aluno(textBox1.Text, maskedTextBox1.Text, cursos));

            //MessageBox.Show($"Data de inicio: {listaDeAlunos[0].cursos[0].dataInicio.ToString("dd/MM/yyyy")}\nData limite: {listaDeAlunos[0].cursos[0].dataLimite.ToString("dd/MM/yyyy")} ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aluno aluno = null;
            bool achou = false;
            foreach(Aluno a in listaDeAlunos)
            {
                if(a.cpf == maskedTextBox2.Text)
                {
                    achou = true;
                    //FormAluno formAluno = new FormAluno(ref a);
                    //formAluno.Show();
                    aluno = a;
                    break;
                }
            }
            if(achou == false)
            {
                MessageBox.Show("CPF não indentificado");
                return;
            }
            FormAluno formAluno = new FormAluno(ref aluno);
            formAluno.Show();
        }

        private void FormLoginAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
    }
}
