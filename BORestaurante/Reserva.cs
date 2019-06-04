using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BORestaurante
{
    /// <summary>
    /// Classe Reserva
    /// </summary>
    [Serializable]
    public class Reserva
    {
        #region Atributos
        int tel;
        int numPessoas;
        DateTime horario;

        #endregion
        #region Construtor
        /// <summary>
        /// Cria uma reserva
        /// </summary>
        /// <param name="tel">Numero de telefone</param>
        /// <param name="numpes">Numero de pessoas</param>
        /// <param name="h">AA/MM/DD HH:MM:SS</param>
        public Reserva(int tel, int numpes, DateTime h)
        {
            this.tel = tel;
            numPessoas = numpes;
            horario = h;
        }

        /// <summary>
        /// Recebe a data e o numero de telefone
        /// </summary>
        /// <param name="date"></param>
        /// <param name="tel"></param>
        public Reserva(DateTime date,int tel)
        {
            this.horario = date;
            this.tel = tel;
            numPessoas = -1;
        }

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Reserva()
        {
            tel = -1;
            numPessoa = -1;
            horario = new DateTime(0, 0, 0);
        }
        #endregion
        #region Propriedades

        /// <summary>
        /// Manipula a ementa
        /// </summary>
        public int numPessoa
        {
            get { return numPessoas; }
            set { numPessoas = value; }
        }

        public int Telefone
        {
            get { return tel; }
            set { tel = value; }
        }

        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        #endregion
        #region Overrides

        public override bool Equals(object obj)
        {
            Reserva aux = (Reserva)obj;
            return tel == aux.tel && horario.CompareTo(aux.horario) == 0;
        }

        public override string ToString()
        {
            return ("Cliente: " + tel + " Horario: " + horario);
        }



        #endregion
    }

    public class ReservaComparer : IEqualityComparer<Reserva>
    {
        public bool Equals(Reserva x, Reserva y)
        {
            if (DateTime.Compare(x.Horario, y.Horario) == 0 && x.Telefone == y.Telefone) return true;
            else return false;
        }

        public int GetHashCode(Reserva obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;
            int hashReservaDate = obj.Horario.GetHashCode();
            int hashRevervaTel = obj.Telefone.GetHashCode();
            return hashReservaDate*hashRevervaTel;
        }
    }

}
