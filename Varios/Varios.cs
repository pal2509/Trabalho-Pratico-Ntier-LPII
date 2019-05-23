using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BORestaurante;

namespace Varios
{
    /// <summary>
    /// Classe para comparar reservas
    /// </summary>
    public class ReservaComp : IComparer<Reserva>
    {
        public int Compare(Reserva x, Reserva y)
        {

            return DateTime.Compare(x.Horario, y.Horario);

        }
    }

    public class Varios
    {
        /// <summary>
        /// Gera um numrero interio positivo entre 1000 e 10 000
        /// </summary>
        /// <returns>Retorna o numero gerado</returns>
        public static int GeraInt()
        {
            Random rng = new Random();
            int n = rng.Next(1000, 10000);
            return n;
        }
    }
}
