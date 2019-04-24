using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * [STAThread]
 * public static void Main()
 * {
 *     var settings = new CefSettings();
 *     settings.BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe";
 * 
 *     Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
 * 
 *     var browser = new BrowserForm();
 *     Application.Run(browser);
 * }
 */

namespace Mileage
{
   public partial class Form1 : Form
   {
      List<Trip> trips;
      List<Location> locations;
      bool getSavedLocation = false;
      public Form1()
      {
         InitializeComponent();

         trips = TripControl.getTrips(@"data\Trips.xml");
         locations = TripControl.getLocations(@"data\Location.xml");

         dataSetTrips.ReadXml(@"data\Trips.xml");
         dataSetTrips.ReadXmlSchema(@"data\TripsSchema.xml");
         bindingSourceTrips.DataSource = dataSetTrips;
         bindingSourceTrips.DataMember = "trip";

         listBoxTrips.DataSource = bindingSourceTrips;
         listBoxTrips.DisplayMember = "tripName";

         dataSetLocations.ReadXml(@"data\Location.xml");
         dataSetLocations.ReadXmlSchema(@"data\LocationSchema.xml");
         bindingSourceLocations.DataSource = dataSetLocations;
         bindingSourceLocations.DataMember = "location";
         getSavedLocation = true;
         listBoxSavedLocations.DataSource = bindingSourceLocations;
         listBoxSavedLocations.DisplayMember = "locationName";




         labelDescription.MaximumSize = new Size(panelTripDetails.Width - 10, 0);
      }

      private void buttonAddNew_Click(object sender, EventArgs e)
      {
         //Form frmloc = new frmLocation();
         //frmloc.ShowDialog();

         Form frmTrip = new frmTrip();
         frmTrip.ShowDialog();

      }

      private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
      {

      }

      private void listBoxTrips_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listBoxTrips.SelectedIndex >= 0)
         {
            DataRow row = ((DataRowView)listBoxTrips.SelectedItem).Row;
            string n = row.ItemArray[0].ToString();
            foreach (Trip t in trips)
            {
               if (t.tripName == n)
               {
                  listBoxLocations.Items.Clear();
                  //listBoxLocations.Items.Add("-----------------------------------Trip Addresses-----------------------------------");
                  foreach (Location l in t.locations)
                  {
                     listBoxLocations.Items.Add(l.address);
                  }
                  labelDistance.Text = "Distance: " + t.distance + " miles";
                  labelDescription.Text = "Description: " + t.description;
               }
            }
         }
      }

      private void listBoxSavedLocations_SelectedIndexChanged(object sender, EventArgs e)
      {

         if (listBoxSavedLocations.SelectedIndex >= 0)
         {
            if (getSavedLocation)
            {
               var view = listBoxSavedLocations.SelectedItem;
               DataRow row = ((DataRowView)view).Row;
               //DataRow row = ((DataRowView)listBoxSavedLocations.SelectedItem).Row;
               string n = row.ItemArray[0].ToString();
               foreach (Location l in locations)
               {
                  if (l.locationName == n)
                  {
                     labelSavedAddress.Text = l.address;
                     labelSavedCode.Text = l.locationCode;
                  }
               }
            }
         }
      }

      private void buttonSaveLocation_Click(object sender, EventArgs e)
      {

      }
   }
}
