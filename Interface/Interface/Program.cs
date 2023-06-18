using Interface;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pilih Printer");
        Console.WriteLine("================");
        Console.WriteLine("1. Epson");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LasetJet");

        Console.Write("Nomor Printer [1..3] : ");
        int nomorPrinter = Convert.ToInt32(Console.ReadLine());

        
        if (nomorPrinter == 1)
        {
            Epson epson = new Epson("Epson", "11*12");
            epson.show();
            epson.print();

        }

        else if (nomorPrinter == 2)
        {
            Canon canon = new Canon("Canon", "10*11");
            canon.show();
            canon.print();
        }

        else if (nomorPrinter == 3)
        {
            LasetJet lasetJet = new LasetJet("LasetJet", "9*10");
            lasetJet.show();
            lasetJet.print();
        }

        Console.ReadLine();
    }
}