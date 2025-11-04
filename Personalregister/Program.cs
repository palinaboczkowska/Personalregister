


class Program {
    static List<Employee> employeeRegister = new List<Employee>();

    static void Main() {

        bool isRunning = true;

        while (isRunning) {
            Console.WriteLine("`\nVälj ett alternativ: ");
            Console.WriteLine("1: Lägg till anställd");
            Console.WriteLine("2: Visa alla anställda och deras lön: ");
            Console.WriteLine("3: Ta bort anställd");
            Console.WriteLine("4: Avsluta");

            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ShowEmployees();
                    break;
                case "3":
                    RemoveEmployee();
                    break;
                case "4":
                    isRunning = false;
                    break;

            
            
            }
        
        }
    
    }

    private static void RemoveEmployee()
    {
        if (employeeRegister.Count == 0) {
            Console.WriteLine("Registret är tomt.");
            return;
        }
        Console.WriteLine("Ange namn på anställd som ska tas bort: ");
        string nameToRemove = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < employeeRegister.Count; i++) { 
            if(employeeRegister[i].Name == nameToRemove) { 
                employeeRegister.RemoveAt(i);
                Console.WriteLine("Anställd " + nameToRemove + " har tagits bort.");
                found = true;
                break;
            }
            if (!found) {
                Console.WriteLine("Ingen anställd med namn " + nameToRemove + " hittades.");
            }


        }




    }

    private static void ShowEmployees()
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

        if (string.IsNullOrEmpty(name)) {
            Console.WriteLine("Namnet får inte vata tomt.");
            return;
        }

        Console.WriteLine("Ange lön: ");
        string salaryInput = Console.ReadLine();
        decimal salary;

        if (!decimal.TryParse(salaryInput, out salary) || salary < 0) {
            Console.WriteLine("Ogiltig lön.");
            return;
        }

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