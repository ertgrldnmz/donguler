internal class Program
{
    private static void Main(string[] args)
    {
       //ekranda girilen sayıya kadar tek olan sayıların yazdırılması
       Console.Write("lütfen bir sayı giriniz:");
        int sayac=int.Parse(Console.ReadLine());
        for (int i = 1; i <=sayac ; i++)     
         {
            if(i%2==1)
            {
                Console.WriteLine(i);
            }
        }
        
        //1 ile 1000 arasında tek ve çift sayıların kendi içlerindeki toplamları
        int tektoplam=0;
        int cifttoplam=0;
        for (int i = 1; i < 1000; i++)
        {
            if(i%2==1)
            {
            tektoplam+=i;
            }
            else
            {
                cifttoplam+=i;
            }
        }

        Console.WriteLine(tektoplam+"/n"+cifttoplam);

        //break,contiune

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
            break;
            
            Console.WriteLine(i);
        }
        
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
            continue;
            Console.WriteLine(i);
        }
    }
}