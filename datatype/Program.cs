using System;
using DataType;
class MainClass
{
    public static void Main(String[] args)
    {
        Int  a= new Int(10);
        Int b= new Int(20);
        Console.WriteLine(a.Add(a,b));
        Console.WriteLine(b.Sub(a,b));

        Float c = new Float(10);
        Float d = new Float(20);

        Console.WriteLine(c.Add(c,d));
        Console.WriteLine(d.Sub(c,d));
    }
    
}
