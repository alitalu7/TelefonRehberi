using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Rehber
    {
        List<Kisi> rehber = new List<Kisi>();

        public void Baslagıc()
        {
            Kisi k1 = new Kisi { Ad = "acil",     SoyAd = "saglık", TelNo = "112" };
            Kisi k2 = new Kisi { Ad = "alo",      SoyAd = "cevre",  TelNo = "181" };
            Kisi k3 = new Kisi { Ad = "dogalgaz", SoyAd = "ariza" , TelNo = "187" };
            Kisi k4 = new Kisi { Ad = "elektrik", SoyAd = "ariza",  TelNo = "186" };
            Kisi k5 = new Kisi { Ad = "telefon",  SoyAd = "ariza",  TelNo = "121" };

            rehber.Add(k1);
            rehber.Add(k2);
            rehber.Add(k3);
            rehber.Add(k4);
            rehber.Add(k5);
        }
        public void Ekle()
        {
            Kisi kisi = new();

            Console.WriteLine("İsmi giriniz...");
            kisi.Ad = Console.ReadLine();
            Console.WriteLine("Soyadı giriniz..");
            kisi.SoyAd = Console.ReadLine();
            Console.WriteLine("Telefon numarasını giriniz..");
            kisi.TelNo = Console.ReadLine();

            rehber.Add(kisi);
        }
        public void Guncelle()
        {
            Kisi kisi = new();
            string gelen;

            Console.WriteLine("Güncellemek istediğiniz ismi veya soyismi giriniz...");
            gelen = Console.ReadLine().ToLower();

            foreach (var item in rehber)
            {
                if (gelen == item.Ad || gelen == item.SoyAd)
                {
                    rehber.RemoveAt(rehber.IndexOf(item));
                    Console.WriteLine("İsmi giriniz...");
                    kisi.Ad = Console.ReadLine();
                    Console.WriteLine("Soyadı giriniz..");
                    kisi.SoyAd = Console.ReadLine();
                    Console.WriteLine("Telefon numarasını giriniz..");
                    kisi.TelNo = Console.ReadLine();

                    rehber.Add(kisi);

                    Console.WriteLine("Güncelleme işlemi tamamlandı...");

                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void Sil()
        {
            Kisi kisi = new();
            string gelen;

            Console.WriteLine("Silmek istediğiniz ismi veya soyismi giriniz...");
            gelen = Console.ReadLine().ToLower();

            foreach (var item in rehber)
            {
                if (gelen == item.Ad || gelen == item.SoyAd)
                {
                    rehber.RemoveAt(rehber.IndexOf(item));
                    Console.WriteLine("Silme işlemi tamamlandı");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void Arama()
        {
            string i;
            string gelen;
            Console.WriteLine("İsim veya soyisme göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            i = Console.ReadLine();

            if (i == "1")
            {
                Console.WriteLine("İsim veya soyisim yazınız...");
                gelen = Console.ReadLine();
                
                foreach(var item in rehber)
                {
                    if (gelen == item.Ad || gelen == item.SoyAd)
                    {
                        Console.WriteLine("Aradığınız kişi : ");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("İSİM             : " + item.Ad);
                        Console.WriteLine("SOYİSİM          : " + item.SoyAd);
                        Console.WriteLine("TELEFON NUMARASI : " + item.TelNo);
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (i == "2")
            {
                Console.WriteLine("Telefon numarasını yazınız...");
                gelen = Console.ReadLine();

                foreach (var item in rehber)
                {
                    if (gelen == item.TelNo)
                    {
                        Console.WriteLine("Aradığınız kişi : ");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("İSİM             : " + item.Ad);
                        Console.WriteLine("SOYİSİM          : " + item.SoyAd);
                        Console.WriteLine("TELEFON NUMARASI : " + item.TelNo);
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Yapılan seçim geçersizdir...");
            }  
        }
        public void GetAll()
        {
            foreach (var item in rehber)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("İSİM             : " + item.Ad);
                Console.WriteLine("SOYİSİM          : " + item.SoyAd);
                Console.WriteLine("TELEFON NUMARASI : " + item.TelNo);
                Console.WriteLine("-------------------");
            }
        }
    }
}
