using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    Dictionary<string, string> Abr;
    public Abbreviations()
    {
      this.Abr = new Dictionary<string, string>();
    }
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      Abr.Add(abbreviation, explanation); 
    }

    public bool HasAbbreviation(string abbreviation)
    {
      if(this.Abr.ContainsKey(abbreviation))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string FindExplanationFor(string abbreviation)
    {
      if(!HasAbbreviation(abbreviation))
      {
        return "not found";
      }
      else
      {
        return this.Abr[abbreviation];
      }
      
    }
  }
}