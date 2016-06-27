using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendasAspNetMVC.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string ProNome { get; set; }
        public int ProQtdEstoque { get; set; }
        public decimal ProPercLucro{ get; set; }
    }
}