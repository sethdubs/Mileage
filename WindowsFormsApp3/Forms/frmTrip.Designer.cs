namespace Mileage
{
   partial class frmTrip
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.bindingSourceLocations = new System.Windows.Forms.BindingSource(this.components);
         this.dataSetLocations = new System.Data.DataSet();
         this.label1 = new System.Windows.Forms.Label();
         this.buttonAddLocation = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.labelAddress = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).BeginInit();
         this.SuspendLayout();
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(97, 8);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(194, 21);
         this.comboBox1.TabIndex = 0;
         this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // bindingSourceLocations
         // 
         this.bindingSourceLocations.AllowNew = true;
         this.bindingSourceLocations.DataSource = this.dataSetLocations;
         this.bindingSourceLocations.Position = 0;
         // 
         // dataSetLocations
         // 
         this.dataSetLocations.DataSetName = "Location";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "Location 1";
         // 
         // buttonAddLocation
         // 
         this.buttonAddLocation.Location = new System.Drawing.Point(364, 340);
         this.buttonAddLocation.Name = "buttonAddLocation";
         this.buttonAddLocation.Size = new System.Drawing.Size(123, 46);
         this.buttonAddLocation.TabIndex = 2;
         this.buttonAddLocation.Text = "Add New Location";
         this.buttonAddLocation.UseVisualStyleBackColor = true;
         this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(364, 392);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(123, 46);
         this.button1.TabIndex = 3;
         this.button1.Text = "Save Trip";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(63, 54);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(145, 23);
         this.button2.TabIndex = 4;
         this.button2.Text = "Additional Location";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // labelAddress
         // 
         this.labelAddress.AutoSize = true;
         this.labelAddress.Location = new System.Drawing.Point(297, 12);
         this.labelAddress.Name = "labelAddress";
         this.labelAddress.Size = new System.Drawing.Size(35, 13);
         this.labelAddress.TabIndex = 5;
         this.labelAddress.Text = "label2";
         // 
         // frmTrip
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(611, 450);
         this.Controls.Add(this.labelAddress);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.buttonAddLocation);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.comboBox1);
         this.Name = "frmTrip";
         this.Text = "frmTrip";
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.BindingSource bindingSourceLocations;
      private System.Data.DataSet dataSetLocations;
      private System.Windows.Forms.Button buttonAddLocation;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label labelAddress;
   }
}