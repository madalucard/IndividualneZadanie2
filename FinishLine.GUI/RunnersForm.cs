using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class RunnersForm : Form
    {
        ViewModel _vm = new ViewModel();

        public RunnersForm()
        {
            InitializeComponent();
            foreach (var item in FileManager.Countries)
            {
                Console.WriteLine(item);
                cmbCountry.Items.Add(item.CountryNameEnglish);

            }
            SetDataGridView();
            LoadDataGridView();
                
        }

        public void SetDataGridView()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns.Add("Country", "Country");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Sex", "Sex");
        }

        public void LoadDataGridView()
        {


            dataGridView1.Rows.Clear();
            foreach (Runner person in _vm.GetRunnersDb().Values)
            {
                dataGridView1.Rows.Add(person.Id, person.FirstName, person.LastName, person.Country, person.Age, person.IsMaleToString);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _vm.FirstName = txtBxFirstName.Text;
            _vm.LastName = txtBxLastName.Text;
            _vm.Country = cmbCountry.Text;
            _vm.Age = int.Parse(nmrAge.Value.ToString());

            if (rdBtMale.Checked)
            {
                _vm.IsMale = true;
            }
            else
            {
                _vm.IsMale = false;
            }

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                _vm.Id = int.Parse(textBox1.Text);
            }
            else
            {
                _vm.Id = -1;
            }

            _vm.AddRunner();

            MessageBox.Show("Ready");
            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void RunnersForm_Load(object sender, EventArgs e)
        {
            // load data to list

            foreach (var item in _vm.GetRunnersDb())
            {
                dataGridView1.Rows.Add(item.Key, item.Value.FirstName, item.Value.LastName, item.Value.Country, item.Value.Age, item.Value.IsMale);
            }

        }
    }
}
