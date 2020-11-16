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
                cursos.Add(listaDeCursos[0]);
            }
            if (checkBox2.Checked)
            {
                cursos.Add(listaDeCursos[1]);
            }

            listaDeAlunos.Add(new Aluno(textBox1.Text, maskedTextBox1.Text, cursos));

            //MessageBox.Show($"Data de inicio: {listaDeAlunos[0].cursos[0].dataInicio.ToString("dd/MM/yyyy")}\nData limite: {listaDeAlunos[0].cursos[0].dataLimite.ToString("dd/MM/yyyy")} ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool achou = false;
            foreach(Aluno a in listaDeAlunos)
            {
                if(a.cpf == maskedTextBox2.Text)
                {
                    achou = true;
                    FormAluno formAluno = new FormAluno(a);
                    formAluno.Show();
                    break;
                }
            }
            if(achou == false)
            {
                MessageBox.Show("CPF não indentificado");
            }
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
