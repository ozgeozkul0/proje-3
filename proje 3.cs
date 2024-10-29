//Soru 1 - Foreach Döngüsü ile Liste Elemanlarını Yazdırma
//Bir ArrayList oluşturun ve içerisine birkaç tamsayı ekleyin.
//foreach döngüsü kullanarak listedeki her bir sayıyı ekrana yazdıran bir program yazınız.
//Döngü tamamlandığında sayıların toplamını da ekrana yazdırınız.

using System;
using System.Collections;
using Microsoft.Win32.SafeHandles;
class prgagram
{
    static void Main()
    {
        ArrayList sayilar = new ArrayList();
        sayilar.Add(3);
        sayilar.Add(4);
        sayilar.Add(5);
        sayilar.Add(6);

        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
            toplam += sayi;
        }
        Console.WriteLine("toplam: " + toplam);
    }
}


//soru 2 hazır metod kullanımı
// kullanıcıdan bir cümle girmesini isteyin ve bu cümledeki kelime sayısını hesaplayıp ekrana yazdıran
// bir program yazınız. kelime sayısını hesaplamak için split() metodu kullanabilir.
using System.Collections;

Console.Write("bir cumle giriniz:");
string cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
int kelimesay = kelimeler.Length;
Console.WriteLine("kelime sayisi: " + kelimesay);


//Soru 3 - ArrayList ile Alfabetik Sıralama 
//Kullanıcıdan 5 adet isim alarak bir ArrayList içinde saklayın. 
//Daha sonra bu isimleri alfabetik olarak sıralayarak ekrana yazdırın. 
//(Not: ArrayList.Sort() metodunu kullanabilirsiniz.)

using System;
using System.Collections;

class alfabetik_siralama
{
    private static void Main()
    {
        ArrayList isimler = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("bir isim giriniz: ");
            string isim = Console.ReadLine();
            isimler.Add(isim);
        }
        isimler.Sort();
        Console.WriteLine("\n alfabetik sıralanmış isimler: ");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}



//Soru 4 - For Döngüsü ile Fibonacci Serisi 
//Kullanıcıdan bir sayı girmesini isteyin. Bu sayı kadar Fibonacci serisindeki sayıları hesaplayıp
//ekrana yazdıran bir program yazınız. for döngüsü kullanarak seriyi oluşturun.
//Örnek: Eğer kullanıcı 5 girerse, ekranda "0 1 1 2 3" yazmalıdır.
Console.WriteLine("bir sayi giriniz:");
int n = int.Parse(Console.ReadLine());
int a = 0, b = 1;
Console.WriteLine("fibonacci serisi: ");
for (int i = 0; i<n; i++)
{
    Console.WriteLine(a);
    int c = a + b;
    a = b;
    b = c;
}


//Soru 5 - While Döngüsü ile Tahmin Oyunu 
//Kullanıcıdan bir sayı tahmin etmesini isteyen bir program yazınız.
//Program, doğru tahmin yapılana kadar kullanıcıdan yeni tahminler almaya devam etmelidir.
//Doğru tahmin yapıldığında ekrana bir tebrik mesajı yazdırılmalıdır.
//Not: Sabit bir sayı belirleyebilir veya Random sınıfı ile rastgele bir sayı oluşturabilirsiniz.

int sayix = 8;
Console.WriteLine("bir sayi tahmin ediniz. ");
sayix = Convert.ToInt32(Console.ReadLine());
while (true)
{

    Console.WriteLine("tahmin yanlıs.");
    Console.Write("tekrar tahmin ediniz: ");
    sayix = Convert.ToInt32(Console.ReadLine());
    if (sayix == 8)
    {
        break;

    }
    
}
Console.WriteLine("tebrikler!");
Console.ReadKey();



//Soru 6 - Do While Döngüsü ile Basit Hesap Makinesi
//Kullanıcıdan işlem türünü (+, -, *, /) ve iki sayı alarak işlemi gerçekleştiren bir program yazınız.
//Kullanıcı "çıkış" yazana kadar işlemleri tekrarlayan bir do while döngüsü kurunuz.
//Ekstra: Bölme işlemi sırasında sıfıra bölme hatasını kontrol ediniz.

int sayi1, sayi2, sonuc;
string islem;
char cıkıs;
do
{
    Console.WriteLine("birinci sayiyi giriniz: ");
    sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ikinci sayiyi giriniz: ");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("islemi giriniz: ");
    islem = Console.ReadLine();
    if (islem == "+")
    {
        sonuc = sayi1 + sayi2;
        Console.Write("sonuc: \n" + sonuc);
    }
    if (islem == "-")
    {
        sonuc = sayi1 - sayi2;
        Console.Write("sonuc: \n " + sonuc);
    }
    if (islem == "*")
    {
        sonuc = sayi1 * sayi2;
        Console.Write("sonuc: \n " + sonuc);
    }
    if (islem == "/")
    {
        sonuc = sayi1 / sayi2;
        Console.Write("sonuc: \n " + sonuc);
    }
    Console.WriteLine("baska bir islem yapmak ister misiniz: (cıkıs yazarak bitirebilirsiniz)");
    cıkıs = Console.ReadKey().KeyChar;
}
while (cıkıs == cıkıs);
    Console.WriteLine("hesap makinesi kapatıldı.");




//Soru 7 - For ve While Döngüsü ile Sayı Toplama Oyunu 
//Kullanıcıdan pozitif tam sayılar girmesini isteyen bir program yazınız. Kullanıcı "0" girdiğinde
//girişi sonlandırın ve girilen pozitif sayıların toplamını bir while döngüsü kullanarak hesaplayın.
//Toplamı bulduktan sonra tüm pozitif sayıları tek tek ekrana yazdırmak için bir for döngüsü kullanınız.
class sayi_oyunu
{
    private static void Main()
    {
        int sayi;
        int toplam = 0;
        List<int> sayilar = new List<int>();
        while (true)
        {
            Console.WriteLine("pozitif tam sayi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                break;
            }
            else
            {
                toplam += sayi;
                sayilar.Add(sayi);
            }
        }
        Console.WriteLine("sayilarin toplami: " + toplam);
        for (int i = 0; i< sayilar.Count; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
    }
}

