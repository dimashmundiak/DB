using DB.DAL.Enteties;
using DB.DAL.Repository;
using System.Windows.Forms;

namespace DB.APP.TableForm
{
    public partial class ClientForm : Form
    {
        private readonly Session<Client> _session;

        public ClientForm()
        {
            InitializeComponent();
            _session = new ClientRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                clientDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
