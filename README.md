# Döngüler
### For Döngüsü
Örnek bir for döngüsü 2 ifade, 1 koşuldan oluşur.
>for(ifade1;kosul;ifade2)
{
    komut1;
    komut2;
}
- **ifade1:** Döngünün sayacının tanımlandığı ve atamasının yapıldığı ifadedir. Örneğin; int i=0;

- **ifade2:** Döngünün sayacının artırım ya da azaltım şeklini belirten ifadedir. Örneğin ; i++, i-- gibi.

- **koşul:**  döngünün devam etme koşuludur. Bu koşul sağlandığı sürece döngü devam eder. Örneğin : i<=12;

>**ÖNEMLİ:** For döngüsünü oluşturan bu 2 ifade 1 koşulun bir kısmı ya da tamamı boş bırakılabilir ama aralardaki " ; " işareti mutlaka kullanılmalıdır.

**Break Anahtar Kelimesi**
Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır.

**Continue Anahtar Kelimesi**
Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu sonlandırır. Döngü bir sonraki iterasyondan devam eder.

##### Örnek Kod  Kullanımı

 ``` csharp
  Console.Write("lütfen bir sayı giriniz:");
        int sayac=int.Parse(Console.ReadLine());
        for (int i = 1; i <=sayac ; i++)     
         {
            if(i%2==1)
            {
                Console.WriteLine(i);
            }
        }

