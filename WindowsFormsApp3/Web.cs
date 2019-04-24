using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Google.Maps;
using Google.Maps.DistanceMatrix;
namespace Mileage
{
   class Web
   {
      private static string apiKey = "AIzaSyADgNCkN_--EY_sXPjZTO2gmdE4XSGPt4I";

      //public static string[] getAutoComplete(string url)
      //{

      //   var xmlResponse = getResponse(url);

      //   var query = from c in xmlResponse.Root.Descendants("prediction")
      //               select c.Element("description").Value + ";" +
      //                      c.Element("place_id").Value;


      //   foreach (string element in query)
      //   {
      //      string[] values = element.Split(';');

      //      string zipurl = String.Format(@"https://maps.googleapis.com/maps/api/place/details/xml?language=en&fields=formatted_address&place_id={0}&key={1}", values[1], apiKey);

      //      var zipResponse = getResponse(zipurl);

      //      var zipQuery = from ele in zipResponse.Root.Descendants("result")
      //                     select ele.Element("formatted_address").Value;

      //      string address = zipQuery.ElementAt(0);
      //      address = address.Substring(0, address.LastIndexOf(','));
      //      list.Add(address);


      //   }
      //   return list.ToArray();
      //}

      private static XDocument getResponse(string url)
      {
         WebRequest request = WebRequest.Create(url);
         WebResponse response = request.GetResponse();
         Stream data = response.GetResponseStream();
         StreamReader reader = new StreamReader(data);

         string serverResponse = reader.ReadToEnd();

         var xmlResponse = XDocument.Parse(serverResponse);

         return xmlResponse;
      }

   }


}
