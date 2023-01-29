using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    interface ISiralama
    {
        int SonrakiSayi();
        void Sifirla();
        void Ayarla(int a);
    }

    interface IBoyut
    {
        void En();
        void Boy();
    }


    class BeserBeser : ISiralama,IBoyut {
        int deger;
        int baslangic;
        int Onceki;

        public BeserBeser(){
            deger=0;
            baslangic = 0;
        }

        public int SonrakiSayi() {
            deger += 5;
            return deger;
        }

        public void Sifirla()
        {
            deger = baslangic;
        }

        public void Ayarla(int a) {
            baslangic = 0;
            deger = baslangic;
        }

        public int OncekiSayi() {
            return Onceki;
        }

        public void En() { 
        
        }


        public void Boy()
        {

        }

        public string ReplaceExt(string fullText,string oldString, string newString) {
            int bb=fullText.IndexOf(oldString);

            string ilkKisim=fullText.Substring(0, bb);

            string sonuc = ilkKisim + newString;

            int baslangic = bb + oldString.Length ;
            int uzunluk = fullText.Length - baslangic;

            string ikinciKisim = fullText.Substring(baslangic, uzunluk);

            sonuc += ikinciKisim;
            return sonuc;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            BeserBeser nesne = new BeserBeser();
            
            Console.WriteLine( nesne.ReplaceExt("My name is Helluri","is","hacı"));

            Console.ReadLine();
        }
    }
}
