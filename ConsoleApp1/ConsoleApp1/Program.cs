// See https://aka.ms/new-console-template for more information
namespace NewApp;
class Program
{
    public string name;
    public string producer;
    public int relase;
    
    public Program(string SoftwareName, string ProducerName, int Relesedate)
    {
        name = SoftwareName;
        producer = ProducerName;
        relase = Relesedate;
    }
    public void getData()
    {
        Console.WriteLine(name + "\n" + producer + "\n" + relase);
    }
    //static int NewMethod(int a, int b)
    //{
    //    return a + b;
    //}
    //static double NewMethod(double a, double b)
    //{
    //    return a + b;
    //}
    static void Main(string[] args)
    {
        //int a, b, c;
        //a = int.Parse(Console.ReadLine());
        //b = int.Parse(Console.ReadLine());
        //c = int.Parse(Console.ReadLine());
        //if (a * a + b * b == c * c) { Console.WriteLine("OK"); }
        //else { Console.WriteLine("Not OK"); }
        //int[] tab1 = {1, 3, 4, 5, 10};
        //Array.Sort(tab1);
        //   foreach (int i in tab1)
        //{
        //   Console.WriteLine(i);
        //}
        //Program Program1 = new();
        //Program1.a = "ab";
        //Program1.b = "ba";
        //Program1.c = 2010;
        //Program Program2 = new();
        //Program2.a = "aba";
        //Program2.b = "bab";
        //Program2.c = 2015;
        //Console.WriteLine(tab1.Max());
        //Console.WriteLine(NewMethod(5, 7));
        //Console.WriteLine(NewMethod(6.5, 6.4));
        Program Program1 = new("Sonic", "SonicEntertaiment", 1998);
        Program Program2 = new("Vortex", "VortexSolution\'s", 2004);

        Program1.getData();
        Program2.getData();
    }
}