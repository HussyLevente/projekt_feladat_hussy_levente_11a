using System.Diagnostics;
Stopwatch stopWatch = new Stopwatch(); //Időmérő
Random rnd = new Random();

Console.Write("1. Összeadás\n2. Kivonás\n3. Szorzás\n4. Osztás\n\nVálasszon menüpontot(1-4): ");
int ValasztottSzam = int.Parse(Console.ReadLine());

int Pontok = 0; //Felhasználó által szerzett jó megoldások száma


stopWatch.Start(); //Start

if (ValasztottSzam < 1 || ValasztottSzam > 4) //Rossz bekérés esetén kiléptetés
{
    Console.WriteLine("Rossz számot adott meg.");
}


else if (ValasztottSzam == 1) //Ha a felhasználó összeadásos feladatokat szeretne
{
    for (int i = 0; i < 10; i++) //10 darab feladat legenerálása (többi feladatnál úgyszintén)
    {
        int Osszeadas1 = rnd.Next(1, 51); //Adott intervallumon belül random szám generálás (többi feladatnál úgyszintén)
        int Osszeadas2 = rnd.Next(1, 51);
        Console.Write($"{i + 1}. {Osszeadas1} + {Osszeadas2} = "); //Indexelés 1-10-ig, random számok kiírása (többi feladatnál úgyszintén)
        int OsszeadasMGLDS = int.Parse(Console.ReadLine());
        if (OsszeadasMGLDS == Osszeadas1 + Osszeadas2) //Megnézzük, hogy a felhasználó által adott megoldás jó-e (többi feladatnál úgyszintén)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helyes megoldás, szerzett egy pontot! :D\n");
            Pontok++; //Helyes megoldás esetén növeljük a felhaszáló jó megoldásainak számát (többi feladatnál úgyszintén)
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Helytelen megoldás\n");
            Console.ResetColor();
        }
    }
}


else if (ValasztottSzam == 2) //Ha a felhasználó kivonásos feladatokat szeretne
{
    for (int i = 0; i < 10; i++)
    {
        int Kivonas1 = rnd.Next(1, 51);
        int Kivonas2 = rnd.Next(1, 51);
        Console.Write($"{i + 1}. {Kivonas1} - {Kivonas2} = ");
        int KivonasMGLDS = int.Parse(Console.ReadLine());
        if (KivonasMGLDS == Kivonas1 - Kivonas2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helyes megoldás, szerzett egy pontot! :D\n");
            Pontok++;
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Helytelen megoldás\n");
            Console.ResetColor();
        }
    }
}


else if (ValasztottSzam == 3) //Ha a felhasználó szorzásos feladatokat szeretne
{
    for (int i = 0; i < 10; i++)
    {
        int Szorzas1 = rnd.Next(2, 11);
        int Szorzas2 = rnd.Next(2, 11);
        Console.Write($"{i + 1}. {Szorzas1} * {Szorzas2} = ");
        int SzorzasMGLDS = int.Parse(Console.ReadLine());
        if (SzorzasMGLDS == Szorzas1 * Szorzas2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helyes megoldás, szerzett egy pontot! :D\n");
            Pontok++;
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Helytelen megoldás\n");
            Console.ResetColor();
        }
    }
}


else if (ValasztottSzam == 4) //Ha a felhasználó osztásos feladatokat szeretne
{
    for (int i = 0; i < 10; i++)
    {
        int Osztas1 = rnd.Next(2, 101);
        int Osztas2 = rnd.Next(2, 101);
        Console.Write($"{i + 1}. {Osztas1} / {Osztas2} = ");
        int OsztasMGLDS = int.Parse(Console.ReadLine());
        if (OsztasMGLDS == Osztas1 / Osztas2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helyes megoldás, szerzett egy pontot! :D\n");
            Pontok++;
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Helytelen megoldás\n");
            Console.ResetColor();
        }
    }
}



stopWatch.Stop(); //Stop
TimeSpan ts = stopWatch.Elapsed;

string elapsedTime = String.Format("{0:00}.{0:00}", ts.Seconds, ts.Milliseconds / 10);
Console.WriteLine("Ennyi ideig tartott(S, Ms): " + elapsedTime); //Kiírja, hogy mennyi ideig tartott, másodpercben és millisecundumban



Console.WriteLine($"Ennyi helyes megoldása volt: {Pontok}"); //Összes helyes megoldása a felhasználónak
if (Pontok == 10) //Ha a felhasználó 10 pontot ért el
{
    Console.WriteLine("Kitűnő megoldás");
}
if (Pontok == 9) //Ha a felhasználó 9 pontot ért el
{
    Console.WriteLine("Nagyon jó megoldás");
}
if (Pontok == 8) //Ha a felhasználó 8 pontot ért el
{
    Console.WriteLine("Jó megoldás");
}
if (Pontok == 7) //Ha a felhasználó 7 pontot ért el
{
    Console.WriteLine("Közepes megoldás");
}
if (Pontok == 6) //Ha a felhasználó 6 pontot ért el
{
    Console.WriteLine("Fejlődőképes");
}
if (Pontok < 6) //Ha a felhasználó 6 pontnál kevesebbet ért el
{
    Console.WriteLine("Neked készült ez a program!");
}