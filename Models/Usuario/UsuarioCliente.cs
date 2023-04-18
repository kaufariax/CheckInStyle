using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CheckInStyle.Models.Servico;

namespace CheckInStyle.Models.Usuario
{
    public class UsuarioCliente
    {
        public User Usuario { get; set; }

        [ForeignKey("MinhasReservas")]
        public List<Quarto> MinhasReservas { get; set; }
    }
}