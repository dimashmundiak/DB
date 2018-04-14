using DB.DAL.Enteties;
using DB.DAL.Repository;
using System.Windows.Forms;

namespace DB.APP.TableForm
{
    public partial class ServiceForm : Form
    {
        private readonly Session<Service> _session;

        public ServiceForm()
        {
            InitializeComponent();
            _session = new ServiceRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                serviceDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
