using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp5
{
    public partial class Form1 : Form
    {
        DataBase basee = new DataBase();
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'list.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.list.Table);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.AddData(IdBox.Text,SurnameBox.Text,NameBox.Text,StatusBox.Text,SubjectBox.Text,EmailBox.Text,PhoneBox.Text);
            Form1_Load(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.DeleteData(IdBox.Text);
            Form1_Load (sender, e);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            tableBindingSource.EndEdit();
            tableTableAdapter.Update(this.list.Table);
            MessageBox.Show("Update successful");
            this.list.Table.AcceptChanges();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
