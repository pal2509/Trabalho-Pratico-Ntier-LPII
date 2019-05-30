/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 */
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
        const string FILEREFEICOES = "Refeicoes.bin";
        //static List<Refeicao> refeicoes = new List<Refeicao>();
        static Dictionary<int, List<Refeicao>> refei = new Dictionary<int, List<Refeicao>>();

        #endregion
        
        /// <summary>
        /// Adiciona uma refeição á lista de refeições
        /// </summary>
        /// <param name="r">Refeição</param>
        /// <returns>-1-Cliente não existe,1-Adicionou,0-Já existe um igual</returns>
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


        public static Dictionary<int,List<Refeicao>> GetRefeicoes()
        {
            return refei;
        }

        public static void GetRefeicoes(Dictionary<int, List<Refeicao>> r)
        {
            refei = r;
        }

        public static string fileNameRefeicoes()
        {
            return FILEREFEICOES;
        }

        /// <summary>
        /// Retorna uma lista de refeições de um dado cliente
        /// </summary>
        /// <param name="n">Numero do cliente</param>
        /// <returns>List<Refeicao> ou null se a chave nao existe</returns>
        public static List<Refeicao>ListaRefeicoesCliente(int n)
        {
            if (refei.ContainsKey(n))
            {
                return refei[n];
            }
            else return null;
        }

    }
}
