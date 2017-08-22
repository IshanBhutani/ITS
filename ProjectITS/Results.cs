using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectITS
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {



            txtTime.Text = QuestionGeometry.testDuration.ToString();
            txtTime.ReadOnly = true;

            //userAlgebra
            userAlgebra.Text = QuestionAlgebra.scoreAlgebra.ToString();
            userAlgebra.ReadOnly = true;
            
            //userArithmetic
            userArithmetic.Text = QuestionArithmetic.scoreArithmetic.ToString();
            userArithmetic.ReadOnly = true;
            
            //userGeometry
            userGeometry.Text = QuestionGeometry.scoreGeometry.ToString();
            userGeometry.ReadOnly = true;
            
            //userTotal
            userTotal.Text = QuestionGeometry.scoreTotal.ToString();
            userTotal.ReadOnly = true;

            //UserName
            userName.Text = Home.userName;
            userName.ReadOnly = true;

            textBox7.Text = QuestionGeometry.s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
            this.Hide();
        }
    }
}
