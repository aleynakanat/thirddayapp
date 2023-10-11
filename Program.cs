using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Lütfen yaşınızı giriniz:");
        //int yas = Convert.ToInt32(Console.ReadLine());
        //if (yas < 18)
        //{
        //    Console.WriteLine("Ehliyet alamazsınız.");
        //}

        //else
        //{
        //    Console.WriteLine("Ehliyet alabilirsiniz.");

        //}
        // yorum satırı için ctrl+k+c

        //hesap makinesi uygulaması 
        // ********************************************   if else   ******************************************************

        //Console.WriteLine("1.sayıyı giriniz:");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("+,- ifadelerinden birini seçiniz"); //debuglama yöntemi veri kontrolü için kullanılır break point
        //string islem = Console.ReadLine();

        //Console.WriteLine("2. sayıyı giriniz:");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    if (islem=="+")
        //    {
        //        int top = sayi1 + sayi2;
        //        //string interpolation işlemi int değerlerini yerine yazar
        //        Console.WriteLine($"{sayi1} ve {sayi2} nin toplamı: {top}");
        //    }
        //    else if  (islem=="-")
        //    {
        //        int sonuc = sayi1 - sayi2;
        //        Console.WriteLine($"{sayi1} ve {sayi2}nin farkı: {sonuc}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yanlış karakter girdiniz.");
        //    }
        //    Console.WriteLine("Uygulama bitti.");


        //**********************************************  switch case  ****************************************

        //try
        //{
        //    Console.WriteLine("1.sayıyı giriniz:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("+,- ifadelerinden birini seçiniz"); //debuglama yöntemi veri kontrolü için kullanılır break point
        //    string islem = Console.ReadLine();

        //    Console.WriteLine("2. sayıyı giriniz:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    switch (islem)
        //    {
        //        case "+":
        //            {
        //                int toplam = sayi1 + sayi2;
        //                Console.WriteLine("Sayıların toplamı:" + toplam);
        //                break;
        //            }
        //        case "-":
        //            {
        //                int sonuc = sayi1 - sayi2;
        //                Console.WriteLine("Sayıların farkı:" + sonuc);
        //                break;
        //            }
        //        default:
        //            {
        //                Console.WriteLine("Yanlış karakter girdiniz.");
        //                break;
        //            }

        //    }

        //}
        //catch (FormatException e)
        //{
        //    Console.WriteLine("Yanlış format");
        //    //Console.WriteLine(e.Message);
        //}


        //pascal case
        //while(true)
        //        {
        //            Console.WriteLine("%100 enerji");
        //        }
        Console.WriteLine("while döngüsü ile");
        int ilkdeger = 0;
        while (ilkdeger <= 10)
        {
            Console.WriteLine(ilkdeger);
            //ilkdeger++; //1. yöntem
            //ilkdeger = ilkdeger + 1; //2. yöntem
            ilkdeger += 3;

        }
        Console.WriteLine("for döngüsü ile");
        for (int i = 0; i <= 10; i+=3)
        {
            Console.WriteLine(i);
        }
    
    
    
    
    }

}
