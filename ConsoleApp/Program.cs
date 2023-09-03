using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region geçmiş
            #region
            #region 30.07.2023
            #region Değişken değerleri
            /*
            Console.WriteLine("YZL 3500");
            byte yakubunAyakkabiNumarasi = 46;
            string isim = "Yakup";
            Console.WriteLine(isim+"'un ayakkabı numarası "+yakubunAyakkabiNumarasi+"'dır.");
            Console.WriteLine("{0}'un ayakkabı numarası {1}'dır.",isim,yakubunAyakkabiNumarasi);
            Console.WriteLine($"{isim}'un ayakkabı numarası {yakubunAyakkabiNumarasi}'dır.");
            */

            //Yorum satırı haline getirmek :  ctrl + k + c
            //Yorum satırı kaldırmak       :  ctrl + k + u 

            //Tam Sayı Veri Tipleri
            //Console.WriteLine("TAM SAYI");
            //Console.WriteLine(     $"byte min : {byte.MinValue}"       );
            //Console.WriteLine(     $"byte max : {byte.MaxValue}"       );
            //Console.WriteLine(     $"sbyte min : {sbyte.MinValue}"     );
            //Console.WriteLine(     $"sbyte max : {sbyte.MaxValue}"     );
            //Console.WriteLine(     $"short min : {short.MinValue}"     );
            //Console.WriteLine(     $"short max : {short.MaxValue}"     );
            //Console.WriteLine(     $"ushort min : {ushort.MinValue}"   );
            //Console.WriteLine(     $"ushort max : {ushort.MaxValue}"   );
            //Console.WriteLine(     $"int min : {int.MinValue}"         );
            //Console.WriteLine(     $"int max : {int.MaxValue}"         );
            //Console.WriteLine(     $"uint min : {uint.MinValue}"       );
            //Console.WriteLine(     $"uint max : {uint.MaxValue}"       );
            //Console.WriteLine(     $"long min : {long.MinValue}"       );
            //Console.WriteLine(     $"long max : {long.MaxValue}"       );
            //Console.WriteLine(     $"ulong min : {ulong.MinValue}"     );
            //Console.WriteLine(     $"ulong max : {ulong.MaxValue}"     );
            //Console.WriteLine("ONDALIKLI SAYI");
            //Console.WriteLine(  $"float max : {float.MaxValue}       Funda   ");
            //Console.WriteLine(  $"float min : {float.MinValue}       Dicle   ");
            //Console.WriteLine(  $"double max : {double.MaxValue}     Volkan  ");
            //Console.WriteLine(  $"double min : {double.MinValue}     Samet   ");
            //Console.WriteLine(  $"decimal max : {decimal.MaxValue}     Emre  ");
            //Console.WriteLine(  $"decimal min : {decimal.MinValue}     Yakup ");

            //Console.Read();
            //Console.ReadLine();
            #endregion
            #region Örnek
            //string isim = "Emre";
            //string araba = "Dacia";
            //decimal fiyat = 550000;
            //int maxHiz = 265;
            //int yas = 26;
            //Console.WriteLine($"{isim} {yas} yaşında {araba} almış ve 1 saniyede {maxHiz}cm hıza ulaşıyormuş. Birde {fiyat}$ a kapatmış. Ben onun yalancısıyım. ");
            #endregion
            #region Örnek2
            //X şuanda y şehrinde yaşamaktadır. t çok hoşlanmaktadır. Her gün düzenli olarak c marka arabası ile gezmektedir. s filmini 5 kere izlemiştir.

            //string isim = "Furkan";
            //string sehir = "İstanbul";
            //string ten = "Araba Sürmekten";
            //string araba = "Seat";
            //string film = "Yüzüklerin Efendisi";
            //Console.WriteLine($"{isim} şuan da {sehir} şehrinde yaşamaktadır. {ten} çok hoşlanmaktadır. Hergün düzenli olarak {araba} marka arabası ile gezmektedir.{film}'ini 5 kere izlemiştir");

            //string isim = "Yakup";
            //string araba = "Renault";
            //string drift = "drift yapmak";
            //string film = "Hizli ve öfkeli";
            //string şehir = "İstanbul";
            //Console.WriteLine($"{isim} şuanda {şehir} da yaşamaktadır.{drift} yapmaktan çok hoşlanır.{araba} marka arabasıyla gezmektedir." +
            //    $"{film} 5 defa izlemiştir. ");

            //string isim = "Abuzer Kömürcü";
            //string sehir = "Tokyo";
            //string hobi = "Amerikan Futbolu";
            //string araba = "Camaro ss";
            //string film = "eternal sunshine of the spotless mind";
            //Console.WriteLine($" {isim} şu anda {sehir} de yaşamaktadır. {hobi} den çok hoşlanmaktadır. Her gün düzenli olarak {araba} arabasıyla gezmektedir.{film} filmini 5 kere izlemiştir. ");
            #endregion
            #region Kullanıcıdan değer almak
            //Kullanıcıdan facebook ve instagram adresini aldıktan sonra ekrana "Facebook adresi : " "İnstagram adresi : " şeklinde yazdırınız.
            //Console.WriteLine("Facebook adresini gir.");
            //string facebook = Console.ReadLine();
            //Console.WriteLine("İnstagram adresini gir.");
            //string instagram = Console.ReadLine();
            //Console.WriteLine($"Facebook adresi : {facebook}");
            //Console.WriteLine($"İnstagram adresi : {instagram}");
            #endregion
            #region Ornek
            //Kullanıcının email ve parolasını isteyiniz. Ekrana "Kullanıcının mail adresi x dir. Parolası y dir."
            //Console.WriteLine("Mail adresinizi giriniz :");
            //string mail = Console.ReadLine();
            //Console.WriteLine("Parolanızı giriniz :");
            //string parola = Console.ReadLine();
            //Console.WriteLine($"Kullanıcının mail adresi {mail}'dir.Parolası {parola}'dır.");
            #endregion
            #region Ornek
            //Kullanıcıdan alınan hobiyi ekrana yazdırınız.
            //Console.Write("Hobi giriniz : ");
            //string hobi = Console.ReadLine();
            //Console.WriteLine($"{hobi}");
            //Console.ReadLine() : Kullanıcı ekranında girilen değerleri okur ve getirir.
            //Console.WriteLine() : Kullanıcı ekranına istenilen ifadeyi yada bildiriyi yazdırmakla görevlidir. Yazdırdıktan sonra kullanıcı ekranında bir satır aşşağıya indirir.
            //Console.Write() : Kullanıcı ekranına istenilen ifadeyi yazdırır. Lakin Sonrasında gelen ifade alt satırda değil kendi bulunduğu satırda yazar.
            #endregion
            #region Sayısal tipte değer almak
            //int sayi = int.Parse("34");
            //int sayi2 = Convert.ToInt32("43");
            //Console.WriteLine(sayi+sayi2);

            //--------------------------------------
            //Console.Write("İlk sayi : ");
            //int sayi1 = int.Parse(  Console.ReadLine()  );
            //Console.Write("İkinci sayi : ");
            //int sayi2 = Convert.ToInt32( Console.ReadLine() );
            //int toplam = sayi2 + sayi1;
            //Console.WriteLine($"Girilen iki sayının toplamı : {toplam}");

            #endregion
            #region Ornek
            //Kullanıcının doğum tarihi yılını ve bulunduğu yılı isteyerek yaşını hesaplayınız ve ekrana yazdırınız.
            //Console.Write("Adınızı giriniz : ");
            //string adi = Console.ReadLine();
            //Console.Write("Doğum yılınız : ");
            //int dogumYili = int.Parse(Console.ReadLine());
            //Console.Write("Bulunduğunuz yıl : ");
            //int bulunulanYil = int.Parse(Console.ReadLine());
            //int yas = bulunulanYil - dogumYili;
            //Console.WriteLine($"{adi} {yas} yaşındadır.");

            #endregion
            #region 30.07.23

            //Kullanıcıdan alınan sayının karesini alan uygulamayı yazınız.
            //Console.Write("Bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //int karesi = sayi * sayi;
            //Console.WriteLine($"{sayi} * {sayi} : {karesi}");
            #endregion
            #region Operatorler
            //int sayi = 10;
            //int sayi2 = 3;
            //int kalan = sayi % sayi2;
            //Console.WriteLine(kalan);
            //int s = 0;
            //Console.WriteLine(s++);
            //Console.WriteLine(++s);
            //int s2 = ++s;
            //Console.WriteLine(s2);
            //Console.WriteLine(s);
            //int s3 = s--;
            //Console.WriteLine(s3);
            //Console.WriteLine(s);
            //++s;
            //Console.WriteLine(s);
            //int v = 21;
            ////v += 5;
            ////Console.WriteLine(v);
            //v = v * 2;
            //v *= 2;
            //bool isTrue = true;
            //Console.WriteLine(isTrue);
            //isTrue = 5 == 2;
            //Console.WriteLine(isTrue);
            //isTrue = 2 < 3;
            //Console.WriteLine(isTrue);
            //isTrue = 5 <= 5 && 2 < 5;
            //Console.WriteLine(isTrue);
            //isTrue = 5 <= 5 && 2 > 5;
            //Console.WriteLine(isTrue);
            //isTrue = 55 < 55 || 55 == 55;
            //Console.WriteLine(isTrue);
            //isTrue = 5 < 2 || "a" == "b";
            //Console.WriteLine(isTrue);
            #endregion
            #region CAST işlemi
            //int sayi = 458;
            //byte yeniSayiTipi = (byte)sayi;
            //Console.WriteLine(yeniSayiTipi);
            //int sayi = 5;
            //string metinselIfade = sayi.ToString();
            //Console.WriteLine(metinselIfade);
            #endregion
            #region Ornek (Dicle)
            // Kullanıcıdan alınan sayısal değeri bir arttırıp, 5 ile çarparak, 3 e göre modunu alıp, cast işlemi farklı bir sayısal tipe dönüştürerek ekrana yazdırınız. ilk gelen değer son durumdan dahamı büyüktü şeklinde karşılaştırmanın sonucunu bool bir değişkene atarak sonucu ekrana yazdırın. Daha sonrasında metinsel bir ifade olarak saklayarak ekrana yazdırınız.
            //Console.Write("Bir sayi giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = ++sayi;
            //sonuc *= 5;
            //sonuc %= 3;
            //byte yeniSayiTipi = (byte)sonuc;
            //bool isTrue = sayi > sonuc;
            //Console.WriteLine(isTrue);
            //string metinselIfade = sonuc.ToString();
            //Console.WriteLine(metinselIfade);
            #endregion
            #region Try Catch (Hata Yönetimi)
            //Kullanıcıdan vize ve final notlarını alarak sonuçlarını ekrana yazdıran uygulamayı yazınız. (Vizenin %40 ı finalin %60 sini alınız)
            //try
            //{
            //    Console.Write("Vize Notu : ");
            //    double vize = double.Parse(Console.ReadLine());
            //    Console.Write("Final Notu : ");
            //    double final = double.Parse(Console.ReadLine());
            //    double sonuc = (vize * 0.4) + (final * 0.6);
            //    Console.WriteLine($"Notunuz : {sonuc}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Ornek
            //Kullanıcıdan alınan iki sayının birbirine bölümünden kalanını ekrana yazdırınız. Eğer bir hata oluşursa önce hata mesajını daha sonra kendi mesajınızı yazdırınız ve ekrana sonucu 0 döndürünüz.
            //try
            //{
            //    Console.Write("İlk sayi : ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("İkinci sayi : ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    int kalan = sayi % sayi2;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}\nBir hata ile karşılaşıldı sonuc : 0");
            //}

            #endregion
            #region Ornek

            //Kullanıcıdan bilgisayar adını,marka,model,fiyat bilgilerini alsın daha sonrasında fiyatı 2 kat fazla olarak ekrana yazdırsın.
            //try
            //{
            //    Console.Write("Bilgisayar Adi : ");
            //    string pcAdi = Console.ReadLine();
            //    Console.Write("Marka : ");
            //    string marka = Console.ReadLine();
            //    Console.Write("Model : ");
            //    string model = Console.ReadLine();
            //    Console.Write("Fiyat : ");
            //    int fiyat = int.Parse(Console.ReadLine());
            //    Console.WriteLine("_______________________________________________________");
            //    Console.WriteLine($"Bilgisayar Adi : {pcAdi}\nMarka : {marka}\nModel : {model}\nFiyat : {fiyat} TL");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region
            // Kullanıcıdan Adını soyadını yaşını facebook instangram adreslerini telefon numarası, mail adresi ve parolasını isteyiniz. Ekranda tek bir satır kod ile alt alta yazdırınız.
            //try
            //{
            //    Console.Write("Adınızı giriniz : ");
            //    string ad = Console.ReadLine();
            //    Console.Write("Soy Adınızı giriniz : ");
            //    string soyad = Console.ReadLine();
            //    Console.Write("Yaşınızı Giriniz : ");
            //    int yas = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("İnstagram Adresini Giriniz : ");
            //    string instagram = Console.ReadLine();
            //    Console.Write("Facebook Adresini Giriniz : ");
            //    string facebook = Console.ReadLine();
            //    Console.Write("Telefon numarasını giriniz : ");
            //    string tel = Console.ReadLine();
            //    Console.Write("Mail Adresini Giriniz : ");
            //    string mail = Console.ReadLine();
            //    Console.Write("Parolanızı Giriniz : ");
            //    string pwd = Console.ReadLine();
            //    Console.WriteLine($"Adı : {ad}\nSoyad : {soyad}\nYaş : {yas}\nİnstagram : {instagram}\nFacebook : {facebook}\n Tel : {tel}\nMail : {mail}\nParola : {pwd}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #endregion
            #region Hobi Orneği
            // Kullanıcıdan hobisini, telefon numarasını ve yaşını alalım. Alınan bu bilgileri ekrana yazdıralım.
            //try
            //{
            //    Console.Write("Hobiniz : ");
            //    string hobi = Console.ReadLine();
            //    Console.Write("Telefon : ");
            //    string tel = Console.ReadLine();
            //    Console.Write("Yaş : ");
            //    int yas = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Hobi : {hobi}\nTelefon : {tel}\nYaş : {yas}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Gormuyor musun sayı istiyorum senden!");
            //}
            #endregion
            #region Yas Örneği
            //Kullanıcıdan isim soyisim ve yaş alınız. Yaşı 18 den küçük olanların yanına reşit değil, büyük olanların yanına reşit yazan uygulamayı oluşturunuz.
            //Console.Write("İsim : ");
            //string isim = Console.ReadLine();
            //Console.Write("Soyisim : ");
            //string soyisim = Console.ReadLine();
            //Console.Write("Yaş : ");
            //int yas = int.Parse(Console.ReadLine());
            //if (yas > 18)
            //{
            //    Console.WriteLine("Buyuk");
            //}
            //else if (yas == 18)
            //{
            //    Console.WriteLine("Orta");
            //}
            //else
            //{
            //    Console.WriteLine("Kucuk");
            //}
            #endregion
            #region Ucuz Pahalı
            //Kullanıcıdan ürün adını markasını modelini fiyatını isteyiniz. Fiyatı 50nin üzerinde olanlara pahalı, altında olanlara ucuz ve eşit olanlara ise ideal yazdırınız. 
            //Console.Write("Urun Adi : "  );
            //string urun = Console.ReadLine();
            //Console.Write("Marka : "  );
            //string marka = Console.ReadLine();
            //Console.Write("Model : "  );
            //string  model = Console.ReadLine();
            //Console.Write("Fiyat : " );
            //double fiyat = double.Parse(Console.ReadLine());
            //if (fiyat >= 50)
            //{
            //    Console.WriteLine("Aboo çok pahalı");
            //}
            //else if(fiyat == 50)
            //{
            //    Console.WriteLine("İdeal");
            //}
            //else
            //{
            //    Console.WriteLine("Ucuz etin yahnisi güzel olur.");
            //}
            #endregion
            #region Şirket bilgileri
            //Şirketin adını adresini personel sayısını isteyiniz. Personel sayısı 50 nin altında olanlara küçük işletme, üzerinde olanlara büyük işletme ve eşit olanlara orta işletme yazan uygulamayı oluşturunuz.
            //try
            //{
            //    Console.Write("Şirket Adı : ");
            //    string sirketAdi = Console.ReadLine();
            //    Console.Write("Adres : ");
            //    string adres = Console.ReadLine();
            //    Console.Write("Personel Sayısı : ");
            //    int personelSayisi = int.Parse(Console.ReadLine());
            //    if (personelSayisi > 50)
            //    {
            //        Console.WriteLine("Büyük işletme");
            //    }
            //    else if (personelSayisi == 50)
            //    {
            //        Console.WriteLine("Orta büyüklukte ısletme");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kucuk işletme");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            #endregion
            #region Not ortalaması
            //Öğrencinin girdiği vize ve final notlarını alınız geçip geçmediğine karar veriniz. Geçme notu 50 dir. Vizenin %30 unu finalin %60 ını ve projenin %10 unu hesaba katınız.
            //try
            //{
            //    Console.Write("Vize Notunuz : ");
            //    double vize = double.Parse(Console.ReadLine());
            //    Console.Write("Final Notunuz : ");
            //    double final = double.Parse(Console.ReadLine());
            //    Console.Write("Proje notu : ");
            //    double proje = double.Parse(Console.ReadLine());
            //    double sonuc = vize * 0.3 + final * 0.6 + proje * 0.1;
            //    if (sonuc < 50)
            //    {
            //        Console.WriteLine("Kaldı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçti");
            //    }

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yanlış giriş yaptınız.");
            //}
            #endregion
            #region Kullanıcı giriş bilgisi doğrulama
            //Kullanıcıdan kullanıcı adı ve parola isteyiniz. Kullanıcı adı admin ve parolası 123 gelirse giriş başarılıdır yazsın. Eğer değilse Kullanıcı adı veya parola hatalıdır yazsın.
            //Console.Write("Kullanıcı adı : "  );
            //string userName = Console.ReadLine();
            //Console.Write("Parola : "  );
            //string password = Console.ReadLine();
            //if (userName == "admin" && password == "123")
            //{
            //    Console.WriteLine("Giriş başarılıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya parola hatalıdır.");
            //}
            #endregion
            #region Aralik belirleme
            //Kullanıcıdan 0-100 arasında sayısal bir değer alalım. 0-20 aralığında yirmi dahil olacak şekilde olsun ve ekrana Sıfır 20 aralığındadır. 21 ile 60 aralığında ise değer 21-60 aralığındadır yazsın. 61 100 aralığında ise değer 61-100 aralığındadır yazsın. Hiçbiri değilse girilen sayı 0-100 aralığında değildir yazsın.  
            //Console.WriteLine( "[0,100] aralığında bir değer giriniz." );
            //int sayi = int.Parse( Console.ReadLine() );
            //if (sayi < 0 || sayi > 100)
            //{
            //    Console.WriteLine("Girilen değer hatalı.");
            //}
            //else
            //{
            //    if (sayi >= 0 && sayi <= 20)
            //    {
            //        Console.WriteLine("Girilen değer [0,20] aralığındadır.");
            //    }
            //    else if ( 20 < sayi && 60 >= sayi)
            //    {
            //        Console.WriteLine( "Girilen değer (20,60] aralığındadır." );
            //    }
            //    else if (60 < sayi)
            //    {
            //        Console.WriteLine("Girilen değer (60,100] aralığındadır.");
            //    }
            //}
            //Bir yol daha
            //Console.Write("Sayı : ");
            //double sayi = double.Parse(Console.ReadLine());
            //if (sayi >= 61 && sayi <= 100)
            //{
            //    Console.WriteLine("61-100 aralığındadır");
            //}
            //else if (sayi >= 21 && sayi <= 60)
            //{
            //    Console.WriteLine("21-60 aralığındadır.");
            //}
            //else if (sayi >= 0 && sayi <= 20)
            //{
            //    Console.WriteLine("0-20 aralığındadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0-100 aralığında değildir.");
            //}
            #endregion
            #region Ternary If 
            ////Kullanicidan iki sayı alalım. Toplamları 20 den büyükse ekrana 20den büyüktür yazıralım küçükse küçüktür yazdıralım.
            //Console.Write("İlk sayi : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayi : ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //string durum = sayi1 + sayi2 > 20 ? "iki sayinin toplamı 20den buyuktur." : "iki sayinin toplamı 20 ye eşit veya küçüktür.";
            ////if (sayi1 + sayi2 > 20)
            ////{
            ////    durum = "iki sayinin toplamı 20den buyuktur.";
            ////}
            ////else
            ////{
            ////    durum = "iki sayinin toplamı 20 ye eşit veya küçüktür.";
            ////}
            //Console.WriteLine(durum);

            #endregion
            #region Ornek
            //Kullanıcıdan bir isim alalım ve girilen isim hakan'sa ekrana direk ismi yazdırsın değilse ekrana şahin yazdırsın.
            //Console.Write(  "İsim : ");
            //string isim = Console.ReadLine();
            //string durum = isim == "Hakan" ? isim : "Şahin";
            //Console.WriteLine( durum );
            #endregion
            #region Ornek2
            // Kullanıcıya reşit olup olmadığını soralım. Gönderdiği boolean değere göre ehliyet alıp alamayacağını yazdıralım.
            //try
            //{
            //    Console.Write("18 yaşından büyük müsün ?  : ");
            //    bool isTrue = bool.Parse(Console.ReadLine());
            //    string mesaj = isTrue ? "Ehliyet alabilir" : "Ehliyet alamaz";
            //    Console.WriteLine(mesaj);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("True evet demektir. False hayır demektir. Buna göre cevaplarsan iyi olur!");
            //}

            #endregion
            #region  Bozacının şahidi şıracıdır 
            // Kullanıcıya ehliyet alıp alamadığını sorun ve yaşını isteyin. Verdiği cevap ile yaşının 18den büyük olup olmadığını kontrol ederek yalan söyleyip söylemediğini ekrana yazdırın.
            //Yol 1
            //try
            //{
            //    Console.Write("Ehliyet aldınız mı? : ");
            //    bool isTrue = bool.Parse(Console.ReadLine());
            //    Console.Write("Yaşınızı giriniz : ");
            //    double yas = double.Parse(Console.ReadLine());
            //    string durum = isTrue && yas <= 18 ? "yalancı seni çakkal" : "tamam inandım hadi hadi";
            //    Console.WriteLine(durum);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("adam gibi bilgi gir canımı sıkma!");
            //}
            //Yol 2
            //Console.WriteLine("Ehliyetin var mı:");
            //bool isTrue = bool.Parse(Console.ReadLine());
            //Console.WriteLine("Yaşınız: ");
            //int yas = int.Parse(Console.ReadLine());
            //string mesaj2 = isTrue == yas >= 18 ? "Ehliyeti var " : "Ehliyeti yok";
            //Console.WriteLine(mesaj2);
            #endregion
            #region Turkiyenin Başkenti
            // Kullanıcıya Türkiyenin başkentini sorun. Verdiği cevaba göre aferin yeda keyfinizce bir mesaj verin. 
            //Yol 1
            //try
            //{
            //    Console.WriteLine("Türkiyenin başkenti neresidir ?");
            //    string cevap = Console.ReadLine();
            //    cevap = cevap == "ankara" ? "aferin" : "yazıklar olsun";
            //    Console.WriteLine(cevap);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Yol 2
            //Console.WriteLine("Türkiyenin başkenti neresidir?");
            //string cevap = Console.ReadLine() == "Ankara" ? "Aferin" : "Tekrar dene. ";
            //Console.WriteLine(cevap);
            //Yol 3
            //try
            //{
            //    Console.Write("Türkiye'nin başkenti : ");
            //    string sehir = Console.ReadLine();
            //    string durum = "Ankara";
            //    string sonuc = durum == sehir ? "Helal len kerata" : "Cahil git burdan";
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region
            //Kullanıcıya 5 adet soru sorunuz. Bu sorular doğru yanlış tipinde olan sorular olsun. 3 adetten fazla doğru bilirse testi başarıyla geçtiniz yazsın. 3 ün altında kalırsa Biz size döneriz yazsın.
            //try
            //{
            //    int sayi = 0;
            //    Console.Write("Alkol kullanıyor musunuz? : ");
            //    bool isTrue = bool.Parse(Console.ReadLine());
            //    sayi = isTrue ? sayi + 0 : sayi + 1;
            //    Console.Write("Sigara kullanıyor musunuz? : ");
            //    isTrue = bool.Parse(Console.ReadLine());
            //    sayi = isTrue ? sayi + 0 : sayi + 1;
            //    Console.Write("Ehliyetiniz var mı? : ");
            //    isTrue = bool.Parse(Console.ReadLine());
            //    sayi = isTrue ? sayi + 1 : sayi + 0;
            //    Console.Write("Türkiye'nin başkenti Ankara'dır? :");
            //    isTrue = bool.Parse(Console.ReadLine());
            //    sayi = isTrue ? sayi + 1 : sayi + 0;
            //    Console.Write("25 yaşından büyük müsün? : ");
            //    isTrue = bool.Parse(Console.ReadLine());
            //    sayi = isTrue ? sayi + 1 : sayi + 0;
            //    Console.WriteLine($"Doğru cevap sayınız : {sayi} ");
            //    string durum = sayi >= 3 ? "Mülakattan geçtiniz." : "Mülakattan kaldınız ama yine sizi ararız biz.";
            //    Console.WriteLine(durum);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("True 'Evet' demek.False 'Hayır' demektir.Cevaplarınızı buna göre veriniz.");
            //}

            #endregion
            #endregion
            #region 060823
            #region mevsimler  
            //Console.Write("Bulunduğunuz ayı giriniz : ");
            //string ay = Console.ReadLine();
            //if (ay == "aralik" || ay == "ocak" || ay == "subat")
            //{
            //    Console.WriteLine("Kış mevsimindesiniz.");
            //}
            //else if (ay == "mart" || ay == "nisan" || ay == "mayis")
            //{
            //    Console.WriteLine("İlkbahar mevsimindesiniz.");
            //}
            //else if (ay == "haziran" || ay == "temmuz" || ay == "agustos")
            //{
            //    Console.WriteLine("Yaz mevsimindesiniz.");
            //}
            //else if (ay == "eylul" || ay == "ekim" || ay == "kasim")
            //{
            //    Console.WriteLine("Sonbahar mevsimindesiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir ay yoktur.");
            //}
            #endregion
            #region Mevsimler Case
            //Console.Write("Bir ay gir : ");
            //string ay = Console.ReadLine().ToLower();
            //switch (ay)
            //{
            //    case "aralik":
            //    case "ocak":
            //    case "subat": Console.WriteLine("Kış mevsimi."); break;
            //    case "mart":
            //    case "nisan":
            //    case "mayis": Console.WriteLine("İlkbahar mevsimi."); break;
            //    case "haziran":
            //    case "temmuz":
            //    case "agustos": Console.WriteLine("Yaz mevsimi"); break;
            //    case "eylul":
            //    case "ekim":
            //    case "kasim": Console.WriteLine("Sonbahar mevsimi"); break;
            //    default:
            //        Console.WriteLine("Girdiğiniz ay hatalıdır.");
            //        break;
            //}
            #endregion
            #region Hesap Makinesi
            //Kullanıcıdan 2 sayı ve bir operatör(*,/,+,-) alınız. Oparatöre göre ilgili işlemin sonucunu ekrana yazdırınız.
            //Console.WriteLine("birinci sayıyı giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Operatörü seçin:");
            //string operatör = Console.ReadLine();
            //switch (operatör)
            //{
            //    case "+":
            //        Console.WriteLine(sayi1 + sayi2);
            //        break;
            //    case "-":
            //        Console.WriteLine(sayi1 - sayi2);
            //        break;
            //    case "/":
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;
            //    case "*":
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;
            //}

            #endregion
            #region Kelime Bulmaca
            //Kullanıcıdan bir kelime isteyin ve kelimeleri siz belirleyin ilk kelimeyi bilirse iyisin, ikinci kelimeyi bilirse idare edersin üçüncü kelimeyi bilirse eh işte bildin ama nasıl bildin yazsın. Bilemezse Bilemedin yazsın.
            //Console.WriteLine("Kelime giriniz : ");
            //string kelime = Console.ReadLine();
            //switch (kelime)
            //{
            //    case "çakal": Console.WriteLine("İyisin"); break;
            //    case "sefo": Console.WriteLine("İdare edersin"); break;
            //    case "yildiz": Console.WriteLine("bildin he"); break;
            //    default:
            //        Console.WriteLine("bu cahillik beni öldürdü.");
            //        break;
            //}


            #endregion
            #region Girilen meyvenin şeker durumu
            //Kullanıcıdan alınan meyve şekerlimi şekersizmi kontrolü yapınız. Meyve olup olmadığınıda kontrol etmeyi unutmayınız.
            //Console.Write("Meyve giriniz :");
            //string meyve = Console.ReadLine().ToLower();
            //switch (meyve)
            //{
            //    case "karpuz":
            //    case "kavun":
            //    case "elma":
            //    case "armut": Console.WriteLine("Şekerli bir meyvedir."); break;
            //    case "limon":
            //    case "Domates": Console.WriteLine("Şekersiz bir meyvedir."); break;
            //    default:
            //        Console.WriteLine("Yani meyvemi şimdi bu yaptığın ayıptır sen benimle dalgamı geçiyorsun erik diye meyvemi olur!");
            //        break;
            //}


            #endregion
            #region DÖNGÜLER
            // Ekrana 0 dan 10a kadar yazdıralım.
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            // Ekrana 0 100 arasındaki çift sayıları yazdırınız.
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            // Ekrana 10 defa isminizi yazdırınız.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hakan");
            //}
            //360 dan geriye 10ar 10ar ekrana yazdırınız.
            //for (int i = 360; i >= 0; i-=10)
            //{
            //    Console.WriteLine( i);
            //}
            #endregion
            #region İsim yazdırma dinamik
            //Kullanıcıdan ad ve adet alınız. Verilen adet kadar adını yazdırınız.
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Adet:");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine($"{ad}");
            //}
            #endregion
            #region  6 da mesaj var
            // 0 - 10 arasında ekrana yazdırın ama sayı 6 olduğunda ekrana 6 dayım yazsın.
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i != 6)
            //        Console.WriteLine(i);
            //    else Console.WriteLine("6 dayım :D");
            //}
            #endregion
            #region Kullanıcıdan alınan 
            // Kullanıcıdan başlangıç ve bitiş değerleri isteyin o aralıktaki sayıları yazdırın.
            //Console.Write("Baslangıc : ");
            //int baslangic = int.Parse(Console.ReadLine());
            //Console.Write("Bitis : ");
            //int bitis = int.Parse(Console.ReadLine());
            //Console.Write("Artış Miktarı : ");
            //int artisMikatari = int.Parse(Console.ReadLine());
            //for (int i = baslangic; i <= bitis; i+=artisMikatari)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region çift-tek sayılar
            //Kullanıcıdan başlangıç ve bitiş değerlerini alalım. Belirtilen aralıktaki çift ve tek sayıları yazdıralım. Tek sayılarda mavi renk yazsın, çift sayıları kırmızı yazsın.
            //Console.Write("Başlangıç : ");
            //int baslangic = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş : ");
            //int bitis = int.Parse(Console.ReadLine());
            //for (int i = baslangic; i < bitis; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(i +"çifttir.");
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine(i+ "tektir.");
            //    }
            //}
            #endregion
            #region break ve continue
            // break : Bu ifade döngüyü sonlandırmak amacı ile kullanılır. Eğer döngü belli bir şartta sonlandırılmak isteniyorsa bu anahtar kelime kullanılır.
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 3)
            //    { 
            //        break;
            //    }
            //}
            // continue : Bu ifade döngüyü başa sarmak amacıyla kullanılır. Belirli şarttaki alanı farklı şekilde çalıştırıp yada atlattırmak amacı ile kullanılır.
            //for (int i = 0; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Sayı tahmini
            //Bir sayı belirleyelim(0-10] ve kullanıcıya 5 kez soralım. Eğer erkenden bilirse bildiniz yazsın ve sorma işlemi bitsin. Bilemediği süre zarfında sormaya devam edelim.
            //int benimSayim = 3;
            //int kullaniciSayisi = -1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (benimSayim != kullaniciSayisi)
            //    {
            //        Console.Write("Tahminin : ");
            //        kullaniciSayisi = int.Parse(Console.ReadLine());
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tebrikler. {i}. seferde bildin :)");
            //        break;
            //    }
            //}
            #endregion
            #region Marka model
            // Kullanıcıdan 3 adet araç markası alalım. Ardından ilgili markalara ait 3 araç isteyelim. Daha sonra ekranı temizleyim araçları markalarının altında yazdıralım.
            //string ifade = "";
            //for (int j = 1;true;j++ )
            //{
            //    Console.Write("Marka : ");
            //    ifade += "\n" + Console.ReadLine();
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"{i+1}. Model : ");
            //        ifade += "\n"+Console.ReadLine();
            //    }
            //    if (j == 3) break;
            //}
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(ifade);
            #endregion
            #region Carpim Tablosu
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i*j}");
            //    }
            //}
            #endregion
            #region Dik üçgen
            //string ifade = "*";
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ifade);
            //    ifade += "*";
            //}
            #endregion
            #endregion
            #endregion
            #region 12.08.23
            #region While
            #region Ornek1
            //int sayac = 0;
            //while (true)
            //{
            //    sayac += 1;
            //    Console.WriteLine(sayac);
            //    if (sayac == 5)
            //    {
            //        break;
            //    }            
            //}
            //Console.WriteLine("Şahin");
            #endregion
            #region Ornek 2
            //Kullanıcıya 4 kez adını sorup 3 kez ekrana yazalım. Bunu while döngüsü ile yapınız.
            //int sayac = 1;
            //string name = null;
            //string tut = null;
            //while (sayac < 5) 
            //{
            //    Console.Write($"{sayac}. Ad : ");
            //    tut = "\n" + Console.ReadLine();
            //    if (sayac != 4)
            //    {
            //        name += tut;
            //    }
            //    sayac++;
            //}
            //Console.WriteLine(name);
            #endregion

            #endregion
            #region Do While
            #region Ornek1
            //int sayac = 1;
            //do
            //{
            //    if (sayac != 11)
            //        Console.WriteLine("Hakan");
            //    else
            //        break;
            //    sayac++;
            //} while (true);

            //while (true)
            //    Console.WriteLine("Hakan");
            #endregion
            #region Ornek2

            // Ekrana hoşgeldiniz mesajını en az 1 defa yazdırınız. Eğer kullanıcı devam et şeklinde bir ifade girerse 9 defa daha yazdırınız.
            //int sayac = 0;
            //string cevap = "";
            //do
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //    if (sayac == 0)
            //    {
            //        Console.WriteLine("Devam edilsinmi ? : ");
            //        cevap = Console.ReadLine().ToLower();
            //    }
            //    sayac++;
            //    if (cevap != "devam et" || sayac == 10) break;
            //} while (true);

            #endregion
            #region Foreach
            #region Ornek1
            //foreach (char item in "hakan") 
            //{
            //    Console.WriteLine( item );
            //}
            #endregion
            #region Ornek 2
            // Kullanıcıdan gelen metnin karakterlerini tek tek büyük harfe çevirerek yazdırınız.
            //Console.WriteLine("İsim yazın");
            //string name = Console.ReadLine().ToUpper();
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ornek 3
            // Kullanıcıdan alınan adı bir büyük bir küçük olacak şekilde ekrana yazdırınız.
            //Console.WriteLine("İsim yazın");
            //bool isTrue = true;
            //string name = Console.ReadLine();
            //string karakter = "";
            //foreach (var item in name)
            //{
            //    karakter = item.ToString();
            //    if (isTrue)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write(karakter.ToUpper());
            //        isTrue = false;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write(karakter.ToLower());
            //        isTrue = true;
            //    }
            //}
            #endregion
            #region Diziler
            #region Ornek 1
            //string[] isimler = { "Oktay", "Muhammet", "Yakup","Volkan","Samet","Emre","Halil","Furkan","Ece","Funda"};
            //int isimlerUzunlugu = isimler.Length-1;
            //string isim = isimler[isimlerUzunlugu];
            //Console.WriteLine(isim);
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(     isimler[i]     );
            //}
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Ornek 2
            // Bir tam sayı dizisi oluşturun. Ekrana dizi elemanlarının orjinal halini ve sağ tarafında 10 arttırılmış hallerini yazdırın.
            //int[] tamSayilar = { 1, 2, 3,4,5,6,7,8,9};
            //foreach (var item in tamSayilar)
            //{
            //    Console.WriteLine($"{item} => {item+10}");
            //}
            #endregion
            #region Ornek 3 
            // Araç markalarının barındığı bir dizi oluşturunuz. Kullanıcı önüne getirdiğiniz her aracın markasının yanına modelini yazmasını isteyelim. En sonda markalar bitti şeklinde mesaj versin :D
            //string[] markalar = {"Mercedes","Dacia","Renault","Nissan","Bmw","Honda","Toyota"};
            //Console.WriteLine("Lütfen gelen markalar karşısına model giriniz.");
            //foreach (string item in markalar) 
            //{
            //    Console.Write($"{item} : ");
            //    Console.ReadLine();
            //}
            //Console.WriteLine("Markalar tükendi :D");

            #endregion
            #region Ornek 4
            // Ürünler ve fiyatlar olarak 2 farklı aynı uzunlukta diziler olsun. Ürünü her yazdığında karşısına diğer dizideki fiyat çıksın. Bununda karşısına zamlı hali çıksın. Zamlı hali denilen olay kullanıcının verdiği fiyat kadar artmış hali olsun.
            //string[] urunler = { "Ekmek", "Su", "Ayran", "İskender", "Zurna Dürüm" };
            //int[] fiyatlar = { 8, 5, 40, 99, 45 };
            //Console.Write("Zam oranı giriniz : ");
            //int zam = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //foreach (var item in urunler)
            //{
            //    Console.Write($"Ürün : {item}\nFiyatlar : {fiyatlar[sayac]} TL\nZamlı hali : {fiyatlar[sayac] + zam} TL\n");
            //    sayac++;
            //}
            //Console.WriteLine("Canım ülkem");
            #endregion
            #region Ornek 5
            // İki farklı tam sayı dizisi oluşturun. Aynı indexe denk gelen elemanları birbirleriyle çarparak ekrana yazdırın.
            //int[] sayilar1 = { 8, 5, 4,2,18,42,15,4,21,2,2};
            //int[] sayilar2 = { 8, 5, 4, 123, 232, 313, 13123, 123, 123, 123, 128 };
            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    Console.WriteLine($"{sayilar1[i] * sayilar2[i]}");
            //}
            #endregion
            #region Ornek 6
            //int[] tamSayilar = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    tamSayilar[i] = i + 1;
            //}
            //foreach (int item in tamSayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ornek 7
            // Kullanıcıdan 5 adet sayı alınız. Bu sayıları elinizdeki diziye yerleştiriniz. Daha sonrasında dizinin son eklenen elemanını ekrana yazdırınız.
            //int[] sayilar = new int[5];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write((i + 1) + ".Sayıyı Giriniz : ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Son sayı : " + sayilar[sayilar.Length-1]);
            #endregion
            #region Ornek 8
            // Kullanıcıdan 2 adet sayı alınız bu sayıları diziye ekleyiniz ve kullanıcıya ilk sayımı daha büyük yoksa ikinci girdiğin sayımı daha büyük şeklinde sorunuz. Kullanıcı yanlış cevap verirse yalancı şeklinde bir mesaj yazdırınız.
            //Muhammet
            //int[] sayiDizim = new int[2];
            //for (int i = 0; i < sayiDizim.Length; i++)
            //{
            //    Console.Write($"{i} sayi : ");
            //    sayiDizim[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Hangi sayi daha büyük ? [0-1] : ");
            //int cevap = int.Parse(Console.ReadLine());
            //if (sayiDizim[0] < sayiDizim[cevap] || sayiDizim[cevap] > sayiDizim[1]) Console.WriteLine("Doğru söyledin");
            //else Console.WriteLine("Yalanci");
            //Ece
            //int[] sayilar = new int[2];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write($"{i + 1}. sayıyı giriniz: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Girdiğiniz sayılardan hangisi büyük? 1 mi 2 mi?");
            //int cevapm = int.Parse(Console.ReadLine());
            //if (cevapm == 1)
            //{
            //    if (sayilar[0] > sayilar[1])
            //    {
            //        Console.Write("Aferin doru.");
            //    }
            //    else
            //    {
            //        Console.Write("Yalancı!");
            //    }
            //}
            //else
            //{
            //    if (sayilar[1] > sayilar[0])
            //    {
            //        Console.Write("Aferin doru.");
            //    }
            //    else
            //    {
            //        Console.Write("Yalancı!");
            //    }
            //}

            #endregion
            #region Ornek 9
            //Kullanıcıdan sürekli sayı alalım ve her seferinde tamammı devammı şeklinde soralım ve cevapları true veya false olarak gelsin. Kullanıcının girdiği her sayıyı oluşturduğumuz diziye ekleyelim. Tamam der demez dizi uzunluğunu ekrana yazdıralım.
            //int[] sayilar = new int[0];
            //int sayi = 0;
            //for (int i = 0; true; i++)
            //{
            //    Console.Write($"{i}. sayi : ");
            //    sayi = int.Parse(Console.ReadLine());

            //    Array.Resize(ref sayilar, sayilar.Length + 1);
            //    sayilar[sayilar.Length - 1] = sayi;

            //    Console.Write("Tamammi Devammi?[True/False]");
            //    bool tamamMi = bool.Parse(Console.ReadLine());
            //    if (!tamamMi) break;
            //}
            //Console.WriteLine($"Dizinin eleman sayisi : {sayilar.Length}");
            #endregion
            #region Ornek 10
            // 10 elemanlı bir dizi oluşturalım içerine gelecek her değer rastgele bilgisayar tarafından verilsin.
            //Random rnd = new Random();
            //int[] rastgeleSayilar = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    rastgeleSayilar[i] = rnd.Next(100,105);
            //}
            //foreach (var item in rastgeleSayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ornek 11
            //Bir tam sayi dizisi oluşturalim bu dizinin ilk elemanı ve son elemanı bilgisayarın verdiği random sayi olsun. İçerisinde kalan kısmı ise kullanıcıdan alalım. Kullanıcı true veya false cevap versin. False derse ekleme işlemleri tamamlansın. Diziye hangi sayılar eklendi ise ekrana yana yana boşluklarla yazılsın.
            //Random random = new Random();
            //int[] sayilar = new int[1];
            //sayilar[sayilar.Length - 1] = random.Next(50, 100);
            //int sayi;
            //for (int i = 0; true; i++)
            //{
            //    Console.Write("Sayi : ");
            //    sayi = int.Parse(Console.ReadLine());

            //    Array.Resize(ref sayilar, sayilar.Length + 1);
            //    sayilar[sayilar.Length - 1] = sayi;

            //    Console.Write("Tamammı? [True/False] : ");
            //    bool tamamMi = bool.Parse(Console.ReadLine());
            //    if (tamamMi)
            //    {
            //        Array.Resize(ref sayilar, sayilar.Length + 1);
            //        sayilar[sayilar.Length - 1] = random.Next(50, 100);
            //        break;
            //    }
            //}
            //foreach (var item in sayilar)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Ornek 12
            // Kullanıcıdan 3 adet menü alsın ve her menü için 5 tane yemek girsin ve en son ekran temizlenerek her menü altında yemekler görünsün. 
            //string[] menuler = new string[3];
            //string[] yemekler = new string[15];
            //int iterasyon = 0;
            //for (int i = 0; i < menuler.Length; i++)
            //{
            //    Console.Write("Menu : ");
            //    menuler[i] = Console.ReadLine();
            //    for (int j = iterasyon; j < iterasyon+5; j++)
            //    {
            //        Console.Write("Yemek : ");
            //        yemekler[j] = Console.ReadLine(); 
            //    }
            //    iterasyon += 5;
            //}
            //Console.Clear();
            //iterasyon = 0;
            //foreach (string menu in menuler)
            //{
            //    Console.WriteLine("****"+menu);
            //    for (int i = iterasyon; i < iterasyon + 5; i++)
            //    {
            //        Console.WriteLine(yemekler[i]);
            //    }
            //    iterasyon += 5;
            //}


            #endregion
            #region Ornek 13 
            // Bir dizi oluşturun default sayilar girin. Bu diziyi tersten yazdırın.
            //int[] dizim = { 1, 2, 8, 5, 2154, 12, 13 };
            //Array.Sort(dizim);
            //Array.Reverse(dizim);
            //foreach (var item in dizim)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region STRING METOTLAR

            // Trim() : Sağdan ve soldan boşlukları siler
            //string fullName = "   Hakan Şahin     ".Trim();

            //foreach (var item in fullName)
            //{
            //    Console.WriteLine( item);
            //}

            // Equals : Karşılaştırma yapar ve karşılaştırma sonucu boolean bir değer döner.
            //string ilkAd = "Hakan";
            //string ikinciAd = "hakan";
            //bool esitMi = ilkAd.Equals(ikinciAd,StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine( esitMi);

            // Substring : İlk parametresi başlangıç indexini belirtir ikinci parametresi kaç adım gideceğini yani uzunluğunu belirtir. İkinci parametresini kullanmazsak başlangıç indexinden metinsel ifadenin sonuna kadar gider.
            //string marka = "LumberJack";
            //Console.WriteLine( marka.Substring(2,3)  );

            // Reverse : Metinsel ifadeyi tersine çevirir geriye bir koleksiyon döndürür.
            //foreach (char item in "hakan".Reverse()) 
            //{
            //    Console.WriteLine(item);
            //}

            // IndexOf : Metinsel ifade içerisinde aratmak istediğimiz karakter yada metinsel ifadenin indexini döner. 
            //Console.WriteLine(    "İfade".IndexOf("de")    );

            // Remove : İlk parametresi kullanıldığında başlangıç indexi verilir ve sonrası silinir. Eğer ikinci parametresi kullanılırsa belirtilen sayı kadar silme işlemi yapar. Bu sayıdan sonrasını silmez.
            //Console.WriteLine( "Zurna Dürüm".Remove(2,7)  );

            // Contains : Arama işlemi yapar. İçerisinde verilen ifade geçiyorsa true geçmiyorsa false döner. 
            //Console.WriteLine(  "Mantı".Contains("i")    );

            // Replace : Yer değiştirme yapar.
            //Console.WriteLine(   "Dal sarkar kartal kalkar kartal kalkar dal sarkar".Replace("kartal","baykuş")    );

            // ToLower() : Gelen metinsel ifadeyi küçük harfe çevirir.
            //Console.WriteLine("HAKAN".ToLower());
            // ToUpper() : Gelen metinsel ifadeyi büyük harfe çevirir.
            //Console.WriteLine("hakan".ToUpper());


            #endregion
            #region METOTLAR
            // Metot : Belirli bir işleve sahip içerinde işlem çeviren ve geriye değer dönen veya dönmeyen yapılara denir.

            ////Değer almayan geriye değer döndürmeyen metod
            //void Selamla()
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //Selamla();
            ////Değer alan geriye değer döndürmeyen metot
            //void KaresiniAl(int sayi)
            //{
            //    int karesi = sayi * sayi;
            //    Console.WriteLine(karesi);
            //}
            //KaresiniAl(5);
            ////Değer alan geriye değer döndürmeyen metot
            //void Topla(int sayi1, int sayi2)
            //{
            //    Console.WriteLine(sayi2 + sayi1);
            //}
            //Topla(5, 11);

            ////Değer almayan geriye değer döndüren metot
            //string KelimeVer()
            //{
            //    return "Merhaba";
            //}
            //string deger = KelimeVer();
            //Console.WriteLine(deger);

            //// Değer almayan geriye değer döndüren metot
            //bool Dogrumu()
            //{
            //    return true;
            //}
            //Console.WriteLine(     Dogrumu()     );

            //// Değer almayan geriye değer döndüren metot
            //int SayiVer()
            //{
            //    int sayi = 10;
            //    return sayi;
            //}
            //int sayim = SayiVer();
            //Console.WriteLine( sayim  );

            //// Değer alan geriye değer döndüren metot
            //int Karesi(int sayi)
            //{
            //   int kare = sayi* sayi;
            //    return kare;
            //}
            //int karesi = Karesi(134);
            //Console.WriteLine( karesi );

            //// Değer alan geriye değer döndüren metot
            //int Toplama(int sayi,int sayi2)
            //{
            //    return sayi+sayi2;
            //}
            //int toplamSonucu = Toplama(951,753);
            //Console.WriteLine(toplamSonucu);
            #endregion
            #region Ornek1
            //Kullanıcıdan alınan ad soyad bilgilerini tek bir ifade olarak birleştirip döndüren bir metot oluşturunuz ve ekrana yazdırınız.
            //Console.Write("Ad : " );
            //string ad = Console.ReadLine();
            //Console.Write("Soyad : "  );
            //string soyad = Console.ReadLine();
            //string Bilgiler(string firstName, string lastName)
            //{
            //    return firstName + " " + lastName;
            //}
            //string adSoyad = Bilgiler(ad,soyad);
            //Console.WriteLine(adSoyad);
            #endregion
            #region Ornek 2
            //Kullanıcıdan alınan 2 adet sayı üzerinde çıkarma işlemi yapınız. Her zaman büyükten küçük çıksın. Yani negatif sonuç çıkmasın.
            //Console.Write("İlk sayi : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write(  "İkinci Sayi :");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int Cikarma(int s1, int s2)
            //{
            //    return s1 > s2 ? s1-s2 : s2-s1;
            //}
            //Console.WriteLine( Cikarma(sayi1, sayi2) );
            #endregion
            #region Ornek 3
            //Kullanıcıdan adını alınız. Bir adette sayı alınız. Kullanıcının adını ekrana verdiği sayı kadar yazan bir metot oluşturunuz ve kullanınız.
            //Console.Write("Ad : ");
            //string ad = Console.ReadLine();
            //Console.Write("Kaç defa yazılsın : "  );
            //int adet = int.Parse(Console.ReadLine());

            //void Yazdir(string name,int count)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Yazdir(ad,adet);
            #endregion
            #region Ornek 4
            // Kullanıcının yaşını hesaplayan ve adıyla beraber ekrana yan yana yazdıran metot oluşturunuz.
            //Console.Write("Ad : ");
            //string ad = Console.ReadLine();
            //Console.Write("Dogum yili : ");
            //int yil = int.Parse(Console.ReadLine());
            //void EkranaYaz(string name,int dogumYili)
            //{
            //    Console.WriteLine( $"Ad : {name}\nYaş : {DateTime.Now.Year-yil}" );
            //}
            //EkranaYaz(ad,yil);
            #endregion
            #region Ornek 5
            //// Rastgele sayı dizisi döndüren bir metot oluşturunuz. İlk gelen rastgele sayı kadar dizi boyutu oluştursun. Bu dizide dönerek oluşan elemanları yazdırınız.
            //int[] Sayilar(int startNumber, int endNumber)
            //{
            //    Random random = new Random();
            //    int ilkSayi = random.Next(startNumber, endNumber);
            //    int[] tamSayilar = new int[ilkSayi];
            //    Console.WriteLine($"Dizi Boyutu : {tamSayilar.Length}");
            //    for (int i = 0; i < ilkSayi; i++)
            //    {
            //        tamSayilar[i] = random.Next(startNumber, endNumber);
            //    }
            //    return tamSayilar;
            //}
            //int[] sayiDizim = Sayilar(5, 10);
            //foreach (var item in sayiDizim)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ornek 6
            // Girilen sayının tekmi çiftmi olduğunu geriye mesaj olarak döndüren metot oluşturunuz.
            //string Ciftmi(int sayi)
            //{
            //    if (sayi%2==0)
            //    {
            //        return "Cift";
            //    }
            //    return "Tek";
            //}
            //Console.Write("Bir sayi giriniz : ");
            //int sayim = int.Parse(Console.ReadLine());
            //Console.WriteLine( Ciftmi(sayim) ); 
            #endregion
            #region Ornek 7
            // Kullanıcıdan göz rengi istensin ve gelen göz renginde ekrana Göz renginiz blabla dır yazsın. (Mor,Kırmızı,Sarı,Beyaz,Turuncu)
            //void GozRengiYazdir(string gozRengi)
            //{
            //    switch (gozRengi)
            //    {
            //        case "mor": Console.ForegroundColor = ConsoleColor.Magenta; break;
            //        case "kırmızı": Console.ForegroundColor = ConsoleColor.Red; break;
            //        case "sarı": Console.ForegroundColor = ConsoleColor.Yellow; break;
            //        case "beyaz": Console.ForegroundColor = ConsoleColor.White; break;
            //        case "turuncu": Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            //        default:
            //            Console.WriteLine("Böyle göz rengimi olur saçmalamaz mısın.");
            //            break;
            //    }
            //    Console.WriteLine($"Göz renginiz {gozRengi} dır.");
            //}
            //Console.Write("Göz renginiz : ");
            //string renk = Console.ReadLine().ToLower();
            //GozRengiYazdir(renk);
            #endregion
            #region Ornek 8
            // Kullanıcıya bu günkü şasını, verdiği aralıktaki değerlere göre döndüren metot oluşturunuz. Ortalamanın altında kalırsa şanssız desin. Ortalamaya eşit veya üzerindeyse şanslı sayılsın.
            //string SansUret(int baslangic,int bitis)
            //{
            //    Random random = new Random();
            //    int sans = random.Next(baslangic, bitis);
            //    int ortalama = (baslangic + bitis) / 2;
            //    return sans >= ortalama ? $"Şanslısın\nSayin : {sans}" : $"Şansızsın\nSayin : {sans}";
            //}
            //Console.Write("Baslangic Degeri : ");
            //int baslangicDegeri = int.Parse(Console.ReadLine());
            //Console.Write("Bitis Degeri : ");
            //int bitisDegeri = int.Parse(Console.ReadLine());
            //string sansim = SansUret(baslangicDegeri,bitisDegeri);
            //Console.WriteLine(sansim);
            #endregion
            #region Ornek 9
            // Sınırsız toplama işlemi yapan ve geriye sonucu döndüren metot oluşturunuz. 
            //int Topla(params int[] values)
            //{
            //    int sonuc = 0;
            //    foreach (var item in values)
            //    {
            //        sonuc += item;
            //    }
            //    return sonuc;
            //}
            //Console.WriteLine(Topla(0, 52, 6, 56, 2314, 6514, 1, 5));
            #endregion
            #region Ornek 10 
            // Kendi içerisinde hazırda bulunan 10 elemanlı bir meyve dizisi ola metot oluşturunuz. Bu metot dışarıya rastgele meyvelerden oluşan 5elemanlı bir dizi yollasın. Bu oluşan dizi içerisinde hiç bir meyve tekrar etmesin hepsi birbirinden bağımsız olsun. Gelen dizi elemanlarınıda ekrana yazdırınız.
            //string[] MeyveOlustur()
            //{
            //    string[] defaultMeyveler = {"Muz","Elma","Armut","Çilek","Kayısı","Karpuz","Kiraz","Kivi","Nektari","Vişne" };
            //    Random rnd = new Random();
            //    string[] meyveler = new string[0];
            //    int sayac = 0;
            //    while (true)
            //    {
            //        if (meyveler.Length <= 4)
            //        {
            //            string meyve = defaultMeyveler[rnd.Next(0, defaultMeyveler.Length)];
            //            if (!meyveler.Contains(meyve))
            //            {
            //                Array.Resize(ref meyveler, meyveler.Length + 1);
            //                meyveler[sayac] = meyve;
            //                sayac++;
            //            }
            //        }
            //        else break;
            //    }
            //    return meyveler;
            //}
            //foreach (var item in MeyveOlustur())
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Ornek 11
            //// Kullanıcıdan bir dizi isteyen ve içerisinde kaç adet tek kaç adet çift olan sayı mevcutsa geriye döndürünüz. 
            //string CiftTekAdet(int[] sayiDizisi)
            //{
            //    int ciftSayiAdeti = 0;
            //    int tekSayiAdeti = 0;
            //    foreach (var item in sayiDizisi)
            //    {
            //        if (item % 2 == 0)
            //        {
            //            ciftSayiAdeti++;
            //        } else tekSayiAdeti++;
            //    }
            //    return $"Cift sayi adeti : {ciftSayiAdeti}\nTek sayi adeti : {tekSayiAdeti}";
            //}
            //int[] sayilar = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Sayi ver : ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //string cevap = CiftTekAdet( sayilar );
            //Console.WriteLine( cevap  );
            #endregion
            #region Ornek 12
            // Gonderilen sayının faktöriyelini hesaplayan ve geriye sonucu dönen metot oluşturunuz.
            //int FaktoriyelHesapla(int sayi)
            //{
            //    if (sayi == 1)
            //    {
            //        return 1;
            //    }
            //    return sayi * FaktoriyelHesapla(sayi - 1);
            //}
            //Console.WriteLine( FaktoriyelHesapla(10)  );

            //int FaktoriyelHesapla2(int sayi)
            //{
            //    int sonuc = 1;
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        sonuc *= i;
            //    }
            //    return sonuc;
            //}
            //Console.WriteLine( FaktoriyelHesapla2(5) );

            #endregion

            #region METOT EZME
            //MesajVer(5,"asdasd");
            //MesajVer("Hakan");
            #endregion
            #endregion
            #endregion
            #endregion
            Console.ReadKey();
        }
        //static string IsimVer()
        //{
        //    Random rnd = new Random();
        //    string[] isims = { "Ece", "Funda", "Furkan", "Halil", "Oktay", "Muhammet", "Emre", "Yakup", "Volkan", "Samet" };
        //    return isims[rnd.Next(0, isims.Length)];
        //}

        //static void MesajVer(int a,string b)
        //{
        //    Console.WriteLine("Merhaba");
        //}
        //static void MesajVer(string name)
        //{
        //    Console.WriteLine($"Merhaba {name}");
        //}
    }
}
