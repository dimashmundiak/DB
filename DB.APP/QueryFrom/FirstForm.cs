using DB.DAL.Enteties;
using DB.DAL.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB.APP.QueryFrom
{
    public partial class FirstForm : Form
    {
        private readonly Session<Employee> _session;
        private readonly ServiceRepository _querySession;

        public FirstForm()
        {
            InitializeComponent();
            _session = new EmployeeRepository();
            _querySession = new ServiceRepository();
            GetListOfEmployee();
        }

        public void GetListOfEmployee()
        {
            var data = _session.Select();
            comboBox1.DataSource = data.Select(employee =>
                employee.Second_Name.Trim() + " " + employee.First_Name.Trim() + " " + employee.Father_Name.Trim()).ToList();
        }

        public void RefreshData()
        {
            var employee = comboBox1.SelectedItem.ToString().Split(Char.Parse(" "));
            var price = float.Parse(textBox1.Text);
            dataGridView1.DataSource =  _querySession.SelectFirstQuery(price, employee[0], employee[1], employee[2]);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            RefreshData();
        }
    }
}
