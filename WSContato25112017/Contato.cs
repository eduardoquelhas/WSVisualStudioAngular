using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSContato25112017
{
    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string NomeOperadora { get; set; }
        public string Data { get; set; }
        public string cor { get; set; }

    }
    

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
    public class Operadora
    {
        public string nome { get; set; }
        public int codigo { get; set; }
        public string categoria { get; set; }
        public double preco { get; set; }
    }

}