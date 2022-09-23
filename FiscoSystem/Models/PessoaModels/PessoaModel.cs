using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiscoSystem.Models.PessoaModels
{
    [Table("TabelaPessoa")]
    public class PessoaModel
    {
        [Key]
        public int PessoaId { get; set; }

        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(200)]
        public string NomeFantasia { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        [StringLength(8)]
        public int Cep { get; set; }

        [StringLength(8)]
        public int Numero { get; set; }

    }
}
