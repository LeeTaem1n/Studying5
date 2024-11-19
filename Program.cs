using System;
// operator overloading
public class AddOne
{
    public int x;

    public static AddOne operator +(AddOne a, AddOne b)
    {
        AddOne addone = new AddOne();
        addone.x = a.x + b.x + 1;
        return addone;
    }
}
public class Program
{
    static void Main(string[] args) { 
AddOne foo = new AddOne();
    foo.x = 2;
AddOne bar = new AddOne();
    bar.x = 3;

Console.WriteLine((foo + bar).x.ToString());
Console.Read(); 
    }
}