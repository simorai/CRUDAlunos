namespace Biblioteca
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        /// <summary>
        /// Obtém o nome completo do aluno, combinando o Nome e o Apelido.
        /// </summary>
        /// <value>Uma string contendo o nome completo do aluno no formato "Nome Apelido".</value>
        /// <remarks>
        /// Esta propriedade é somente leitura e é calculada automaticamente
        /// com base nos valores das propriedades Nome e Apelido.
        /// </remarks>
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }

    }
}
