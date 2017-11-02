using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dog dog2 = new Dog();
            //Console.WriteLine("Sisesta koera nimi: ");
            //dog2.Name = Console.ReadLine();
            //Console.WriteLine("Sisesta koera värv: ");
            //dog2.Color = Console.ReadLine();
            //Console.WriteLine("Sisesta koera vanus: ");
            //dog2.Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Koera värv: " + dog2.Color);
            //Console.WriteLine("Koera vanus: " + dog2.Age);
            //Console.WriteLine("Koera nimi: " + dog2.Name);

            Dog dog1 = new Dog();
            dog1.SetAge(7);
            dog1.Color = "Red";
            dog1.Name = "Muki";

            Console.WriteLine("Koera värv: " + dog1.Color);
            Console.WriteLine("Koera vanus: " + dog1.RealYears);
            Console.WriteLine("Koera nimi: " + dog1.Name);

           

            Dog dog3 = new Dog();
            dog3.NumberOfEyes = 3;
            Console.WriteLine(dog3.Name);
            Console.WriteLine(dog3.RealYears);
            Console.WriteLine(dog3.Color);
            Console.WriteLine("Silmade arv: " +dog3.NumberOfEyes);
            Console.WriteLine(dog3.IsCarnivore);
            dog3.Bark();
            Console.WriteLine("Koera tegelik vanus: " + dog3.CalculateDogYears());

            


        }
    }
}
