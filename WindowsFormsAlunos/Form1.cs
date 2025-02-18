using Biblioteca;

namespace WindowsFormsAlunos
{
    /// <summary>
    /// Representa o formulário principal da aplicação de gestão de alunos.
    /// Esta classe gerencia a interface do usuário para adicionar, exibir e remover alunos.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Lista que armazena os objetos Aluno.
        /// Esta coleção mantém todos os alunos adicionados durante a execução do programa.
        /// </summary>
        List<Aluno> Alunos;
        /// <summary>
        /// Lista que armazena os objetos Disciplina.
        /// Esta coleção mantém todas as Disciplinas adicionados durante a execução do programa.
        /// </summary>
        List<Disciplinas> Disciplinas;
        /// <summary>
        /// Contador para gerar IDs únicos para os alunos.
        /// Este contador é incrementado cada vez que um novo aluno é adicionado,
        /// garantindo que cada aluno tenha um ID único.
        /// </summary>
        int contaAlunos = 1;
        int contaDisciplinas = 1;
        /// <summary>
        /// Construtor do formulário.
        /// Inicializa a lista de Alunos e configura os componentes iniciais do formulário.
        /// </summary>
        public Form1()
        {
            Alunos = new List<Aluno>();
            Disciplinas = new List<Disciplinas>();
            InitializeComponent();
            TxtIdAluno.Text = contaAlunos.ToString();
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }
        /// <summary>
        /// Manipula o evento de clique no botão Guardar.
        /// Este método valida os dados inseridos, cria um novo objeto Aluno,
        /// adiciona-o à lista e atualiza a exibição da lista de alunos.
        /// Também limpa os campos de entrada após a adição bem-sucedida.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o botão Guardar.</param>
        /// <param name="e">Contém dados do evento. Não é utilizado neste método.</param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Cria um novo aluno com os dados fornecidos
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
                // Exibe uma mensagem de erro se a validação falhar
                MessageBox.Show("Preencha os dados corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
            TxtIdAluno.Text = contaAlunos.ToString();
        }
        /// <summary>
        /// Inicializa a ListBox com a lista atualizada de alunos.
        /// Este método é chamado sempre que a lista de alunos é modificada para
        /// garantir que a interface do usuário reflita o estado atual da lista.
        /// </summary>
        public void initLista()
        {
            // Reseta a fonte de dados para forçar a atualização
            AlunosListBox.DataSource = null;
            AlunosListBox.DataSource = Alunos;
            // Define qual propriedade do objeto Aluno será exibida na ListBox
            AlunosListBox.DisplayMember = "NomeCompleto";
        }

        /// <summary>
        /// Valida os campos do formulário.
        /// Verifica se os campos de nome e apelido do aluno foram preenchidos.
        /// Exibe mensagens de erro específicas para cada campo não preenchido.
        /// </summary>
        /// <returns>
        /// Retorna true se ambos os campos estão preenchidos, false caso contrário.
        /// </returns>
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

        /// <summary>
        /// Manipula o evento de clique no botão Cancelar.
        /// Limpa os campos de texto, descartando quaisquer dados não salvos.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o botão Cancelar.</param>
        /// <param name="e">Contém dados do evento. Não é utilizado neste método.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
        }

        /// <summary>
        /// Manipula o evento de clique no botão Apagar Aluno.
        /// Este método remove o aluno selecionado da lista após confirmação do usuário.
        /// Inclui verificações para garantir que um aluno está selecionado antes de tentar removê-lo.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o botão Apagar Aluno.</param>
        /// <param name="e">Contém dados do evento. Não é utilizado neste método.</param>
        private void BtnApagarAluno_Click(object sender, EventArgs e)
        {
            // Obtém o aluno selecionado na ListBox
            Aluno alunoApagar = (Aluno)AlunosListBox.SelectedItem;
            Aluno apagado = null;
            if (alunoApagar != null)
            {
                // Encontra o aluno correspondente na lista
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoApagar.Id == aluno.Id)
                    {
                        apagado = aluno;
                    }
                }

                if (apagado != null)
                {
                    // Solicita confirmação do usuário antes de apagar
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeCompleto}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resposta == DialogResult.OK)
                    {
                        // Remove o aluno da lista e atualiza a ListBox
                        Alunos.Remove(apagado);
                        initLista();
                    }
                }
            }
        }

        private void BtnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAEditar = (Aluno)AlunosListBox.SelectedItem;

            Aluno editado = null;

            if (alunoAEditar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoAEditar.Id == aluno.Id)
                    {
                        editado = aluno;
                    }
                }
                //abrir a nova form para editar
                EditarAlunoForm editarAlunoForm = new EditarAlunoForm(this, editado);
                editarAlunoForm.Show();
            }
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
    }
}
