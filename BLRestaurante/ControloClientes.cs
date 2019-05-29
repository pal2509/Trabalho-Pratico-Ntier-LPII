using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using BDDadosRestaurante;
using Varios;

namespace BLRestaurante
{
    public class ControloClientes
    {
        /// <summary>
        /// Adiciona um cliente ao restaurante
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <returns>1-Adicionou,2-já existe</returns>
        public static int AddCliente(Cliente c)
        {
            try
            {
                c.numCli = GeraNumCliente();
                bool r = Clientes.AddCliente(c);
                if (r == true) return 1;
                else return 0;
            }
            catch(Exception e)
            {
                throw new Exception("Erro:", e);
            }
        }

        /// <summary>
        /// Gera um numero de cliente único
        /// </summary>
        /// <returns>Retorna um inteiro enre 1000 e 10 000</returns>
        static int GeraNumCliente()
        {
            int n = Varios.Varios.GeraInt();
            Cliente[] cli = Clientes.GetClientes().ToArray();
            bool x = false;
            for (int i = 0; i < cli.Length; i++)
            {
                if (n == cli[i].numCli) x = true;
            }
            if (x == true) return n = GeraNumCliente();
            else return n;
        }

        /// <summary>
        /// Calcula o dinheiro gasto de um dado cliente 
        /// </summary>
        /// <param name="n">Numero do cliente</param>
        /// <returns>Total do dinheiro gasto,-1 se nao existe refeições</returns>
        public static double TotalGastoCliente(int n)
        {

            if (Refeicoes.GetRefeicoes().ContainsKey(n))
            {
                double soma = 0;
                foreach (Refeicao r in Refeicoes.ListaRefeicoesCliente(n)) soma = soma + r.Custo;
                return soma;
            }
            else return -1;
        }


        /// <summary>
        /// Verifica se um cliente existe no restaurante
        /// </summary>
        /// <param name="n">Numero do cliente</param>
        /// <returns></returns>
        public static bool ExisteCliente(int n)
        {
            return Clientes.ExisteCliente(n);
        }

        /// <summary>
        /// Lista de CLientes
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> GetClientes()
        {
            return Clientes.GetClientes();
        }

        public static string NClientes()
        {
            return Clientes.NumeroClientes().ToString();
        }

        /// <summary>
        /// Remove um cliente do restaurante
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool RemoveCliente(int n)
        {
            if (Clientes.ExisteCliente(n))
            {
                Clientes.RemoveCliente(n);
                return true;
            }
            else return false;
        }

        #region Dados

        /// <summary>
        /// Carrega de um ficherio binario os dados do restaturante para memoria
        /// </summary>
        /// <returns></returns>
        public static bool CarregarDados()
        {
            try
            {
                return Dados.Load();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Guarda os dados do restaturante em ficheiros
        /// </summary>
        /// <returns></returns>
        public static bool GuardarDados()
        {
            try
            {
                return Dados.Guardar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion



    }
}
