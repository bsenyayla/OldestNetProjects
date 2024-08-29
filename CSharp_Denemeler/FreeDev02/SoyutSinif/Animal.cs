using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02.SoyutSinif
{
    internal abstract class Animal
    {
        public abstract void MakeSound();

        public void Eat() {
            Console.WriteLine("hayvan yemek yiyor.");
        }
    }
}


/*
 
     public abstract void MakeSound();

    // Ortak bir metod: Tüm hayvanlar için ortak bir işlev
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
 */