byte i;

Console.WriteLine("1'den 4'e kadar gün veya departman seçin");
i = Convert.ToByte(Console.ReadLine());

Gunler gunAdi;
gunAdi = (Gunler)i;
Departman departman;
departman = (Departman)i;



if (i==0)
{
    Console.WriteLine("Toplantı {1} günü {0} birimi ile olacak", (Departman)i, (Gunler)i);
}
else if (i==1)
{
    Console.WriteLine("Toplantı {1} günü {0} birimi ile olacak", (Departman)i, (Gunler)i);
}
else if (i == 2)
{
    Console.WriteLine("Toplantı {1} günü {0} birimi ile olacak", (Departman)i, (Gunler)i);
}
else if (i == 3)
{
    Console.WriteLine("Toplantı {1} günü {0} birimi ile olacak", (Departman)i, (Gunler)i);
}
else if (i == 4)
{
    Console.WriteLine("Toplantı {1} günü {0} birimi ile olacak", (Departman)i, (Gunler)i);
}
else
{
    Console.WriteLine("Haftasonu toplantı çalışma yoktur.");
}

enum Departman
{
    Elektrik, Mekanik, Otomasyon, Bilgi_Islem, Laboratuvar
}

enum Gunler
{
    Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
}

