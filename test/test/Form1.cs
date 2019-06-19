using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace test
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Wojciech\Desktop\BMI.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Tabela1 (Waga,Wzrost) values('" + textBox1.Text + "','" + textBox2.Text + "' )";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("record inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "  + ex);
            }
        }
    }
}
