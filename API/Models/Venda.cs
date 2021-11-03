using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Venda
    {
        //Construtor
        public Venda() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}