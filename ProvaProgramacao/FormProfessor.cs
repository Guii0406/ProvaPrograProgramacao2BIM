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
    public partial class FormProfessor : Form
    {
        List<Curso> listaDeCursos;
        List<Aluno> listaDeAlunos;
        Form1 form1;
        Aluno aluno = null;
        public FormProfessor(List<Curso> listaDeCursos, List<Aluno> listaDeAlunos, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.listaDeAlunos = listaDeAlunos;
            this.listaDeCursos = listaDeCursos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Aluno a in listaDeAlunos)
            {
                if (a.nome == textBox1.Text)
                {
                    aluno = a;
                    break;
                }
            }
            if (aluno == null)
            {
                MessageBox.Show("Aluno não encontrado");
                return;
            }
            listView1.Items.Clear();
            label2.Text = aluno.nome;
            label3.Text = aluno.cpf;

            foreach (Curso c in aluno.cursos)
            {
                string[] item = new string[3] { c.nome, c.nota, c.dataLimite.ToString("dd/MM/yyyy") };
                item[0] = c.nome;
                if (c.concluido == true && c.nota == "cursando")
                {
                    item[1] = "concluido/esperando nota";
                }
                listView1.Items.Add(new ListViewItem(item));
            }
        }

        private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index;
            if (aluno.cursos[index].concluido == true || DateTime.Today >= aluno.cursos[index].dataLimite)
            {
                aluno.cursos[index].nota = numericUpDown1.Value.ToString();
                listView1.SelectedItems[0].SubItems[1].Text = numericUpDown1.Value.ToString();
                aluno.cursos[index].concluido = true;
            }
            else
            {
                MessageBox.Show("O aluno ainda não concluiu este curso");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index;
            if (DateTime.Today >= aluno.cursos[index].dataLimite && aluno.cursos[index].concluido == false)
            {
                aluno.cursos[index].dataLimite = aluno.cursos[index].dataLimite.AddDays((int)numericUpDown2.Value);
                listView1.SelectedItems[0].SubItems[2].Text = aluno.cursos[index].dataLimite.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("O prazo ainda não acabou");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
