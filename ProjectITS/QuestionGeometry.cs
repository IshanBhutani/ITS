using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectITS
{
    public partial class QuestionGeometry : Form
    {
        public static int scoreGeometry = 0, scoreTotal = 0;
        public static double testDuration = 0;
        public static string s;
        public QuestionGeometry()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ItaliaLaptop;Initial Catalog=IntelligentTutoringSystem;Integrated Security=True");
            con.Open();
            //MessageBox.Show("Connection Established");

            SqlCommand cmd = new SqlCommand("INSERT INTO Information(Name,Age,scoreAlgebra,scoreArithmetic,scoreGeometry,Gender,Email) VALUES ('" + Home.userName + "','" + Home.userAge + "','" + QuestionAlgebra.scoreAlgebra + "','" + QuestionArithmetic.scoreArithmetic + "','" + scoreGeometry + "','" + Home.userGender + "','"+Home.userEmail+"')", con);
            cmd.ExecuteNonQuery();

            
            //Naive Bayes Start 
            DataTable table = new DataTable();
            table.Columns.Add("Class");
            table.Columns.Add("Age", typeof(double));
            table.Columns.Add("TimeTaken", typeof(double));
            table.Columns.Add("scoreTotal", typeof(double));

            //training data.
            table.Rows.Add("poor", 13, 574.7373846, 9);
            table.Rows.Add("poor", 14, 1097.118137, 13);
            table.Rows.Add("poor", 12, 1029.089239, 8);
            table.Rows.Add("poor", 15, 62.54089996, 9);
            table.Rows.Add("poor", 10, 1775.262307, 8);
            table.Rows.Add("poor", 14, 1521.363214, 14);
            table.Rows.Add("poor", 15, 330.961437, 9);
            table.Rows.Add("poor", 15, 531.5901265, 9);
            table.Rows.Add("poor", 13, 1377.84305, 11);
            
            //Moderate
            table.Rows.Add("Moderate", 11, 681.6100372, 13);
            table.Rows.Add("Moderate", 14, 1016.93348,
              16);
            table.Rows.Add("Moderate", 14, 774.8893106, 21);
            table.Rows.Add("Moderate", 14, 319.1738865, 14);
            table.Rows.Add("Moderate", 13, 984.3784999, 10);
            table.Rows.Add("Moderate", 15, 1659.324665, 19);
            table.Rows.Add("Moderate", 14, 1135.719961, 15);
            table.Rows.Add("Moderate", 13, 250.9178152, 12);
            table.Rows.Add("Moderate", 10, 1340.935111, 13);

            //Good
            table.Rows.Add("Good", 14, 322.4769867, 20);
            table.Rows.Add("Good", 13, 652.258442, 19);
            table.Rows.Add("Good", 11, 926.4787494, 18);
            table.Rows.Add("Good", 11, 1640.839796, 19);
            table.Rows.Add("Good", 12, 847.0374206, 16);
            table.Rows.Add("Good", 10, 777.5868589, 16);
            table.Rows.Add("Good", 10, 1292.645709, 15);
            table.Rows.Add("Good", 10, 102.948872, 14);
            table.Rows.Add("Good", 10, 613.6737728, 16);

            //Excellent
            table.Rows.Add("Excellent", 13, 1000.797076, 28);
            table.Rows.Add("Excellent", 12, 465.1102689, 25);
            table.Rows.Add("Excellent", 11, 322.888544, 21);
            table.Rows.Add("Excellent", 12, 242.1867542, 25);
            table.Rows.Add("Excellent", 10, 1079.296855, 26);
            table.Rows.Add("Excellent", 11,274.6427725, 22);
            table.Rows.Add("Excellent", 15, 262.8521693, 28);
            table.Rows.Add("Excellent", 11, 1525.929799, 25);
            table.Rows.Add("Excellent", 11, 1541.274541, 29);
            
            Classifier classifier = new Classifier();
            classifier.TrainClassifier(table);

            s = classifier.Classify(new double[] { Home.userAge, testDuration, scoreTotal });
            //Naive Bayes End

            if (rdbtn12.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn24.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn33.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn44.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn64.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn71.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn84.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn92.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn101.Checked)
            {
                scoreGeometry += 1;
            }
            if (rdbtn51.Checked)
            {
                scoreGeometry += 1;
            }


            Home.TimeCalculator.counter.Stop();
            testDuration = Home.TimeCalculator.counter.Elapsed.TotalSeconds;

            scoreTotal = scoreGeometry + QuestionAlgebra.scoreAlgebra + QuestionArithmetic.scoreArithmetic;
            Results R = new Results();

            R.Show();            
            this.Hide();
            
        }
    }
}
