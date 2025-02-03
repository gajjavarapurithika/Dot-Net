class Person
{
    public void walk()
    {
        System.Console.WriteLine("Person walks slowly");
    }
}
class Employee:Person
{
    public void walk()
    {
        System.Console.WriteLine("Employee walks fastly");
    }
    public static void Main()
    {
        Employee e=new Employee();
        e.walk();
    }
}