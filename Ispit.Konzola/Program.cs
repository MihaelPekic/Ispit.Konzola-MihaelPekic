using Ispit.Model;

for (int i = 1; i <= 3; i++)
{

    Console.Write("Unesi ime ucenika :");
    string ime = Console.ReadLine();

    Console.Write("Unesi prezime ucenika :");
    string prezime = Console.ReadLine();

    bool ispravanUnosDatuma;
    do
    {
        Console.WriteLine("Unesite godinu rodjenja u formatu dd.MM.yyyy : ");
        string unosDatuma = Console.ReadLine();

        ispravanUnosDatuma = DateTime.TryParse(unosDatuma, out DateTime datumRodjenja);

        if (ispravanUnosDatuma)
        {
            Ucenik ucenik = new Ucenik
            {
                Ime = ime,
                Prezime = prezime,
                DatumRodjenja = datumRodjenja

            };
            Console.WriteLine($"Ime: {ucenik.Ime}");
            Console.WriteLine($"Prezime: {ucenik.Prezime}");
            Console.WriteLine($"Datum rođenja: {ucenik.DatumRodjenja.ToString(format:"dd.MM.yyyy")}");
            ucenik.Starost();
            ucenik.IspisProsjeka();

        }
        else
        {
            Console.WriteLine("krivi format datuma!! ponovi :");
        }
    } while (ispravanUnosDatuma == false);

}