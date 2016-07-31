using EmployeeWindowsApp.PFService;
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
    public partial class PFForm : Form
    {

        private PFServiceClient _pfServiceClient = null;

        public PFForm()
        {
            InitializeComponent();
        }

        private void PFForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDBDataSet.Employees);

        }

        private void pfDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _pfServiceClient = new PFServiceClient();

            if (this.pfDataGridView.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (pfDataGridView.Columns[e.ColumnIndex].HeaderText == "EmployeeContrib")
                {
                    var result = _pfServiceClient.GetPfEmployeeControlSofarWithId((int)pfDataGridView[0, e.RowIndex].Value);
                    MessageBox.Show("Employee Contribution is: " + result, "WebService Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (pfDataGridView.Columns[e.ColumnIndex].HeaderText == "EmployerContrib")
                {
                    var result = _pfServiceClient.GetPfEmployerControlSofarWithId((int)pfDataGridView[0, e.RowIndex].Value);

                    MessageBox.Show("Employer Contribution is: " + result, "WebService Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
