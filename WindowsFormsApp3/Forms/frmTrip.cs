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
      ComboBox[] boxes = new ComboBox[6];
      public frmTrip()
      {
         InitializeComponent();

         boxes[0] = comboBox1;
         boxes[1] = comboBox2;
         boxes[2] = comboBox3;
         boxes[3] = comboBox4;
         boxes[4] = comboBox5;
         boxes[5] = comboBox6;


         updateComboBox();

      }

      private void buttonAddLocation_Click(object sender, EventArgs e)
      {

         Form frmloc = new frmLocation();
         frmloc.ShowDialog();
         updateComboBox();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var nameForm = new Forms.frmName();


         DialogResult res = nameForm.ShowDialog();
         if (res == DialogResult.OK)
         {

            string tname = nameForm.TripName;
            string tdesc = nameForm.Description;
            List<string> lnames = new List<string>();
            List<Location> locations = new List<Location>();

            foreach (ComboBox b in boxes)
            {
               if (b.Enabled && (b.Text != String.Empty || b.Text != null))
               {
                  lnames.Add(b.Text);
               }
            }
            List<Location> lSaved = TripControl.getLocations(@"data\Location.xml");
            foreach (Location sav in lSaved)
            {
               if (lnames.Contains(sav.locationName))
               {
                  locations.Add(sav);
               }
            }
            this.Close();
         }

      }

      private void updateComboBox()
      {
         List<Location> locations = TripControl.getLocations(@"data\Location.xml");
         List<object> names = new List<object>();

         foreach (Location l in locations)
         {
            names.Add(l.locationName);
         }

         foreach (ComboBox b in boxes)
         {
            int ind = b.SelectedIndex;
            b.Items.Clear();
            b.Items.AddRange(names.ToArray());
            if (ind >= 0)
            {
               b.SelectedIndex = ind;
               b.Text = b.Items[ind].ToString();
            }
         }

      }

      private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
      {


         ComboBox box = (ComboBox)sender;
         if (box.SelectedIndex >= 0)
         {
            string name = (string)box.Items[box.SelectedIndex];
            List<Location> locations = TripControl.getLocations(@"data\Location.xml");
            foreach (Location l in locations)
            {
               if (l.locationName == name)
               {
                  getAssociatedLabel(box).Text = l.address;
               }
            }
         }
      }


      private Label getAssociatedLabel(ComboBox box)
      {
         switch (box.Name)
         {
            case "comboBox1":
               return labelAddress1;
            case "comboBox2":
               return labelAddress2;
            case "comboBox3":
               return labelAddress3;
            case "comboBox4":
               return labelAddress4;
            case "comboBox5":
               return labelAddress5;
            case "comboBox6":
               return labelAddress6;
         }
         return null;
      }

      private ComboBox getAssociatedCombo(CheckBox c)
      {
         switch (c.Name)
         {
            case "checkBox1":
               return comboBox1;
            case "checkBox2":
               return comboBox2;
            case "checkBox3":
               return comboBox3;
            case "checkBox4":
               return comboBox4;
            case "checkBox5":
               return comboBox5;
            case "checkBox6":
               return comboBox6;
         }
         return null;
      }

      private void frmTrip_Load(object sender, EventArgs e)
      {

      }

      private void checkBox_CheckedChanged(object sender, EventArgs e)
      {
         CheckBox c = (CheckBox)sender;
         ComboBox b = getAssociatedCombo(c);
         Label label = getAssociatedLabel(b);

         bool state = c.Checked;

         b.Enabled = state;
         label.Enabled = state;
      }
   }
}
