using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Date {get;set;}
    public int BreadCount {get;set;}
    public int PastryCount {get;set;}
    public int Total {get;set;}
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};

    public Order (string date, int breadCount, int pastryCount, int total)
    {
      Date = date;
      BreadCount = breadCount;
      PastryCount = pastryCount;
      Total = total;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}