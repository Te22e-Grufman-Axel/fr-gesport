string spelaIgen = "ja";

while (spelaIgen == "ja")
{

    int points = 0;  //skapar en variabel för att hålla koll på poäng

    Console.WriteLine("Välkommen till Axels frågesport ");
    Console.WriteLine("För att börja klicka på valfri knapp"); //Välkomand text
    Console.ReadKey();     //startar frågesporten
    Console.Clear();


    // ---------------------------------------------------------------

    Console.WriteLine("I spelet Rust, Vilket vapen är bäst");
    Console.WriteLine("1 = AK47  2 = Lr-300   3 = Mp5"); //Frågan

    string answer1 = Console.ReadLine();
    if (answer1 == "1") //om man får rätt
    {
        points++;
        Console.WriteLine("Rätt");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Fel");
        Console.ReadKey(); //om man får fel
        Console.Clear();
    }


    // ------------------------------------


    Console.WriteLine("I spelet Rust, hur många helekoptrar finns det?");
    Console.WriteLine("1 = 1  2 = 3   3 = 4");     //frågan

    string answer2 = Console.ReadLine();
    if (answer2 == "3")
    {
        points++;
        Console.WriteLine("Rätt"); //om man får rätt
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Fel");
        Console.ReadKey(); //om man får fel
        Console.Clear();
    }

    // -----------------------------------------------------------------------------------

    Console.WriteLine(" för hur många år sen kom rust ut?");
    Console.WriteLine("1 = 5  2 = 10   3 = 15");      //Frågan

    string answer3 = Console.ReadLine();
    if (answer3 == "2")
    {
        points++;
        Console.WriteLine("Rätt");
        Console.ReadKey();  //om man får rätt
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Fel");  //om man får fel
        Console.ReadKey();
        Console.Clear();
    }

    // -------------------------------------------------------




    Console.WriteLine("Villket företag äger Rust");     //Frågan
    Console.WriteLine("1 = Facepunch  2 = Riotgames   3 = Mojang");

    string answer4 = Console.ReadLine();
    if (answer4 == "1")
    {
        points++;
        Console.WriteLine("Rätt");
        Console.ReadKey(); //om man får rätt
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Fel");
        Console.ReadKey();    //om man får fel
        Console.Clear();
    }

    // --------------------

    if (points == 0)
    {
        Console.WriteLine("DU suger");
        Console.WriteLine("Du fick ingen rätt");     //om man får 0 poäng
        Console.WriteLine("Du fick " + points);
    }
    else
    {
        Console.WriteLine("Du klarade det");
        Console.WriteLine("Du fick " + points + " rätt!!!");  //om man får mer än 0 poäng

    }
    // ------------------------------
Console.WriteLine("Tryck på en knapp för att köra igen");
    Console.ReadKey();
 spelaIgen = "ja";
 Console.Clear();
}