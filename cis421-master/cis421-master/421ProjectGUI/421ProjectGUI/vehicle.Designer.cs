namespace _421ProjectGUI
{
    partial class vehicle
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
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TruckGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TruckGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CarGridView
            // 
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Location = new System.Drawing.Point(6, 59);
            this.CarGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.RowTemplate.Height = 33;
            this.CarGridView.Size = new System.Drawing.Size(818, 202);
            this.CarGridView.TabIndex = 0;
            this.CarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGridView_CellValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trucks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TruckGridView
            // 
            this.TruckGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TruckGridView.Location = new System.Drawing.Point(6, 295);
            this.TruckGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TruckGridView.Name = "TruckGridView";
            this.TruckGridView.RowTemplate.Height = 33;
            this.TruckGridView.Size = new System.Drawing.Size(818, 196);
            this.TruckGridView.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Vehicles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(585, 15);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(88, 30);
            this.GoBack.TabIndex = 5;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Car";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Truck";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TruckGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vehicle";
            this.Text = "Vechile";
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TruckGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TruckGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}