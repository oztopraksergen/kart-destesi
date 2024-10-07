// Kullanıcıdan veri alıp 4 işlem yapabileceğin bir uygulama 
// Benim yazdığım kodu tamamlamanı istiyorum.

double Topla(double x, double y)
{
    return x + y;
}
double Cikar(double x, double y)
{
return x - y; 
}
double Carp(double x, double y)
{
    return x * y;
}
double Bol(double x, double y)
{
    return x / y;
}


Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
Console.WriteLine("1 - Toplama \n2 - Çıkartma \n3 - Çarpma \n4 - Bölme");

int secim = Convert.ToInt32(Console.ReadLine());


double sonuc = 0;
Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

if (secim == 1)
{
 sonuc = Topla(sayi1, sayi2);
    Console.WriteLine("Sonuc : " + sonuc);
}
else if (secim==2)
{
    sonuc = Cikar(sayi1, sayi2);
    Console.WriteLine("Sonuc : " + sonuc);
}
else if (secim == 3)
{
    sonuc = Carp(sayi1, sayi2);
    Console.WriteLine("Sonuc : " + sonuc);
}
else if (secim == 4)
{
    sonuc = Bol(sayi1, sayi2);
    Console.WriteLine("Sonuc : " + sonuc);
}
else
{
    Console.WriteLine("Geçersiz bir seçim yaptınız");
}
Console.ReadLine();