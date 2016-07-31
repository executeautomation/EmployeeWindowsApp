using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeWindowsApp.PFService;

namespace EmployeeWindowsApp
{
    public partial class EmployeePF : Form
    {

        private PFServiceClient _pfServiceClient = null;


        public EmployeePF()
        {
            InitializeComponent();
        }

        private void EmployeePF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDBDataSet.Employees);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            _pfServiceClient = new PFServiceClient();

            if (this.pfDataGridView.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (pfDataGridView.Columns[e.ColumnIndex].HeaderText == "EmployeeContrib")
                {
                    var result = _pfServiceClient.GetPfEmployeeControlSofarWithId((int)pfDataGridView["Id", e.RowIndex].Value);
                    MessageBox.Show("Employee Contribution is: " + result);
                }
                else if (pfDataGridView.Columns[e.ColumnIndex].HeaderText == "EmployerContrib")
                {
                    var result = _pfServiceClient.GetPfEmployerControlSofarWithId((int)pfDataGridView["Id", e.RowIndex].Value);

                    MessageBox.Show("Employer Contribution is: " + result);
                }

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["EmployeeApp"];

            if (form == null)
                form.Show();

            this.Hide();


        }
    }
}
