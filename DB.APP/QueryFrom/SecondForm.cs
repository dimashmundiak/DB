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

namespace DB.APP.QueryFrom
{
    public partial class SecondForm : Form
    {
        private readonly CustomRepository _querySession;
        private readonly Session<Client> _session;

        public SecondForm()
        {
            InitializeComponent();
            _querySession = new CustomRepository();
            _session = new ClientRepository();
            GetListOfClient();
        }

        public void GetListOfClient()
        {
            var data = _session.Select();
            comboBox1.DataSource = data.Select(client =>
                client.Second_Name.Trim() + " " + client.First_Name.Trim() + " " + client.Father_Name.Trim()).ToList();
        }

        public void RefreshData()
        {
            var employee = comboBox1.SelectedItem.ToString().Split(Char.Parse(" "));
            var date = dateTimePicker1.Text;
            dataGridView1.DataSource = _querySession.SelectSecondQuery(date, employee[0], employee[1], employee[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
