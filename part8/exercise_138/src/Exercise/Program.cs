using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Do something here
      Dictionary< string , string > name = new Dictionary<string, string>();

      name.Add("matthew", "matt");
      name.Add("michael", "mix");
      name.Add("arthur", "artie");
      

      foreach (KeyValuePair<string, string> kvp in name)
      {
        Console.WriteLine(kvp.Key + "'s nickname is " + kvp.Value);
      }
    }
  }
}