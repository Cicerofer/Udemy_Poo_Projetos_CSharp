using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Polimorfismo
{
    class Produto
    {
        private string _nome;                /* <-------  Atributo Privativo*/
        public double Preco { get; private set; }    //  <---
        public int Quantidade { get; private set; } //  <---  Propriedades Auto implementadas*/

        public Produto()                                               //
        {                                                              // Consrutores
        }                                                              //

        public Produto(string nome, double preco, int quantidade)           //
        {                                                                   //
            _nome = nome;                                                   // Construtores
            Preco = preco;                                                  //
            Quantidade = quantidade;                                        //
        }
        /* Auto Properties "Propriedades" é uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operçãoes get e set.*/
        public string Nome                                              //
        {
            get { return _nome; }                                       //
            set                                                         //
            {
                if (value != null && value.Length > 1)                  //  Propriedades Customizadas
                {
                    _nome = value;                                      //
                }
            }
        }




        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            quantidade += quantidade;
        }

        public override string ToString()
        {
            return _nome + ",$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", $ "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }

}
