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



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _vm.FirstName = txtBxFirstName.ToString();
            _vm.LastName = txtBxLastName.ToString();
            _vm.Country = comboBox1.Text;
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
