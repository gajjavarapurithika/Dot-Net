struct Emp
{
    public int eno;
    public string ename;
    public double esal;
    public char egrade;
}
class Test
{
    public static void Main()
    {
        Emp e = new Emp();
        e.eno = 101;
        e.ename = "Anil";
        e.esal = 4325.65;
        e.egrade = 'A';
        Console.WriteLine("Emp No : " + e.eno);
        Console.WriteLine("Emp Name : " + e.ename);
        Console.WriteLine("Emp Sal : " + e.esal);
        Console.WriteLine("Emp Grade : " + e.egrade);
        Console.WriteLine("--------------------------");
    }
}