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
    public partial class NewEmployee : Form
    {

        EmployeeModel employeeModel = new EmployeeModel();

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Salary = int.Parse(txtSalary.Text),
                DurationWorked = int.Parse(txtDuration.Text),
                Grade = int.Parse(txtGrade.Text),
            };

            //Update in database
            employeeModel.Employees.Add(emp);
            employeeModel.SaveChanges();

            MessageBox.Show("Employee Saved Sucessfully !!!", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtGrade.Text = "";
            txtDuration.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
        }
    }
}
