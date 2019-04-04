using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _421ProjectGUI
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Execute($@"INSERT INTO [dbo].[Vehicle]
                                                   ([Year]
                                                   ,[Color]
                                                   ,[Mileage]
                                                   ,[Power_Source]
                                                   ,[Model]
                                                   ,[Condition]
                                                   ,[Vin_Number])
                                            VALUES
                                                   ('{ DateTime.ParseExact(textBoxYear.Text, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)}'
                                                   ,'{textBoxColor.Text}'
                                                   ,{textBoxMileage.Text}
                                                   ,'{textBoxPowerSource.Text}'
                                                   ,'{textBoxModel.Text}'
                                                   ,'{textBoxCondition.Text}'
                                                   ,'{textBoxVinNumber.Text}')");

                connection.Execute($@"INSERT INTO [dbo].[Car]
                                                   ([Type]
                                                   ,[Vin_Number])
                                            VALUES
                                                   ('{textBoxType.Text}'
                                                   ,'{textBoxVinNumber.Text}')");
            }

            textBoxYear.Clear();
            textBoxColor.Clear();
            textBoxMileage.Clear();
            textBoxPowerSource.Clear();
            textBoxModel.Clear();
            textBoxCondition.Clear();
            textBoxVinNumber.Clear();
            textBoxType.Clear();
        }
    }
}
