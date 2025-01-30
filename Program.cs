using System.Xml;

namespace IDP_assg_3
{
    class Program
    {
        public class Grundämne
        {
            public string Namn;
            public int Atomnummer;
            public string Typ;
            public double Smältpunkt;
            public double Kokpunkt;

            public Grundämne(string namn, int atomnummer, string typ, double smältpunkt, double kokpunkt)
            {
                Namn = namn;
                Atomnummer = atomnummer;
                Typ = typ;
                Smältpunkt = smältpunkt;
                Kokpunkt = kokpunkt;
            }

            public void Print()
            {
                Console.WriteLine($"Grundämne: {Namn}");
                Console.WriteLine($"  Atomnummer: {Atomnummer}");
                Console.WriteLine($"  Typ: {Typ}");
                Console.WriteLine($"  Smältpunkt: {Smältpunkt} K");
                Console.WriteLine($"  Kokpunkt: {Kokpunkt} K");
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {
            Grundämne syre = new("Syre", 8, "Ickemetall", 54.36, 90.188);
            Grundämne järn = new("Järn", 26, "Metall", 1811, 3134);
            Grundämne guld = new("Guld", 79, "Metall", 1337.33, 3243);

        }
    }
}