using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using _421ProjectGUI.Person;

namespace _421ProjectGUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        //GET LIST OF CURRENT CUSTOMERS
        private void GetCurrentCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {

                var cust = connection.Query<Customer>(@"SELECT *
                                                   FROM [dbo].[Person] AS p
                                                   JOIN Customer AS c on p.[Id] = c.[Id]").ToList();

                dataGridView1.DataSource = cust;

                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            }
        }


        //DELETE CUSTOMER WITH ID 123456 (Make sure to populte database with a customer with license#=123456)
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {

                var cust = connection.Query<Customer>(@"DELETE
                                                   FROM [dbo].[Customer] AS c
                                                   WHERE c.License=123456").ToList();

                dataGridView1.DataSource = cust;
           
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            }
        }

      
        //Insert New Person -> Customer
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //In order to avoid data overcrowding, it is useful to clear the dataGridView1 

            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                //Create first a Person
                var per = connection.Query<People>(@"INSERT INTO [dbo].[Person]
                                                    VALUES(00001, John Wick, 586 563 9999)").ToList();

                //Create Customer (which is a person with id 00001
                var cust = connection.Query<Customer>(@"INSERT INTO [dbo].[Customer]
                                                   VALUES ($100, 00001, L100200300,I9876)").ToList();

                dataGridView1.DataSource = cust;
                
                //This code just updates the GRID where the data will be displayed (I think) 
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            }
        }


        //RE-CHECK THIS ONE!!!!
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = dataGridView1.Columns[e.ColumnIndex].Name;
                var tableName = "";
                connection.Execute($@"UPDATE [{tableName}] 
                                    SET [{colName}] 
                                    = '{dataGridView1[e.ColumnIndex, e.RowIndex].Value}'
                                    WHERE [Id] = 
                                   '{dataGridView1["Id", e.RowIndex].Value}'");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}