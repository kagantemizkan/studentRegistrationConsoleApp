using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;

namespace studentRegistrationConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("---------Öğrenci Kayıt Programı V 0.1---------");
            Console.WriteLine(" ");
            Console.WriteLine("Bilinen Hata(lar):");
            Console.WriteLine(" ");
            Console.WriteLine("Öğrenci kayıt düzenleme kısmında öğrenci numarasını yanlış yazsanız bile sanki doğru yazılmış gibi düzenlemeye geçicek.");
            Console.WriteLine(" ");
            Console.WriteLine("***********************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Uygulamada 20 tane rastgele öğrenci konulmuştur.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Lütfen bekleyiniz, program kısa bir süre içerisinde açılacak.");
            Thread.Sleep(9000);
            Console.Clear();

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("***********************MENÜ********************");
                Console.WriteLine(" ");
                Console.WriteLine("1-Kayıt Ekle");
                Console.WriteLine(" ");
                Console.WriteLine("2-Kayıtları Listele");
                Console.WriteLine(" ");
                Console.WriteLine("3-Kayıt Ara");
                Console.WriteLine(" ");
                Console.WriteLine("4-Kayıt Düzenle");
                Console.WriteLine(" ");
                Console.WriteLine("5-Çıkış");
                Console.WriteLine(" ");
                Console.WriteLine("***********************************************");
                Console.WriteLine(" ");

                string filePath = "../../ogrenciler.txt";

                int secenek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if (secenek > 0 & secenek < 6)
                {
                    if (secenek == 1)
                    {
                        Thread.Sleep(85);
                        Console.Clear();

                        Console.WriteLine(" ");
                        Console.WriteLine("***********************KAYIT*EKLE*********************");
                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Adını Giriniz");
                        string ad = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Soyadını Giriniz");
                        string soyad = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Numarasını Giriniz");
                        string numara = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Bölümünü Giriniz");
                        string bolum = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Cinsiyet Giriniz");
                        string cinsiyet = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Doğum Yeri Giriniz");
                        string dogumYeri = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Yaşını Giriniz");
                        string yas = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Telefon Numarası Giriniz");
                        string telefonNo = Console.ReadLine();


                        ogrenciEkle(ad, soyad, numara, bolum, cinsiyet, dogumYeri, yas, telefonNo, filePath);

                        Console.WriteLine(" ");
                        Console.WriteLine("Öğrenci Eklenmiştir");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else if (secenek == 2)
                    {
                        Thread.Sleep(85);
                        Console.Clear();

                        Console.WriteLine(" ");
                        Console.WriteLine("*******************Kayıtlar********************");
                        ogrencileriListele(filePath);
                    }
                    else if (secenek == 3)
                    {
                        Thread.Sleep(85);
                        Console.Clear();

                        bool kayitAraDongusu = true;
                        while (kayitAraDongusu)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("*******************KAYIT*ARA*******************");
                            Console.WriteLine(" ");
                            Console.WriteLine("Ne aramak istiyorsunuz? (Sayıyı Giriniz)");
                            Console.WriteLine(" ");
                            Console.WriteLine("1 - Ad");
                            Console.WriteLine("2 - Soyad");
                            Console.WriteLine("3- Numara");
                            Console.WriteLine("4 - Bölüm");
                            Console.WriteLine("5 - Cinsiyet");
                            Console.WriteLine("6 - Doğum Yeri");
                            Console.WriteLine("7 - Yaş");
                            Console.WriteLine("8 - Telefon No");
                            Console.WriteLine(" ");
                            Console.WriteLine("***********************************************");
                            Console.WriteLine(" ");

                            int arananTerim = Convert.ToInt32(Console.ReadLine());

                            Thread.Sleep(85);
                            Console.Clear();

                            if (arananTerim == 1)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz adı giriniz");
                                Console.WriteLine(" ");
                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 1);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 2)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz soyadını giriniz");
                                Console.WriteLine(" ");
                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 2);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 3)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz numarayı giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 3);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 4)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz bölümü giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 4);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 5)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz cinsiyeti giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 5);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 6)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz doğum yerini giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 6);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 7)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz yaşı giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 7);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else if (arananTerim == 8)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Aramak istediğiniz telefon numarasını giriniz");
                                Console.WriteLine(" ");

                                string arananSozcuk = Console.ReadLine();
                                Console.WriteLine(" ");
                                Thread.Sleep(85);
                                Console.Clear();

                                string[] output = readMultipleRecords(arananSozcuk, filePath, 8);

                                for (int i = 0; i < output.Length; i++)
                                {
                                    Console.WriteLine(output[i]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("Yanlış Tuşa Bastınız.");
                                Console.WriteLine("Lütfen Tekrar Giriniz.");
                                Console.WriteLine("***********************************************");
                                Thread.Sleep(1400);
                                Console.Clear();
                            }

                            kayitAraDongusu = false;
                        }
                    }
                    else if (secenek == 4)
                    {
                        Thread.Sleep(85);
                        Console.Clear();

                        Console.WriteLine(" ");
                        Console.WriteLine("*****************KAYIT*DÜZENLE*****************");

                        Console.WriteLine(" ");
                        Console.WriteLine("Düzenlemek istediğiniz öğrencinin numarasını giriniz.");
                        Console.WriteLine(" ");
                        string numara = Console.ReadLine();
                        Console.WriteLine(" ");


                        Console.WriteLine(string.Join(" ", readRecord(numara, filePath, 3)));

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni adı giriniz.");
                        Console.WriteLine(" ");
                        string yeniAd = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni soyadı giriniz.");
                        Console.WriteLine(" ");
                        string yeniSoyad = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni numara giriniz.");
                        Console.WriteLine(" ");
                        string yeniNumara = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni bölüm giriniz.");
                        Console.WriteLine(" ");
                        string yeniBölüm = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni cinsiyet giriniz.");
                        Console.WriteLine(" ");
                        string yeniCinsiyet = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni doğum yeri giriniz.");
                        Console.WriteLine(" ");
                        string yeniDoğumYeri = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni yaş giriniz.");
                        Console.WriteLine(" ");
                        string yeniYaş = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni telefon numarası giriniz.");
                        Console.WriteLine(" ");
                        string yeniTelefonNo = Console.ReadLine();

                        ogrenciDuzenle(numara, filePath, 3, yeniAd, yeniSoyad, yeniNumara, yeniBölüm, yeniCinsiyet, yeniDoğumYeri, yeniYaş, yeniTelefonNo);

                    }
                    else if (secenek == 5)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("Yanlış Tuşa Bastınız.");
                    Console.WriteLine("Lütfen Tekrar Giriniz.");
                    Console.WriteLine("***********************************************");
                    Thread.Sleep(1400);
                    Console.Clear(); 
                }
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void ogrencileriListele(string filePath)
        {
            try
            {

                string[] satirlar = System.IO.File.ReadAllLines(filePath);

                foreach (string satir in satirlar)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(satir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya okuma hatası: " + ex);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string[] readMultipleRecords(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            ArrayList records = new ArrayList();
            string[] recordNotFound = { "Kayıt Bulunamadı" };


            try 
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);

                for(int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        records.Add(lines[i]);
                    }
                }

                if (records[0] == null)
                {
                    return recordNotFound;
                }


                return (string[])records.ToArray(typeof(string));
            }
            catch(Exception ex)
            {
                return recordNotFound;
                throw new Exception("Program Hata Verdi: ", ex);
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string[] readRecord(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Kayıt Bulunamadı" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');


                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        return fields;
                    }
                }

                return recordNotFound;
            }
            catch (Exception ex)
            {
                return recordNotFound;
                throw new ApplicationException("Uygulama Calismadi", ex);
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool recordMatches(string searchTerm, string[] record, int positionOfTheSearchTerm)
        {
            if (record[positionOfTheSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void ogrenciEkle(string ad, string soyad, string numara, string bolum, string cinsiyet, string dogumYeri, string yas, string telefonNo, string filePath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, true))
                {
                    file.WriteLine(ad + ","
                                 + soyad + ","
                                 + numara + ","
                                 + bolum + ","
                                 + cinsiyet + ","
                                 + dogumYeri + ","
                                 + yas + ","
                                 + telefonNo + ",");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Uygulama Calismadi", ex);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void ogrenciDuzenle(string searchTerm, string filepath, int positionOfSearchTerm, string ad, string soyad, string numara, string bolum, string cinsiyet, string dogumYeri, string yas, string telefonNo)
        {
            positionOfSearchTerm--;
            string tempFile = "../../tempFile.txt";
            bool edited = false;

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                
                
                
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (!(recordMatches(searchTerm, fields, positionOfSearchTerm)))
                    {
                        ogrenciEkle(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], @tempFile);
                    }
                    else
                    {
                        if (!edited)
                        {
                            ogrenciEkle(ad, soyad, numara, bolum, cinsiyet, dogumYeri, yas, telefonNo, @tempFile);
                            Console.WriteLine(" ");
                            Console.WriteLine("Düzenlendi");
                            Thread.Sleep(500);
                            Console.Clear();
                            edited = true;
                        }
                    }
                }

                
                File.Delete(@filepath);

                
                System.IO.File.Move(tempFile, filepath);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Program hata verdi");
                throw new ApplicationException("Program hata verdi: " , ex);
            }



        }
    }

}


