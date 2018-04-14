using DB.DAL.Repository;
using System;
using System.Windows.Forms;

namespace DB.APP.QueryFrom
{
    public partial class FourthForm : Form
    {
        private readonly ArchiveRepository _querySession;

        public FourthForm()
        {
            InitializeComponent();
            _querySession = new ArchiveRepository();
        }

        public void RefreshData()
        {
            var age = int.Parse(textBox1.Text);
            var status = textBox2.Text;
            var gender = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = _querySession.SelectFourthQuery(age, status, gender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
