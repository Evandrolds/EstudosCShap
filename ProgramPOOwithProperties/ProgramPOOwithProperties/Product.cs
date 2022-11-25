using System.Globalization;
namespace ProgramWithProperties;

class Product {
    private string _name;
    private string _description;
    private int _quantity;
    private double _price;

    public Product(string name, string description, int quantity, double price) {
        this._name = name;
        this._description = description;
        this._quantity = quantity;
        this._price = price;
    }
    public string Name {
        get { return _name; }
        set {
            if (value != null && value.Length > 1) {

                _name = value;
            }
        }
    }
    public string Description {
        get { return _description; }
        set {
            if (value != null && value.Length > 1) {

                _description = value;
            }
        }
    }
    public int Quantity {
        get { return _quantity; }

    }
    public double Price {
        get { return _price; }

    }
    public void AddProduct(int quantity) {
        if (quantity > 0) {
            this._quantity = quantity;
        }
        else {
            this._quantity = 0;
        }
    }
    public int RemoveQuantity(int quantity) {
        if (quantity > 0 && quantity < this.Quantity) {

            return this._quantity -= quantity;
        }
        return 0;
    }
    public double TotalValueInventoies() {
        return this._price *=_quantity;
    }
    override
    public string ToString() {
     return " Name: " + _name +
            "\n Description: " + _description +
            "\n Quantity: " + _quantity +
            "\n Price R$ " + _price.ToString("F2",CultureInfo.InvariantCulture) +
            "\n Total value inventoies R$ " + TotalValueInventoies().ToString("F2", CultureInfo.InvariantCulture);
    }

}
