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



string gulse = "Gurse Birsel";
string demet = "Demet Evgar";
Console.WriteLine(gulse + " " + demet);
Console.WriteLine("Lufen sirasiyla iki adet metin giriniz.");
string x = Console.ReadLine();
string y = Console.ReadLine();
gulse = x;
demet = y;
Console.WriteLine(gulse + " " + demet);





void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();


Console.WriteLine("Sirasiyla, toplanmasini istediginiz iki sayi giriniz.");
int sayiBir = Convert.ToInt32(Console.ReadLine());
int sayiIki = Convert.ToInt32(Console.ReadLine());
Toplam(sayiBir, sayiIki);
int Toplam(int a, int b)
{
    int sonuc = a + b;
    Console.WriteLine("Sonuc={0}", sonuc);
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

Console.WriteLine("Lutfen sirasiyla uc adet sayi giriniz.");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
EnYasliKim(a, b, c);
int EnYasliKim(int a, int b, int c)
{
    int sonuc = Math.Max(Math.Max(a, b), c);
    Console.WriteLine("En yasli {0}'yasindadir.", sonuc);
    return
        sonuc;
}



List<int> depo = new List<int>();
Console.WriteLine("Lutfen istediginiz kadar sayi giriniz ve yeterli gordugunuzde yeterli yaziniz.");
while (true)
{
    string minput = Console.ReadLine().ToLower();
    if (minput == "yeterli")
        break;
    else
    {
        int converted = Convert.ToInt32(input);
        depo.Add(converted);
    }
}
int[] revDepo = depo.ToArray();

SinirsizAl(revDepo);

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



Console.WriteLine("Lutfen sirasiyla yerlerinin degismesini istediginiz metinleri giriniz");
string ilkDegisken = Console.ReadLine();
string ikinciDegisken = Console.ReadLine();
YerDegistir(ilkDegisken, ikinciDegisken);

void YerDegistir(string birinci, string ikinci)
{
    string ucuncu = birinci;
    birinci = ikinci;
    ikinci = ucuncu;
    Console.WriteLine(birinci + " " + ikinci);
}


Console.WriteLine("Lutfen bir sayi giriniz.");
int sayi =Convert.ToInt32(Console.ReadLine());
CiftseTrue(sayi);

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

Console.WriteLine("Lutfen sirasiyla hiz ve zamani giriniz.");
int hiz =Convert.ToInt32(Console.ReadLine());
int zaman = Convert.ToInt32(Console.ReadLine());
YolHesap(hiz, zaman);
void YolHesap(int hiz, int zaman)
{
    double yol = hiz * zaman;
    Console.WriteLine("{0}'km", yol);
}


Console.WriteLine("Lutfen dairenin yari capini giriniz");
double maricap = Convert.ToDouble(Console.ReadLine());
DaireAlanHesap(maricap);
void DaireAlanHesap(double yaricap)
{
    double PI = 3.1415926535897931;
    double kare = yaricap * yaricap;
    double sonuc = kare * PI;
    Console.WriteLine("Dairenin alani {0}'dir", sonuc);
}


string zamanBuyukKucuk = "Zaman bir GeRi SayIm";
OnceBuyukSonraKucuk(zamanBuyukKucuk);
void OnceBuyukSonraKucuk(string input)
{
    Console.WriteLine(input.ToLower());
    Console.WriteLine(input.ToUpper());
}



string selam = "    Selamlar   ";
Trimmer(selam);
void Trimmer(string melam)
{
    selam = melam.Trim();
    Console.WriteLine(selam);
}

