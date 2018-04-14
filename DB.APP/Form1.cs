using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.APP.QueryFrom;
using DB.APP.TableForm;
using DB.DAL.Enteties;
using DB.DAL.Repository;

namespace DB.APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seriveForm = new ServiceForm();
            seriveForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var departmentForm = new DepartmentForm();
            departmentForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var customForm = new CustomForm();
            customForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var archiveForm = new ArchiveForm();
            archiveForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var firstQuery = new FirstForm();
            firstQuery.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var secondQuery = new SecondForm();
            secondQuery.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var thirdQuery = new ThirdForm();
            thirdQuery.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var fourthQuery = new FourthForm();
            fourthQuery.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var fifthQuery = new FifthForm();
            fifthQuery.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var sixQuery = new SixthForm();
            sixQuery.ShowDialog();
        }
    }
}
