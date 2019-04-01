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
    public partial class RunnersForm1 : Form
    {
        public RunnersForm1()
        {
            InitializeComponent();

            // Working combobox inicializaion
            foreach (var v in FileManager.Countries)
            {
                cmbBxCountry.Items.Add(v.CountryNameEnglish);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
