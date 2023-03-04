 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FiscoSystem.Models.TelefoneModels;

namespace FiscoSystem.Models.PessoaModels
{
    [Table("TabelaPessoas")]
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

        public List<TelefoneModel> Telefones { get; set; }
    }
}
