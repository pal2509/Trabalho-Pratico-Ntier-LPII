using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using Varios;

namespace BDDadosRestaurante
{
    [Serializable]
    public class Ementa
    {
        #region Atributos
        static List<Produto> ementa = new List<Produto>();
        const string FILEEMENTA = "Ementa.bin";
        #endregion


        public static List<Produto>GetEmenta()
        {
            return ementa;
        }

        public static void GetListaEmenta(List<Produto> c)
        {
            ementa = c;
        }

        public static string fileNameEmenta()
        {
            return FILEEMENTA;
        }

        #region Metodos
        /// <summary>
        /// Adiciona um produto á ementa do restaurante
        /// </summary>
        /// <param name="x">Produto</param>
        /// <returns></returns>
        public static bool AddProduto(Produto x)
        {
            if (ementa.Contains(x) == false)
            {
                x.Cod = Varios.Varios.GeraInt100();
                ementa.Add(x);
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Numero de produtos na ementa
        /// </summary>
        /// <returns></returns>
        public static int NumeroProdutos()
        {
            return ementa.Count;
        }

        #endregion
    }
}
