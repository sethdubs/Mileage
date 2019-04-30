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

namespace Mileage.Forms
{
   public partial class frmName : Form
   {
      public string TripName { get; set; }
      public string Description { get; set; }
      public frmName()
      {

         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
         if (textBoxTripName.Text != String.Empty && richTextBoxDescription.Text != String.Empty)
         {
            TripName = textBoxTripName.Text;
            Description = richTextBoxDescription.Text;
            this.Close();
         }
         else
         {
            MessageBox.Show("Please enter a name and description for the trip.", "Empty Field", MessageBoxButtons.OK);
         }

      }

      private void button2_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         this.Close();
      }
   }
}
