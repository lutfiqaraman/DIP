using System;

namespace dipproject
{
  class Program
  {
    static void Main(string[] args)
    {
      Mammal cat = new Mammal(new CatNoise());
      Mammal dog = new Mammal(new DogNoise());

      Console.WriteLine("Cat says " + cat.makeNoise());
      Console.WriteLine("Dog says " + dog.makeNoise());
    }
  }
}
