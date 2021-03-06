﻿/*
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
using BDDadosRestaurante;
namespace BLRestaurante
{
    public class ControloEmenta
    {

        public static int AddProduto(Produto p)
        {
            bool x = Ementa.AddProduto(p);
            if (x == true) return 1;
            else return 0;
        }

        public static List<Produto> GetEmenta()
        {
            return Ementa.GetEmenta();
        }

        public static bool ExisteProduto(int n)
        {
            foreach(Produto p in Ementa.GetEmenta())
            {
                if (n == p.Cod) return true;
            }
            return false;
        }

        /// <summary>
        /// Transforma 3 string em uma reservas
        /// </summary>
        /// <param name="telefone">string telefone</param>
        /// <param name="npessoas">srintf numero de pessoas</param>
        /// <param name="data">string data</param>
        /// <param name="r">out Reserva</param>
        /// <returns>1-Converteu,-2-preco errado</returns>
        public static int CriaEmenta(string nome, string preco, out Produto r)
        {
            try
            {
               
                bool x = double.TryParse(preco, out double prec);
                if (x == true)
                {
                    r = new Produto(nome, prec);
                    return 1;
                }
                else r = new Produto();
                if (x == false) return -2;
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: ", e);
            }
        }

        public static string NProdutos()
        {
            return Ementa.NumeroProdutos().ToString();
        }
    }
}
