// See https://aka.ms/new-console-template for more information
namespace NewApp;
class Producer
{
    public string ppname;
    public string swname;
    public int cyint;
    public double ssstatus;
    public string companystatus = "active";
    public Producer(string ProducerName, string SoftwareName, int CreationYear, double StockStatus)
    {
        ppname = ProducerName;
        swname = SoftwareName;
        cyint = CreationYear;
        ssstatus = StockStatus;
    }
    class ProducerStatus : Producer
    {
        public ProducerStatus(string ProducerName, string SoftwareName, int CreationYear, double StockStatus, string corpstatus) : base(ProducerName, SoftwareName, CreationYear, StockStatus)
        {
            companystatus = corpstatus;
        }
    }
    public void getDataProducer()
    {
        Console.WriteLine(ppname + "\n" + swname + "\n" + cyint + "\n" + ssstatus + "\n" + companystatus);
    }
}
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
    static void Main(string[] args)
    {
        Producer Producer1 = new("XD", "XD", 1405, 302);
        Program Program1 = new("Sonic", "SonicEntertaiment", 1998);
        Program Program2 = new("Vortex", "VortexSolution\'s", 2004);
        Producer1.getDataProducer();
        Program1.getData();
        Program2.getData();
    }
}