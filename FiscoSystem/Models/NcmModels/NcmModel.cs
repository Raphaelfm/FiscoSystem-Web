using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiscoSystem.Models.NcmModels
{
    [Table("TabelaNCM")]
    public class NcmModel
    {
        [Key]
        public int NcmId { get; set; }

        [StringLength(8)]
        public string CodigoNcm { get; set; }

        [StringLength(1200)]
        public string DescricaoNcm { get; set; }

        [StringLength(3)]
        public string UnNcm { get; set; }

        [StringLength(45)]
        public string Usuario { get; set; }

        [StringLength(45)]
        public string Terminal { get; set; }

        public DateTime? Data { get; set; }

        [StringLength(4)]
        public string Nivel1 { get; set; }

        [StringLength(5)]
        public string Nivel2 { get; set; }

        [StringLength(6)]
        public string Nivel3 { get; set; }

        public int Versao { get; set; }
    }
}
