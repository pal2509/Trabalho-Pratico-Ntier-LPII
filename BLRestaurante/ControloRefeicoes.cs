using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDadosRestaurante;
using BORestaurante;


namespace BLRestaurante
{
    class ControloRefeicoes
    {

        public static int AddRefeicao(Refeicao r)
        {
            r.Custo = CalculaCusto(r.Codigo.ToArray());
            bool x = Refeicoes.AddReficao(r);
            if (x == true) return 1;
            else return 0;
        }

        /// <summary>
        /// Calcula o custo da refeição
        /// </summary>
        /// <param name="cod">array de codigos dos produtos da refeição</param>
        /// <returns></returns>
        public static double CalculaCusto(int[] cod)
        {
            double soma = 0;
            Produto[] emen = Ementa.GetEmenta().ToArray();
            for (int i = 0; i < cod.Length; i++)
            {
                for (int j = 0; j < emen.Length; j++)
                {
                    if (cod[i] == emen[j].Cod) soma = soma + emen[j].Preco;
                }
            }
            return soma;

        }


        /// <summary>
        /// Calcula a media do custo de todas as refeições do restaurante
        /// </summary>
        /// <returns></returns>
        public double MediaCustoRefeicoes()
        {
            int cont = 0;
            double soma = 0;
            foreach (Refeicao r in Refeicoes.GetRefeicaos())
            {
                if (r.Custo > 0)
                {
                    soma = soma + r.Custo;
                    cont++;
                }
            }
            if (cont != 0)
            {
                return soma / cont;
            }
            else return 0;
        }



    }
}
