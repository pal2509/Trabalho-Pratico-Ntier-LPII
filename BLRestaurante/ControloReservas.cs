using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using BDDadosRestaurante;

namespace BLRestaurante
{
    class ControloReservas
    {

        /// <summary>
        /// Adiciona uma reserva verificando se o restaturante não está cheio
        /// </summary>
        /// <param name="r">Reserva</param>
        /// <returns>1-adicionou,0-Repetida,-1-já existem 5 reservas nessa hora</returns>
        public static int AddReserva(Reserva r)
        {
            int n = VerificaData(r.Horario);
            if (n <= 5)
            {
                bool x = Reservas.AddReserva(r);
                if (x == true) return 1;
                else return 0;
            }
            else return -1;
        }


        /// <summary>
        /// Verifica quantas reservas existe +30 e -30 minutos de uma determinada hora
        /// </summary>
        /// <param name="h">hora da reseva</param>
        /// <returns>Numero de revervas</returns>
        static int VerificaData(DateTime h)
        {
            Reserva[] x = Reservas.GetReservas().ToArray();

            int cont = 0;
            for (int i = 0; i < x.Length; i++)
            {
                DateTime y = x[i].Horario;
                TimeSpan dif = h - y;
                if (dif < new TimeSpan(0, 30, 0)) cont++;
            }
            return cont;
        }
    }
}
