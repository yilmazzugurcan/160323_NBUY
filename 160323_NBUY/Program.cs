using System;
using System.Security.Principal;
using System.Xml;

namespace _160323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kredi Kartı Numarasını Property Alma,İlk 4 Hane ve Son 2 Hane yazdırma
            /*   musteri m1 = new musteri();
               Console.WriteLine("Kredi Kartı Numarası Giriniz:");
               string kredikart = Console.ReadLine();

               m1.kredikart = kredikart;

           }

           public class musteri
           {

               private string kredikart1;
               public string kredikart
               {
                   get
                   {
                       return kredikart1;
                   }
                   set
                   {

                       if (value.Length < 16)
                       {
                           Console.WriteLine("Hatalı Giriş. Lütfen 16 Haneli Kredi Kart Numaranızı Giriniz.");

                           kredikart1 = value;
                       }
                       else
                       {
                           string ilkDortHane = value.Substring(0, 4);
                           string sonIkiHane = value.Substring(14, 2);
                           Console.WriteLine($"Kartınızın ilk 4 hanesi: {ilkDortHane}");
                           Console.WriteLine($"Kartınızın son 2 hanesi: {sonIkiHane}");
                           Console.WriteLine("Doğru Kredi Kart Numarası");
                       }

                   }
               }
           } */
            #endregion

            #region Yemek sınıfları ile Polymorphism 
            /*yemek sınıfı oluştur, ana yemekler, ara sıcaklar, tatlılar, metod sunum şekli yemek alt özellik malzeme, acı tipi, aşcı, pişme süresi,pişme yeri
                            anaYemek a1 = new anaYemek();
                            a1.yemekAdi = "Pastırmalı Kuru ";
                            a1.sure = 30;
                            a1.malzeme = "Kuru Fasulye , Pastırma";
                            a1.acilik = "Az Acılı";
                            a1.asci = "Bolulu Hasan Usta";
                            a1.pismeYeri = "Odun Ateşi Fırın";
                            Console.WriteLine("Ana Yemek");
                            Console.WriteLine("Yemek Adı:"+a1.yemekAdi+"\n"+"Pişme Süresi:"+a1.sure+" Dk"+"\n"+"Kullanılan Malzemeler :"+a1.malzeme+"\n"+"Acı:"+a1.acilik+"\n"+"Ustası:"+a1.asci+"\n"+"Nerede Pişti:"+a1.pismeYeri);
                            Console.WriteLine("Sunum:"+a1.sunumSekli());
                            Console.WriteLine();

                            araSicak a2= new araSicak();
                            a2.yemekAdi = "Arnavut Ciğeri";
                            a2.sure = 10;
                            a2.malzeme = "Dana Ciğer, Patates, Soğan";
                            a2.acilik = "Az Acı";
                            a2.asci = "Manisalı Turgut Usta";
                            a2.pismeYeri = "Ocak";
                            Console.WriteLine("Ara Sıcak");
                            Console.WriteLine("Yemek Adı:" + a2.yemekAdi + "\n" + "Pişme Süresi:" + a2.sure + " Dk" + "\n" + "Kullanılan Malzemeler :" + a2.malzeme + "\n" + "Acı:" + a2.acilik + "\n" + "Ustası:" + a2.asci + "\n" + "Nerede Pişti:" + a2.pismeYeri);
                            Console.WriteLine("Sunum:" + a2.sunumSekli());
                            Console.WriteLine();

                            tatli t1= new tatli();
                            t1.yemekAdi = "Fırın Sütlaç";
                            t1.sure = 20;
                            t1.malzeme = "Baldo Pirinç, Süt, Yumurta";
                            t1.acilik = "Acısız";
                            t1.asci = "Antalyalı Fikret Usta";
                            t1.pismeYeri = "Fırın";
                            Console.WriteLine("Tatlı"); 
                            Console.WriteLine("Yemek Adı:" + t1.yemekAdi + "\n" + "Pişme Süresi:" + t1.sure + " Dk" + "\n" + "Kullanılan Malzemeler :" + t1.malzeme + "\n" + "Acı:" + t1.acilik + "\n" + "Ustası:" + t1.asci + "\n" + "Nerede Pişti:" + t1.pismeYeri);
                            Console.WriteLine("Sunum:" + t1.sunumSekli());
                            Console.WriteLine();

                        }

                        class Yemek
                        {
                            public string yemekAdi { get; set; }
                            public string malzeme { get; set; }
                            public string acilik { get; set; }
                            public string asci { get; set; }
                            public string pismeYeri { get; set; }
                            public int sure { get; set; }

                            public virtual string sunumSekli()
                            {
                                return "tabak";
                            }

                            internal bool yazdirma()
                            {
                                throw new NotImplementedException();
                            }
                        }
                        class anaYemek : Yemek
                        {
                           public override string sunumSekli()
                            {
                                return "Güveçte, Kızarmış Ekmek ile";
                            }

                        }
                        class tatli : Yemek
                        {
                            public override string sunumSekli()
                            {
                                return "Kasede, Üzerine Fındık Ufalanarak";
                            }
                        }
                        class araSicak : Yemek
                        {
                            public override string sunumSekli()
                            {
                                return "Küçük Yemek Tabağı,Soğanlar Yarım Ay Doğranmış,Az Baharatlı";
                            }
                        }*/
            #endregion

            #region Yemek Sınıfları Uğur hoca
            /*    Tatlilar tatlilar = new Tatlilar();
        AnaYemek ana=new AnaYemek();
        SebzeYemekleri sebze=new SebzeYemekleri();
        AraSicaklar ara=new AraSicaklar();
        ana.Ad = "Patlıcan Kebabı";
        sebze.Ad = "Pastırmalı Kuru Fasulye";
        ara.Ad = "Paçanga";

        tatlilar.Ad = "Kalburabasti";
        Console.WriteLine(ana.Ad + " " + ana.SunumSekli());
        Console.WriteLine(sebze.Ad + " " + sebze.SunumSekli());
        Console.WriteLine(ara.Ad + " " + ara.SunumSekli());
        Console.WriteLine(tatlilar.Ad+" "+tatlilar.SunumSekli());
        Console.WriteLine("==============================");

        Sunumlar snm=new Sunumlar();
        snm.SunumGoster(ana);
        snm.SunumGoster(sebze);
        snm.SunumGoster(ara);
        snm.SunumGoster(tatlilar);


    }
    class Yemek
    {
        public string Ad { get; set; }
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public string aciTipi { get; set; }
        public string asci { get; set; }
        public string pismeSekli { get; set; }
        public string pismeYeri { get; set; }
        public virtual string SunumSekli()

        {
            return "Pilav ile";
        }
    }
    class AnaYemek : Yemek
    {
        public string cesit { get; set; }

        public override string SunumSekli()

        {
            return "Salata ile";
        }
    }
    class SebzeYemekleri:Yemek
    {
        public string sebzeTipi { get; set; }
        public string sulususuz { get; set; }

        public override string SunumSekli()

        {
            return "Yoğurt ile";
        }
    }
    class Tatlilar : Yemek
    {
        public  override string SunumSekli()

        {
            return "Kaymak ile";
        }
    }
    class AraSicaklar : Yemek
    {
        public override string SunumSekli()

        {
            return "Haydari";
        }
    }
    class Sunumlar
    {
        public  void SunumGoster(Yemek ymk)
        {
            Console.WriteLine(ymk.SunumSekli());
        }
    }*/
            #endregion

            #region urun cinsine göre kdv hesaplatma polymorphism
            //urun sınıfı,kdv metodu, urun fıyatına gore kdvli fiyat hesaplayan metod olacak her urune gore ayrı hesap yapacak

         /*   elektronik e1 = new elektronik();
            e1.fiyat = 1000;
            e1.kdv = 0.18;
            unlu u1 = new unlu();
            u1.fiyat = 1000;
            u1.kdv = 0.01;
            Console.WriteLine("Elektronik Ürün Kdvli Fiyat:" + e1.kdvhesap());
            Console.WriteLine("Unlu Mamul Kdvli Fiyat:" + u1.kdvhesap());

        }
        class urun
        {

            public string ad { get; set; }
            public int fiyat { get; set; }
            public double kdv { get; set; }

            public virtual int kdvhesap()

            {
                return ((int)(fiyat * kdv)); ;
            }

        }
        class unlu : urun
        {
            public double kdv { get; set; }
            public override int kdvhesap()

            {

                return ((int)(fiyat + fiyat * kdv));
            }
        }
        class elektronik : urun
        {
            public double kdv { get; set; }
            public override int kdvhesap()

            {

                return ((int)(fiyat + fiyat * kdv));
            }
        }
        class kdvler
        {
            public static int KdvHesapla(urun urn)
            {
                return (urn.kdvhesap());
            }
        } */
        #endregion


    }
}
