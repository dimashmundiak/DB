using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.DAL.Enteties;
using DB.DAL.Repository;

namespace DB.APP.TableForm
{
    public partial class EmployeeForm : Form
    {
        private readonly Session<Employee> _session;
        public EmployeeForm()
        {
            InitializeComponent();
            _session = new EmployeeRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                employeeDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
