using System.Collections.Generic;

namespace CRMBLL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override int GetHashCode()
        {
            return ProductId;
        }
        public override bool Equals(object obj)
        {
            var product = obj as Product;
            if(this.ProductId == product.ProductId)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
