Console.Write("Birinci sayıyı girin: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Yapılacak işlemi seçin (+, -, *, /): ");
char islem = Convert.ToChar(Console.ReadLine());

switch (islem)
{
    case '+':
        Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
        break;
    case '-':
        Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
        break;
    case '*':
        Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
        break;
    case '/':
        if (sayi2 != 0)
            Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
        else
            Console.WriteLine("Hata! Sıfıra bölme yapılamaz.");
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        break;
}
