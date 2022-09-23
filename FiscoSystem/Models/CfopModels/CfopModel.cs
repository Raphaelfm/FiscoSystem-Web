using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiscoSystem.Models.CfopModels
{
    [Table("CFOP")]
    public class CfopModel
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(5)]
        public string Cfop { get; set; }

        [StringLength(60)]
        public string Descricao { get; set; }

        [StringLength(250)]
        public string DescricaoCompleta { get; set; }

        [StringLength(10)]
        public string Versao { get; set; }

    }
}
