using System.Globalization;
namespace ProgramWithProperties;

class Product {
    private string _name;
    public string Description { get; set; }
    public int Quantity { get; private set; }
    public double Price { get; private set; }

    public Product(string name, string description, int quantity, double price) {
        this._name = name;
        Description = description;
        Quantity = quantity;
        Price = price;
    }
    public string GetName() {
        return _name;
    }
    public void SetName(string name) {
        if (_name != null && _name.Length > 1) {
            _name = name;

        }
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
        return Price * Quantity;
    }
    override
    public string ToString() {
        return " Name: " + _name +
               "\n Description: " + Description +
               "\n Quantity: " + Quantity +
               "\n Price R$ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
               "\n Total value inventoies R$ " + TotalValueInventoies().ToString("F2", CultureInfo.InvariantCulture);
    }

}
