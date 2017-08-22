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
    public partial class QuestionAlgebra : Form
    {
        //string query;
        //public static string userName;
        //public static int ID;
        public static int scoreAlgebra = 0;
        public QuestionAlgebra()
        {
            InitializeComponent();
        }
        private void QuestionAlgebra_Load(object sender, EventArgs e)
        {
        //    SqlConnection con = new SqlConnection("Data Source=ItaliaLaptop;Initial Catalog=IntelligentTutoringSystem;Integrated Security=True");
        //    con.Open();

        //    query = "select * from Information where Name='" + Home.name + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);

        //    SqlDataReader dr = cmd.ExecuteReader();
            
        //    if(dr.Read())
        //    {
        //        label1.Text = dr["userID"].ToString();
        //        userName = dr["Name"].ToString();
        //        ID = dr.GetInt32(0);
        //    }
        }
        private void btnAlgebra_Click(object sender, EventArgs e)
        {
            if (rdbtn12.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn21.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn32.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn43.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn63.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn71.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn83.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn91.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn102.Checked)
            {
                scoreAlgebra += 1;
            }
            if (rdbtn54.Checked)
            {
                scoreAlgebra += 1;
            }

            QuestionArithmetic QAr = new QuestionArithmetic();
            QAr.Show();
            this.Hide();

            //QAr.Activate();
            //DateTime dt = DateTime.Now;
            //TimeCalculator.counter.Stop();
            //double c = TimeCalculator.counter.Elapsed.TotalSeconds;
            //label1.Text =c.ToString();
            //lbls
        }

        
    }
}
