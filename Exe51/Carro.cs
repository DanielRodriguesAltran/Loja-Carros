using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe51
{
    public class Carro
    {
        public int Codigo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double PrecoBasico { get; set; }
        public Marca Marca { get; set; }
        public List<Acessorio> Acessorios { get; set; }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Ano = ano;
            this.PrecoBasico = precoBasico;
            this.Marca = marca;
            this.Acessorios = new List<Acessorio>();
        }

        public double PrecoTotal()
        {
            double soma=0;
            foreach(Acessorio ac in Acessorios)
            {
                soma += ac.preço;
            }
            return PrecoBasico+soma;
        }

        public override string ToString()
        {
            return Codigo + ", " + Modelo + ", Ano: " + Ano + ", Preço Básico: " + PrecoBasico+", Preço Total: "+PrecoTotal() ;
        }
    }
}