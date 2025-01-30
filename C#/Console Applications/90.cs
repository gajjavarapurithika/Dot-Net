using System;
struct Emp
{
    public int eno;
    public string ename;
    public double esal;
    public char egrade;
    public void getemp()
    {
        Console.WriteLine("Enter Employee Number");
        eno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        ename = Console.ReadLine();
        Console.WriteLine("Enter Employee Salary");
        esal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Employee Grade");
        egrade = Convert.ToChar(Console.ReadLine());
    }
    public void hi()
    {
        Console.WriteLine("Employee Number : " + eno);
        Console.WriteLine("Employee Name : " + ename);
        Console.WriteLine("Employee Salary : " + esal);
        Console.WriteLine("Employee Grade : " + egrade);
    }
}
class Test
{
    public static void Main()
    {
        Emp e=new Emp();
        e.getemp();
        e.hi();
    }
}