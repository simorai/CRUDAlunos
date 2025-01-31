using Biblioteca;

namespace WindowsFormsAlunos
{
    public partial class Form1 : Form
    {
        List<Aluno> Alunos;
        int contaAlunos = 1;
        public Form1()
        {
            Alunos = new List<Aluno>();
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno;
            if (ValidaForm())
            {
                novoAluno = new Aluno
                {
                    Id = contaAlunos,
                    Nome = TxtNomeAluno.Text,
                    Apelido = TxtApelido.Text,
                };
                Alunos.Add(novoAluno);
                contaAlunos++;
                initLista();
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
        }

        private void initLista()
        {
            AlunosListBox.DataSource = null;
            AlunosListBox.DataSource = Alunos;
            AlunosListBox.DisplayMember = "NomeCompleto";
        }

        private bool ValidaForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(TxtNomeAluno.Text))
            {
                MessageBox.Show("Inserir nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(TxtApelido.Text))
            {
                MessageBox.Show("Inserir apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
        }

        private void BtnApagarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoApagar = (Aluno)AlunosListBox.SelectedItem;
            Aluno apagado = null;
            if (alunoApagar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoApagar.Id == aluno.Id)
                    {
                        apagado = aluno;
                    }
                }

                if(apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeCompleto}","Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resposta == DialogResult.OK)
                    {
                        Alunos.Remove(apagado);
                        initLista();
                    }
                }
            }
        }
    }
}
