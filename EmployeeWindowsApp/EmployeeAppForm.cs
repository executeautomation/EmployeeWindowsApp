using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWindowsApp
{
    public partial class EmployeeApp : Form
    {


        EmployeeModel employeeModel = new EmployeeModel();

        public EmployeeApp()
        {
            InitializeComponent();
            DetectLongServeEmployee();
        }

        public void DetectLongServeEmployee()
        {
            var result = employeeModel.Employees.OrderByDescending(x => x.DurationWorked).First();

            lblLongServeEmployee.Text = result.Name;

        }



        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmployee newEmpForm = new NewEmployee();
            newEmpForm.Show();
        }

        private void employeeBenefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee detailsForm = new ManageEmployee();
            detailsForm.Show();
        }

        private void EmployeeApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDBDataSet.Employees);

        }

        private void employeePFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PFForm().ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDBDataSet.Employees);

            DetectLongServeEmployee();
        }
    }
}
