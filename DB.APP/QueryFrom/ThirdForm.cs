using DB.DAL.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DB.APP.QueryFrom
{
    public partial class ThirdForm : Form
    {
        private readonly DepartmentRepository _querySession;

        public ThirdForm()
        {
            InitializeComponent();
            _querySession = new DepartmentRepository();
            GetListOfCity();
        }

        public void GetListOfCity()
        {
            var data = _querySession.Select();
            comboBox1.DataSource = data.Select(client => client.City.Trim()).ToList();
        }

        public void RefreshData()
        {
            var city = comboBox1.SelectedItem.ToString();
            var director = textBox1.Text;
            dataGridView1.DataSource = _querySession.SelectThirdQuery(city, director);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
