using System.Globalization;

namespace employee;

class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; private set; }
    public Employee() { }

    public Employee(int id, string name, double salary) {
        Id = id;
        Name = name;
        this.Salary = salary;
    }
    override
    public string ToString() {
        return " Id: " + Id +
            "\n Name: " + Name +
            "\n Salary $ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }
    public void Increase(double increase) {
        Salary += (Salary * increase) / 100;
    }
}