using System;
using System.Collections.Generic;

namespace BORestaurante
{
    [Serializable]
    public enum Funcao
    {
        Cozinheiro,
        EmpregadoMesa,
        AjudanteCozinha,
        Balcao,
        Gerente,
    }
    [Serializable]
    public class Funcionario : Pessoa
    {
        #region Atributos
        int numEmpregado;
        Funcao funcao;
        #endregion
        #region Construtor

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Funcionario() : base()
        {
            numEmpregado = -1;
            funcao = 0;
        }

        /// <summary>
        /// Cria um funcionario com nome, telefone e função
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="tel">Telfone</param>
        /// <param name="funcao">Função</param>
        public Funcionario(string nome, int tel, Funcao funcao) : base(nome, tel)
        {
            this.funcao = funcao;
        }

        /// <summary>
        /// Construtor que so recebe o codigo do empregado
        /// </summary>
        /// <param name="cod"></param>
        public Funcionario(int cod):base()
        {
            numEmpregado = cod;
            funcao = 0;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Manipula o numero de empregado
        /// </summary>
        public int Empregado
        {
            get { return numEmpregado; }
            set { numEmpregado = value; }
        }

        /// <summary>
        /// Manipula a funçõa do empregado
        /// </summary>
        public Funcao Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        #endregion

        #region Metodos


        /// <summary>
        /// Retorna uma string baseado na função do empregado
        /// </summary>
        /// <param name="n">Função</param>
        /// <returns>String</returns>
        public string FuncaoToString(Funcao n)
        {
            if (n == Funcao.Cozinheiro) return "Cozinheiro";
            if (n == Funcao.AjudanteCozinha) return "Ajudante de Cozinha";
            if (n == Funcao.Balcao) return "Balcão";
            if (n == Funcao.EmpregadoMesa) return "Empregado de Mesa";
            if (n == Funcao.Gerente) return "Gerente";
            else return "Sem função";
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format("Nome: {0} Numero: {1} Função: {2}", Nome, numEmpregado, FuncaoToString(funcao));
        }

        public override bool Equals(object obj)
        {

            return base.Equals(obj);
        }
        #endregion

    }

    public class FuncionarioComparer : IEqualityComparer<Funcionario>
    {
        public bool Equals(Funcionario x, Funcionario y)
        {
            if (x.Empregado.CompareTo(y.Empregado) == 0) return true;
            else return false;
        }

        public int GetHashCode(Funcionario obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;
            int hashFuncCode = obj.Empregado.GetHashCode();
            return hashFuncCode % 10;
        }
    }
}
