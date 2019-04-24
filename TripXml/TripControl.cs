using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Mileage
{
   public class TripControl
   {

      public void WriteTripToXml(Trip t, string path)
      {
         XDocument xml;
         if (File.Exists(path))
         {
            xml = XDocument.Load(path);
            xml.Element("trips").Add(t.getTripXElement());
         }
         else
         {
            xml = new XDocument();
            xml.Add(new XElement("trips", t.getTripXElement()));
         }

         xml.Save(path);
      }

      public List<Trip> getTrips(string path)
      {
         List<Trip> t = new List<Trip>();

         XDocument xml = XDocument.Load(path);

         foreach (XElement e in xml.Elements("trip"))
         {
            string name = e.Element("tripName").Value;
            List<Location> locations = new List<Location>();
            string distance = e.Element("distance").Value;
            string description = e.Element("description").Value;

            foreach (XElement loc in e.Element("locations").Elements("location"))
            {
               locations.Add(new Location(loc.Element("locationName").Value, loc.Element("address").Value));
            }
            t.Add(new Trip(name, locations.ToArray(), distance, description));
         }
         return t;
      }





   }
}
