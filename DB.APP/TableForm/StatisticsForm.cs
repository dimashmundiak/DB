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
    public partial class StatisticsForm : Form
    {
        private readonly Session<Statistics> _session;

        public StatisticsForm()
        {
            InitializeComponent();
            _session = new StatisticsRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                statisticsDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
