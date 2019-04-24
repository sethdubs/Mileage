using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mileage
{

   public class Location
   {
      public string locationName;
      public string address;
      public string locationCode;

      public Location(string name, string addr, string code)
      {
         locationName = name;
         address = addr;
         locationCode = locationCode = code;
      }
      public Location(string name, string addr)
      {
         locationName = name;
         address = addr;
      }

      public XElement getLocationXElement()
      {
         XElement[] locInfo = new XElement[3];

         locInfo[0] = new XElement("locationName", locationName);
         locInfo[1] = new XElement("address", address);
         locInfo[2] = new XElement("locationCode", locationCode);

         return new XElement("location", locInfo);
      }
   }
}
