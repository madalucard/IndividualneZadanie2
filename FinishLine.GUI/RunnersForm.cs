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
            _vm.AddRunner();
        }

       
    }
}
