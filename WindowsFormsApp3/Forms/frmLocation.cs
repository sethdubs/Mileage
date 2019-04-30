using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Google.Maps;
using Google.Maps.DistanceMatrix;
using System.Xml.Linq;


namespace Mileage
{
   public partial class frmLocation : Form
   {
      public frmLocation()
      {
         InitializeComponent();
         AutoCompleteStringCollection src = new AutoCompleteStringCollection();
         StreamReader file = new StreamReader(@"E:\Tennessee\addresses.txt");
         string line;
         while ((line = file.ReadLine()) != null)
         {
            src.Add(line);
         }

         textBoxAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
         textBoxAddress.AutoCompleteSource = AutoCompleteSource.CustomSource;
         textBoxAddress.AutoCompleteCustomSource = src;
      }

      private void buttonSaveLocation_Click(object sender, EventArgs e)
      {
         string name = textBoxName.Text;
         string address = textBoxAddress.Text;
         string locationCode = textBoxLocationCode.Text;

         TripControl.WriteLocationToXml(new Location(name, address, locationCode), @"data\Location.xml");
         this.Close();
      }
   }


}
