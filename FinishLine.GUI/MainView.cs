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
    public partial class MainView : Form
    {
        ViewModel _vm;

        public MainView()
        {   
            InitializeComponent();
            
        }

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersForm1 runner = new RunnersForm1();
            runner.Show();
        }
    }
}
