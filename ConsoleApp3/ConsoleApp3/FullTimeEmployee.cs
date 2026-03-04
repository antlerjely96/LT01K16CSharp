namespace ConsoleApp3;

//Class FullTimeEmployee kế thừa class Employee
public class FullTimeEmployee : Employee, ITaxable
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Full-time Employee");
    }

    public override double CaculatorSalary()
    {
        throw new NotImplementedException();
    }

    public double CaculatorTax()
    {
        throw new NotImplementedException();
    }
    
    //Constructor
    public FullTimeEmployee()
    {
        
    }

    public FullTimeEmployee(String Name)
    {
        
    }
}