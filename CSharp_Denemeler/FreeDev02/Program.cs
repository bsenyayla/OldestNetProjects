

using FreeDev02.SoyutSinif;
using FreeDev02.VirtualSample;

namespace FreeDev02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car objCar= new Car();
            objCar.Model = "tst";
            objCar.Color = "Black";
            objCar.Drive();

            Utils.Msg("--> Soyut Sinif Ornegi");

            SoyutSinif.Animal objCat = new SoyutSinif.Cat();
            SoyutSinif.Animal objDog = new SoyutSinif.Dog();


            objCat.MakeSound();
            objDog.MakeSound();




            Utils.Msg("--> Sorted List Sample");
            SortedListSample fncSortedList =new SortedListSample();


            Utils.Msg("--> Virtual and Overide  Kullanimi");
            VirtualSample.Animal myAnimal= new VirtualSample.Animal();
            VirtualSample.Animal myDog= new VirtualSample.Dog();
            VirtualSample.Animal myHorse = new VirtualSample.Horse();


            myAnimal.MakeSound();
            myDog.MakeSound();
            myHorse.MakeSound();

            Console.ReadLine();
        }
    }
}