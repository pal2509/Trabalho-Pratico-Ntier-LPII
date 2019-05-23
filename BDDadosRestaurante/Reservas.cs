using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using Varios;

namespace BDDadosRestaurante
{
    public class Reservas
    {
        #region Atributos
        const string fileReservas = "Reservas.bin";
        static List<Reserva> reser = new List<Reserva>();
        #endregion

        public static List<Reserva>GetReservas()
        {
            return reser;
        }

        #region Metodos

        /// <summary>
        /// Adiciona uma reserva 
        /// </summary>
        /// <param name="t">Reserva</param>
        /// <returns>Retorna 1 se adicionar,0 se ja existe uma reserva igual</returns>
        public static bool AddReserva(Reserva t)
        {
            if (reser.Contains(t) == false)
            {
                reser.Add(t);
                reser.Sort(new ReservaComp());
                return true;
            }
            return false;

        }


        #endregion
    }
}
