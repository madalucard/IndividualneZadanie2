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
        

        public MainView()
        {   
            InitializeComponent();
            
        }

        private void runnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunnersForm runner = new RunnersForm();
            runner.Show();
        }

        /// <summary>
        /// It will allow to create new event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBxRaceParameters.Visible = true;
            dataGridView1.Visible = true;
        }
        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
