using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW02
{
    class Arac
    {
        public int yonIndis;
        private int aracX, aracY, firca, boyut, XartiYon = 1, XeksiYon = 3, YartiYon = 2, YeksiYon = 0; //
        public bool  sagSol, geri = false;
        public bool[] yonler = new bool[4]; //[0] - yukarı yön, [1] - sağ yön,[2] - aşağı yön, [3] - saol yön
        
        int[,] Matris;
        //Boyut sınırın min 5 belirledim
        public int Boyut
        {
            get
            {
                return boyut;
            }

            set
            {
                if (26 > value || value > 4)
                    boyut = value;
                else
                    boyut = 5;
            }
        }
        public int Firca
        {
            get { return firca; }
            set
            {
                if (value == 1 || value == 0)
                    firca = value;
                else
                    firca = 0;
            }
        }
        public Arac()
        {
            yonler[0] = true; //yukarı yönüm default. 
            sagSol = true;    //sağ'a dön default. Bu iki default sonucunda sağ yönüm elde edilir.
        }
        public Arac(int matrisBoyut)
        {
            yonler[0] = true; //yukarı yönüm default. 
            sagSol = true;    //sağ'a dön default. Bu iki default sonucunda sağ yönüm elde edilir.
            Boyut = matrisBoyut;
            Matris = new int[Boyut, Boyut];
        }
        //yeni yön üretildiğinde diğer yönleri etkisiz yapan method
        private void defaultYap()
        {
            for (int i = 0; i < 4; i++)
                yonler[i] = false;
        }
        //Aracın yönünü bulan method
        public bool yonuBul()
        {   //eğer yönüm ağağı yön ise, bu yönde yapılacak olan sağ ve sol sönümlerinde oluşacak yönlerin
            //indisini ozelKontrol methodu veriyor ve bu indislere göre yeni yonumu true değeri atarak return ediyor
            if (yonler[YartiYon] == true) //YartiYon
            {
                yonIndis = ozelKontrol(ref XeksiYon, ref XartiYon); //Yon indis oluşan yeni yönün indisini tutuyor
                return yonler[yonIndis] = true;
            }
            else if (yonler[YeksiYon] == true) //YeksiYon 
            {
                yonIndis = ozelKontrol(ref XartiYon, ref XeksiYon);
                return yonler[yonIndis] = true;
            }
            else if (yonler[XartiYon] == true) //XartiYon
            {
                yonIndis = ozelKontrol(ref YartiYon, ref YeksiYon);
                return yonler[yonIndis] = true;
            }
            else if (yonler[XeksiYon] == true) //XeksiYon
            {
                yonIndis = ozelKontrol(ref YeksiYon, ref YartiYon);
                return yonler[yonIndis] = true;
            }
            return false;
        }
        //arac geri don komutu aldığında yonBul metodunda tutulan yon indisine göre o yönün tersini döndürüyor
        public bool geriDon(int Indis)
        {
            if (Indis == YeksiYon)
            {
                defaultYap();
                return yonler[YartiYon] = true;
            }
            else if (Indis == YartiYon)
            {
                defaultYap();
                return yonler[YeksiYon] = true;
            }
            else if (Indis == XartiYon)
            {
                defaultYap();
                return yonler[XeksiYon] = true;
            }
            else if (Indis == XeksiYon)
            {
                defaultYap();
                return yonler[XartiYon] = true;
            }
            return false;
        }
        //ozelKontol metodu yonuBul() methodunda her yön için sağa ve sola döndüğünde oluşacak yön indisini buluyor
        private int ozelKontrol(ref int sagYon, ref int solYon)
        {
            if (sagSol == true) //true ise sağ
            {
                defaultYap();
                return sagYon;
            }
            else if (sagSol == false) //false ise sol
            {
                defaultYap();
                return solYon;
            }
            return -1;
        }
        // sağ yönünde ilerleme
        private int[,] ArtigoX(int x, int firca)
        {
            for (int i = aracY; i < x + aracY; i++)
            {
                Matris[aracX, i] = firca;
            }
            return Matris;
        }
        //aşağı yönde ilerleme için
        private int[,] goArtiY(int x, int firca)
        {
            for (int i = aracX; i < aracX + x; i++)
            {
                Matris[i, aracY] = firca;
            }
            return Matris;
        }
        //yukarı yönde ilerleme
        private int[,] goEksiY(int x, int firca)
        {
            for (int i = aracX; aracX - x < i; i--)
            {
                Matris[i, aracY] = firca;
            }
            return Matris;
        }
        //sol yönde ilerleme
        private int[,] goEksiX(int x, int firca)
        {
            for (int i = aracY; aracY - x < i; i--)
            {
                Matris[aracX, i] = firca;
            }
            return Matris;
        }
        //5_x komutu, 4 farklı yön için var olan yöne göre ilerleme methodunu çalıştırır.
        //fırca parametresi, fırca komutuna göre matrise 1 ve ya 0 atar
        public void Bes_X(int x)
        {
            if (yonler[YartiYon] == true) //YartiYon 
            {
                yArtiTasmaDurumu(x, firca);
            }
            else if (yonler[XartiYon] == true) //XartiYon
            {
                xArtiTasmaDurumu(x, firca);
            }
            else if (yonler[YeksiYon] == true) //YeksiYon
            {
                yEksiTasmaDurumu(x, firca);
            }
            else if (yonler[XeksiYon] == true) //XeksiYon
            {
                xEksiTasmaDurumu(x, firca);
            }
        }
        //  aşağı yönünde  ilerlerken taşma durumunu kontrol ederek ilerlemek
        private int[,] yArtiTasmaDurumu(int x, int firca)
        {
            if (Boyut >= x + aracX)
            {
                goArtiY(x, firca);
                aracX += x;
            }
            else
            {
                goArtiY((Boyut - aracX), firca);
                goArtiY((aracX + x % Boyut - Boyut), firca);
                aracX = ((x % Boyut));
            }
            return Matris;
        }
        //  sağ yönünde  ilerlerken taşma durumunu kontrol ederek ilerlemek
        private int[,] xArtiTasmaDurumu(int x, int firca)
        {
            if (Boyut >= x + aracY)
            {
                ArtigoX(x, firca);
                aracY += x;
            }
            else
            {

                ArtigoX((Boyut - aracY) , firca);
                ArtigoX((aracY + x%Boyut - Boyut) , firca);
                aracY = ((x%Boyut));
            }
            return Matris;
        } //Tamam
        //  yukarı yönünde  ilerlerken taşma durumunu kontrol ederek ilerlemek
        private int[,] yEksiTasmaDurumu(int x, int firca)
        {
            if (0 <= aracX - x)
            {
                goEksiY(x, firca);
                aracX -= x;
            }
            else
            {
                goEksiY(aracX, firca);
                int temp = Boyut - aracX;
                aracX = Boyut - 1;
                goEksiY(temp, firca);
                aracX = ((x % Boyut));

            }
            return Matris;
        } //Tamam
        //  sol yönünde  ilerlerken taşma durumunu kontrol ederek ilerlemek
        private int[,] xEksiTasmaDurumu(int x, int firca)
        {
            if (0 <= aracY - x)
            {
                goEksiX(x, firca);
                aracY -= x;
            }
            else
            {
                goEksiX(aracY, firca);
                int temp = Boyut - aracY;
                aracY = Boyut - 1;
                goEksiX(temp, firca);
                aracY = ((x % Boyut));
            }
            return Matris;
        } //Tamam
        //komut 8, Aracın matris üzerindeki hareketini * olarak görüntüler.
        public void Display()
        {
            for (int i = 0; i < Matris.GetLength(0); i++)
            {
                for (int j = 0; j < Matris.GetLength(1); j++)
                {
                    if (Matris[i, j] == 1)
                        Console.Write("*" + " | ");
                    else
                        Console.Write("0" + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
