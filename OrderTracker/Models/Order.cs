using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Date {get;set;}
    public int breadCount {get;set;}
    public int pastryCount {get;set;}
    public int Total {get;set;}
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};

    public Order (string date, int breadCount, int pastryCount, int total)
    {
      Date = date;
      BreadCount = breadCount;
      pastryCount = pastryCount;
      Total = total;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}