class Books
{
    public int bno;
    public string bname;
    public double bprice;
    public Books()
    {
        bno = 1;
        bname = "C#";
        bprice = 100;
    }
    public void bonedet()
    {
        System.Console.WriteLine("Book No:" + bno);
        System.Console.WriteLine("Book Name:" + bname);
        System.Console.WriteLine("Book Price:" + bprice);
    }
    public Books(int bn,string bna)
    {
        bno = bn;
        bname = bna;
    }
    public void btwodet()
    {
        System.Console.WriteLine("Book No:" + bno);
        System.Console.WriteLine("Book Name:" + bname);
    }
    public Books(int bn,string bna,double bp)
    {
        bno = bn;
        bname = bna;
        bprice = bp;
    }
    public void bthreedet()
    {
        System.Console.WriteLine("Book No:"+ bno);
        System.Console.WriteLine("Book Name:" + bname);
        System.Console.WriteLine("Book Price:" + bprice);
    }
    public static void Main()
    {
        Books b1 = new Books();
        b1.bonedet();
        Books b2 = new Books(2,"Java");
        b2.btwodet();
        Books b3 = new Books(3, "C++", 300);
        b3.bthreedet();
    }
}