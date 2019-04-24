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
         this.textBoxAddress = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(14, 15);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Name";
         // 
         // textBoxAddress
         // 
         this.textBoxAddress.Location = new System.Drawing.Point(55, 12);
         this.textBoxAddress.Name = "textBoxAddress";
         this.textBoxAddress.Size = new System.Drawing.Size(202, 20);
         this.textBoxAddress.TabIndex = 5;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(165, 38);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(92, 23);
         this.button1.TabIndex = 7;
         this.button1.Text = "OK";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(55, 38);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(92, 23);
         this.button2.TabIndex = 8;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // frmName
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(269, 65);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBoxAddress);
         this.Name = "frmName";
         this.Text = "frmName";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBoxAddress;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
   }
}