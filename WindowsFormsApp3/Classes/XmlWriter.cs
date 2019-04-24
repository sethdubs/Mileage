using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Mileage
{
   class XmlWriter
   {


      public void writeTripToFile(string path, Trip trip)
      {
         List<XElement> elements = new List<XElement>();
         XElement[] eles1 = new XElement[4];
         eles1[0] = new XElement("Name", trip.tripName);
         List<XElement> eles2 = new List<XElement>();
         foreach (Location l in trip.locations)
         {
            eles2.Add(new XElement("Location", l.locationName));
         }



      }
      public static void writeLocationToFile(Location loc)
      {
         List<Location> locations = XmlReader.readLocationData();

         locations.Add(loc);
         List<XElement> locEles = new List<XElement>();
         foreach (Location l in locations)
         {
            XElement[] locData = new XElement[4];
            locData[0] = new XElement("name", l.locationName);
            locData[1] = new XElement("address", l.address);
            locEles.Add(new XElement("location", locData));
         }
         new XDocument(new XElement("locations", locEles.ToArray())).Save(@"Data\Location.xml");

      }
      public static void writeNameToFile(string name)
      {
         var xml = XDocument.Load("SavedNames.xml");

         var query = from c in xml.Root.Descendants("Names")
                     select c.Element("Name");


         List<string> names = new List<string>();
         foreach (string element in query)
         {
            names.Add(element.Trim().ToLower());
         }

         if (names.Contains(name.Trim().ToLower()))
         {
            MessageBox.Show("That name already exists.", "Name exists", MessageBoxButtons.OK);
         }
         else
         {
            names.Add(name);

            List<XElement> eles = new List<XElement>();
            foreach (string s in names)
            {
               eles.Add(new XElement("name", s));
            }
            XDocument doc = new XDocument(new XElement("Names", eles));

         }
      }
   }
}
