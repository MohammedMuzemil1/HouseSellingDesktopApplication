using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseSellingDesktopApplication
{
    public partial class MainForm : Form
    {
        private DataTable houseDataTable = new DataTable();

        List<House> Houses { get; set; } 

        public MainForm()
        {
            InitializeComponent();
            Houses = new List<House>();

            employeeListDataGridView.DataSource = employeeList(); ;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            houseDataTable.Columns.Add("Name", typeof(string));
            houseDataTable.Columns.Add("Price", typeof(double));
            houseDataTable.Columns.Add("Status", typeof(string));
            houseDataTable.Columns.Add("EndDate", typeof(DateTime));
        }

        private List<Employee> employeeList()
        {
            var employees = new List<Employee>();
           
            for (var i = 1; i < 16; i++)
            {
                var jobTitle = "";

                if (i == 1 || i == 2)
                {
                    jobTitle = "Manager";
                }else
                {
                    jobTitle = "Builder";
                }

                employees.Add(new Employee()
                {
                    FullName = "Employee " + i,
                    JobTitle = jobTitle
                });
            }

            return employees;
        }

        private void addHouse_Button_Click(object sender, EventArgs e)
        {
            try
            {
                houseDataTable.Rows.Add(houseNameTextBox.Text, housePriceTextBox.Text, "Building", null);
                houseListDataGridView.DataSource = houseDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void houseListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
            DataGridViewRow row = houseListDataGridView.Rows[i];
            houseNameTextBox.Text = row.Cells[0].Value.ToString();
            housePriceTextBox.Text = row.Cells[1].Value.ToString();
        }


      
    }
}
