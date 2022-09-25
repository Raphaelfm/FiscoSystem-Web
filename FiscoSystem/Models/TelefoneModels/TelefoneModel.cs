using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FiscoSystem.Models.PessoaModels;

namespace FiscoSystem.Models.TelefoneModels
{
    [Table("TabelaTelefones")]
    public class TelefoneModel
    {
        [Key]
        public int TelefoneId { get; set; }

        [MaxLength(2)]
        public int TelefonePrefixo { get; set; }

        [MaxLength(9)]
        public long TelefoneNumero { get; set; }

        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
    }
}
