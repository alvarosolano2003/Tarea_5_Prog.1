using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CalendarioPrestamo
    {
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Principal { get; set; }
        public decimal PrincipalPagado { get; set; }
        public decimal Interes { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal Cuota { get; set; }
        public decimal CuotaPagado { get; set; }
        public Estado Estado { get; set; }


    }
}
