﻿using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {    
        string userinput = Console.ReadLine();
        
        if (userinput == "")
        {
          break;
        }
        string[] parts = userinput.Split(" ");
        {
          Console.WriteLine(parts[0]);
        } 
        
      }
      
    }
  }
}



