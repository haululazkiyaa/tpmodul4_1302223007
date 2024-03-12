using tpmodul4_1302223007;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        void printInfo(KodePos.Kelurahan kelurahan)
        {
            Console.WriteLine("- " + kelurahan + " (" + kodePos.getKodePos(kelurahan) + ")");
        }

        Console.WriteLine("KELURAHAN (KODE POS)");
        printInfo(KodePos.Kelurahan.Batununggal);
        printInfo(KodePos.Kelurahan.Kujangsari);
        printInfo(KodePos.Kelurahan.Mengger);
        printInfo(KodePos.Kelurahan.Wates);
        printInfo(KodePos.Kelurahan.Cijaura);
        printInfo(KodePos.Kelurahan.Jatisari);
        printInfo(KodePos.Kelurahan.Margasari);
        printInfo(KodePos.Kelurahan.Sekejati);
        printInfo(KodePos.Kelurahan.Kebonwaru);
        printInfo(KodePos.Kelurahan.Maleer);
        printInfo(KodePos.Kelurahan.Samoja);

        Console.WriteLine("");

        DoorMachine door = new DoorMachine();
        Console.WriteLine("State awal : " + door.currentState);
        Console.WriteLine("---trigger kunci pintu---");
        door.ActivateTrigger(Trigger.KunciPintu);
        Console.WriteLine("---trigger buka pintu---");
        door.ActivateTrigger(Trigger.BukaPintu);
        Console.WriteLine("---trigger buka pintu---");
        door.ActivateTrigger(Trigger.BukaPintu);
        Console.WriteLine("---trigger kunci pintu---");
        door.ActivateTrigger(Trigger.KunciPintu);
    }
}