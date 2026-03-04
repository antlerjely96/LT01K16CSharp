// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

public class Program
{
    public static void Main()
    {
        //Tạo đối tượng
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        fullTimeEmployee.DisplayInfo();
        fullTimeEmployee.Birthday = DateOnly.Parse("");
        Console.WriteLine(fullTimeEmployee.Birthday);
    }
}