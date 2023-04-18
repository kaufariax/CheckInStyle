using System.ComponentModel.DataAnnotations.Schema;

namespace CheckInStyle.Models.Servico
{
    public class Quarto
    {
        public long Id { get; set; }
        public double TamanhoQuarto { get; set; }
        public int QuartidadeCamas { get; set; }
        public int LimitePessoas { get; set; }
        public double ValorDiaria { get; set; }
        
        [ForeignKey("Hotel")]
        public long Hotel { get; set; }
        public List<string> PrincipaisComodidades { get; set; }
    }
}