namespace Mileage.Forms
{
   partial class frmName
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
         this.label2 = new System.Windows.Forms.Label();
         this.textBoxTripName = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(14, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Name";
         // 
         // textBoxTripName
         // 
         this.textBoxTripName.Location = new System.Drawing.Point(17, 25);
         this.textBoxTripName.Name = "textBoxTripName";
         this.textBoxTripName.Size = new System.Drawing.Size(265, 20);
         this.textBoxTripName.TabIndex = 5;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(165, 166);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(92, 33);
         this.button1.TabIndex = 7;
         this.button1.Text = "OK";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(35, 166);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(92, 33);
         this.button2.TabIndex = 8;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // richTextBoxDescription
         // 
         this.richTextBoxDescription.Location = new System.Drawing.Point(17, 69);
         this.richTextBoxDescription.Name = "richTextBoxDescription";
         this.richTextBoxDescription.Size = new System.Drawing.Size(265, 82);
         this.richTextBoxDescription.TabIndex = 9;
         this.richTextBoxDescription.Text = "";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 53);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "Trip Description";
         // 
         // frmName
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(294, 208);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.richTextBoxDescription);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBoxTripName);
         this.Name = "frmName";
         this.Text = "Save Trip";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBoxTripName;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.RichTextBox richTextBoxDescription;
      private System.Windows.Forms.Label label1;
   }
}