using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCiclo.Models
{
    class Reserva
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionHoras { get; set; }
        public List<string> Asistentes { get; set; }
        public Dictionary<int, int> CombosPorPersona { get; set; }

        public decimal CalcularCosto()
        {
            decimal total = 0;
            foreach (var combo in CombosPorPersona)
            {
                decimal precio = combo.Key switch
                {
                    1 => 10,
                    2 => 20,
                    3 => 25,
                    _ => 0,
                };
                total += precio * combo.Value * DuracionHoras;
            }
            return total;
        }  
        
    }  
}
