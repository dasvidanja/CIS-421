using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _421ProjectGUI
{
     public partial class Menu : Form
     {

      
         public Menu()
         {
            InitializeComponent();
           
         }

          private void DealsTable_Click(object sender, EventArgs e)
          {
            this.Hide();
            Deal form2 = new Deal();

            form2.ShowDialog();
            this.Show();
          }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicle form3 = new vehicle();

            form3.ShowDialog();
            this.Show();

        }

        private void People_Button(object sender, EventArgs e)
        {
            this.Hide();
            //create customer class

            CustomerForm customer = new CustomerForm();
            customer.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            this.Hide();
        }
     }
}
