

class Program {
    static List<Employee> employeeRegister = new List<Employee>();

    static void Main() {

        bool isRunning = true;

        while (isRunning) {
            Console.WriteLine("`\nVälj ett alternativ: ");
            Console.WriteLine("1: Lägg till anställd");
            Console.WriteLine("2: Visa alla anställda och deras lön: ");
            Console.WriteLine("3: Avsluta");

            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ShowEployees();
                    break;
                case "3":
                    isRunning = false;
                    break;

            
            
            }
        
        }
    
    }

    private static void ShowEployees()
    {
        if (employeeRegister.Count == 0) {
            Console.WriteLine("Inga anställda registrerade.");
            return;
        }

        Console.WriteLine("\nAnställdaregister: ");
        foreach (Employee emp in employeeRegister) { 
        emp.PrintInfo();
        }

    }

    private static void AddEmployee()
    {
        Console.WriteLine("Ange namn: ");
        string name = Console.ReadLine();

        Console.WriteLine("Ange lön: ");
        decimal salary = decimal.Parse(Console.ReadLine());
        Employee newEmployee = new Employee {Name = name, Salary = salary };
        employeeRegister.Add(newEmployee);
        Console.WriteLine("Anställd " + name + " har lagts till.");

    }
}

public class Employee {

  public string Name {
        get;
        set;
    }

    public decimal Salary {
        get;
        set;
    }

    public void PrintInfo() {
        Console.WriteLine($"Name: {Name}, Salary: {Salary} SEK");
    }

}