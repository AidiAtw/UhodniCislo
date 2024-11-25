Console.WriteLine("Vítejte ve hře -- UHODNI ČÍSLO");


int pokus = 10;
Console.WriteLine("Hráči, máš 10 pokusů na uhodnutí čísla od 1 do 100.");
Random random = new Random();
int cislo = random.Next(1, 100);


for (int i = 0; i < 10; i++)
{
    int tip = -1;
    Console.WriteLine("Zadej svůj tip: ");
    string tipStr = Console.ReadLine();
    tip = Convert.ToInt32(tipStr);
    Console.WriteLine("Váš tip je: " + tip);

    while (tip != cislo)
        if (tip < cislo)
        {
            Console.WriteLine("Hledané číslo je větší.");
            pokus -= 1;
            Console.WriteLine("Poznámka: Máš ještě," + pokus, "pokusů");
            break;
        }

        else if (tip > cislo)
        {
            Console.WriteLine("Hledané číslo je menší.");
            pokus -= 1;
            Console.WriteLine("Poznámka: Máš ještě," + pokus, "pokusů");
            break;
        }

        if (tip == cislo)
           {
        Console.WriteLine("Gratuluji! Uhodl jsi číslo" + cislo + "po" + (11 - pokus) + "pokusů");
        break;
        }
}

Console.WriteLine("KONEC HRY");