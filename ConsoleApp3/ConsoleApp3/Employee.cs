
namespace ConsoleApp3;

//Khai báo class
public abstract class Employee
{
    //Khai báo thuộc tính
    public String Name;
    private DateOnly _birthday;
    protected String _address;

    public DateOnly Birthday
    {
        get { return _birthday; }
        set { _birthday = value; }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Employee");
    }

    public void DisplayInfo(String Name)
    {
        
    }

    public abstract double CaculatorSalary();
}