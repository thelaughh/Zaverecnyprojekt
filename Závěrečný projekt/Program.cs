using Závěrečný_projekt;


Random generatorVoleb= new Random();
int cislo = generatorVoleb.Next(1,4);

Console.WriteLine("Ahoj vítej v mé hře kámen-nůžky-papír doufám že si hru užiješ a vyhraješ nad pc (Jinak si u mě bot xdddddd)");

#region začátek
Console.WriteLine("Vitej ve hře kámen - nůžky  - papír");
Console.WriteLine("Hra začíná za");
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Console.Clear();
#endregion začátek
bool hraVProcesu = true;
int SkoreHrac = 0; 
int SkoreNepritel = 0;
#region while a if
while (hraVProcesu == true)
{
    Console.ReadKey();
    Console.Clear();
  
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Hrac:{SkoreHrac} ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Nepritel:{SkoreNepritel} ");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("---------");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Kolo hráče:");
    Console.WriteLine("1 - kámen");
    Console.WriteLine("2 - nůžky");
    Console.WriteLine("3 - papír");

    Console.WriteLine("---------");

    string Hrac = Console.ReadLine();

    if (Hrac == "1")
    {
        if (cislo == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepřítel Vyhraje");
            ++SkoreNepritel;
        }
    
        if (cislo == 2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vyhrál jsi");
            ++SkoreHrac;
        }

        
     

        if (cislo == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ani jeden remíza");
        }


    }
    if (Hrac == "2")
    {
        if (cislo == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prohrál jsi");
            ++SkoreNepritel;
        }
   

        if (cislo == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Remíza a nůžky se stupily xdddd");
        }
  

        if (cislo == 3)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vyhrál jsi, nůžky papír rozstřihly");
            ++SkoreHrac;
        }
    

    }
    if (Hrac == "3")
    {
        if(cislo == 1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vyhrál jsi a zabalil kámen");
                ++SkoreHrac;
        }
        if(cislo == 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prohrál jsi a nemáš papír xddddd");
             ++SkoreNepritel;
        }
        if(cislo == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Remíza a papíry se zmuchali");
        }
    }
    //podmínka, když ScoreHrac == 5 NEBO ScoreEnemy == 5
    // break;
    #endregion while a if
    #region if
    if (SkoreHrac == 5 )
    {
        Console.WriteLine("Jsí vítěz");
            break;
    }
    if(SkoreNepritel == 5)
    {
        Console.WriteLine("Jsi looser");
        break;
    }
    #endregion if
}
//pokračování po přerušení cyklu while






