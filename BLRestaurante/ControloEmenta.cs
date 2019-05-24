using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BORestaurante;
using BDDadosRestaurante;
namespace BLRestaurante
{
    class ControloEmenta
    {

        public static int AddProduto(Produto p)
        {
            bool x = Ementa.AddProduto(p);
            if (x == true) return 1;
            else return 0;
        }
    }
}
