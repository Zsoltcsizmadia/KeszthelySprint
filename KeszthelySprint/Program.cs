namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Versenyző> versenyzok = new();
            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyző(sor));
            }
            Console.WriteLine($"2. feladat: A versenyt {versenyzok.Count} fő versenyző fejezte be ");


            //3.
            var junior = 0;

            foreach (var v in versenyzok)
            {
                if (v.ÉletKategória == "elit junior")
                {
                    junior++;
                }
            }
            Console.WriteLine($"3. feladat: Versenyzők száma az \"elit junior\" kategóriában: {junior} fő");


            //4.
            double ossz_eletkor = 0;
            foreach (var v in versenyzok)
            {
                ossz_eletkor += DateTime.Now.Year - v.SzületésiÉv;
            }
            Console.WriteLine($"4. feladat: Átlag életkor: {Math.Round(ossz_eletkor / versenyzok.Count, 1)} év");
        }
    }
}
