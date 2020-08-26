using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    private Dictionary<string, List<string>> translation;

    public DictionaryOfManyTranslations()
    {
      this.translation = new Dictionary<string, List<string>>(); 
    }
    public void Add(string word, string translation)
    {
      if (!this.translation.ContainsKey(word))
      {
        this.translation.Add(word, new List<string>());
      }
      this.translation[word].Add(translation);
    }

    public List<string> Translate(string word)
    {
    
    if (!this.translation.ContainsKey(word))
    {
      this.translation.Add(word, new List<string>());
    }
    return this.translation[word];
    }
    public void Remove(string word)
    {
      if (this.translation.ContainsKey(word))
      {
        this.translation.Remove(word);
      }
     
    }
  }
}