using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Cat gizmo = new Cat("Gizmo Cat");
      Console.WriteLine(gizmo);

      Cat Cat = gizmo;
      Cat.GrowOlder(4);
      Console.WriteLine(gizmo);

      Cat Malva= new Cat("Malva");
      Console.WriteLine(Malva);

      Malva = null;
      Malva.GrowOlder(5);
      Console.WriteLine(Malva);
    }
  }
}
