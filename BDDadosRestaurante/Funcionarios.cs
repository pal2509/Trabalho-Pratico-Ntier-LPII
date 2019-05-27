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
        const string fileEmpregados = "Empregados.bin";
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
            return fileEmpregados;
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



        #endregion
    }
}
