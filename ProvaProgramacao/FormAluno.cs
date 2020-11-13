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
    public partial class FormAluno : Form
    {
        Aluno aluno;
        public FormAluno(Aluno aluno)
        {
            InitializeComponent();
            label1.Text = aluno.nome;
            label2.Text = aluno.cpf;

            foreach (Curso c in aluno.cursos)
            {
                string[] item = new string[3] { c.nome, c.nota, c.dataLimite.ToString("dd/MM/yyyy") };
                item[0] = c.nome;
                if (c.concluido == true && c.nota == "cursando")
                {
                    item[1] = "concluido/esperando nota";
                }
                if (c.concluido == false && c.nota == "cursando" && (DateTime.Today >= c.dataLimite))
                {
                    item[2] = "não concluído";
                }
                listView1.Items.Add(new ListViewItem(item));
            }
            this.aluno = aluno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index;
            if (aluno.cursos[index].concluido == true)
            {
                MessageBox.Show("Você ja finalizou este curso");
                return;
            }
            aluno.cursos[index].concluido = true;
            try
            {
                listView1.SelectedItems[0].SubItems[1].Text = "concluido/esperando nota";
            }
            catch (Exception erro) { }
        }
    }
}
