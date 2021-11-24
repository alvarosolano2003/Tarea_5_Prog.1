using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class CalendarioRepository : BaseRepository<CalendarioPrestamo>, ICalendarioRepository
    {
        public decimal CalculateCuota(decimal principal, decimal inters)
        {
            return Math.Round(principal + inters);
        }

        public decimal CalculateInteres(decimal monto, decimal tasa, decimal terminos)
        {
            return Math.Round(monto * tasa / terminos);
        }

        public decimal CalculatePrincipal(decimal monto, decimal tasa, decimal terminos)
        {
            return Math.Round(monto * (tasa + 1) / terminos);
        }
    }
}
