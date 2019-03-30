namespace _421ProjectGUI
{
     partial class Menu
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
            this.DealsTable = new System.Windows.Forms.Button();
            this.vehicle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealsTable
            // 
            this.DealsTable.Location = new System.Drawing.Point(48, 47);
            this.DealsTable.Name = "DealsTable";
            this.DealsTable.Size = new System.Drawing.Size(90, 31);
            this.DealsTable.TabIndex = 0;
            this.DealsTable.Text = "Deals";
            this.DealsTable.UseVisualStyleBackColor = true;
            this.DealsTable.Click += new System.EventHandler(this.DealsTable_Click);
            // 
            // vehicle
            // 
            this.vehicle.Location = new System.Drawing.Point(48, 83);
            this.vehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(90, 31);
            this.vehicle.TabIndex = 2;
            this.vehicle.Text = "vehicles";
            this.vehicle.UseVisualStyleBackColor = true;
            this.vehicle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "PeopleButton";
            this.button1.Location = new System.Drawing.Point(48, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "People";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.People_Button);
            
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.DealsTable);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

          }

          #endregion

        private System.Windows.Forms.Button DealsTable;
        private System.Windows.Forms.Button vehicle;
        private System.Windows.Forms.Button button1;
    }
}

