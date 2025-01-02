int a = 5, b=3;
System.Console.WriteLine("Values before swap a="+ a + " b=" +b);
a = a + b;
b = a - b;
a = a - b;
System.Console.WriteLine("Values after swap a=" + a + " b=" + b);