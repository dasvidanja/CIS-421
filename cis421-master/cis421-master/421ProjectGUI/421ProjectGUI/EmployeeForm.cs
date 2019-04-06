using _421ProjectGUI.Person;
using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace _421ProjectGUI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {

                var managers = connection.Query<Manager>(@"SELECT [Person].[Id], [Name], [Phone_Number], [Salary], [Employee_Discount], [Clearance_Level] FROM [Person] 
                                                       INNER JOIN [Employee] ON [Employee].[Id] = [Person].[Id]
                                                       INNER JOIN [Manager] ON [Manager].[Id] = [Employee].[Id]").ToList();

                var salespeople = connection.Query<SalesPerson>(@"SELECT [Person].[Id], [Name], [Phone_Number], [Salary], [Employee_Discount], [Yearly_Sales], [Managers_Id] FROM [Person] 
                                                              INNER JOIN [Employee] ON [Employee].[Id] = [Person].[Id]
                                                              INNER JOIN [Sales_Person] ON [Sales_Person].[Id] = [Employee].[Id]").ToList();

                dataGridView1.DataSource = managers;
                dataGridView2.DataSource = salespeople;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Show();
            this.Hide();

        }
    }
}
