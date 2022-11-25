using System.Globalization;
namespace ProgramWithProperties;

class Product {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; private set; }
    public double Price { get; private set; }

    public Product(string name, string description, int quantity, double price) {
       Name = name;
        Description = description;
        Quantity = quantity;
        Price = price;
    }
    
   
    public void AddProduct(int quantity) {
        if (quantity > 0) {
            Quantity = quantity;
        }
        else {
            Quantity = 0;
        }
    }
    public int RemoveQuantity(int quantity) {
        if (quantity > 0 && quantity < this.Quantity) {

            return Quantity -= quantity;
        }
        return 0;
    }
    public double TotalValueInventoies() {
        return Price* Quantity;
    }
    override
    public string ToString() {
     return " Name: " + Name +
            "\n Description: " +Description +
            "\n Quantity: " + Quantity +
            "\n Price R$ " + Price.ToString("F2",CultureInfo.InvariantCulture) +
            "\n Total value inventoies R$ " + TotalValueInventoies().ToString("F2", CultureInfo.InvariantCulture);
    }

}
