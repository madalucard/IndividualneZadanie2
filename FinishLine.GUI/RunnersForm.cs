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
        /// <summary>
        /// Constructor that will initialize form Window and load countries to ComboBox, and prepare columns
        /// </summary>
        public RunnersForm()
        {
            InitializeComponent();
            // set combobox with countries
            foreach (var item in FileManager.Countries)
            {
                Console.WriteLine(item);
                cmbCountry.Items.Add(item.CountryNameEnglish);
            }
            
            SetDataGridView();
            //LoadDataGridView();
                
        }
        /// <summary>
        /// Prepares columns for data loading
        /// </summary>
        public void SetDataGridView()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns.Add("Country", "Country");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Sex", "Sex");
        }
        /// <summary>
        /// Loads data to DatagridView
        /// </summary>
        public void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Runner person in _vm.GetRunnersDb().Values)
            {
                dataGridView1.Rows.Add(person.Id, person.FirstName, person.LastName, person.Country, person.Age, person.IsMaleToString);
            }

        }
        /// <summary>
        /// Button for registration of runners, create runner and refresh DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            _vm.FirstName = txtBxFirstName.Text;
            _vm.LastName = txtBxLastName.Text;
            _vm.Country = cmbCountry.Text;
            _vm.Age = int.Parse(nmrAge.Value.ToString());
            // sets male or female
            if (rdBtMale.Checked)
            {
                _vm.IsMale = true;
            }
            else
            {
                _vm.IsMale = false;
            }
            // TODO Control same IDs
            // if txtStartingNum have chosen id -> sets it for id
            // else set it to -1
            if (!string.IsNullOrEmpty(txtStartingNum.Text))
            {
                
                _vm.Id = int.Parse(txtStartingNum.Text);
            }
            else
            {
                _vm.Id = -1;
            }
            // create runner
            _vm.AddRunner();
            MessageBox.Show("Registred");
            //refresh database
            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }
        /// <summary>
        /// Button for loading runners from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDb_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        /// <summary>
        /// Button for saving runners to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveDb_Click(object sender, EventArgs e)
        {
            FileManager.SaveRunners();
            MessageBox.Show("Saved");
            this.Close();
        }
        /// <summary>
        /// Remove runner from db, saves it to txt and refresh DatagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RunnerManger.RunnerDelete(int.Parse(txtBxRemove.Text));
            LoadDataGridView();
        }
    }
}
