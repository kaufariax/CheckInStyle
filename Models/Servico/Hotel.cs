
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckInStyle.Models.Servico
{
    public class Hotel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long EmpresaPertencente { get; set; }
        
        [InverseProperty("Hotel")]
        public List<Quarto> Quartos {get ; set; }
        public List<string> PrincipaisComodidades { get; set; }
    }
}