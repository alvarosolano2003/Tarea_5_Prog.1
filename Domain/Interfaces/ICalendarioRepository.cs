using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICalendarioRepository : IModel<CalendarioPrestamo>
    {
        decimal CalculatePrincipal(decimal monto, decimal tasa, decimal terminos);
        decimal CalculateInteres(decimal monto, decimal tasa, decimal terminos);
        decimal CalculateCuota(decimal principal, decimal inters);
        int GetLastIndex();
        List<CalendarioPrestamo> GetBy(Predicate<CalendarioPrestamo> predicate);
    }
}
