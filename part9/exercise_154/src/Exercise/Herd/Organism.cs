namespace Exercise
{
  public class Organism : IMovable
  {
    private int x;
    private int y;
    public Organism(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(int dx, int dy)
    {
      this.x = dx + this.x;
      this.y = dy + this.y;
    }

    public override string ToString()
    {
      return "x: " + this.x + "; y: " + this.y;
    }
  }
}