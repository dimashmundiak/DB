using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.DAL.Repository;

namespace DB.APP.QueryFrom
{
    public partial class FifthForm : Form
    {
        private readonly ClientRepository _querySession;

        public FifthForm()
        {
            InitializeComponent();
            _querySession = new ClientRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            var countMarriage = int.Parse(textBox1.Text);
            var countChildren = int.Parse(textBox2.Text);
            var bottomAge = int.Parse(textBox3.Text);
            var topAge = int.Parse(textBox4.Text);
            dataGridView1.DataSource = _querySession.SelectFifthQuery(countMarriage, countChildren, bottomAge, topAge);
        }
    }
}
