using Závěrečný_projekt;


Random generatorVoleb= new Random();
int cislo = generatorVoleb.Next(1,4);

Console.WriteLine("Ahoj vítej v mé hře kámen-nůžky-papír doufám že si hru užiješ a vyhraješ nad pc (Jinak si u mě bot xdddddd)");


Console.WriteLine("Vitej ve hře kámen - nůžky  - papír");
Console.WriteLine("Hra začíná za");
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Console.Clear();
while(Hra)
{
int SkoreHrac = 0;
int SkoreNepritel = 0;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Hrac: {score1}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Nepritel:{score2}");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("---------");

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
        Console.WriteLine("Nepřítel Vyhraje");
            
        
    }
 
    if (cislo == 2)
    {
        Console.WriteLine("Vyhrál jsi");
        score++
    }
   

    if (cislo == 1)
    {
        Console.WriteLine("Ani jeden remíza");
    }


}
if (Hrac == "2")
{
    if (cislo == 1)
    {
        Console.WriteLine("Prohrál jsi");
    }


    if (cislo == 2)
    {
        Console.WriteLine("Remíza a nůžky se stupily xdddd");
    }


    if (cislo == 3)
    {
        Console.WriteLine("Vyhrál jsim, nůžky papír rozstřihly");
    }

}
if (Hrac == "3")
{
    if(cislo == 1)
    {
        Console.WriteLine("Vyhrál jsi a zabalil kámen");
    }
    if(cislo == 2)
    {
        Console.WriteLine("Prohrál jsi a nemáš papír xddddd");
    }
    if(cislo == 3)
    {
        Console.WriteLine("Remíza a papíry se zmuchali");
    }
    break;
    }

}





