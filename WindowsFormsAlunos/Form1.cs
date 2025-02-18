using Biblioteca;

namespace WindowsFormsAlunos
{
    /// <summary>
    /// Representa o formul�rio principal da aplica��o de gest�o de alunos.
    /// Esta classe gerencia a interface do usu�rio para adicionar, exibir e remover alunos.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Lista que armazena os objetos Aluno.
        /// Esta cole��o mant�m todos os alunos adicionados durante a execu��o do programa.
        /// </summary>
        List<Aluno> Alunos;
        /// <summary>
        /// Lista que armazena os objetos Disciplina.
        /// Esta cole��o mant�m todas as Disciplinas adicionados durante a execu��o do programa.
        /// </summary>
        List<Disciplinas> Disciplinas;
        /// <summary>
        /// Contador para gerar IDs �nicos para os alunos.
        /// Este contador � incrementado cada vez que um novo aluno � adicionado,
        /// garantindo que cada aluno tenha um ID �nico.
        /// </summary>
        int contaAlunos = 1;
        int contaDisciplinas = 1;
        /// <summary>
        /// Construtor do formul�rio.
        /// Inicializa a lista de Alunos e configura os componentes iniciais do formul�rio.
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
        /// Manipula o evento de clique no bot�o Guardar.
        /// Este m�todo valida os dados inseridos, cria um novo objeto Aluno,
        /// adiciona-o � lista e atualiza a exibi��o da lista de alunos.
        /// Tamb�m limpa os campos de entrada ap�s a adi��o bem-sucedida.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o bot�o Guardar.</param>
        /// <param name="e">Cont�m dados do evento. N�o � utilizado neste m�todo.</param>
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
                // Exibe uma mensagem de erro se a valida��o falhar
                MessageBox.Show("Preencha os dados corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
            TxtIdAluno.Text = contaAlunos.ToString();
        }
        /// <summary>
        /// Inicializa a ListBox com a lista atualizada de alunos.
        /// Este m�todo � chamado sempre que a lista de alunos � modificada para
        /// garantir que a interface do usu�rio reflita o estado atual da lista.
        /// </summary>
        public void initLista()
        {
            // Reseta a fonte de dados para for�ar a atualiza��o
            AlunosListBox.DataSource = null;
            AlunosListBox.DataSource = Alunos;
            // Define qual propriedade do objeto Aluno ser� exibida na ListBox
            AlunosListBox.DisplayMember = "NomeCompleto";
        }

        /// <summary>
        /// Valida os campos do formul�rio.
        /// Verifica se os campos de nome e apelido do aluno foram preenchidos.
        /// Exibe mensagens de erro espec�ficas para cada campo n�o preenchido.
        /// </summary>
        /// <returns>
        /// Retorna true se ambos os campos est�o preenchidos, false caso contr�rio.
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
        /// Manipula o evento de clique no bot�o Cancelar.
        /// Limpa os campos de texto, descartando quaisquer dados n�o salvos.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o bot�o Cancelar.</param>
        /// <param name="e">Cont�m dados do evento. N�o � utilizado neste m�todo.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNomeAluno.Text = string.Empty;
            TxtApelido.Text = string.Empty;
        }

        /// <summary>
        /// Manipula o evento de clique no bot�o Apagar Aluno.
        /// Este m�todo remove o aluno selecionado da lista ap�s confirma��o do usu�rio.
        /// Inclui verifica��es para garantir que um aluno est� selecionado antes de tentar remov�-lo.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, normalmente o bot�o Apagar Aluno.</param>
        /// <param name="e">Cont�m dados do evento. N�o � utilizado neste m�todo.</param>
        private void BtnApagarAluno_Click(object sender, EventArgs e)
        {
            // Obt�m o aluno selecionado na ListBox
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
                    // Solicita confirma��o do usu�rio antes de apagar
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
                // Exibe uma mensagem de erro se a valida��o falhar
                MessageBox.Show("Preencha os dados corretamente e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNomeDisciplina.Text = string.Empty;            
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }
    }
}
