using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Mileage
{
   public static class TripControl
   {

      public static void WriteTripToXml(Trip t, string path)
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

      public static List<Trip> getTrips(string path)
      {
         List<Trip> t = new List<Trip>();

         XDocument xml = XDocument.Load(path);

         foreach (XElement e in xml.Element("trips").Elements("trip"))
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

      public static List<Location> getLocations(string path)
      {
         List<Location> L = new List<Location>();

         XDocument xml = XDocument.Load(path);

         foreach (XElement e in xml.Element("locations").Elements("location"))
         {
            L.Add(new Location(e.Element("locationName").Value, e.Element("address").Value, e.Element("locationCode").Value));
         }
         return L;
      }

      public static void WriteLocationToXml(Location l, string path)
      {
         XDocument xml;
         if (File.Exists(path))
         {
            xml = XDocument.Load(path);
            xml.Element("locations").Add(l.getLocationXElement());
         }
         else
         {
            xml = new XDocument();
            xml.Add(new XElement(l.getLocationXElement()));
         }

         xml.Save(path);
      }

      public static void RemoveLocation(Location l, string path)
      {
         XDocument xml;

         xml = XDocument.Load(path);
         foreach (XElement e in xml.Element("locations").Elements("location"))
         {
            if (e.Element("locationName").Value == l.locationName)
            {
               e.Remove();
            }
         }

         xml.Save(path);
      }
      public static void UpdateLocation(Location l, string path)
      {
         XDocument xml;

         xml = XDocument.Load(path);
         foreach (XElement e in xml.Element("locations").Elements("location"))
         {
            if (e.Element("locationName").Value == l.locationName)
            {
               e.Element("address").Value = l.address;
               e.Element("locationCode").Value = l.locationCode;
            }
         }

         xml.Save(path);
      }



   }
}
