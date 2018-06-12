using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicio51.Models
{
    public class Carro
    {
        public int codigo;
        public string modelo;
        public int ano;
        public double precoBasico;
        public Marca marca;
        public List<Acessorio> acessorios;

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
        }

    }
}