using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Maps;
using Google.Maps.DistanceMatrix;
using System.Xml.Linq;
using System.Net;
using System.IO;

namespace Mileage
{
   class Distance
   {
      private static string apiKey = "AIzaSyADgNCkN_--EY_sXPjZTO2gmdE4XSGPt4I";

      public static int GetDistance(List<string> locations)
      {
         int distance = 0;

         GoogleSigned.AssignAllServices(new GoogleSigned(apiKey));

         var request = new DistanceMatrixRequest();
         foreach (string s in locations)
         {
            request.AddOrigin(new Google.Maps.Location(s));
            request.AddDestination(new Google.Maps.Location(s));
         }
         request.Units = Units.imperial;

         var response = new DistanceMatrixService().GetResponse(request);

         if (response.Status == ServiceResponseStatus.Ok && response.Rows.Count() > 0)
         {
            for (int i = 0; i < response.Rows.Length - 1; i++)
            {
               distance += (int)response.Rows[i].Elements[i + 1].distance.Value;
            }
         }

         return distance;
      }

   }
}
