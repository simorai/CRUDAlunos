using Biblioteca;

namespace WindowsFormsAlunos
{
    public partial class EditarDisciplinaForm : Form
    {
        Disciplinas _editado;
        Form2 _form;

        public EditarDisciplinaForm(Form2 form, Disciplinas editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;

            TxtIdDisciplina.Text = editado.Id.ToString();
            TxtNomeDisciplina.Text = editado.Disciplina;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Disciplina = TxtNomeDisciplina.Text;
                _form.initLista();
                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(TxtNomeDisciplina.Text))
            {
                MessageBox.Show("Inserir nome do aluno",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
