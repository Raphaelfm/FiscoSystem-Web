using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FiscoSystem.Models.NcmModels
{
    [Table("TabelaFisco")]
    public class TabelaFiscoModel
    {
        [Key]
        public int FiscoId { get; set; }

        [StringLength(100)]
        public string Grupo { get; set; }

        [StringLength(8)]
        public string Ncm { get; set; }

        [StringLength(11)]
        public string Aliquota { get; set; }

        [StringLength(10)]
        public string Forma_Tributacao { get; set; }

        [StringLength(4)]
        public string CST { get; set; }

        [StringLength(20)]
        public string forma_Pis_Cofins { get; set; }
    }
}
