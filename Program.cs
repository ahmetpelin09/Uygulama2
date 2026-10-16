using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> numaralar = new List<string> { "101", "102", "103", "104", "105" };
        List<string> bosListe = new List<string>();

        while (true)
        {
            Console.Write("\nAramak istediğin numarayı gir: ");
            string aranan = Console.ReadLine();

            bool sonuc = NumaraVarMi(numaralar, aranan);
            Console.WriteLine("Listede arama sonucu: " + sonuc);

            bool bosSonuc = NumaraVarMi(bosListe, aranan);
            Console.WriteLine("Boş listede arama sonucu: " + bosSonuc);
            break;
        }
    }

    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (string eleman in liste)
        {
            if (eleman == aranan)
            {
                return true;
            }
        }
        return false;
    }
}