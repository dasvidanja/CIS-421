using System;
using System.Windows.Forms;

namespace _421ProjectGUI
{
     partial class Deal
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
            this.GetDeals = new System.Windows.Forms.Button();
            this.LeaseGridView = new System.Windows.Forms.DataGridView();
            this.RentGridView = new System.Windows.Forms.DataGridView();
            this.SellGridView = new System.Windows.Forms.DataGridView();
            this.Lease = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Label();
            this.Sells = new System.Windows.Forms.Label();
            this.GoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GetDeals
            // 
            this.GetDeals.Location = new System.Drawing.Point(12, 12);
            this.GetDeals.Name = "GetDeals";
            this.GetDeals.Size = new System.Drawing.Size(106, 36);
            this.GetDeals.TabIndex = 0;
            this.GetDeals.Text = "All Deals";
            this.GetDeals.UseVisualStyleBackColor = true;
            this.GetDeals.Click += new System.EventHandler(this.GetDeals_Click);
            // 
            // LeaseGridView
            // 
            this.LeaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaseGridView.Location = new System.Drawing.Point(12, 451);
            this.LeaseGridView.Name = "LeaseGridView";
            this.LeaseGridView.Size = new System.Drawing.Size(1363, 120);
            this.LeaseGridView.TabIndex = 1;
            // 
            // RentGridView
            // 
            this.RentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentGridView.Location = new System.Drawing.Point(12, 84);
            this.RentGridView.Name = "RentGridView";
            this.RentGridView.Size = new System.Drawing.Size(1375, 139);
            this.RentGridView.TabIndex = 4;
            // 
            // SellGridView
            // 
            this.SellGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellGridView.Location = new System.Drawing.Point(12, 267);
            this.SellGridView.Name = "SellGridView";
            this.SellGridView.Size = new System.Drawing.Size(1375, 133);
            this.SellGridView.TabIndex = 5;
            // 
            // Lease
            // 
            this.Lease.AutoSize = true;
            this.Lease.Location = new System.Drawing.Point(12, 435);
            this.Lease.Name = "Lease";
            this.Lease.Size = new System.Drawing.Size(36, 13);
            this.Lease.TabIndex = 6;
            this.Lease.Text = "Lease";
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Location = new System.Drawing.Point(9, 68);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(30, 13);
            this.Rent.TabIndex = 7;
            this.Rent.Text = "Rent";
            // 
            // Sells
            // 
            this.Sells.AutoSize = true;
            this.Sells.Location = new System.Drawing.Point(13, 251);
            this.Sells.Name = "Sells";
            this.Sells.Size = new System.Drawing.Size(33, 13);
            this.Sells.TabIndex = 8;
            this.Sells.Text = "Sales";
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(375, 24);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(142, 24);
            this.GoBack.TabIndex = 9;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Deal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 583);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Sells);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Lease);
            this.Controls.Add(this.SellGridView);
            this.Controls.Add(this.RentGridView);
            this.Controls.Add(this.LeaseGridView);
            this.Controls.Add(this.GetDeals);
            this.Name = "Deal";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.LeaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        

        #endregion

        private System.Windows.Forms.Button GetDeals;
        private System.Windows.Forms.DataGridView LeaseGridView;
        private System.Windows.Forms.DataGridView RentGridView;
        private System.Windows.Forms.DataGridView SellGridView;
        private Label Lease;
        private Label Rent;
        private Label Sells;
        private Button GoBack;
    }
}