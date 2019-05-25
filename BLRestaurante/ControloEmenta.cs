using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using BDDadosRestaurante;
namespace BLRestaurante
{
    public class ControloEmenta
    {

        public static int AddProduto(Produto p)
        {
            bool x = Ementa.AddProduto(p);
            if (x == true) return 1;
            else return 0;
        }

        public static List<Produto> GetEmenta()
        {
            return Ementa.GetEmenta();
        }

        /// <summary>
        /// Transforma 3 string em uma reservas
        /// </summary>
        /// <param name="telefone">string telefone</param>
        /// <param name="npessoas">srintf numero de pessoas</param>
        /// <param name="data">string data</param>
        /// <param name="r">out Reserva</param>
        /// <returns>1-Converteu,-1-codigo errado,-2-preco errado</returns>
        public static int CriaEmenta(string codigo, string nome, string preco, out Produto r)
        {
            try
            {
                bool y = int.TryParse(codigo, out int cod);
                bool x = double.TryParse(preco, out double prec);
                if (y == true && x == true)
                {
                    r = new Produto(nome, cod, prec);
                    return 1;
                }
                else r = new Produto();
                if (y == false) return -1;
                if (x == false) return -2;
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: ", e);
            }
        }
    }
}
