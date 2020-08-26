using System;
using System.Collections.Generic;
namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> iou; 
    public IOU()
    {
      this.iou = new Dictionary<string, int>();
    }
    public void ChangeDebt(string toWhom, int amount)
    {
      if(this.iou.ContainsKey(toWhom))
      {
        int newAmount = this.iou[toWhom] + amount;
        if(newAmount > 0)
        {
          this.iou[toWhom] = newAmount;
        }
        else
        {
          this.iou[toWhom] = 0;
        }
      }
      else if(amount > 0)
      {
        this.iou[toWhom] = amount;
      }
      else
      {
        this.iou[toWhom] = 0;
      }
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
      if(this.iou.ContainsKey(toWhom))
      {
        return this.iou[toWhom];
      }
      return 0;
      
      
    }
  }
}
