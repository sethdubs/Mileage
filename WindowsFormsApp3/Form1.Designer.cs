namespace Mileage
{
   partial class Form1
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
         this.bindingSourceTrips = new System.Windows.Forms.BindingSource(this.components);
         this.dataSetTrips = new System.Data.DataSet();
         this.buttonEdit = new System.Windows.Forms.Button();
         this.buttonRemove = new System.Windows.Forms.Button();
         this.buttonAddNew = new System.Windows.Forms.Button();
         this.listBoxTrips = new System.Windows.Forms.ListBox();
         this.listBoxLocations = new System.Windows.Forms.ListBox();
         this.labelDistance = new System.Windows.Forms.Label();
         this.labelDescription = new System.Windows.Forms.Label();
         this.panelbottom = new System.Windows.Forms.Panel();
         this.buttonRemoveLocation = new System.Windows.Forms.Button();
         this.listBoxSavedLocations = new System.Windows.Forms.ListBox();
         this.bindingSourceLocations = new System.Windows.Forms.BindingSource(this.components);
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.buttonSaveLocation = new System.Windows.Forms.Button();
         this.textBoxLocationCode = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBoxAddress = new System.Windows.Forms.TextBox();
         this.buttonEnterTrip = new System.Windows.Forms.Button();
         this.panelTripDetails = new System.Windows.Forms.Panel();
         this.dataSetLocations = new System.Data.DataSet();
         this.buttonEditLocation = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.labelSavedAddress = new System.Windows.Forms.Label();
         this.labelSavedCode = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrips)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetTrips)).BeginInit();
         this.panelbottom.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).BeginInit();
         this.panelTripDetails.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).BeginInit();
         this.SuspendLayout();
         // 
         // bindingSourceTrips
         // 
         this.bindingSourceTrips.DataMember = "trip";
         // 
         // dataSetTrips
         // 
         this.dataSetTrips.DataSetName = "NewDataSet";
         // 
         // buttonEdit
         // 
         this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.buttonEdit.Location = new System.Drawing.Point(590, 86);
         this.buttonEdit.Name = "buttonEdit";
         this.buttonEdit.Size = new System.Drawing.Size(130, 42);
         this.buttonEdit.TabIndex = 1;
         this.buttonEdit.Text = "Edit Selected";
         this.buttonEdit.UseVisualStyleBackColor = true;
         // 
         // buttonRemove
         // 
         this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.buttonRemove.Location = new System.Drawing.Point(590, 144);
         this.buttonRemove.Name = "buttonRemove";
         this.buttonRemove.Size = new System.Drawing.Size(130, 42);
         this.buttonRemove.TabIndex = 2;
         this.buttonRemove.Text = "Remove Selected";
         this.buttonRemove.UseVisualStyleBackColor = true;
         // 
         // buttonAddNew
         // 
         this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.buttonAddNew.Location = new System.Drawing.Point(590, 26);
         this.buttonAddNew.Name = "buttonAddNew";
         this.buttonAddNew.Size = new System.Drawing.Size(130, 42);
         this.buttonAddNew.TabIndex = 0;
         this.buttonAddNew.Text = "Create New Trip";
         this.buttonAddNew.UseVisualStyleBackColor = true;
         this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
         // 
         // listBoxTrips
         // 
         this.listBoxTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.listBoxTrips.DataSource = this.bindingSourceTrips;
         this.listBoxTrips.FormattingEnabled = true;
         this.listBoxTrips.Location = new System.Drawing.Point(726, 26);
         this.listBoxTrips.Name = "listBoxTrips";
         this.listBoxTrips.Size = new System.Drawing.Size(198, 160);
         this.listBoxTrips.TabIndex = 0;
         this.listBoxTrips.SelectedIndexChanged += new System.EventHandler(this.listBoxTrips_SelectedIndexChanged);
         // 
         // listBoxLocations
         // 
         this.listBoxLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.listBoxLocations.FormattingEnabled = true;
         this.listBoxLocations.HorizontalScrollbar = true;
         this.listBoxLocations.Location = new System.Drawing.Point(3, 15);
         this.listBoxLocations.Name = "listBoxLocations";
         this.listBoxLocations.SelectionMode = System.Windows.Forms.SelectionMode.None;
         this.listBoxLocations.Size = new System.Drawing.Size(300, 82);
         this.listBoxLocations.TabIndex = 3;
         // 
         // labelDistance
         // 
         this.labelDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.labelDistance.AutoSize = true;
         this.labelDistance.Location = new System.Drawing.Point(3, 96);
         this.labelDistance.Name = "labelDistance";
         this.labelDistance.Size = new System.Drawing.Size(71, 13);
         this.labelDistance.TabIndex = 4;
         this.labelDistance.Text = "labelDistance";
         // 
         // labelDescription
         // 
         this.labelDescription.AutoSize = true;
         this.labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.labelDescription.Location = new System.Drawing.Point(3, 110);
         this.labelDescription.Name = "labelDescription";
         this.labelDescription.Size = new System.Drawing.Size(82, 13);
         this.labelDescription.TabIndex = 5;
         this.labelDescription.Text = "labelDescription";
         // 
         // panelbottom
         // 
         this.panelbottom.BackColor = System.Drawing.SystemColors.ControlLight;
         this.panelbottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panelbottom.Controls.Add(this.label6);
         this.panelbottom.Controls.Add(this.label5);
         this.panelbottom.Controls.Add(this.labelSavedCode);
         this.panelbottom.Controls.Add(this.labelSavedAddress);
         this.panelbottom.Controls.Add(this.label1);
         this.panelbottom.Controls.Add(this.buttonEditLocation);
         this.panelbottom.Controls.Add(this.buttonRemoveLocation);
         this.panelbottom.Controls.Add(this.listBoxSavedLocations);
         this.panelbottom.Controls.Add(this.textBoxName);
         this.panelbottom.Controls.Add(this.label4);
         this.panelbottom.Controls.Add(this.buttonSaveLocation);
         this.panelbottom.Controls.Add(this.textBoxLocationCode);
         this.panelbottom.Controls.Add(this.label3);
         this.panelbottom.Controls.Add(this.label2);
         this.panelbottom.Controls.Add(this.textBoxAddress);
         this.panelbottom.Controls.Add(this.buttonEnterTrip);
         this.panelbottom.Controls.Add(this.listBoxTrips);
         this.panelbottom.Controls.Add(this.buttonAddNew);
         this.panelbottom.Controls.Add(this.buttonRemove);
         this.panelbottom.Controls.Add(this.panelTripDetails);
         this.panelbottom.Controls.Add(this.buttonEdit);
         this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panelbottom.Location = new System.Drawing.Point(0, 246);
         this.panelbottom.Name = "panelbottom";
         this.panelbottom.Size = new System.Drawing.Size(1336, 204);
         this.panelbottom.TabIndex = 9;
         // 
         // buttonRemoveLocation
         // 
         this.buttonRemoveLocation.Location = new System.Drawing.Point(111, 155);
         this.buttonRemoveLocation.Name = "buttonRemoveLocation";
         this.buttonRemoveLocation.Size = new System.Drawing.Size(100, 44);
         this.buttonRemoveLocation.TabIndex = 18;
         this.buttonRemoveLocation.Text = "Remove Location";
         this.buttonRemoveLocation.UseVisualStyleBackColor = true;
         this.buttonRemoveLocation.Click += new System.EventHandler(this.buttonRemoveLocation_Click);
         // 
         // listBoxSavedLocations
         // 
         this.listBoxSavedLocations.DataSource = this.bindingSourceLocations;
         this.listBoxSavedLocations.FormattingEnabled = true;
         this.listBoxSavedLocations.Location = new System.Drawing.Point(11, 23);
         this.listBoxSavedLocations.Name = "listBoxSavedLocations";
         this.listBoxSavedLocations.Size = new System.Drawing.Size(200, 95);
         this.listBoxSavedLocations.TabIndex = 17;
         this.listBoxSavedLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxSavedLocations_SelectedIndexChanged);
         // 
         // bindingSourceLocations
         // 
         this.bindingSourceLocations.DataMember = "trip";
         // 
         // textBoxName
         // 
         this.textBoxName.Location = new System.Drawing.Point(258, 126);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.Size = new System.Drawing.Size(121, 20);
         this.textBoxName.TabIndex = 12;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(255, 111);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(79, 13);
         this.label4.TabIndex = 16;
         this.label4.Text = "Name Location";
         // 
         // buttonSaveLocation
         // 
         this.buttonSaveLocation.Location = new System.Drawing.Point(394, 94);
         this.buttonSaveLocation.Name = "buttonSaveLocation";
         this.buttonSaveLocation.Size = new System.Drawing.Size(74, 48);
         this.buttonSaveLocation.TabIndex = 13;
         this.buttonSaveLocation.Text = "Add Location";
         this.buttonSaveLocation.UseVisualStyleBackColor = true;
         this.buttonSaveLocation.Click += new System.EventHandler(this.buttonSaveLocation_Click);
         // 
         // textBoxLocationCode
         // 
         this.textBoxLocationCode.Location = new System.Drawing.Point(258, 88);
         this.textBoxLocationCode.Name = "textBoxLocationCode";
         this.textBoxLocationCode.Size = new System.Drawing.Size(121, 20);
         this.textBoxLocationCode.TabIndex = 11;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(255, 72);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 13);
         this.label3.TabIndex = 15;
         this.label3.Text = "Location Code";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(255, 36);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(45, 13);
         this.label2.TabIndex = 14;
         this.label2.Text = "Address";
         // 
         // textBoxAddress
         // 
         this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.textBoxAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
         this.textBoxAddress.Location = new System.Drawing.Point(258, 52);
         this.textBoxAddress.Name = "textBoxAddress";
         this.textBoxAddress.Size = new System.Drawing.Size(210, 20);
         this.textBoxAddress.TabIndex = 10;
         // 
         // buttonEnterTrip
         // 
         this.buttonEnterTrip.Location = new System.Drawing.Point(1245, 70);
         this.buttonEnterTrip.Name = "buttonEnterTrip";
         this.buttonEnterTrip.Size = new System.Drawing.Size(90, 83);
         this.buttonEnterTrip.TabIndex = 7;
         this.buttonEnterTrip.Text = "Enter Trip to Website";
         this.buttonEnterTrip.UseVisualStyleBackColor = true;
         // 
         // panelTripDetails
         // 
         this.panelTripDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.panelTripDetails.BackColor = System.Drawing.SystemColors.ControlLight;
         this.panelTripDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panelTripDetails.Controls.Add(this.label7);
         this.panelTripDetails.Controls.Add(this.listBoxLocations);
         this.panelTripDetails.Controls.Add(this.labelDescription);
         this.panelTripDetails.Controls.Add(this.labelDistance);
         this.panelTripDetails.Location = new System.Drawing.Point(928, 26);
         this.panelTripDetails.Margin = new System.Windows.Forms.Padding(1);
         this.panelTripDetails.Name = "panelTripDetails";
         this.panelTripDetails.Size = new System.Drawing.Size(310, 161);
         this.panelTripDetails.TabIndex = 6;
         // 
         // dataSetLocations
         // 
         this.dataSetLocations.DataSetName = "NewDataSet";
         // 
         // buttonEditLocation
         // 
         this.buttonEditLocation.Location = new System.Drawing.Point(11, 155);
         this.buttonEditLocation.Name = "buttonEditLocation";
         this.buttonEditLocation.Size = new System.Drawing.Size(100, 44);
         this.buttonEditLocation.TabIndex = 19;
         this.buttonEditLocation.Text = "Edit Location";
         this.buttonEditLocation.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(65, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(87, 13);
         this.label1.TabIndex = 20;
         this.label1.Text = "Saved Locations";
         // 
         // labelSavedAddress
         // 
         this.labelSavedAddress.AutoSize = true;
         this.labelSavedAddress.Location = new System.Drawing.Point(13, 121);
         this.labelSavedAddress.Name = "labelSavedAddress";
         this.labelSavedAddress.Size = new System.Drawing.Size(139, 13);
         this.labelSavedAddress.TabIndex = 21;
         this.labelSavedAddress.Text = "Selected Locations Address";
         // 
         // labelSavedCode
         // 
         this.labelSavedCode.AutoSize = true;
         this.labelSavedCode.Location = new System.Drawing.Point(13, 139);
         this.labelSavedCode.Name = "labelSavedCode";
         this.labelSavedCode.Size = new System.Drawing.Size(126, 13);
         this.labelSavedCode.TabIndex = 22;
         this.labelSavedCode.Text = "Selected Locations Code";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(794, 10);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(64, 13);
         this.label5.TabIndex = 23;
         this.label5.Text = "Saved Trips";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(930, 10);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(39, 13);
         this.label6.TabIndex = 24;
         this.label6.Text = "Details";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(108, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(77, 13);
         this.label7.TabIndex = 25;
         this.label7.Text = "Trip Addresses";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1336, 450);
         this.Controls.Add(this.panelbottom);
         this.Name = "Form1";
         this.Text = "Form1";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTrips)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetTrips)).EndInit();
         this.panelbottom.ResumeLayout(false);
         this.panelbottom.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).EndInit();
         this.panelTripDetails.ResumeLayout(false);
         this.panelTripDetails.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.BindingSource bindingSourceTrips;
      private System.Data.DataSet dataSetTrips;
      private System.Windows.Forms.Button buttonEdit;
      private System.Windows.Forms.Button buttonRemove;
      private System.Windows.Forms.Button buttonAddNew;
      private System.Windows.Forms.ListBox listBoxTrips;
      private System.Windows.Forms.ListBox listBoxLocations;
      private System.Windows.Forms.Label labelDistance;
      private System.Windows.Forms.Label labelDescription;
      private System.Windows.Forms.Panel panelbottom;
      private System.Windows.Forms.Panel panelTripDetails;
      private System.Windows.Forms.Button buttonEnterTrip;
      private System.Windows.Forms.Button buttonRemoveLocation;
      private System.Windows.Forms.ListBox listBoxSavedLocations;
      private System.Windows.Forms.TextBox textBoxName;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button buttonSaveLocation;
      private System.Windows.Forms.TextBox textBoxLocationCode;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBoxAddress;
      private System.Windows.Forms.BindingSource bindingSourceLocations;
      private System.Data.DataSet dataSetLocations;
      private System.Windows.Forms.Label labelSavedAddress;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button buttonEditLocation;
      private System.Windows.Forms.Label labelSavedCode;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label7;
   }
}