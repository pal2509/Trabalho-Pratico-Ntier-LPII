/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 * Classe para guardar dados em ficheiro
 */
using BORestaurante;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace BDDadosRestaurante
{
    public class Dados
    {

        /// <summary>
        /// Carregas os dados de um restaurante para a memoria
        /// </summary>
        /// <param name="r">Restaurante</param>
        /// <returns></returns>
        public static bool Load()
        {
            try
            {
                

                if (File.Exists(Clientes.fileNameClientes()))
                {
                   Clientes.GetListaClientes(ReadClientes(Clientes.fileNameClientes()));
                }
                if (File.Exists(Ementa.fileNameEmenta()))
                {
                    Ementa.GetListaEmenta(ReadProdutos(Ementa.fileNameEmenta()));
                }
                if (File.Exists(Refeicoes.fileNameRefeicoes()))
                {
                    Refeicoes.GetRefeicoes(ReadRefeicoes(Refeicoes.fileNameRefeicoes()));
                }
                if (File.Exists(Reservas.fileNameReservas()))
                {
                    Reservas.GetListaReservas(ReadReservas(Reservas.fileNameReservas()));
                }
                if(File.Exists(Funcionarios.fileNameFuncionario()))
                {
                    Funcionarios.GetListaFuncionario(ReadFuncionario(Funcionarios.fileNameFuncionario()));
                }
                if (File.Exists(Clientes.fileNameRemovidos()))
                {
                    Clientes.GetRemovidos(ReadClientes(Clientes.fileNameRemovidos()));
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao carregar dados:", e);
            }

        }

        /// <summary>
        /// Guarda em ficheiro todos os dados do restaurante
        /// </summary>
        /// <returns></returns>
        public static bool Guardar()
        {
            try
            {
                Save(Clientes.fileNameClientes(), Clientes.GetClientes());
                Save(Ementa.fileNameEmenta(), Ementa.GetEmenta());
                Save(Refeicoes.fileNameRefeicoes(), Refeicoes.GetRefeicoes());
                Save(Reservas.fileNameReservas(), Reservas.GetReservas());
                Save(Funcionarios.fileNameFuncionario(), Funcionarios.GetFuncionarios());
                Save(Clientes.fileNameRemovidos(), Clientes.GetRemovidos());
                return true;

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao guardar dados:", e);
            }
        }


        /// <summary>
        /// Guarda num ficheiro binario uma lista de Clientes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <param name="c">Lista</param>
        /// <returns></returns>
        public static bool Save(string fileName, List<Cliente> c)
        {
            try
            {
                using (Stream str = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(str, c);
                    str.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO-", e);
            }
        }

        /// <summary>
        /// Guarda num ficheiro binario uma lista de Reservas
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <param name="c">Lista</param>
        /// <returns></returns>
        public static bool Save(string fileName, List<Reserva> c)
        {
            try
            {
                using (Stream str = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(str, c);
                    str.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO-", e);
            }
        }

        /// <summary>
        /// Guarda num ficheiro binario uma lista de Refeiçoes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <param name="c">Lista</param>
        /// <returns></returns>
        public static bool Save(string fileName, Dictionary<int,List<Refeicao>> r)
        {
            try
            {
                using (Stream str = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(str, r);
                    str.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO-", e);
            }
        }

        /// <summary>
        /// Guarda num ficheiro binario uma lista de produtos
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <param name="c">Lista</param>
        /// <returns></returns>
        public static bool Save(string fileName, List<Produto> c)
        {
            try
            {
                using (Stream str = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(str, c);
                    str.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO-", e);
            }
        }

        public static bool Save(string fileName, List<Funcionario> c)
        {
            try
            {
                using (Stream str = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(str, c);
                    str.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO-", e);
            }
        }

        /// <summary>
        /// Lê um ficheiro binario e retorna uma lista de clientes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <returns></returns>
        public static List<Cliente> ReadClientes(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    List<Cliente> c;
                    using (Stream str = File.OpenRead(fileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        c = (List<Cliente>)bf.Deserialize(str);
                    }
                    return c;
                }
                else
                {
                    throw new Exception("Ficheiro não existe!!!");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO:Nao foi possivel ler o ficheiro!!!-", e);
            }
        }

        /// <summary>
        /// Lê um ficheiro binario e retorna uma lista de clientes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <returns></returns>
        public static Dictionary<int,List<Refeicao>> ReadRefeicoes(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    Dictionary<int, List<Refeicao>> c;
                    using (Stream str = File.OpenRead(fileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        c = (Dictionary<int, List<Refeicao>>)bf.Deserialize(str);
                    }
                    return c;
                }
                else
                {
                    throw new Exception("Ficheiro não existe!!!");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO:Nao foi possivel ler o ficheiro!!!-", e);
            }
        }

        /// <summary>
        /// Lê um ficheiro binario e retorna uma lista de clientes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <returns></returns>
        public static List<Reserva> ReadReservas(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    List<Reserva> c;
                    using (Stream str = File.OpenRead(fileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        c = (List<Reserva>)bf.Deserialize(str);
                    }
                    return c;
                }
                else
                {
                    throw new Exception("Ficheiro não existe!!!");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO:Nao foi possivel ler o ficheiro!!!-", e);
            }
        }

        /// <summary>
        /// Lê um ficheiro binario e retorna uma lista de clientes
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <returns></returns>
        public static List<Produto> ReadProdutos(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    List<Produto> c;
                    using (Stream str = File.OpenRead(fileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        c = (List<Produto>)bf.Deserialize(str);
                    }
                    return c;
                }
                else
                {
                    throw new Exception("Ficheiro não existe!!!");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO:Nao foi possivel ler o ficheiro!!!-", e);
            }
        }

        public static List<Funcionario> ReadFuncionario(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    List<Funcionario> c;
                    using (Stream str = File.OpenRead(fileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        c = (List<Funcionario>)bf.Deserialize(str);
                    }
                    return c;
                }
                else
                {
                    throw new Exception("Ficheiro não existe!!!");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO:Nao foi possivel ler o ficheiro!!!-", e);
            }
        }

    }
}

