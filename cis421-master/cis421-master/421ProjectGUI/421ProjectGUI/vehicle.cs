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
using _421ProjectGUI.Model;

namespace _421ProjectGUI
{
    public partial class vehicle : Form
    {
        public vehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {

                var cars = connection.Query<CarModel>(@"SELECT *
                                                   FROM [dbo].[Vehicle] AS v
                                                   JOIN Car AS c on v.[Vin_Number] = c.[Vin_Number]").ToList();
                

                var trucks = connection.Query<TruckModel>(@"  SELECT *
                                                         FROM [dbo].[Vehicle] AS v
                                                         JOIN Truck AS t on v.[Vin_Number] = t.[Vin_Number]").ToList();

                CarGridView.DataSource = cars;
                TruckGridView.DataSource = trucks;

                CarGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                CarGridView.CellValueChanged -= CarGridView_CellValueChanged;
                CarGridView.CellValueChanged += CarGridView_CellValueChanged;

                TruckGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                TruckGridView.CellValueChanged -= TruckGridViewGridView_CellValueChanged;
                TruckGridView.CellValueChanged += TruckGridViewGridView_CellValueChanged;

            }

        }

        private void TruckGridViewGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = TruckGridView.Columns[e.ColumnIndex].Name;
                var tableName = "";

                if (colName == "Weight_Capacity" || colName == "Towing_Capacity")
                {
                    tableName = "Truck";
                }
                else
                {
                    tableName = "Vehicle";
                }

                connection.Execute($@"UPDATE [{tableName}] SET [{colName}] = '{TruckGridView[e.ColumnIndex, e.RowIndex].Value}' WHERE [Vin_Number] = '{TruckGridView["Vin_Number", e.RowIndex].Value}'");
            }
        }

        private void CarGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = CarGridView.Columns[e.ColumnIndex].Name;
                var tableName = "";

                if (colName == "Type")
                {
                    tableName = "Car";
                }
                else
                {
                    tableName = "Vehicle";
                }

                connection.Execute($@"UPDATE [{tableName}] SET [{colName}] = '{CarGridView[e.ColumnIndex, e.RowIndex].Value}' WHERE [Vin_Number] = '{CarGridView["Vin_Number", e.RowIndex].Value}'");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

   

        
    }
}
