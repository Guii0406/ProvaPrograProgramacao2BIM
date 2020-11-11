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
        public FormAluno(Aluno aluno)
        {
            InitializeComponent();
            label1.Text = aluno.nome;
            label2.Text = aluno.cpf;

            foreach (Curso c in aluno.cursos)
            {
                string[] item = new string[2] { c.nome, c.nota };
                listView1.Items.Add(new ListViewItem(item));
            }
        }
    }
}
