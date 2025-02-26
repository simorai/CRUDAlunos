using Biblioteca;

namespace WindowsFormsAlunos
{
    public partial class Form2 : Form
    {
        List<Disciplinas> Disciplinas;
        int contaDisciplinas = 1;
        public Form2()
        {
            InitializeComponent();
            Disciplinas = new List<Disciplinas>();
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }
        public void initLista()
        {
            // Reseta a fonte de dados para forçar a atualização
            DisciplinasListBox.DataSource = null;
            DisciplinasListBox.DataSource = Disciplinas;
            // Define qual propriedade do objeto Aluno será exibida na ListBox
            DisciplinasListBox.DisplayMember = "Disciplina";
        }
        private bool ValidaForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txtNomeDisciplina.Text))
            {
                MessageBox.Show("Inserir disciplina", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void btnGuardarDisciplina_Click(object sender, EventArgs e)
        {
            // Cria uma nova disciplina com os dados fornecidos
            Disciplinas novaDisciplina;
            if (ValidaForm())
            {
                novaDisciplina = new Disciplinas
                {
                    Id = contaDisciplinas,
                    Disciplina = txtNomeDisciplina.Text,

                };
                Disciplinas.Add(novaDisciplina);
                contaDisciplinas++;
                initLista();
            }
            else
            {
                // Exibe uma mensagem de erro se a validação falhar
                MessageBox.Show("Preencha os dados corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNomeDisciplina.Text = string.Empty;
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }

        private void BtnLimparDisciplina_Click(object sender, EventArgs e)
        {
            txtNomeDisciplina.Text = string.Empty;
        }

        private void BtnApagarDisciplina_Click(object sender, EventArgs e)
        {
            // Obtém o aluno selecionado na ListBox
            Disciplinas disciplinaApagar = (Disciplinas)DisciplinasListBox.SelectedItem;
            Disciplinas apagado = null;
            if (disciplinaApagar != null)
            {
                // Encontra o aluno correspondente na lista
                foreach (Disciplinas disciplina in Disciplinas)
                {
                    if (disciplinaApagar.Id == disciplina.Id)
                    {
                        apagado = disciplina;
                    }
                }

                if (apagado != null)
                {
                    // Solicita confirmação do usuário antes de apagar
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar a disciplina {apagado.Disciplina}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resposta == DialogResult.OK)
                    {
                        // Remove o aluno da lista e atualiza a ListBox
                        Disciplinas.Remove(apagado);
                        initLista();
                    }
                }
            }
        }

        private void BtnEditarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplinas disciplinaEditar = (Disciplinas)DisciplinasListBox.SelectedItem;

            Disciplinas editado = null;

            if (disciplinaEditar != null)
            {
                foreach (Disciplinas disciplina in Disciplinas)
                {
                    if (disciplinaEditar.Id == disciplina.Id)
                    {
                        editado = disciplina;
                    }
                }
                //abrir a nova form para editar a disciplina
                EditarDisciplinaForm editarDisciplinaForm = new EditarDisciplinaForm(this, editado);
                editarDisciplinaForm.Show();

            }
        }
    }
}
