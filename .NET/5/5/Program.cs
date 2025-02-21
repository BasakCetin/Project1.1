Console.Write("Şifrenizi girin: ");
string sifre = Console.ReadLine();

bool uzunlukYeterli = sifre.Length >= 8;
bool harfVar = sifre.Any(char.IsLetter);
bool rakamVar = sifre.Any(char.IsDigit);
bool ozelKarakterVar = sifre.Any(ch => "!@#$%^&*()_+-=[]{}|;':\",.<>?/`~".Contains(ch));

if (uzunlukYeterli && harfVar && rakamVar && ozelKarakterVar)
{
    Console.WriteLine("Şifre güçlü.");
}
else
{
    Console.WriteLine("Şifre zayıf. En az 8 karakter, bir harf, bir rakam ve bir özel karakter içermelidir.");
}
