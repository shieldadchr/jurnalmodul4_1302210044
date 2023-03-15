// See https://aka.ms/new-console-template for more information

namespace modul4_1302210044
{ 
    class program
    {
        static void Main(String[] args)
        {
            kodeBuah buah = new kodeBuah();
            Console.WriteLine("Kode Buah " + kodeBuah.buah.Anggur + " kodenya adalah: " + buah.getKodeBuah(kodeBuah.buah.Anggur));
        }

    }
}
