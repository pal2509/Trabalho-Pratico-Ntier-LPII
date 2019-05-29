using System;
using System.Collections;
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
        static Dictionary<int, List<Refeicao>> refei = new Dictionary<int, List<Refeicao>>();

        #endregion

        public static int AddRef(Refeicao r)
        {
            if (r.Cliente != -1)
            {
                if (refei.ContainsKey(r.Cliente))
                {
                    if (refei[r.Cliente].Contains(r) == false)
                    {
                        refei[r.Cliente].Add(r);
                        return 1;
                    }
                    else return 0;
                }
                else
                {
                    refei.Add(r.Cliente, new List<Refeicao>());
                    refei[r.Cliente].Add(r);
                    return 1;
                }
            }
            else return -1;
        }

        public static Dictionary<int,List<Refeicao>> GetRefeicaos()
        {
            return refei;
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

        public static int Nrefeicoes()
        {
            return refeicoes.Count;
        }



        #endregion

    }
}
