using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDadosRestaurante;
using Varios;
using BORestaurante;

namespace BLRestaurante
{
    class ControloFunc
    {
        /// <summary>
        /// Adiciona um funcionario aos dados e gera um numero para ele
        /// </summary>
        /// <param name="f">Funcionario</param>
        /// <returns>Inteirio: 1-adicionou,2-já existe</returns>
        public static int AddFunc(Funcionario f)
        {
            f.Empregado = GeraNumFuncionario();
            bool r = Funcionarios.AddFuncionario(f);
            if (r == true) return 1;
            else return 0;
        }


        /// <summary>
        /// Gera um numero de funcionario único
        /// </summary>
        /// <returns>Retorna um inteiro enre 1000 e 10 000</returns>
        static int GeraNumFuncionario()
        {
            int n = Varios.Varios.GeraInt();
            Funcionario[] cli = Funcionarios.GetFuncionarios().ToArray();
            bool x = false;
            for (int i = 0; i < cli.Length; i++)
            {
                if (n == cli[i].Empregado) x = true;
            }
            if (x == true) return n = GeraNumFuncionario();
            else return n;
        }

    }
}
