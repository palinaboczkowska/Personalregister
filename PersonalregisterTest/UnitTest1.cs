using Xunit;

public class EmployeeTests
{
    [Fact]
    public void Employee_ShouldStoreNameAndSalary()
    {
        var employee = new Employee { Name = "Anna", Salary = 25000 };

        Assert.Equal("Anna", employee.Name);
        Assert.Equal(25000, employee.Salary);
    }
 

}