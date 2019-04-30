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
         this.labelAddress1 = new System.Windows.Forms.Label();
         this.labelAddress2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.comboBox2 = new System.Windows.Forms.ComboBox();
         this.labelAddress4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.comboBox4 = new System.Windows.Forms.ComboBox();
         this.labelAddress3 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.comboBox3 = new System.Windows.Forms.ComboBox();
         this.labelAddress6 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.comboBox6 = new System.Windows.Forms.ComboBox();
         this.labelAddress5 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.comboBox5 = new System.Windows.Forms.ComboBox();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.checkBox2 = new System.Windows.Forms.CheckBox();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.checkBox4 = new System.Windows.Forms.CheckBox();
         this.label13 = new System.Windows.Forms.Label();
         this.checkBox5 = new System.Windows.Forms.CheckBox();
         this.checkBox6 = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).BeginInit();
         this.SuspendLayout();
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(154, 33);
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
         this.label1.Location = new System.Drawing.Point(69, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "Location 1";
         // 
         // buttonAddLocation
         // 
         this.buttonAddLocation.Location = new System.Drawing.Point(92, 365);
         this.buttonAddLocation.Name = "buttonAddLocation";
         this.buttonAddLocation.Size = new System.Drawing.Size(108, 46);
         this.buttonAddLocation.TabIndex = 2;
         this.buttonAddLocation.Text = "Add New Location";
         this.buttonAddLocation.UseVisualStyleBackColor = true;
         this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(223, 365);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(108, 46);
         this.button1.TabIndex = 3;
         this.button1.Text = "Save Trip";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // labelAddress1
         // 
         this.labelAddress1.AutoSize = true;
         this.labelAddress1.Location = new System.Drawing.Point(354, 37);
         this.labelAddress1.Name = "labelAddress1";
         this.labelAddress1.Size = new System.Drawing.Size(0, 13);
         this.labelAddress1.TabIndex = 5;
         // 
         // labelAddress2
         // 
         this.labelAddress2.AutoSize = true;
         this.labelAddress2.Location = new System.Drawing.Point(354, 86);
         this.labelAddress2.Name = "labelAddress2";
         this.labelAddress2.Size = new System.Drawing.Size(0, 13);
         this.labelAddress2.TabIndex = 8;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(69, 83);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(79, 16);
         this.label3.TabIndex = 7;
         this.label3.Text = "Location 2";
         // 
         // comboBox2
         // 
         this.comboBox2.FormattingEnabled = true;
         this.comboBox2.Location = new System.Drawing.Point(154, 82);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(194, 21);
         this.comboBox2.TabIndex = 6;
         this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // labelAddress4
         // 
         this.labelAddress4.AutoSize = true;
         this.labelAddress4.Enabled = false;
         this.labelAddress4.Location = new System.Drawing.Point(354, 184);
         this.labelAddress4.Name = "labelAddress4";
         this.labelAddress4.Size = new System.Drawing.Size(0, 13);
         this.labelAddress4.TabIndex = 14;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(69, 181);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(79, 16);
         this.label5.TabIndex = 13;
         this.label5.Text = "Location 4";
         // 
         // comboBox4
         // 
         this.comboBox4.Enabled = false;
         this.comboBox4.FormattingEnabled = true;
         this.comboBox4.Location = new System.Drawing.Point(154, 180);
         this.comboBox4.Name = "comboBox4";
         this.comboBox4.Size = new System.Drawing.Size(194, 21);
         this.comboBox4.TabIndex = 12;
         this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // labelAddress3
         // 
         this.labelAddress3.AutoSize = true;
         this.labelAddress3.Enabled = false;
         this.labelAddress3.Location = new System.Drawing.Point(354, 135);
         this.labelAddress3.Name = "labelAddress3";
         this.labelAddress3.Size = new System.Drawing.Size(0, 13);
         this.labelAddress3.TabIndex = 11;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(69, 132);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(79, 16);
         this.label7.TabIndex = 10;
         this.label7.Text = "Location 3";
         // 
         // comboBox3
         // 
         this.comboBox3.Enabled = false;
         this.comboBox3.FormattingEnabled = true;
         this.comboBox3.Location = new System.Drawing.Point(154, 131);
         this.comboBox3.Name = "comboBox3";
         this.comboBox3.Size = new System.Drawing.Size(194, 21);
         this.comboBox3.TabIndex = 9;
         this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // labelAddress6
         // 
         this.labelAddress6.AutoSize = true;
         this.labelAddress6.Enabled = false;
         this.labelAddress6.Location = new System.Drawing.Point(354, 281);
         this.labelAddress6.Name = "labelAddress6";
         this.labelAddress6.Size = new System.Drawing.Size(0, 13);
         this.labelAddress6.TabIndex = 20;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(69, 278);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(79, 16);
         this.label9.TabIndex = 19;
         this.label9.Text = "Location 6";
         // 
         // comboBox6
         // 
         this.comboBox6.Enabled = false;
         this.comboBox6.FormattingEnabled = true;
         this.comboBox6.Location = new System.Drawing.Point(154, 277);
         this.comboBox6.Name = "comboBox6";
         this.comboBox6.Size = new System.Drawing.Size(194, 21);
         this.comboBox6.TabIndex = 18;
         this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // labelAddress5
         // 
         this.labelAddress5.AutoSize = true;
         this.labelAddress5.Enabled = false;
         this.labelAddress5.Location = new System.Drawing.Point(354, 232);
         this.labelAddress5.Name = "labelAddress5";
         this.labelAddress5.Size = new System.Drawing.Size(0, 13);
         this.labelAddress5.TabIndex = 17;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label11.Location = new System.Drawing.Point(69, 229);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(79, 16);
         this.label11.TabIndex = 16;
         this.label11.Text = "Location 5";
         // 
         // comboBox5
         // 
         this.comboBox5.Enabled = false;
         this.comboBox5.FormattingEnabled = true;
         this.comboBox5.Location = new System.Drawing.Point(154, 228);
         this.comboBox5.Name = "comboBox5";
         this.comboBox5.Size = new System.Drawing.Size(194, 21);
         this.comboBox5.TabIndex = 15;
         this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Checked = true;
         this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBox1.Enabled = false;
         this.checkBox1.Location = new System.Drawing.Point(28, 36);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(15, 14);
         this.checkBox1.TabIndex = 21;
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // checkBox2
         // 
         this.checkBox2.AutoSize = true;
         this.checkBox2.Checked = true;
         this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBox2.Enabled = false;
         this.checkBox2.Location = new System.Drawing.Point(28, 85);
         this.checkBox2.Name = "checkBox2";
         this.checkBox2.Size = new System.Drawing.Size(15, 14);
         this.checkBox2.TabIndex = 22;
         this.checkBox2.UseVisualStyleBackColor = true;
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Location = new System.Drawing.Point(28, 133);
         this.checkBox3.Name = "checkBox3";
         this.checkBox3.Size = new System.Drawing.Size(15, 14);
         this.checkBox3.TabIndex = 23;
         this.checkBox3.UseVisualStyleBackColor = true;
         this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
         // 
         // checkBox4
         // 
         this.checkBox4.AutoSize = true;
         this.checkBox4.Location = new System.Drawing.Point(28, 182);
         this.checkBox4.Name = "checkBox4";
         this.checkBox4.Size = new System.Drawing.Size(15, 14);
         this.checkBox4.TabIndex = 24;
         this.checkBox4.UseVisualStyleBackColor = true;
         this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(12, 9);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(46, 13);
         this.label13.TabIndex = 26;
         this.label13.Text = "Enabled";
         // 
         // checkBox5
         // 
         this.checkBox5.AutoSize = true;
         this.checkBox5.Location = new System.Drawing.Point(28, 231);
         this.checkBox5.Name = "checkBox5";
         this.checkBox5.Size = new System.Drawing.Size(15, 14);
         this.checkBox5.TabIndex = 27;
         this.checkBox5.UseVisualStyleBackColor = true;
         this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
         // 
         // checkBox6
         // 
         this.checkBox6.AutoSize = true;
         this.checkBox6.Location = new System.Drawing.Point(28, 281);
         this.checkBox6.Name = "checkBox6";
         this.checkBox6.Size = new System.Drawing.Size(15, 14);
         this.checkBox6.TabIndex = 28;
         this.checkBox6.UseVisualStyleBackColor = true;
         this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
         // 
         // frmTrip
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(611, 450);
         this.Controls.Add(this.checkBox6);
         this.Controls.Add(this.checkBox5);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.checkBox4);
         this.Controls.Add(this.checkBox3);
         this.Controls.Add(this.checkBox2);
         this.Controls.Add(this.checkBox1);
         this.Controls.Add(this.labelAddress6);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.comboBox6);
         this.Controls.Add(this.labelAddress5);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.comboBox5);
         this.Controls.Add(this.labelAddress4);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.comboBox4);
         this.Controls.Add(this.labelAddress3);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.comboBox3);
         this.Controls.Add(this.labelAddress2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.comboBox2);
         this.Controls.Add(this.labelAddress1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.buttonAddLocation);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.comboBox1);
         this.Name = "frmTrip";
         this.Text = "frmTrip";
         this.Load += new System.EventHandler(this.frmTrip_Load);
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
      private System.Windows.Forms.Label labelAddress1;
      private System.Windows.Forms.Label labelAddress2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox comboBox2;
      private System.Windows.Forms.Label labelAddress4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox comboBox4;
      private System.Windows.Forms.Label labelAddress3;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox comboBox3;
      private System.Windows.Forms.Label labelAddress6;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.ComboBox comboBox6;
      private System.Windows.Forms.Label labelAddress5;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.ComboBox comboBox5;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.CheckBox checkBox2;
      private System.Windows.Forms.CheckBox checkBox3;
      private System.Windows.Forms.CheckBox checkBox4;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.CheckBox checkBox5;
      private System.Windows.Forms.CheckBox checkBox6;
   }
}