using TelefonRehberi;

Rehber rehber = new Rehber();
string secim = "a";

rehber.Baslagıc();

while (secim != "q")
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz...");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Yeni Numara Kaydetmek");
    Console.WriteLine("(2) Varolan Numarayı Silmek");
    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
    Console.WriteLine("(4) Rehberi Listelemek");
    Console.WriteLine("(5) Rehberde Arama Yapmak");
    secim = Console.ReadLine().ToLower();

    switch (secim)
    {
        case "1":
            rehber.Ekle();
            break;

        case "2":
            rehber.Sil();
            break;

        case "3":
            rehber.Guncelle();
            break;

        case "4":
            rehber.GetAll();
            break;

        case "5":
            rehber.Arama();
            break;

        case "q":
            secim = "q";
            break;

        case "Q":
            secim = "q";
            break;

        default:
            Console.WriteLine("Çıkış yapmak için q'ya basınız veya tekrar seçim yapınız...");
            secim = Console.ReadLine().ToLower();
            break;
    }
}



