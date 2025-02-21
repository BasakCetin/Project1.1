int sayi;
Console.Write("Bir sayı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi > 0)
{
    Console.WriteLine("Sayı pozitiftir.");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayı negatiftir.");
}
else
{
    Console.WriteLine("Sayı sıfırdır.");
}
