namespace Exercise
{
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    private List<Item> box;
    public MisplacingBox()
    {
      this.box = new List<Item>();
    }

    public override void Add(Item item)
    {
      this.box.Add(item);
    }


    public override bool IsInBox(Item item)
    {
      return false; 
    }
  }
}