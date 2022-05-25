using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoP2.Classes
{
    public class FormaPagamento
    {
        public String nomePagamento { get; set; }
        public Double taxaPagamento { get; set; }
        public FormaPagamento(String nm, Double tx)
        {
            this.nomePagamento = nm;
            this.taxaPagamento = tx;
        }
    }
}
