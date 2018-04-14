using DB.DAL.Enteties;
using DB.DAL.Repository;
using System.Windows.Forms;

namespace DB.APP.TableForm
{
    public partial class ArchiveForm : Form
    {
        private readonly Session<Archive> _session;

        public ArchiveForm()
        {
            InitializeComponent();
            _session = new ArchiveRepository();
            refreshData();
        }

        private void refreshData()
        {
            var data = _session.Select();
            if (data != null)
            {
                archiveDataGrid.DataSource = data;
            }
            else
            {
                MessageBox.Show(@"Error");
            }
        }
    }
}
