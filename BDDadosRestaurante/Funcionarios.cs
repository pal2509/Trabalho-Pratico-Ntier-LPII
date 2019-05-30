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

namespace BDDadosRestaurante
{
    public class Funcionarios
    {
        const string FILEEMPREGADOS = "Empregados.bin";
        static List<Funcionario> empregados = new List<Funcionario>();

        public static List<Funcionario>GetFuncionarios()
        {
            return empregados;
        }

        public static void GetListaFuncionario(List<Funcionario> c)
        {
            empregados = c;
        }

        public static string fileNameFuncionario()
        {
            return FILEEMPREGADOS;
        }

        #region Metodos


        /// <summary>
        /// Adiciona um funcionario ao restaurante
        /// </summary>
        /// <param name="f">Funcionario</param>
        /// <returns>True/false</returns>
        public static bool AddFuncionario(Funcionario f)
        {
            if (empregados.Contains(f) == false)
            {
                empregados.Add(f);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Conta o numero de empregados
        /// </summary>
        /// <returns>Numero de empregados</returns>
        public static int Nfunc()
        {
            return empregados.Count();
        }

        #endregion
    }
}
