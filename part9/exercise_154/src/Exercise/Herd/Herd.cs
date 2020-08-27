namespace Exercise
{
  using System.Collections.Generic;
  public class Herd : IMovable
  {
    private List<IMovable> herd;
    public Herd()
    {
      this.herd = new List<IMovable>();
    }

    public void AddToHerd(IMovable m)
    {
      this.herd.Add(m);
    }

    public void Move(int dx, int dy)
    {
      foreach (IMovable herd in herd)
      {
        herd.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      string herdPosition = "";
      foreach (IMovable herd in herd)
      {
        herdPosition += herd.ToString() + "\n";
      }
      return herdPosition;
    }
  }
}