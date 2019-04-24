namespace Mileage
{
   partial class frmLocation
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
         this.textBoxAddress = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textBoxLocationCode = new System.Windows.Forms.TextBox();
         this.buttonSaveLocation = new System.Windows.Forms.Button();
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // textBoxAddress
         // 
         this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.textBoxAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
         this.textBoxAddress.Location = new System.Drawing.Point(56, 12);
         this.textBoxAddress.Name = "textBoxAddress";
         this.textBoxAddress.Size = new System.Drawing.Size(313, 20);
         this.textBoxAddress.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(5, 15);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(45, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Address";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(5, 46);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Location Code";
         // 
         // textBoxLocationCode
         // 
         this.textBoxLocationCode.Location = new System.Drawing.Point(87, 43);
         this.textBoxLocationCode.Name = "textBoxLocationCode";
         this.textBoxLocationCode.Size = new System.Drawing.Size(106, 20);
         this.textBoxLocationCode.TabIndex = 2;
         // 
         // buttonSaveLocation
         // 
         this.buttonSaveLocation.Location = new System.Drawing.Point(272, 110);
         this.buttonSaveLocation.Name = "buttonSaveLocation";
         this.buttonSaveLocation.Size = new System.Drawing.Size(97, 32);
         this.buttonSaveLocation.TabIndex = 4;
         this.buttonSaveLocation.Text = "Save";
         this.buttonSaveLocation.UseVisualStyleBackColor = true;
         this.buttonSaveLocation.Click += new System.EventHandler(this.buttonSaveLocation_Click);
         // 
         // textBoxName
         // 
         this.textBoxName.Location = new System.Drawing.Point(99, 117);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.Size = new System.Drawing.Size(167, 20);
         this.textBoxName.TabIndex = 3;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(5, 120);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(97, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Save Location As..";
         // 
         // frmLocation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(381, 151);
         this.Controls.Add(this.textBoxName);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.buttonSaveLocation);
         this.Controls.Add(this.textBoxLocationCode);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBoxAddress);
         this.Name = "frmLocation";
         this.Text = "frmLocation";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TextBox textBoxAddress;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textBoxLocationCode;
      private System.Windows.Forms.Button buttonSaveLocation;
      private System.Windows.Forms.TextBox textBoxName;
      private System.Windows.Forms.Label label4;
   }
}