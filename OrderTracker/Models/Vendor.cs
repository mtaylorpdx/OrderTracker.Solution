using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName {get;set;}
    public int Id {get;}
    public List<Order> Orders {get;set;}

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
  }
}