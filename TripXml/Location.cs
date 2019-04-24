using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripXml
{

   public class Location
   {
      public string locationName;
      public string address;

      public Location(string name, string addr)
      {
         locationName = name;
         address = addr;
      }
   }
}
