using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Date {get;set;}
    public int BreadCount {get;set;}
    public int PastryCount {get;set;}
    public int Total {get;set;} = 0;
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};

    public Order (string date, int breadCount, int pastryCount)
    {
      Date = date;
      BreadCount = breadCount;
      PastryCount = pastryCount;
      Total = GetTotal();
      _instances.Add(this);
      Id = _instances.Count;
    }

    public int GetTotal()
    {
      int total = ((BreadCount * 2) + (PastryCount * 1));
      return total;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}