using System.Globalization;
using System.Text;

namespace Ex_Fixacao08.Entities
{
    class OrderItem
    {  
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get ; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        

        public double SubTotal()
        {
            return Quantity * Price;
        }
          public override string ToString()
        {
            StringBuilder sb = new StringBuilder();                      
            sb.Append(Product.Name + ", $" + Product.Price +" Quantity: " + Quantity + " SubTotal: $" + SubTotal().ToString("F2",CultureInfo.InvariantCulture));                     
            return sb.ToString();
        }
        
    }
}