using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaSalas.Models
{
        public class Reserva
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
                    decimal precio = 0;

                    switch (combo.Key)
                    {
                        case 1:
                            precio = 10;
                            break;
                        case 2:
                            precio = 20;
                            break;
                        case 3:
                            precio = 25;
                            break;
                        default:
                            precio = 0;
                            break;
                    }

                    total += precio * combo.Value * DuracionHoras;
                }

                return total;
            }
        }

}
