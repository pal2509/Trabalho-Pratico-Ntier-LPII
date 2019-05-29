using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;

namespace BDDadosRestaurante
{
    [Serializable]
    public class Clientes
    {
        #region Atributos
        const string FILECLIENTES = "Clientes.bin";
        static List<Cliente> lista = new List<Cliente>();
        static List<Cliente> removidos = new List<Cliente>();
        const string fileRemovidos = "ClientesRemovidos.bin";
        #endregion


        #region Propriedades

        public static List<Cliente> GetClientes()
        {
            return lista;
        }

        public static void GetListaClientes(List<Cliente> c)
        {
            lista = c;
        }

        public static string fileNameClientes()
        {
            return FILECLIENTES;
        }

        public static List<Cliente> GetRemovidos()
        {
            return removidos;
        }

        public static void GetRemovidos(List<Cliente> c)
        {
            removidos = c;
        }

        public static string fileNameRemovidos()
        {
            return fileRemovidos;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Adiciona um cliente
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <returns>True se iseriu ou false se ja existe</returns>
        public static bool AddCliente(Cliente c)
        {
            try
            {
                if (lista.Contains(c) == false)
                {
                    lista.Add(c);
                    return true;

                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Procura um cliente atraves do numero de cliente na lista de clientes
        /// </summary>
        /// <param name="num">Numero do cliente</param>
        /// <param name="c">Retorna o Cliente</param>
        /// <returns>Verdadeiro se existe e falso se nao existe</returns>
        public static bool ProcuraCliente(int num, out Cliente c)
        {
            Cliente[] x = lista.ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].numCli == num)
                {
                    c = x[i];
                    return true;
                }

            }
            c = new Cliente();
            return false;
        }

        /// <summary>
        /// Procura cliente pelo numero de cliente ou pelo o numero de telefone
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int ProCliente(int n, out Cliente c)
        {
            Cliente[] x = lista.ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].numCli == n || x[i].Telefone == n)
                {
                    c = x[i];
                    return 1;
                }
            }
            c = new Cliente();
            return 0;
        }

        /// <summary>
        /// Verifica se o cliente existe no restaurante pelo numero de cliente
        /// </summary>
        /// <param name="num">Numero de cliente</param>
        /// <returns></returns>
        public static bool ExisteCliente(int num)
        {
            Cliente[] c = lista.ToArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].numCli == num) return true;
            }
            return false;
        }

        /// <summary>
        /// Numero de clientes
        /// </summary>
        /// <returns></returns>
        public static int NumeroClientes()
        {
            return lista.Count;
        }

        /// <summary>
        /// Remove um cliente e passa-o para uma lista secundaria
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool RemoveCliente(int n)
        {
            if (ExisteCliente(n))
            {
                var item = lista.Single(c => c.numCli == n);
                removidos.Add(item);
                lista.Remove(item);
                return true;
            }
            else return false;
        }

        #endregion
    }
}
