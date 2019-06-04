/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 */
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
        const string FILERESERVAS = "Reservas.bin";
        static List<Reserva> reser = new List<Reserva>();
        #endregion


        public static List<Reserva>GetReservas()
        {
            return reser;
        }

        public static void GetListaReservas(List<Reserva> c)
        {
            reser = c;
        }

        public static string fileNameReservas()
        {
            return FILERESERVAS;
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

        /// <summary>
        /// Numero de reservas
        /// </summary>
        /// <returns></returns>
        public static int NumeroReservas()
        {
            return reser.Count;
        }

        /// <summary>
        /// Verifica se uma reserva existe numa dada com aquele numero de telefone
        /// </summary>
        /// <param name="date">Data</param>
        /// <param name="tel">Numero de telefone</param>
        /// <returns></returns>
        public static bool ExisteReserva(DateTime date,int tel)
        {
            if (reser.Contains(new Reserva(date, tel), new ReservaComparer())) return true;
            else return false;
        }

        #endregion
    }
}
