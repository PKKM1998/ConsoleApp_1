// See https://aka.ms/new-console-template for more information
class Parcels
{
    static void Main(string[] args)
    {
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a*a+b*b==c*c) { Console.WriteLine("OK"); }
        else { Console.WriteLine("Not OK"); }
    }
}
