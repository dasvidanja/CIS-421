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
               Deal form2 = new Deal();
               form2.Show();

               this.Hide();
          }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle form3 = new vehicle();
            form3.Show();
            this.Hide();

        }

        private void People_Button(object sender, EventArgs e)
        {
            //create customer class
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }   
    }
}
