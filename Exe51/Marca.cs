using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe51
{
    public class Marca
    {
        public int codigo;
        public string nome;
        public string pais;
        public List<Carro> carros;

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }
        public void addCarro(Carro c)
        {
            carros.Add(c);
        }
        public  override string ToString()
        {
            return ""+codigo+", "+nome+", País: "+pais+", Número de carros: "+carros.Count;
        }
    }
}