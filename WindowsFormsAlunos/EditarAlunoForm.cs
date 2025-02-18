using Biblioteca;

namespace WindowsFormsAlunos
{
    public partial class EditarAlunoForm : Form
    {
        Aluno _editado;
        Form1 _form;
        public EditarAlunoForm(Form1 form, Aluno editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;

            TxtIdAluno.Text = editado.Id.ToString();
            TxtNomeAluno.Text = editado.Nome;
            TxtApelido.Text = editado.Apelido;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = TxtNomeAluno.Text;
                _editado.Apelido = TxtApelido.Text;
                _form.initLista();
                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(TxtNomeAluno.Text))
            {
                MessageBox.Show("Inserir nome do aluno",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(TxtApelido.Text))
            {
                MessageBox.Show("Inserir apelido do aluno",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
