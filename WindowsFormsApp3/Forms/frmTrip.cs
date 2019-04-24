using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mileage
{
   public partial class frmTrip : Form
   {
      string curdir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
      public frmTrip()
      {
         InitializeComponent();

         updateComboBox();

         comboBox1.DataSource = bindingSourceLocations;
         comboBox1.DisplayMember = "locationName";

      }

      private void buttonAddLocation_Click(object sender, EventArgs e)
      {

         Form frmloc = new frmLocation();
         frmloc.ShowDialog();
         updateComboBox();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void updateComboBox()
      {
         dataSetLocations = new DataSet();
         dataSetLocations.ReadXml(String.Format(@"{0}\Data\Location.xml", curdir));
         dataSetLocations.ReadXmlSchema(String.Format(@"{0}\Data\LocationSchema.xml", curdir));

         bindingSourceLocations = new BindingSource();
         bindingSourceLocations.DataSource = dataSetLocations;
         bindingSourceLocations.DataMember = "location";

         int index = comboBox1.SelectedIndex;

         comboBox1.DataSource = null;
         comboBox1.DataSource = bindingSourceLocations;
         comboBox1.DisplayMember = "locationName";
         comboBox1.SelectedIndex = index;
      }

      private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
      {
         if (comboBox1.SelectedIndex >= 0)
         {
            DataRowView row = (DataRowView)comboBox1.Items[comboBox1.SelectedIndex];
            string selected = row.Row.ItemArray[0].ToString();
            List<Location> locations = XmlReader.readLocationData();
            foreach (Location l in locations)
            {
               if (l.locationName == selected)
               {
                  labelAddress.Text = l.address;
               }
            }
         }
      }
   }
}
