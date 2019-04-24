using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mileage
{
   public class Trip
   {
      public string tripName;
      public Location[] locations;
      public string distance;
      public string description;

      public Trip(string name, Location[] locs, string dist, string desc)
      {
         tripName = name;
         locations = locs;
         distance = dist;
         description = desc;
      }

      public XElement getTripXElement()
      {
         XElement[] locs = new XElement[locations.Length];
         for (int i = 0; i < locations.Length; i++)
         {
            XElement[] locationInfo = new XElement[2];
            Location l = locations[i];
            locationInfo[0] = new XElement("locationName", l.locationName);
            locationInfo[1] = new XElement("address", l.address);

            locs[i] = new XElement("location", locationInfo);
         }

         XElement[] trip = new XElement[4];
         trip[0] = new XElement("tripName", tripName);
         trip[1] = new XElement("locations", locs);
         trip[2] = new XElement("distance", distance);
         trip[3] = new XElement("description", description);

         return new XElement("trip", trip);
      }
   }
}
