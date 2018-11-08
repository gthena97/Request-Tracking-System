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
    /*
     Created by Jubril Bakare
     ID 700673263
     */
    public partial class ViewRequest : Form
    {
        public ViewRequest()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //exit form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void ViewRequest_Load(object sender, EventArgs e)
        {
           
                DataTable dt = new DataTable();
           // DataSet ds = new DataSet();

            DataColumn dc1 = new DataColumn("Request ID");
            DataColumn dc2 = new DataColumn("Description");
            DataColumn dc3 = new DataColumn("Created By");
            DataColumn dc4 = new DataColumn("Created On");
            DataColumn dc5 = new DataColumn("Status");

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);

            dt.Rows.Add("101", "Change Database", "Jubril", "11/17/2018", "New");
            dt.Rows.Add("102", "Other features", "Shikhir", "11/17/2018", "In progress");
            dt.Rows.Add("103", "create lists", "Jubril", "11/17/2018", "Completed");
            dt.Rows.Add("104", "presentation slides", "Paravastu", "11/17/2018", "New");

            itemsComboBox.DataSource = dt;

            itemsComboBox.DisplayMember = "Request ID";
            itemsComboBox.ValueMember = "Description";
           
           

            //resultDataGridView.DataSource = ds.Tables[0];
            // resultDataGridView.DataSource = itemsComboBox.SelectedValue.ToString();

        }

        private void itemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resultDataGridView.DataSource = itemsComboBox.SelectedValue.ToString();
            //resultDataGridView.DataSource = ds.Tables[0];
            textBox1.Text = itemsComboBox.SelectedValue.ToString();
        }
    }
}
