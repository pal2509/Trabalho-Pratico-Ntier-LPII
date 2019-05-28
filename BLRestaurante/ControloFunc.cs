using BDDadosRestaurante;
using BORestaurante;

namespace BLRestaurante
{
    public class ControloFunc
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
        /// Verifica se o numero é um tipo de empregado
        /// </summary>
        /// <param name="n">Numero</param>
        /// <param name="f">Out tipo de função</param>
        /// <returns>true/false</returns>
        public static bool GetFuncao(int n, out Funcao f)
        {
            if (n == Funcao.AjudanteCozinha.GetHashCode())
            {
                f = Funcao.AjudanteCozinha;
                return true;
            }
            if (n == Funcao.Balcao.GetHashCode())
            {
                f = Funcao.Balcao;
                return true;
            }
            if (n == Funcao.Cozinheiro.GetHashCode())
            {
                f = Funcao.Cozinheiro;
                return true;
            }
            if (n == Funcao.EmpregadoMesa.GetHashCode())
            {
                f = Funcao.EmpregadoMesa;
                return true;
            }
            if (n == Funcao.Gerente.GetHashCode())
            {
                f = Funcao.Gerente;
                return true;
            }
            f = 0;
            return false;
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
