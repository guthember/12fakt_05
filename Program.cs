using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Random vel = new Random(); ez is tökéletesen jó!
      Random vel = new Random(Guid.NewGuid().GetHashCode());
      // 10 elemű egészeket tartalmazó tömb
      int[] tomb = new int[10]; // 0..9 indexek

      // tömb feltöltése
      for (int i = 0; i < tomb.Length; i++)
      {
        tomb[i] = vel.Next(1, 101); // [1..100]
        Console.WriteLine("{0}. indexű eleme: {1}",i,tomb[i]);
      }

      // Összegzés
      // tömb elemeinek összegét ( sok elem -> egy érték )
      int osszeg = 0; // amiben tároljuk és kezdőérték beállítása

      for (int i = 0; i < tomb.Length; i++)
      {
        // osszeg = osszeg + tomb[i];
        osszeg += tomb[i];
      }

      Console.WriteLine("\nAz elemek összege: {0}",osszeg);
      // Console.ReadKey(); // egy billentyű lenyomására vár
      Console.ReadLine(); // "Enter" lenyomásáig vár
    }
  }
}
