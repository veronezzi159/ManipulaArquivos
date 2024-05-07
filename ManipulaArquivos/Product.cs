using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaArquivos
{
    internal class Product
    {
        public int id { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Product(int id, string d, double p, int qtd)
        {
            this.id = id;
            this.description = d;
            this.price = p;
            this.quantity = qtd;
        }
    }
}
