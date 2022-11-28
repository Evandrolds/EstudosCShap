using employee;
using System.Globalization;

namespace ExercicioLista {
    class Application {
        static void Main(string[] args) {

            Console.WriteLine("How many employee do you want register?");
            List<Employee> employeeList = new List<Employee>();
            int n = int.Parse(Console.ReadLine());
            Employee employee = new Employee();
            for (int i = 1; i <= n; i++) {

                Console.Write("Enter " + i + "º Id of employee...");
                int id2 = int.Parse(Console.ReadLine());

                Console.Write("Enter name ...");
                string name = Console.ReadLine();

                Console.WriteLine("Enter salary $ ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("\n");

                employee = new Employee(id2, name, salary);
                employeeList.Add(employee);

                Console.WriteLine(employee);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.Write("Enter employee id that will have increase salary ...");
            int id = int.Parse(Console.ReadLine());
            Employee emp = employeeList.Find(x => x.Id == id);
            if (emp != null) {

                Console.WriteLine("Enter increase value $ ");
                double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Increase(increase);
            }
            else {
                Console.WriteLine(" Invalid id ");
            }
            Console.WriteLine("\n");

            employeeList.ForEach(x => Console.WriteLine(x));

        }

    }
}
