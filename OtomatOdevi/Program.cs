using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OtomatOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- SQL BAĞLANTISI -- //
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CUCGJ2O;Initial Catalog=otomatsql;Integrated Security=True");
            baglanti.Open();
            if (baglanti.State==ConnectionState.Closed)
            {
                Console.WriteLine("Bağlantı Kurulamadı!");
            }
            else
            {
                Console.WriteLine("Bağlantı Kuruldu!");
            }
            // -- SQL BAĞLANTISI -- //

            Console.WriteLine("Giriş Seçin: 1-Müşteri / 2-Admin");
            int girismenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (girismenu == 1)
            {
                Console.WriteLine("1-Su (5TL) / 2-Kola (20TL) / 3-Çikolata (15TL)");
                Console.WriteLine("Ürün Kodu Seçin");
                int urunsecim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen Bekleyin...");
                Thread.Sleep(3000);
                Console.Clear();

                if (urunsecim == 1)
                {

                    Console.WriteLine("Su İçin Ödeme Yöntemi Seçiniz / 1-Nakit / 2-Kart");
                    int odeme = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (odeme == 2)
                    {
                        Console.WriteLine("Kart Şifrenizi Girin");
                        int kartsifre = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else if (odeme == 1)
                    {
                        Console.WriteLine("Ürünün Ücretini Giriniz");
                        int nakit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem");
                    }
                }
                else if (urunsecim == 2)
                {
                    Console.WriteLine("Kola İçin Ödeme Yöntemi Seçiniz / 1-Nakit / 2-Kart");
                    int odeme = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (odeme == 2)
                    {
                        Console.WriteLine("Kart Şifrenizi Girin");
                        int kartsifre = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else if (odeme == 1)
                    {
                        Console.WriteLine("Ürünün Ücretini Giriniz");
                        int nakit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem");
                    }
                }
                else if (urunsecim == 3)
                {
                    Console.WriteLine("Çikolata İçin Ödeme Yöntemi Seçiniz / 1-Nakit / 2-Kart");
                    int odeme = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (odeme == 2)
                    {
                        Console.WriteLine("Kart Şifrenizi Girin");
                        int kartsifre = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else if (odeme == 1)
                    {
                        Console.WriteLine("Ürünün Ücretini Girin");
                        int nakit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen Bekleyin...");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("Ürün Satın Alındı");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem Yaptınız.");
                }

            }
            else if (girismenu == 2)
            {
                string username = "alpgurcay";
                string password = "123";


                Console.WriteLine("Kullanıcı Adı:");
                string kullanici = Console.ReadLine();

                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();


                bool girissonuc = (username == kullanici && password == sifre);

                Console.WriteLine("Giriş:" + girissonuc);

                if (girissonuc==true)
                {
                    Console.Clear();
                    Console.WriteLine("1-Ürün Ekleme / 2-Ürün Listeleme / 3-Ürün Sil");
                    int islemsec = Convert.ToInt32(Console.ReadLine());

                    if (islemsec == 1)
                    {
                        Console.Clear();
                        // -- VERİ EKLEME -- //
                        Console.WriteLine("Ürün Adı");
                        string Urunler = Console.ReadLine();
                        Console.WriteLine("Ürün Fiyatı");
                        string Fiyat = Console.ReadLine();
                        SqlCommand komut = new SqlCommand("insert into Products(Urunler,Fiyat) values('" + Urunler + "','" + Fiyat + "')", baglanti);
                        int sonuc = komut.ExecuteNonQuery();
                        Console.Clear();
                        Console.WriteLine(sonuc + " Kayıt Eklendi");
                        // -- VERİ EKLEME -- // 

                        

                    }
                    else if (islemsec == 2)
                    {
                        Console.Clear();
                        // -- VERİ LİSTELEME -- //
                        SqlCommand liste = new SqlCommand("select *from Products", baglanti);
                        SqlDataReader oku = liste.ExecuteReader();
                        int kayitsayisi = 0;
                        while (oku.Read())
                        {
                            kayitsayisi++;
                            Console.WriteLine(oku[0] + "\t" + oku[1]);
                        }
                        Console.WriteLine(kayitsayisi + " Kayıt Listelendi");
                        // -- VERİ LİSTELEME -- // 
                    }
                    else if (islemsec == 3)
                    {
                        Console.Clear();
                        // -- VERİ SİLME -- // 
                        Console.WriteLine("Silinecek Ürün");
                        string Urunler = Console.ReadLine();
                        int sonuc = 0;
                        ConsoleKeyInfo tus = new ConsoleKeyInfo();
                        Console.WriteLine("Kayıtları Silmeyi Onaylıyor musun ? (E-H)");
                        tus = Console.ReadKey(true);
                        if (tus.Key==ConsoleKey.E)
                        {
                            SqlCommand verisil = new SqlCommand("delete from Products where urunler='" + Urunler + "'", baglanti);
                            sonuc = verisil.ExecuteNonQuery();
                            Console.Clear();
                            Console.WriteLine(sonuc + " Kayıt Silindi"); 
                        }
                        else if (tus.Key==ConsoleKey.H)
                        {
                            Environment.Exit(0);
                        }
                        // -- VERİ SİLME -- // 
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Kullanıcı Adı ve Şifre");
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("?");
            }
        }
    }
}
