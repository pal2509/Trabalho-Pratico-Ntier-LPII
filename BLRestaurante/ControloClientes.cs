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
        /// <returns>Total do dinheiro gasto</returns>
        public static double TotalGastoCliente(int n)
        {
     
                double soma = 0;
                Refeicao[] x = Refeicoes.GetRefeicaos().ToArray();
                for (int i = 0; i < x.Length; i++)
                {
                    if (n == x[i].Cliente) soma = soma + x[i].Custo;
                }
                return soma;
    
        }

        public static bool ExisteCliente(int n)
        {
            return Clientes.ExisteCliente(n);
        }

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

        public static List<Cliente>GetClientes()
        {
            return Clientes.GetClientes();
        }

    }
}
