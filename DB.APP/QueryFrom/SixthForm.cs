using DB.DAL.Repository;
using System;
using System.Windows.Forms;

namespace DB.APP.QueryFrom
{
    public partial class SixthForm : Form
    {
        private readonly DepartmentRepository _querySession;

        public SixthForm()
        {
            InitializeComponent();
            _querySession = new DepartmentRepository();
        }

        public void RefreshData()
        {
            var dayCount = int.Parse(textBox1.Text);
            var date = dateTimePicker1.Text;
            dataGridView1.DataSource = _querySession.SelectSixthQuery(dayCount, date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
