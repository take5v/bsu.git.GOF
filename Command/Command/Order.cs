using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Order
    {
        public IList<Product> List { get; set; }

        public void AddProduct(Product product)
        {
            List.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            List.Remove(product);
        }

        public int GetSumPrice()
        {
            return List.Sum(product => product.Price);
        }

        public override string ToString()
        {
            return List.Aggregate("", (current, product) => current + product.ToString());
        }

        public Order()
        {
            List = new List<Product>();
        }
    }
}
