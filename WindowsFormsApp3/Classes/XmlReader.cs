using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
namespace Mileage
{
   class XmlReader
   {
      public static List<Location> readLocationData()
      {
         List<Location> locations = new List<Location>();
         if (File.Exists(@"Data\Location.xml"))
         {
            var xml = XDocument.Load(@"Data\Location.xml");
            var query = from c in xml.Root.Descendants("location")
                        select c.Element("locationName").Value + ";" +
                               c.Element("address").Value + ";" +
                               c.Element("locationCode").Value;


            foreach (string element in query)
            {
               string[] values = element.Split(';');
               Location location = new Location(values[0], values[1], values[2]);
               locations.Add(location);
            }
         }
         return locations;
      }
   }
}

