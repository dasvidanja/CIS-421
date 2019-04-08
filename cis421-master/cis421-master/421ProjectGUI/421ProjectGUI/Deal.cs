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
    public partial class Deal : Form
    {
        public Deal()
        {
            InitializeComponent();
        }

        private void GetDeals_Click(object sender, EventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {

                var rents = connection.Query<RentModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, r.[Hours], r.[Days], v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info, c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join rent as r on r.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Car as ca on ca.Vin_Number = Vehicle_Vin_Number").ToList();

                rents.AddRange(connection.Query<RentModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, r.[Hours], r.[Days], v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info, c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join rent as r on r.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Truck as t on t.Vin_Number = Vehicle_Vin_Number").ToList());

                var leases = connection.Query<LeaseModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, l.Contract_Number as Contract, l.End_Date, l.Miles, v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info,  c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join Lease as l on l.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Car as ca on ca.Vin_Number = Vehicle_Vin_Number").ToList();

                leases.AddRange(connection.Query<LeaseModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, l.Contract_Number as Contract, l.End_Date, l.Miles, v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info,  c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join Lease as l on l.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Truck as t on t.Vin_Number = Vehicle_Vin_Number").ToList());

                var sells = connection.Query<SellModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, s.Title, v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info,  c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join Sell as s on s.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Car as ca on ca.Vin_Number = Vehicle_Vin_Number
                                                                inner join Truck as t on t.Vin_Number = Vehicle_Vin_Number").ToList();

                sells.AddRange(connection.Query<SellModel>(@"select d.[Id], d.[Date], d.Price, d.Commission, s.Title, v.Color, v.Condition, v.Mileage, v.Model, v.Power_Source, v.[Year], p.[Name] as Cname, p.Phone_Number as Cphone, c.Billing_Info,  c.Insurance_Number as Insurance, c.License_Number as License, p1.[Name] as Sname, p1.Phone_Number as Sphone 
                                                                from deal as d
                                                                inner join Sell as s on s.Id = d.Id
                                                                inner join Customer as c on c.Id = d.Customer_Id
                                                                inner join person as p on p.id = c.Id
                                                                inner join person as p1 on p1.id = d.Sales_Person_Id
                                                                inner join Vehicle as v on v.Vin_Number = Vehicle_Vin_Number
                                                                inner join Truck as t on t.Vin_Number = Vehicle_Vin_Number").ToList());

                LeaseGridView.DataSource = leases;
                RentGridView.DataSource = rents;
                SellGridView.DataSource = sells;

                LeaseGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                LeaseGridView.CellValueChanged -= LeaseGridView_CellValueChanged;
                LeaseGridView.CellValueChanged += LeaseGridView_CellValueChanged;

                RentGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                RentGridView.CellValueChanged -= RentGridView_CellValueChanged;
                RentGridView.CellValueChanged += RentGridView_CellValueChanged;

                SellGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                SellGridView.CellValueChanged -= SellGridView_CellValueChanged;
                SellGridView.CellValueChanged += SellGridView_CellValueChanged;
            }
        }

        private void SellGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = SellGridView.Columns[e.ColumnIndex].Name;
                var tableName = "";

                if (colName == "Title")
                {
                    tableName = "Sell";
                }
                else if (colName == "Price" || colName == "Date" || colName == "Commission")
                {
                    tableName = "Deal";
                }
                else
                {
                    connection.Execute($@" DELETE FROM [Sell] WHERE [Id] = '{SellGridView["Id", e.RowIndex].Value}'");
                    connection.Execute($@"DELETE FROM [Deal] WHERE[Id] = '{SellGridView["Id", e.RowIndex].Value}'");
                    return;
                }

                connection.Execute($@"UPDATE [{tableName}] SET [{colName}] = {SellGridView[e.ColumnIndex, e.RowIndex].Value} WHERE [Id] = '{SellGridView["Id", e.RowIndex].Value}'");
            }
        }

        private void RentGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = RentGridView.Columns[e.ColumnIndex].Name;
                var tableName = "";

                if (colName == "Hours" || colName == "Days")
                {
                    tableName = "Rent";
                }
                else if(colName == "Price" || colName == "Date" || colName == "Commission")
                {
                    tableName = "Deal";
                }
                else
                {
                    connection.Execute($@" DELETE FROM [Rent] WHERE [Id] = '{RentGridView["Id", e.RowIndex].Value}'");
                    connection.Execute($@"DELETE FROM [Deal] WHERE[Id] = '{RentGridView["Id", e.RowIndex].Value}'");
                    return;
                }

                connection.Execute($@"UPDATE [{tableName}] SET [{colName}] = {RentGridView[e.ColumnIndex, e.RowIndex].Value} WHERE [Id] = '{RentGridView["Id", e.RowIndex].Value}'");
            }
        }

        private void LeaseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                var colName = LeaseGridView.Columns[e.ColumnIndex].Name;
                var tableName = "";

                if (colName == "Contract" || colName == "End_Date" || colName == "Miles")
                {
                    tableName = "Lease";
                }
                else if (colName == "Price" || colName == "Date" || colName == "Commission")
                {
                    tableName = "Deal";
                }
                else
                {
                    connection.Execute($@" DELETE FROM [Lease] WHERE [Id] = '{LeaseGridView["Id", e.RowIndex].Value}'");
                    connection.Execute($@"DELETE FROM [Deal] WHERE[Id] = '{LeaseGridView["Id", e.RowIndex].Value}'");
                    return;
                }

                connection.Execute($@"UPDATE [{tableName}] SET [{colName}] = {LeaseGridView[e.ColumnIndex, e.RowIndex].Value} WHERE [Id] = '{LeaseGridView["Id", e.RowIndex].Value}'");
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}