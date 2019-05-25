using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using BDDadosRestaurante;

namespace BLRestaurante
{
    public class ControloReservas
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
        /// Transforma 3 string em uma reservas
        /// </summary>
        /// <param name="telefone">string telefone</param>
        /// <param name="npessoas">srintf numero de pessoas</param>
        /// <param name="data">string data</param>
        /// <param name="r">out Reserva</param>
        /// <returns>1-Converteu,-1-telefone errado,-2-numero de pessoas errado,-3-data errada</returns>
        public static int CriaReserva(string telefone, string npessoas, string data, out Reserva r)
        {
            try
            {
                bool y = int.TryParse(telefone, out int tel);
                bool x = int.TryParse(npessoas, out int npes);
                bool z = DateTime.TryParse(data, out DateTime date);
                if (y == true && x == true && z == true)
                {
                    r = new Reserva(tel, npes, date);
                    return 1;
                }
                else r = new Reserva();
                if (y == false) return -1;
                if (x == false) return -2;
                if (z == false) return -3;
                return 0;
            }
            catch(Exception e)
            {
                throw new Exception("Erro: ", e);
            }
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
