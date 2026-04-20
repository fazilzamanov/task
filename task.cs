using System;
using System.Collections.Generic;
public class Product
{

    public string Ad { get; set; }
    public string  Kateqoriya { get; set; }
    public DateTime SonIstifade { get; set; }
    public  Product(string ad, string kateqoriya, DateTime sonIstifade)

    {
        Ad = ad;
        Kateqoriya = kateqoriya;
        SonIstifade = sonIstifade;

    }
    public void GetData()
    {
         Console.WriteLine($"Məhsul: {Ad}, Kateqoriya: {Kateqoriya}, Tarix: {SonIstifade.ToShortDateString()}");
    }
    public bool  VaxtiKecibmi()
    {
        return DateTime.Now > SonIstifade;
    }
}
class Program
{


    static void Main()
    {


        List<Product> mehsullar = new List<Product>();
        mehsullar.Add(new Product("Sud", "Sud mehsullari", new DateTime(2024, 1, 10)));
        mehsullar.Add(new Product("Qatiq", "Sud mehsullari", new DateTime(2026, 12, 30)));
        mehsullar.Add(new Product("Corek", "Un memulati", new DateTime(2026, 4, 25)));
        mehsullar.Add(new Product("p1", "Diger", new DateTime(2026, 6, 15)));


        Console.WriteLine("Butun mehsullarin siyahisi :");
        foreach (var m in mehsullar)
        {
            m.GetData();
        }
        P1Yoxla(mehsullar);
        Console.WriteLine("\nFiltr edilmis mehsullar (Sud mehsullari):");
        KateqoriyaFiltrle(mehsullar, "Sud mehsullari");
        VaxtiKecenleriSil(mehsullar);
        Console.WriteLine("\nKohne mehsullar silindikden sonra siyahı:");
        foreach (var m in mehsullar)
        {
            m.GetData();
        }
    }
    static  void P1Yoxla(List<Product> siyahı)
    {
        bool varmi = false;
        foreach (var m in siyahı)
        {
            if (m.Ad == "p1")
            {
                varmi = true;
                break;
            }

        }
        Console.WriteLine(varmi ? "\np1 mehsulu siyahida var." : "\np1 mehsulu tapilmadi.");
    }
    static void KateqoriyaFiltrle(List<Product> siyahı, string secilmisKateqoriya)
    {
        foreach (var m in siyahı)
        {
            if  (m.Kateqoriya == secilmisKateqoriya)
            {
                m.GetData();
            }
        }
    }


    static void VaxtiKecenleriSil(List<Product> siyahı)
    {
        for  (int i = 0; i < siyahı.Count; i++)
        {
            if (siyahı[i].VaxtiKecibmi())
            {
                
                siyahı.RemoveAt(i);
                i--; 
            }

        
        }
    }
}