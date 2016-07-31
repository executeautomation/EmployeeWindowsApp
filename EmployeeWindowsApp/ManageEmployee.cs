using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWindowsApp
{
    public partial class ManageEmployee : Form
    {

        EmployeeModel employeeModel = new EmployeeModel();


        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDBDataSet.Employees);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {

                var id = int.Parse(dataGridView1[0, oneCell.RowIndex].Value.ToString());

                var employee = employeeModel.Employees.Where(x => x.Id == id);

                string name = employee.FirstOrDefault().Name;

                employeeModel.Employees.Remove(employee.FirstOrDefault());
                employeeModel.SaveChanges();

                dataGridView1.Rows.RemoveAt(oneCell.RowIndex);

                MessageBox.Show($"Employee {name} deleted sucessfully !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnGoPF_Click(object sender, EventArgs e)
        {


            EmployeePF pfForm = new EmployeePF();
            if (!pfForm.Visible)
                pfForm.Show();

            this.Hide();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["EmployeeApp"];

            if (form == null)
                form.Show();

            this.Hide();
        }
    }
}
