using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectITS
{
    //public static class TimeCalculator
    //{

    //    public static Stopwatch counter = new Stopwatch();
    //}
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public static string userName, userEmail, userGender;
        public static int userAge;

        public static class TimeCalculator
        {

            public static Stopwatch counter = new Stopwatch();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            userName = txtName.Text;
            userEmail = txtEmail.Text;
            userGender = cmbGender.SelectedItem.ToString();
            userAge = (int)numAge.Value;

            // Database Connection 
            //SqlConnection con = new SqlConnection("Data Source=ItaliaLaptop;Initial Catalog=IntelligentTutoringSystem;Integrated Security=True");
            //con.Open();
            //MessageBox.Show("Connection Established");

            //// Insert data


            //SqlCommand cmd = new SqlCommand("INSERT INTO Information(Name) VALUES ('"+txtName.Text+"')", con);
            ////con.Open();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Connection Successful");
            // name = txtName.Text;

            QuestionAlgebra QA = new QuestionAlgebra();
            QA.Show();
            this.Hide();
            TimeCalculator.counter.Start();
        }
    }
}
