using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestTrackerProject
{
    public partial class RequestTracker : Form
    {
        /*
         * Created by Jubril Bakare
         * ID 700673263
         * */
        public RequestTracker()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this block of code would show the about box
            AboutBox ab = new AboutBox();
            ab.MdiParent = this;
            ab.Show(); 
        }

        private void createNewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRequest cr = new CreateRequest();
            cr.MdiParent = this;
            cr.Show();
        }

        private void viewAllRequestBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this block would show the View request form when clicked
            ViewRequest vr = new ViewRequest();
            vr.MdiParent = this;
            vr.Show();
        }
    }
}
