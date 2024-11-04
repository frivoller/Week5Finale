using System;
using System.Collections.Generic;

namespace ArabaFabrikasi
{
    // Araba sınıfı tanımlanıyor
    public class Araba
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        // Constructor ile üretim tarihi otomatik atanır
        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();

            while (true)
            {
                Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
                string cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == "h")
                {
                    break;
                }
                else if (cevap == "e")
                {
                    Araba yeniAraba = new Araba();

                    Console.Write("Seri Numarası: ");
                    yeniAraba.SeriNumarasi = Console.ReadLine();

                    Console.Write("Marka: ");
                    yeniAraba.Marka = Console.ReadLine();

                    Console.Write("Model: ");
                    yeniAraba.Model = Console.ReadLine();

                    Console.Write("Renk: ");
                    yeniAraba.Renk = Console.ReadLine();

                KapiSayisiTekrar:
                    Console.Write("Kapı Sayısı: ");
                    if (int.TryParse(Console.ReadLine(), out int kapiSayisi))
                    {
                        yeniAraba.KapiSayisi = kapiSayisi;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş! Kapı sayısını sayısal bir değer olarak giriniz.");
                        goto KapiSayisiTekrar;
                    }

                    // Yeni araba nesnesini listeye ekle
                    arabalar.Add(yeniAraba);
                    Console.WriteLine("Araba başarıyla üretildi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen e veya h harfi ile yanıtlayınız.");
                }
            }

            Console.WriteLine("\nÜretilen arabaların seri numaraları ve markaları:");
            foreach (var araba in arabalar)
            {
                Console.WriteLine($"Seri No: {araba.SeriNumarasi}, Marka: {araba.Marka}");
            }
        }
    }
}
