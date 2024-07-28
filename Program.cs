using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");              

int tamSayi = 7;
string sirket = "Patika";
Console.WriteLine("Tam Sayi={0}, Metinsel ifade={1}", tamSayi, sirket);

Random rnd = new Random();
Console.WriteLine(rnd.Next());

double sonuc = rnd.Next() % 3;
Console.WriteLine(sonuc);

Console.WriteLine("Lutfen yasinizi giriniz.");
Console.Write("Yas:");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem");
}



string gulse = "Gulse Birsel";
string demet = "Demet Evgar";
Console.WriteLine(gulse+","+demet);
Console.WriteLine("Lutfen metinsel bir deger giriniz");
string a = Console.ReadLine();
if (a != null)
{
    Console.WriteLine(demet + ","+gulse);
}
Console.WriteLine("Lutfen metinsel bir deger giriniz");
string b = Console.ReadLine();
if (b != null)
    Console.WriteLine(gulse + "," + demet);
Console.WriteLine("=====================================");
// tabi ki soru sunu da istiyor olabilir




Console.WriteLine(gulse + "," + demet);
Console.Write("Lutfen metinsel bir deger giriniz: ");
gulse =Console.ReadLine();
Console.Write("Lutfen metinsel bir deger giriniz: ");
demet = Console.ReadLine();
Console.WriteLine(gulse + "," + demet);





void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

int Toplam(int a,int b)
{
    int sonuc = a + b;
    return
        sonuc;
}



Console.WriteLine(Toplam(1, 2));
int dogru = 2;
Console.Write("Bir arti bir kactir: ");
int input=Convert.ToInt32(Console.ReadLine());
if (input != dogru)
{
    Console.WriteLine("Yanlis.");
}
else if (input == dogru)
{
    Console.WriteLine("Dogru.");
}


int EnYasliKim(int a,int b, int c)
{
    int sonuc=Math.Max(Math.Max(a, b), c);
    return
        sonuc;
}



int SinirsizAl(params int[] sayilar)
{
    if (sayilar == null)
    {
        Console.WriteLine("Parametrelere sayi girilmedi.");
    }
    else
        Console.WriteLine(sayilar.Max());
    return sayilar.Max();
}




void YerDegistir(string birinci, string ikinci)
{
    Console.WriteLine(ikinci + " " + birinci);
}



bool CiftseTrue(int sayi)
{
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayi Cifttir.");
        return true;
    }
    else
        Console.WriteLine("Sayi Tektir.");
    return false;

}


void YolHesap(int hiz, int zaman)
{
    double yol = hiz * zaman;
    Console.WriteLine("Yol={0}", yol);
}


void DaireAlanHesap(double yaricap)
{
    double PI = 3.1415926535897931;
    double kare = yaricap * yaricap;
    double sonuc = kare * PI;
    Console.WriteLine("Dairenin alani {0}'dir", sonuc);
}


string zamanBuyukKucuk = "Zaman bir GeRi SayIm";
Console.WriteLine(zamanBuyukKucuk.ToLower());
Console.WriteLine(zamanBuyukKucuk.ToUpper());



string selam = "    Selamlar   ";
if (selam == "    Selamlar   ")
{
    selam = "Selamlar";
}
Console.WriteLine(selam);









