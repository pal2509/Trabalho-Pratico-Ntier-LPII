﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;

namespace BDDadosRestaurante
{
    [Serializable]
    public class Ementa
    {
        #region Atributos
        static List<Produto> ementa = new List<Produto>();
        const string fileEmenta = "Ementa.bin";
        #endregion


        public static List<Produto>GetEmenta()
        {
            return ementa;
        }


        #region Metodos
        /// <summary>
        /// Adiciona um produto á ementa do restaurante
        /// </summary>
        /// <param name="x">Produto</param>
        /// <returns></returns>
        public static bool AddProduto(Produto x)
        {
            if (ementa.Contains(x) == false)
            {
                ementa.Add(x);
                return true;
            }
            else return false;
        }
        #endregion
    }
}