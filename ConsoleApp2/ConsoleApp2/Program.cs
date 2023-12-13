using ConsoleApp2;

class Program 
{ 
    static void Main(string[] args)
    {
        Cvartira cv1 = new Cvartira(23,-30,-1);
        cv1.Inf();
        cv1.S = 12;
        cv1.Coast = 100;
        cv1.Inf();
        cv1.CoastKv();
    }
}
