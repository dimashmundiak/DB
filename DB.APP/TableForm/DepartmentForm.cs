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
    public partial class DepartmentForm : Form
    {
        private readonly Session<Department> _session;
        public DepartmentForm()
        {
            InitializeComponent();
            _session = new DepartmentRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                departmentDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
