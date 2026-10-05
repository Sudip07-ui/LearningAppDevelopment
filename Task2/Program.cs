public class Circle
{
    public  const double PI = 3.14;
}

class Program
{
    static void Main(string[] args)
    {
        //Circle.PI = 3.14;
    }
}
// The error occur because when we declare the value of PI , it is declared in const so that const are immutable and we can not change.     