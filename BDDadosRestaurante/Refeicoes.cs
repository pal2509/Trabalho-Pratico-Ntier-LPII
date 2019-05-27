using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;

namespace BDDadosRestaurante
{
    public class Refeicoes
    {
        #region Atributos
        const string fileRefeicoes = "Refeicoes.bin";
        static List<Refeicao> refeicoes = new List<Refeicao>();
        #endregion

        public static List<Refeicao>GetRefeicaos()
        {
            return refeicoes;
        }
        public static void GetListaRefeicoes(List<Refeicao> c)
        {
            refeicoes = c;
        }

        public static string fileNameRefeicoes()
        {
            return fileRefeicoes;
        }

        #region Metodos
        /// <summary>
        /// Adiciona uma refeiçao 
        /// </summary>
        /// <param name="x">Refeição</param>
        /// <returns>true se adicionar e false se nao adicionar</returns>
        public static bool AddReficao(Refeicao x)
        {
            if (x.Cliente == -1) return false;
            else
            {
                if (refeicoes.Contains(x) == false)
                {           
                    refeicoes.Add(x);
                    return true;
                }
                else return false;
            }

        }



        #endregion

    }
}
