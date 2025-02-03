class Emp
{
    public int eno;
    public string ename;
    public double esal;
    public void empdet()
    {
        System.Console.WriteLine("Eno=" + eno + "\t" + "Ename=" + ename + "\t" + "Esal=" + esal);
    }
    public void empdet(int en,string ena)
    {
        eno = en;
        ename = ena;
        System.Console.WriteLine("Eno=" + eno + "\t" + "Ename=" + ename);
    }
    public void empdet(int en,string ena,double esa)
    {
        eno = en;
        ename = ena;
        esal = esa;
        System.Console.WriteLine("Eno=" + eno + "\t" + "Ename=" + ename + "\t" + "Esal=" + esal);
    }
    public static void Main()
    {
        Emp e=new Emp();
        e.eno = 101;
        e.ename = "Ravi";
        e.esal = 1000;
        e.empdet();
        e.empdet(102, "Raju");
        e.empdet(102, "Anil", 29820.09);
    }
}