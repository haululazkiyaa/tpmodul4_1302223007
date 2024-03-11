using tpmodul4_1302223007;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine(KodePos.Kelurahan.Batununggal + " - " + kodePos.getKodePos(KodePos.Kelurahan.Cijaura));
    }
}